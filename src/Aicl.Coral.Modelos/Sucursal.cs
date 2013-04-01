using System.ComponentModel.DataAnnotations;
using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

namespace Aicl.Coral.Modelos
{
	[Alias("SUCURSAL")]
	public partial class Sucursal:IHasIntId
	{
		public Sucursal(){}

		[Alias("IDEMPRESA")]
		[PrimaryKey]
		public int IdEmpresa { get; set;} 

		[Alias("IDSUCURSAL")]
		[Sequence("IDSUCURSAL_GEN")]
		[PrimaryKey]
		[AutoIncrement]
		public int Id { get; set;} 

		[Alias("CODIGO_SUCURSAL")]
		[Required]
		[StringLength(2)]
		public string Codigo { get; set;} 

		[Alias("IDMUNICIPIO")]
		public int IdMunicipio { get; set;} 

		[Alias("DIRECCION_SUCURSAL")]
		[Required]
		[StringLength(60)]
		public string Direccion { get; set;} 

		[Alias("TELEFONO_SUCURSAL")]
		[Required]
		[StringLength(15)]
		public string Telefono { get; set;} 

		[Alias("NOMBRE_SUCURSAL")]
		[Required]
		[StringLength(30)]
		public string Nombre { get; set;} 

		[Alias("JEFE_SUCURSAL")]
		[Required]
		[StringLength(30)]
		public string Gerente { get; set;} 

		[Alias("IDREPRESENTA")]
		public int? IdRepresentante { get; set;} 

		[Alias("CARGO_FIRMA")]
		[StringLength(80)]
		public string CargoFirma { get; set;} 

	}
}
