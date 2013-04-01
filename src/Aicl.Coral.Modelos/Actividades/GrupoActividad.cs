using ServiceStack.DataAnnotations;

namespace Aicl.Coral.Modelos
{
	[Alias("REL_GRUPOS_ACTIVIDADES")]
	public partial class GrupoActividad
	{
		public GrupoActividad(){}

		[Ignore]
		public string Id 
		{
			get{
				return string.Format("{0}-{1}",IdGrupo ,IdActividad);
			}
		}

		[Alias("IDGRUPO")]
		[PrimaryKey]
		public int IdGrupo { get; set;} 

		[Alias("IDACTIVIDAD")]
		[PrimaryKey]
		public int IdActividad { get; set;} 

	}
}
