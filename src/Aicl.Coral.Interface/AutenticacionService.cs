using System;
using Cayita.Tools.Auth;
using Aicl.Coral.Modelos;
using ServiceStack.ServiceInterface.Auth;
using ServiceStack.ServiceInterface;
using Aicl.Coral.BL;
using ServiceStack.Redis;

namespace Aicl.Coral.Interface
{
	public class AutenticacionService:AppServiceBase
	{

		public UserLoginResponse Post(UserLogin request)
		{
			AuthService authService = ResolveService<AuthService>();
			
			authService.Post (new Auth {
				provider = AuthService.CredentialsProvider,
				UserName = request.Nombre,
				Password = request.Clave
			});

			IAuthSession session = this.GetSession();

			var lr= request.Do (Controller, session.UserAuthId);

			session.Permissions = lr.Actividades;
			session.Roles.Add ("User"); 
			authService.SaveSession(session);
			return lr;
		}

		public void Post(UserLogout request){
			
			AuthService authService = base.ResolveService<AuthService>();
			authService.Delete(new Auth {
				provider = AuthService.LogoutAction
			});
			
			var cache = authService.TryResolve<IRedisClientsManager>();
			if(cache!=null){
				var sessionId = authService.GetSessionId();
				
				var pattern = string.Format("urn:{0}:*", sessionId);
				cache.Execute(client=>{
					var keys =client.SearchKeys(pattern);
					client.RemoveAll(keys);
				}); 	
				
			}
		}

	}
}

