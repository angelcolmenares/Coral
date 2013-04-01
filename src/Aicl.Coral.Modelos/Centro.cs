using System.ComponentModel.DataAnnotations;
using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

namespace Aicl.Coral.Modelos
{
	[Alias("CENTRO_COSTO")]
	public partial class Centro:IHasIntId
	{

		public Centro(){}


		[Alias("IDEMPRESA")]
		[PrimaryKey]
		public int IdEmpresa { get; set;} 


		[Alias("IDCENTRO_COSTO")]
		[Sequence("IDCENTRO_COSTO_GEN")]
		[PrimaryKey]
		[AutoIncrement]
		public int Id { get; set;} 

		[Alias("CODIGO_CENTRO")]
		[Required]
		[StringLength(8)]
		public string Codigo { get; set;} 

		[Alias("NOMBRE_CENTRO_COSTO")]
		[Required]
		[StringLength(40)]
		public string Nombre { get; set;} 

		[Alias("FECHA_INICIO")]
		public System.DateTime FechaInicio { get; set;} 

		[Alias("FECHA_TERMINACION")]
		public System.DateTime? FechaTerminacion { get; set;} 

		[Alias("NUMERO_CONTRATO")]
		[StringLength(80)]
		public string NumeroContrato { get; set;} 

		[Alias("IDTERCERO")]
		public int? IdTercero { get; set;} 

	}
}
