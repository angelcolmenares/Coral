using System;
using Aicl.Coral.Modelos;
using ServiceStack.Text;
using System.Collections.Generic;
using System.Linq;
using ServiceStack.OrmLite;
using Cayita.Tools;

namespace Aicl.Coral.BL
{
	public static class AuthorizacionController
	{
		public static UserLoginResponse Do(this UserLogin user, Controller controler, string userId)
		{
			return controler.Execute(proxy=>{
				var empresa = proxy.FirstOrDefault<Empresa>(f=>f.Nit== user.Nit);

				if( empresa==default(Empresa) )
					throw new Exception("No existe empresa con NIT='{0}'".Fmt(user.Nit));

				empresa.ConexionContabilidad="*";

				var ue= proxy.FirstOrDefault<UsuarioEmpresa>(
					f=> f.IdEmpresa== empresa.Id && f.IdUsuario== int.Parse(userId));

				if( ue==default(UsuarioEmpresa) )
				   throw new Exception("Usuario NO registrado en la empresa con NIT='{0}'".Fmt(user.Nit));

				var sucursales = proxy.Read<Sucursal>(f=>f.IdEmpresa== empresa.Id);

				var centros = proxy.Read<Centro> ( f=> f.IdEmpresa== empresa.Id);

				var sa = new List<SucursalAutorizada>();

				if( ue.RequiereSucursal ){
					var us = proxy.Read<UsuarioSucursal>(
						f=> f.IdEmpresa== empresa.Id && f.IdUsuario== int.Parse(userId));

					var ls = sucursales.Where(
						s=>  us.Where(f=>f.RequiereCentro).Select(f=>f.IdSucursal).Contains(s.Id)
						).ToList();

					if( ls.Count>0 ) {
						LlenarSA (empresa, userId, proxy, ls, sa);
					}

					if( ls.Count< us.Count) {
						var nrc = sucursales.Where(
							s=> us.Where(f=>!f.RequiereCentro).Select(f=>f.IdSucursal).Contains(s.Id)
							).ToList();
						LLenarSA (empresa, proxy, nrc, sa);
					}

				} else {
					LLenarSA (empresa, proxy, sucursales, sa);
				}

				var c =new  List<int>();
				sa.ForEach(f=> c.AddRange(f.IdCentros));
				centros = centros.Where(s=> c.Contains( s.Id)).ToList();

				var actividades = UsuarioActividades(proxy, userId);
					
				return new UserLoginResponse {
					Empresa= empresa,
					Centros = centros,
					SucursalesAutorizadas = sa,
					Actividades= actividades.OrderBy(f=>f.Nombre).ToList().ConvertAll(f=>f.Nombre),
					Menu= UsuarioMenu(proxy, actividades)
				};
			});

		}

		static void LLenarSA (Empresa empresa, DbProxy proxy, List<Sucursal> sucursales, List<SucursalAutorizada> sa)
		{
			var ls = sucursales.Select (f => f.Id).ToList (); 
			
			var sc = proxy.Read<CentroSucursal> (f => f.IdEmpresa == empresa.Id  && Sql.In( f.IdSucursal, ls) );
			foreach (var s in sucursales) {
				var lc = sc.Where (f => f.IdSucursal == s.Id).Select (f => f.IdCentro).ToList ();
				sa.Add (new SucursalAutorizada {
					Sucursal = s,
					IdCentros = lc
				});
			}
		}

		static void LlenarSA (Empresa empresa, string userId, Cayita.Tools.DbProxy proxy, List<Sucursal> sucursales, IList<SucursalAutorizada> sa)
		{
			var ls= sucursales.Select (f => f.Id).ToList (); 
			var ucs = proxy.Read<UsuarioCentroSucursal> (f => f.IdEmpresa == empresa.Id && Sql.In (f.IdSucursal, ls) && f.IdUsuario == int.Parse (userId));
			foreach (var s in sucursales) {
				var c = ucs.Where (f => f.IdSucursal == s.Id).Select (f => f.IdCentro).ToList ();
				sa.Add (new SucursalAutorizada () {
					Sucursal = s,
					IdCentros = c
				});
			}
		}


		static List<Actividad> UsuarioActividades ( DbProxy proxy, string userId)
		{
			var sgu = ReadExtensions.CreateExpression<GrupoUsuario> ()
				.Where (f => f.IdUsuario == int.Parse (userId) )
					.Select(f=>f.IdGrupo)
					.OrderBy(f=>f.IdGrupo)
					.ToSelectStatement();

			var sga = ReadExtensions.CreateExpression<GrupoActividad> ()
				.Where ("{0} in ({1})".Fmt(
				        ModelDefinition<GrupoActividad>
				        .Definition.GetQuotedFieldName<GrupoActividad>(f=>f.IdGrupo),
				        sgu))
					.Select(f=>f.IdActividad)
					.OrderBy(f=>f.IdActividad)
					.ToSelectStatement();
	
			var a = ReadExtensions.CreateExpression<Actividad> ()
				.SelectDistinct (f => new {f.Id, f.IdTipoActividad , f.Codigo, f.Nombre, f.BloquearEnPeriodoCerrado})
					.Where( "{0} in ({1})".Fmt(
					       ModelDefinition<Actividad>
					       .Definition.GetQuotedFieldName<Actividad>(s=>s.Id),
					       sga));

			return proxy.Read (a);
		}

		static List<Menu> UsuarioMenu(DbProxy proxy,  List<Actividad> actividades)
		{
			var la = actividades.ConvertAll (f => f.Id).Distinct ().ToList();

			var ac = proxy.Read (ReadExtensions.CreateExpression<ActividadClase> ()
			                    .Where (f => Sql.In (f.IdActividad, la)));

			var lac = ac.ConvertAll (f => f.IdClase).Distinct ().ToList();

			var cc = proxy.Read (ReadExtensions.CreateExpression<ClaseCliente> ()
			                    .Where (f => Sql.In (f.Id, lac)));

			var lta = actividades.ConvertAll (f => f.IdTipoActividad).Distinct ().ToList();

			var ta = proxy.Read (ReadExtensions.CreateExpression<TipoActividad> ()
			                     .Where (f => Sql.In ( f.Id, lta)));

			List<Menu> menu = new List<Menu> ();

			var lacIds = ac.ConvertAll(f=>f.IdActividad).ToList();

			ta.ForEach (f => {

				var a = actividades.Where(x=>x.IdTipoActividad==f.Id && lacIds.Contains(x.Id)  );

				List<Item>  items = new List<Item>();

			    foreach(var actividad in a)
				{
					var rca=  ac.Where(x=>x.IdActividad==actividad.Id).ToList().ConvertAll(x=>x.IdClase);

					items.AddRange( cc.Where(x=> rca.Contains(x.Id)).ToList()
							.ConvertAll(x=> new Item{Titulo= x.Titulo, Modulo=x.Nombre, Icono= x.Icono}) );
				}

				if(items.Count()>0){
					menu.Add( new Menu{
						Titulo= f.Nombre,
						Items = items
					});
				}

			});

			return menu;

		}
	}
}