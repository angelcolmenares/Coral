using ServiceStack.DataAnnotations;

namespace Aicl.Coral.Modelos
{
	[Alias("EMPRESAS_CCF")]
	public partial class EmpresaCcf
	{

		public EmpresaCcf()	{}

		[Ignore]
		public string Id
		{
			get{ return string.Format ("{}-{}", IdEmpresa, IdDepartamento); }
		}

		[Alias("IDEMPRESA")]
		[PrimaryKey]
		public int IdEmpresa { get; set;} 

		[Alias("IDDEPARTAMENTO")]
		[PrimaryKey]
		public int IdDepartamento { get; set;} 

		[Alias("IDADMINISTRADORA")]
		public int IdAdministradora { get; set;} 

	}
}
