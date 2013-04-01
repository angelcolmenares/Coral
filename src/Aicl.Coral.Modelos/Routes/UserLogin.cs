using System;
using ServiceStack.ServiceHost;

namespace Aicl.Coral.Modelos
{
	[Route("/User/login","POST")]
	public class UserLogin:IReturn<UserLoginResponse>
	{
		public string Nit { get; set; }
		public string Nombre { get; set; }
		public string Clave { get; set; }
	}

	[Route("/User/logout","POST")]
	public class UserLogout:IReturnVoid
	{
				
	}


	[Route("/Admin/login","POST")]
	public class AdminLogin:IReturn<AdminLoginResponse>
	{
		public string Nombre { get; set; }
		public string Clave { get; set; }	
	}

	[Route("/Admin/logout","POST")]
	public class AdminLogout:IReturnVoid
	{
		
	}

}

