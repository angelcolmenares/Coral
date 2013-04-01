using System.ComponentModel.DataAnnotations;
using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

namespace Aicl.Coral.Modelos
{
	[Alias("CLASES_CLIENTES")]
	public partial class ClaseCliente:IHasIntId
	{
		public ClaseCliente(){}

		[Alias("IDCLASE")]
		[Sequence("IDCLASE_GEN")]
		[PrimaryKey]
		[AutoIncrement]
		public int Id { get; set;} 

		[Alias("NOMBRE_CLASE_CLIENTE")]
		[Required]
		[StringLength(60)]
		public string Nombre { get; set;} 

		[Alias("TITULO_CLASE_CLIENTE")]
		[Required]
		[StringLength(80)]
		public string Titulo { get; set;} 

		[Alias("ICONO")]
		[StringLength(60)]
		public string Icono { get; set;} 

	}
}
