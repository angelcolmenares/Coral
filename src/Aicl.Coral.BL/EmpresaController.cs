using Aicl.Coral.Modelos;
using System.Collections.Generic;
using Cayita.Tools;

namespace Aicl.Coral.BL
{
	public static class EmpresaController
	{
		public static Empresa Do(this EmpresaCreate empresa, Controller controller)
		{
			return controller.Execute( proxy=> proxy.Create<Empresa> (empresa));
		}

		public static TList<Empresa> Do(this EmpresaRead empresa, Controller controller)
		{
			return controller.Execute (proxy => proxy.Read<Empresa> ()).ConvertToTList();
		}

		public static Empresa Do(this EmpresaUpdate empresa, Controller controller)
		{
			return controller.Execute( proxy=> proxy.Update<Empresa> (empresa, f => f.Id == empresa.Id));
		}
		
		public static void Do(this EmpresaDestroy empresa, Controller controller)
		{
			controller.Execute (proxy => proxy.Destroy<Empresa> (f => f.Id == empresa.Id));
		}

	}
}

