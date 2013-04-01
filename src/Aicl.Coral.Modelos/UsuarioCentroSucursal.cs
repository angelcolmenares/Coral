using System;
using System.ComponentModel.DataAnnotations;
using ServiceStack.Common;
using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

namespace Aicl.Coral.Modelos
{
	[Alias("USUARIOS_CENTROS_SUCURSAL")]
	public partial class UsuarioCentroSucursal
	{

		public UsuarioCentroSucursal(){}

		[Ignore]
		public string Id 
		{
			get { return string.Format("{0}-{1}", IdSucursal, IdUsuario); }
		}

		[Alias("IDEMPRESA")]
		[PrimaryKey]
		public int IdEmpresa { get; set;} 

		[Alias("IDSUCURSAL")]
		[PrimaryKey]
		public int IdSucursal { get; set;} 

		[Alias("IDCENTRO_COSTO")]
		[PrimaryKey]
		public int IdCentro { get; set;} 

		[Alias("IDUSUARIO_AUTORIZADO")]
		[PrimaryKey]
		public int IdUsuario { get; set;} 

	}
}
