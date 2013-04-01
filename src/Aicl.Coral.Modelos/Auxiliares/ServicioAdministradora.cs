using System.ComponentModel.DataAnnotations;
using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

namespace Aicl.Coral.Modelos
{
	[Alias("SERVICIOS_ADMINISTRADORA")]
	public partial class ServicioAdministradora:IHasIntId
	{
		public ServicioAdministradora(){}

		[Alias("IDSERVICIO")]
		[PrimaryKey]
		public int Id { get; set;} 

		[Alias("TIPO_SERVICIO")]
		[Required]
		[StringLength(25)]
		public string TipoServicio { get; set;} 

	}
}
