using ServiceStack.DataAnnotations;

namespace Aicl.Coral.Modelos
{
	[Alias("ACTIVIDADES_CLASES")]
	public partial class ActividadClase
	{

		public ActividadClase(){}

		[Ignore]
		public string Id 
		{
			get{
				return string.Format("{0}-{1}",IdActividad, IdClase);
			}
		}

		[Alias("IDACTIVIDAD")]
		[PrimaryKey]
		public int IdActividad { get; set;} 

		[Alias("IDCLASE")]
		[PrimaryKey]
		public int IdClase { get; set;} 

	}
}
