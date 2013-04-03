using System.Collections.Generic;

namespace Aicl.Coral.Modelos
{
	public class UserLoginResponse
	{
		public UserLoginResponse ()
		{
			Actividades = new List<string> ();
			Menu = new List<Menu> ();
			SucursalesAutorizadas = new List<SucursalAutorizada> ();
		}

		public string DisplayName { get; set; }
		public string Email { get; set; }

		public Empresa Empresa { get; set; }

		public List<Centro> Centros { get; set; }

		public List<SucursalAutorizada> SucursalesAutorizadas { get; set; }

		public List<string> Actividades{ get; set; }

		public List<Menu> Menu { get; set; }
	}


	public class AdminLoginResponse
	{
		public AdminLoginResponse ()
		{
		}
	}


	public class Menu
	{
		public Menu()
		{
			Items = new List<Item> ();
		}

		public string Titulo { get; set; }
		public List<Item> Items { get; set; }

	}


	public class Item
	{
		public string Titulo { get; set; }
		public string Modulo { get; set; }
		public string Icono { get; set; }
	}


	public class SucursalAutorizada
	{
		public SucursalAutorizada()
		{
			IdCentros = new List<int> ();
		}

		public Sucursal Sucursal { get; set; }
		public List<int> IdCentros { get; set; }


	}
}
