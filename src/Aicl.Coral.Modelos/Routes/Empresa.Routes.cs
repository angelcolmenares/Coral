using ServiceStack.ServiceHost;
using ServiceStack.DesignPatterns.Model;
using Cayita.Tools;

namespace Aicl.Coral.Modelos
{
	[Route("/Empresa/create","POST")]
	public class EmpresaCreate: IReturn<Empresa>
	{

		public string Codigo { get; set;} 
		public string Nombre { get; set;} 
		public string Direccion{ get; set;} 
		public string Nit { get; set;} 
		public string Dv { get; set;} 		
		public string Telefono { get; set;} 		
		public string Email{ get; set;} 
		public string RepresentanteLegal { get; set;} 		

		public int IdMunicipio { get; set;} 

		public int IdAdministradora { get; set;} 
		
		public string FormaPresentacionSS { get; set;} 
		
		public int IdTipoDocumento { get; set;} 
		
		public int TipoAportanteSS { get; set;} 
		
		public bool UsarXmpp { get; set;} 
		
		public string ConexionContabilidad { get; set;} 
		
		public int? IdRepresentanteLegal { get; set;} 

		public string CargoFirma { get; set;} 

	}

	[Route("/Empresa/read","POST,GET")]
	public class EmpresaRead:  IReturn<TList<Empresa>>
	{
	}
	
	
	[Route("/Empresa/update","POST,PUT")]
	public class EmpresaUpdate:IHasIntId, IReturn<Empresa>{
		
		public int Id{ get; set;}
		public string Codigo { get; set;} 
		public string Nombre { get; set;} 
		public string Direccion{ get; set;} 
		public string Nit { get; set;} 
		public string Dv { get; set;} 		
		public string Telefono { get; set;} 		
		public string Email{ get; set;} 
		public string RepresentanteLegal { get; set;} 		
		
		public int IdMunicipio { get; set;} 
		
		public int IdAdministradora { get; set;} 
		
		public string FormaPresentacionSS { get; set;} 
		
		public int IdTipoDocumento { get; set;} 
		
		public int TipoAportanteSS { get; set;} 
		
		public bool UsarXmpp { get; set;} 
		
		public string ConexionContabilidad { get; set;} 
		
		public int? IdRepresentanteLegal { get; set;} 
		
		public string CargoFirma { get; set;} 
	}
	
	[Route("/Empresa/destroy","POST,DELETE")]
	public  class EmpresaDestroy:IHasIntId, IReturnVoid
	{
		public int Id{get;set;}
	}

}

