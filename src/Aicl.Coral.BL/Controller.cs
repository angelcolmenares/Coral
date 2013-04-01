using Cayita.Tools;
using System;
using ServiceStack.OrmLite;
using ServiceStack.Redis;

namespace Aicl.Coral.BL
{
	public class Controller :IDisposable
	{
		IDbConnectionFactory dbConnectionFactory;

		IRedisClientsManager redisClientsManager;

		public Controller (IDbConnectionFactory dbConnectionFactory, IRedisClientsManager redisClientsManager)
		{
			this.dbConnectionFactory = dbConnectionFactory;
			this.redisClientsManager = redisClientsManager;
		}

		public AppConfig Config { get; set; }

		public Mailer Mailer {get;  set;}


		protected internal void Execute(Action<DbProxy> proxy)
		{
			using (DbProxy p = new DbProxy (dbConnectionFactory, redisClientsManager))
				proxy (p);
		}


		protected internal T Execute<T>(Func<DbProxy,T> proxy)
		{
			using (DbProxy p = new DbProxy (dbConnectionFactory, redisClientsManager))
				return proxy (p);
		}

		#region IDisposable implementation
		public void Dispose ()
		{
		}
		#endregion
	}
}

