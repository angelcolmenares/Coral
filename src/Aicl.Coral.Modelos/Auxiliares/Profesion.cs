using System.ComponentModel.DataAnnotations;
using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

namespace Aicl.Coral.Modelos
{
	[Alias("PROFESION")]
	public partial class Profesion:IHasIntId
	{
		public Profesion(){}

		[Alias("IDPROFESION")]
		[PrimaryKey]
		public int Id { get; set;} 

		[Alias("NOMBRE_PROFESION")]
		[Required]
		[StringLength(50)]
		public string Nombre { get; set;} 

	}
}
