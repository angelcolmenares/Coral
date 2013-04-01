using System.ComponentModel.DataAnnotations;
using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

namespace Aicl.Coral.Modelos
{
	[Alias("SANGUINEO")]
	public partial class Sanguineo:IHasIntId
	{

		public Sanguineo(){}

		[Alias("IDSANGUINEO")]
		[PrimaryKey]
		public int Id {get; set;} 

		[Alias("NOMBRE_SANGUINEO")]
		[Required]
		[StringLength(30)]
		public string Nombre { get; set;} 

	}
}
