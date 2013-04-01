using System.ComponentModel.DataAnnotations;
using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

namespace Aicl.Coral.Modelos
{
	[Alias("NIVEL_ACADEMICO")]
	public partial class NivelAcademico:IHasIntId
	{

		public NivelAcademico(){}

		[Alias("IDNIVEL_ACADEMICO")]
		[PrimaryKey]
		public int Id { get; set;} 

		[Alias("NOMBRE_NIVEL_ACADEMICO")]
		[Required]
		[StringLength(20)]
		public string Nombre{ get; set;} 

	}
}
