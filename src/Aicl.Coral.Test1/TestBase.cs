using System;
using NUnit.Framework;
using ServiceStack.ServiceClient.Web;

namespace Aicl.Coral.Test1
{
	public class TestBase:IDisposable
	{
		protected const string BaseUrl = "http://localhost:8080/api";

		protected JsonServiceClient Client;

		[TestFixtureSetUp]
		public virtual void TestFixtureSetUp()
		{
			Client = new JsonServiceClient(BaseUrl);
			Console.WriteLine ("TestFixtureSetUp");
		}
		
		[TestFixtureTearDown]
		public void TestFixtureTearDown()
		{
			Console.WriteLine ("TestFixtureTearDown");
			Dispose();
		}

		#region IDisposable implementation

		public void Dispose ()
		{
			Client.Dispose ();
		}

		#endregion
	}
}

