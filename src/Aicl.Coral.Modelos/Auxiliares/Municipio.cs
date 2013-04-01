using System;
using System.ComponentModel.DataAnnotations;
using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

namespace Aicl.Coral.Modelos
{
	[Alias("MUNICIPIOS")]
	public partial class Municipio{

		public Municipio(){}

		[Alias("IDMUNICIPIO")]
		[PrimaryKey]
		public int Id { get; set;} 

		[Alias("CODIGO_MUNICIPIO")]
		[Required]
		[StringLength(5)]
		public string Codigo { get; set;} 

		[Alias("NOMBRE_MUNICIPIO")]
		[Required]
		[StringLength(30)]
		public string Nombre { get; set;} 

		[Alias("IDDEPARTAMENTO")]
		public int IDDepartamento { get; set;} 

		[Alias("CD_1")]
		[Required]
		[StringLength(5)]
		public string CodigoAlternativo { get; set;} 

	}
}
