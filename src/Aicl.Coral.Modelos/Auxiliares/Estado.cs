using System.ComponentModel.DataAnnotations;
using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

namespace Aicl.Coral.Modelos
{
	[Alias("ESTADO")]
	public partial class Estado:IHasIntId
	{
		public Estado(){}

		[Alias("IDESTADO")]
		[PrimaryKey]
		public int Id { get; set;} 

		[Alias("DESCRIPCION_ESTADO")]
		[Required]
		[StringLength(20)]
		public string Descripcion { get; set;} 

		[Alias("COMENTARIO_ESTADO")]
		[StringLength(20)]
		public string Comentario{ get; set;} 

	}
}
