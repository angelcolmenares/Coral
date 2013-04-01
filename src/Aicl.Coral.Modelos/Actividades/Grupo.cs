using System.ComponentModel.DataAnnotations;
using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

namespace Aicl.Coral.Modelos
{
	[Alias("GRUPOS")]
	public partial class Grupo:IHasIntId
	{
		public Grupo(){}

		[Alias("IDGRUPO")]
		[Sequence("IDGRUPO_GEN")]
		[PrimaryKey]
		[AutoIncrement]
		public int Id { get; set;} 

		[Alias("NOMBRE_GRUPO")]
		[Required]
		[StringLength(40)]
		public string Nombre { get; set;} 

	}
}
