using ServiceStack.ServiceInterface;
using Aicl.Coral.BL;
using ServiceStack.ServiceHost;
using Cayita.Tools;

namespace Aicl.Coral.Interface
{
	public class AppServiceBase:Service
	{

		public Controller Controller { get; set; }

		public bool IsCayita (IRequestContext requestContext)
		{
			var httpReq= requestContext.Get<IHttpRequest>();
			return httpReq.IsCayita();
		}
		
		public Pager Paginador(IRequestContext requestContext)
		{
			var httpRequest= requestContext.Get<IHttpRequest>();
			return httpRequest.BuildPager();
		}

	}
}

