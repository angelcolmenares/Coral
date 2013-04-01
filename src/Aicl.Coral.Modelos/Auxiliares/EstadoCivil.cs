using System.ComponentModel.DataAnnotations;
using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

namespace Aicl.Coral.Modelos
{
	[Alias("ESTADO_CIVIL")]
	public partial class EstadoCivil:IHasIntId
	{

		public EstadoCivil(){}

		[Alias("IDESTADO_CIVIL")]
		[PrimaryKey]
		public int Id{ get; set;} 

		[Alias("NOMBRE_ESTADO_CIVIL")]
		[Required]
		[StringLength(20)]
		public string Nombre { get; set;} 

	}
}
