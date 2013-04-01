using System;
using System.ComponentModel.DataAnnotations;
using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

namespace Aicl.Coral.Modelos
{
	[Alias("CANDIDATOS")]
	public partial class Candidato:IHasIntId
	{

		public Candidato(){}

		[Alias("IDCANDIDATO")]
		[PrimaryKey]
		public int Id{ get; set;} 

		[Alias("DOCUMENTO_IDENTIDAD_CANDIDATO")]
		[Required]
		[StringLength(15)]
		public string Documento { get; set;} 

		[Alias("IDTIPO_DOCUMENTO")]	
		public int IdTipoDocumento { get; set;} 

		[Alias("IDLUGAR_EXPEDICION")]
		public int IdLugarExpedicion { get; set;} 

		[Alias("NOMBRES_CANDIDATO")]
		[Required]
		[StringLength(30)]
		
		public string Nombres { get; set;} 

		[Alias("PRIMER_APELLIDO_CANDIDATO")]
		[Required]
		[StringLength(20)]
		public string PrimerApellido { get; set;} 

		[Alias("SEGUNDO_APELLIDO_CANDIDATO")]
		[StringLength(20)]
		public string SegundoApellido { get; set;} 

		[Alias("IDESTADO_CIVIL")]
		public int IdEstadoCivil { get; set;} 

		[Alias("FECHA_NACIMIENTO_CANDIDATO")]
		public System.DateTime FechaNacimiento { get; set;} 

		[Alias("IDSANGUINEO")]
		public int IdSanguineo { get; set;} 

		[Alias("SEXO_CANDIDATO")]
		[Required]
		[StringLength(1)]
		public string Sexo { get; set;} 

		[Alias("IDCIUDAD_NACIMIENTO")]
		public int IdCiudadNacimiento { get; set;} 

		[Alias("DIRECCION_RESIDENCIA_CANDIDATO")]
		[Required]
		[StringLength(60)]
		public string DireccionResidencia { get; set;} 

		[Alias("TELEFONO_CANDIDATO")]
		[Required]
		[StringLength(15)]
		public string Telefono { get; set;} 


		[Alias("CELULAR_CANDIDATO")]
		[StringLength(15)]
		public string Celular { get; set;} 

		[Alias("EMAIL_CANDIDATO")]
		[StringLength(50)]
		public string Email { get; set;} 

		[Alias("IDEPS")]
		public int IdEps { get; set;} 

		[Alias("IDAFP")]
		public int IdAfp { get; set;} 

		[Alias("IDCESANTIAS")]
		public int IdCesantias { get; set;} 

		[Alias("IDPROFESION")]
		
		public int IdProfesion { get; set;} 

		[Alias("IDNIVEL_ACADEMICO")]
		
		public int IdNivelAcademico { get; set;} 

		[Alias("LIBRETA_MILITAR_CANDIDATO")]
		[StringLength(15)]
		public string LibretaMilitar { get; set;} 

		[Alias("FECHA_EXPEDICION_DAS_CANDIDATO")]
		
		public DateTime? FechaExpedicionDas{ get; set;} 

		[Alias("IDPUESTO")]
		public int? IdPuesto { get; set;} 

		[Alias("TARJETA_PROFESIONAL_CANDIDATO")]
		[StringLength(15)]
		public string TarjetaProfesional { get; set;} 

		[Alias("IDUSUARIO_APRUEBA")]
		public int? IdUsuarioAprueba { get; set;} 

		[Alias("IDUSUARIO_REGISTRA")]
		public int IdUsuarioRegistra { get; set;} 

		[Alias("FECHA_REGISTRO_CANDIDATO")]
		public System.DateTime FechaRegistro { get; set;} 

		[Alias("PASADO_JUDICIAL_CANDIDATO")]
		[StringLength(15)]
		public string PasadoJudicial { get; set;} 

		[Alias("FECHA_APRUEBA_CANDIDATO")]
		public DateTime? FechaAprobacion { get; set;} 

		[Alias("IDESTADO")]
		public int IdEstado { get; set;} 

		[Alias("IDBARRIO_RESIDENCIA_CANDIDATO")]
		public int? IdBarrioResidencia { get; set;} 

		[Alias("OBSERVACION")]
		[StringLength(100)]
		public string Observacion { get; set;} 

	}
}
