using ServiceStack.DataAnnotations;
using ServiceStack.Text;

namespace Aicl.Coral.Modelos
{
	[Alias("REL_CENTRO_COSTO_SUCURSAL")]
	public partial class CentroSucursal{

		public CentroSucursal(){}

		[Ignore]
		public string Id {
			get{ return "{0}-{1}-{2}".Fmt (IdEmpresa, IdSucursal, IdCentro);}
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

	}
}
