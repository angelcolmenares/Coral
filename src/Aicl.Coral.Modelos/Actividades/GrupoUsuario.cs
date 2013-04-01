using ServiceStack.DataAnnotations;

namespace Aicl.Coral.Modelos
{
	[Alias("REL_GRUPOS_USUARIOS")]
	public partial class GrupoUsuario
	{
		public GrupoUsuario(){}

		[Ignore]
		public string Id 
		{
			get{
				return string.Format("{0}-{1}",IdGrupo ,IdUsuario);
			}
		}

		[Alias("IDGRUPO")]
		[PrimaryKey]
		public int IdGrupo { get; set;} 

		[Alias("IDUSUARIO_AUTORIZADO")]
		[PrimaryKey]
		public int IdUsuario { get; set;} 

	}
}
