using System.ComponentModel.DataAnnotations;
using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

namespace Aicl.Coral.Modelos
{
	[Alias("PAIS")]
	public partial class Pais:IHasIntId
	{

		public Pais(){}

		[Alias("IDPAIS")]
		[PrimaryKey]
		public int Id { get; set;} 

		[Alias("NOMBRE_PAIS")]
		[Required]
		[StringLength(30)]
		public string Nombre { get; set;} 

		[Alias("CODIGO_PAIS")]
		[Required]
		[StringLength(3)]
		public string Codigo { get; set;} 

	}
}
