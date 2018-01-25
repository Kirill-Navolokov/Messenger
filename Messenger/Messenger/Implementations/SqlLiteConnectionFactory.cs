using Messenger.Interfaces;
using System.Threading.Tasks;
using SQLite;
using Messenger.Models;

namespace Messenger.Implementations
{
	public class SqlLiteConnectionFactory : ISqlLiteConnectionFactory
	{
		private static SQLiteAsyncConnection _asyncConnection;

		public void SetDbConnection(SQLiteAsyncConnection connection)
		{
			if (_asyncConnection == null)
			{
				_asyncConnection = connection;
			}
		}

		public Task Initialize()
		{
			return _asyncConnection.CreateTableAsync<Chat>();
		}
	}
}