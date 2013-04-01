using ServiceStack.DataAnnotations;

namespace Aicl.Coral.Modelos
{
	[Alias("USUARIOS_SUCURSAL")]
	public partial class UsuarioSucursal
	{

		public UsuarioSucursal(){}

		[Ignore]
		public string Id 
		{
			get { return string.Format("{0}-{1}-{2}",IdEmpresa, IdSucursal, IdUsuario); }
		}

		[Alias("IDEMPRESA")]
		[PrimaryKey]
		public int IdEmpresa { get; set;} 

		[Alias("IDSUCURSAL")]
		[PrimaryKey]
		public int IdSucursal { get; set;} 

		[Alias("IDUSUARIO_AUTORIZADO")]
		[PrimaryKey]
		public int IdUsuario { get; set;} 

		[Alias("REQUIERE_CENTRO")]
		public bool RequiereCentro { get; set;} 

	}
}
