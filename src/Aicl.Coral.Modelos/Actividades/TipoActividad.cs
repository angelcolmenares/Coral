using System.ComponentModel.DataAnnotations;
using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

namespace Aicl.Coral.Modelos
{
	[Alias("TIPO_ACTIVIDADES")]
	public partial class TipoActividad:IHasIntId
	{
		public TipoActividad(){}

		[Alias("IDTIPO_ACTIVIDAD")]
		[Sequence("IDTIPO_ACTIVIDAD_GEN")]
		[PrimaryKey]
		[AutoIncrement]
		public int Id { get; set;} 

		[Alias("NOMBRE_TIPO_ACTIVIDAD")]
		[StringLength(30)]
		public string Nombre { get; set;} 

		[Alias("CODIGO_TIPO")]
		[Required]
		[StringLength(3)]
		public string Codigo { get; set;} 

		[Alias("NIVEL_CHEQUEO")]
		public int NivelChequeo { get; set;} 

	}
}
