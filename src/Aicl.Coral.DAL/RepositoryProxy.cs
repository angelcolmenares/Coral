using System;
using ServiceStack.OrmLite;
using ServiceStack.Redis;
using System.Data;
using ServiceStack.DesignPatterns.Model;
using ServiceStack.Common;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Aicl.Coral.DAL
{
	public class RepositoryProxy:IDisposable 
	{

		IDbTransaction dbTransaction=null;

		internal IDbConnection DbConn { get; private set; }
				
		internal IRedisClient RedisClient { get; private set; }


		public RepositoryProxy (IDbConnectionFactory dbConnectionFactory, IRedisClientsManager redisClientsManager)
		{
			DbConn = dbConnectionFactory.OpenDbConnection(); 
			RedisClient= redisClientsManager.GetClient();
		}

		public void BeginDbTransaction()
		{
			if (dbTransaction == null)
				dbTransaction = DbConn.BeginTransaction ();
		}
		
		public void CommitDbTransaction()
		{
			if(dbTransaction!=null)
			{
				dbTransaction.Commit();
				dbTransaction.Dispose();
				dbTransaction=null;
			}
		}
		
		public void RollbackDbTransaction()
		{
			if(dbTransaction!=null)
			{
				dbTransaction.Rollback();
				dbTransaction.Dispose();
				dbTransaction=null;
			}
		}

		public IDisposable AcquireLock(string lockKey, double timeOut)
		{
			return RedisClient.AcquireLock(lockKey, TimeSpan.FromSeconds(timeOut));
		}


		public void CreateTable<T>(bool overwrite = false) where T: new()
		{
			DbConn.CreateTable<T> (overwrite);
		}

		public T Create<T>(object model,SqlExpressionVisitor<T> visitor=null) where T:  IHasIntId,  new ()
		{
			T c = new T();
			c.PopulateWith(model);
			DbConn.InsertAndAssertId(c,visitor);
			return c;
		}

		public List<T> Read<T>( SqlExpressionVisitor<T> visitor)
		{
			return DbConn.Select (visitor);
		}

		public List<T> Read<T>(Expression<Func<T, bool>> predicate)
		{
			return DbConn.Select (predicate);
		}

		public List<T> Read<T>()
		{
			return DbConn.Select<T> ();

		}

		public T FirstOrDefault<T>(Expression<Func<T, bool>> predicate)
		{
			return DbConn.FirstOrDefault (predicate);
		}

		public long Count<T>(Expression<Func<T, bool>> predicate= null )
			where T: IHasIntId, new()
		{
			return  DbConn.GetScalar<T,long>( e=>  Sql.Count(e.Id),	predicate??PredicateBuilder.True<T>());
		}


		public T Update<T>(T record, Expression<Func<T, bool>> predicate)
		{
			DbConn.UpdateOnly<T>(record, ReadExtensions.CreateExpression<T>().Where(predicate));
			return DbConn.FirstOrDefault (predicate);
		}

		public T Update<T>(T record, SqlExpressionVisitor<T> visitor)
		{
			DbConn.UpdateOnly<T>(record, visitor);
			return DbConn.FirstOrDefault (visitor);
		}


		public void Destroy<T>(Expression<Func<T, bool>> predicate)
		{
			DbConn.Delete<T> (predicate);
		}

		#region IDisposable implementation

		public void Dispose ()
		{
			RedisClient.Dispose ();
			DbConn.Dispose ();
		}

		#endregion
	}
}

