using System.ComponentModel.DataAnnotations;
using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

namespace Aicl.Coral.Modelos
{
	[Alias("ADMINISTRADORAS")]
	public partial class Administradora:IHasIntId
	{

		public Administradora(){}

		[Alias("IDADMINISTRADORA")]
		[Sequence("IDADMINISTRADORA_GEN")]
		[PrimaryKey]
		[AutoIncrement]
		public int Id { get; set;} 

		[Alias("NIT_ADMINISTRADORA")]
		[Required]
		[StringLength(11)]
		public string Nit { get; set;} 

		[Alias("DV_ADMINISTRADORA")]
		[Required]
		[StringLength(1)]
		public string Dv { get; set;} 

		[Alias("NOMBRE_ADMINISTRADORA")]
		[Required]
		[StringLength(60)]
		public string Nombre { get; set;} 

		[Alias("IDSERVICIO")]
		public int IdServicio { get; set;} 

		[Alias("CODIGO_ADMINISTRADORA")]
		[Required]
		[StringLength(8)]
		public string Codigo { get; set;} 

		[Alias("DIRECCION_ADMINISTRADORA")]
		[Required]
		[StringLength(60)]
		public string Direccion { get; set;} 

		[Alias("TELEFONO_ADMINISTRADORA")]
		[Required]
		[StringLength(15)]
		public string Telefono{ get; set;} 

	}
}
