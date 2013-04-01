using System.ComponentModel.DataAnnotations;
using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

namespace Aicl.Coral.Modelos
{
	[Alias("TIPO_DOCUMENTO")]
	public partial class TipoDocumento:IHasIntId
	{

		public TipoDocumento(){}

		[Alias("IDTIPO_DOCUMENTO")]
		[PrimaryKey]
		public int Id{ get; set;} 

		[Alias("DESCRIPCION_TIPO_DOCUMENTO")]
		[Required]
		[StringLength(4)]
		public string Descripcion { get; set;} 

	}
}
