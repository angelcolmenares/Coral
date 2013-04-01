using System;
using NUnit.Framework;
using Aicl.Coral.Modelos;
using Cayita.Tools;

namespace Aicl.Coral.Test1
{

	public class Test:TestBase
	{
		[Test()]
		public void CrearEmpresa1 ()
		{
			var empresa = Client.Post<Empresa> (new EmpresaCreate{
				Codigo="XX",
				Nit="789",
				Nombre="La Empresota",
				Dv="8",
				RepresentanteLegal="Ignacio",
				Direccion= "calle 13",
				Telefono="555",
				IdAdministradora= 35,
				Email="empresa@mail.com"
			});

			Console.WriteLine (empresa);

			Client.Post (new EmpresaDestroy{Id=empresa.Id});
		}

		[Test()]
		public void CrearEmpresa2 ()
		{
			var empresa = Client.Post<Empresa> (new EmpresaCreate{
				Codigo="XX",
				Nit="789",
				Nombre="La Empresota",
				Dv="8",
				RepresentanteLegal="Ignacio",
				Direccion= "calle 13",
				Telefono="555",
				IdAdministradora= 35,
				Email="empresa@mail.com"
			});
			
			Console.WriteLine (empresa);
			
			Client.Post (new EmpresaDestroy{Id=empresa.Id});
		}

		[Test]
		public void LeerEmpresa()
		{
			var empresas= Client.Post<TList<Empresa>> (new EmpresaRead ());
			foreach (var empresa in empresas.Result) {
				Console.WriteLine(empresa.Nit);
			}

		}
	}
}

