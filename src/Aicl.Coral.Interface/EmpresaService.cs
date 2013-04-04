using System;
using Aicl.Coral.Modelos;
using Cayita.Tools;
using Aicl.Coral.BL;

namespace Aicl.Coral.Interface
{
	public class EmpresaService:AppServiceBase
	{
		public Empresa Post(EmpresaCreate empresa)
		{
			return empresa.Do (Controller);
		}

		public TList<Empresa> Post(EmpresaRead empresa)
		{
			return empresa.Do (Controller);
		}

		public TList<Empresa> Get(EmpresaRead empresa)
		{
			return empresa.Do (Controller);
		}


		public Empresa Post (EmpresaUpdate empresa)
		{
			return empresa.Do (Controller);
		}

		public void Post (EmpresaDestroy empresa)
		{
			empresa.Do (Controller);
		}
	}
}

