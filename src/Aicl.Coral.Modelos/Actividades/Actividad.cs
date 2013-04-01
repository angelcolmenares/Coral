using System.ComponentModel.DataAnnotations;
using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

namespace Aicl.Coral.Modelos
{
	[Alias("ACTIVIDADES")]
	public partial class Actividad:IHasIntId
	{

		public Actividad(){}

		[Alias("IDACTIVIDAD")]
		[PrimaryKey]
		public int Id { get; set;} 

		[Alias("NOMBRE_ACTIVIDAD")]
		[Required]
		[StringLength(50)]
		public string Nombre { get; set;} 

		[Alias("IDTIPO_ACTIVIDAD")]
		public int IdTipoActividad { get; set;} 

		[Alias("CODIGO_ACTIVIDAD")]
		[StringLength(5)]
		public string Codigo { get; set;} 

		[Alias("BLOQUEAR_PERIODO_CERRADO")]
		public bool BloquearEnPeriodoCerrado { get; set;} 

	}
}
