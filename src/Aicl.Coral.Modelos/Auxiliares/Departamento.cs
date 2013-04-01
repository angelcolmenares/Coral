using System;
using System.ComponentModel.DataAnnotations;
using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

namespace Aicl.Coral.Modelos
{
	[Alias("DEPARTAMENTOS")]
	public partial class Departamento:IHasIntId
	{

		public Departamento(){}

		[Alias("IDDEPARTAMENTO")]
		[PrimaryKey]
		public int Id { get; set;} 

		[Alias("CODIGO_DEPARTAMENTO")]
		[Required]
		[StringLength(5)]
		public string Codigo { get; set;} 

		[Alias("NOMBRE_DEPARTAMENTO")]
		[Required]
		[StringLength(30)]
		public string Nombre { get; set;} 

		[Alias("IDPAIS")]
		public int IdPais { get; set;} 

		[Alias("CD_1")]
		[Required]
		[StringLength(5)]
		public string CodigoAlternativo { get; set;} 

	}
}
