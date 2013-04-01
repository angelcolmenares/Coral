using System.ComponentModel.DataAnnotations;
using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

namespace Aicl.Coral.Modelos
{
	[Alias("EMPRESAS")]
	public partial class Empresa:IHasIntId
	{
		public Empresa(){}

		[Alias("IDEMPRESA")]
		[Sequence("IDEMPRESA_GEN")]
		[PrimaryKey]
		[AutoIncrement]
		public int Id { get; set;} 

		[Alias("CODIGO_EMPRESA")]
		[Required]
		[StringLength(2)]
		public string Codigo { get; set;} 

		[Alias("NOMBRE_EMPRESA")]
		[Required]
		[StringLength(40)]
		public string Nombre { get; set;} 

		[Alias("DIRECCION_EMPRESA")]
		[Required]
		[StringLength(60)]
		public string Direccion{ get; set;} 

		[Alias("NIT_EMPRESA")]
		[Required]
		[StringLength(12)]
		public string Nit { get; set;} 

		[Alias("DV_EMPRESA")]
		[Required]
		[StringLength(1)]
		public string Dv { get; set;} 

		[Alias("TELEFONO_EMPRESA")]
		[Required]
		[StringLength(15)]
		public string Telefono { get; set;} 

		[Alias("EMAIL_EMPRESA")]
		[Required]
		[StringLength(50)]
		public string Email{ get; set;} 

		[Alias("REPRESENTANTE_LEGAL")]
		[Required]
		[StringLength(50)]
		public string RepresentanteLegal { get; set;} 

		[Alias("IDMUNICIPIO")]
		public int IdMunicipio { get; set;} 

		[Alias("IDADMINISTRADORA")]
		public int IdAdministradora { get; set;} 

		[Alias("FORMA_PRESENTACION_SS")]
		[Required]
		[StringLength(1)]
		public string FormaPresentacionSS { get; set;} 

		[Alias("IDTIPO_DOCUMENTO")]
		public int IdTipoDocumento { get; set;} 

		[Alias("TIPO_APORTANTE_SS")]
		public int TipoAportanteSS { get; set;} 

		[Alias("USAR_XMPP")]
		public bool UsarXmpp { get; set;} 

		[Alias("CON_CONTA")]
		[StringLength(180)]
		public string ConexionContabilidad { get; set;} 

		[Alias("IDREPRESENTA")]
		public int? IdRepresentanteLegal { get; set;} 

		[Alias("CARGO_FIRMA")]
		[StringLength(80)]
		public string CargoFirma { get; set;} 

	}
}
