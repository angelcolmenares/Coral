using System;
using Aicl.Coral.Modelos;
using ServiceStack.ServiceInterface.Auth;
using ServiceStack.ServiceInterface;
using Aicl.Coral.BL;
using ServiceStack.Redis;
using ServiceStack.FluentValidation;
using ServiceStack.Common.Web;
using ServiceStack.ServiceInterface.ServiceModel;
using System.Text;

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


			try{
				var lr= request.Do (Controller, session.UserAuthId);
				session.Permissions = lr.Actividades;
				session.Roles.Add ("User"); 
				authService.SaveSession(session);
				lr.DisplayName = session.DisplayName;
				lr.Email = session.Email;
				return lr;
			}
			catch(ValidationException e){

				authService.RemoveSession();
				authService.RemoveUserData ();
				var rs = ((IResponseStatusConvertible)e).ToResponseStatus();
				var ms = new StringBuilder();
				rs.Errors.ForEach(x=>ms.Append( x.Message));
				throw HttpError.Conflict( ms.ToString());
			}

		}

		public void Post(UserLogout request){
			
			AuthService authService = base.ResolveService<AuthService>();
			authService.Delete(new Auth {
				provider = AuthService.LogoutAction
			});

			authService.RemoveUserData ();

		}


	}
}

