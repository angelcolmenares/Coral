
using ServiceStack.DataAnnotations;
using ServiceStack.Text;

namespace Aicl.Coral.Modelos
{
	[Alias("USUARIOS_EMPRESAS")]
	public partial class UsuarioEmpresa
	{

		public UsuarioEmpresa(){}

		[Ignore]
		public string Id {
			get{ return "{0}-{1}".Fmt (IdEmpresa, IdUsuario);}
		}

		[Alias("IDEMPRESA")]
		[PrimaryKey]
		public int IdEmpresa { get; set;} 

		[Alias("IDUSUARIO_AUTORIZADO")]
		[PrimaryKey]
		public int IdUsuario { get; set;} 

		[Alias("REQUIERE_SUCURSAL")]
		public bool RequiereSucursal { get; set;} 

	}
}
