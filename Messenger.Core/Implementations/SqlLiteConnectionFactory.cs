using Messenger.Core.Interfaces;
using SQLite;
using System.Threading.Tasks;
using Messenger.Core.Models;

namespace Messenger.Core.Implementations
{
	public class SqlLiteConnectionFactory : ISqlLiteConnectionFactory
	{
		private SQLiteAsyncConnection _asyncConnection;

		public Task Initialize()
		{
			return _asyncConnection.CreateTableAsync<Chat>();
		}

		public void SetConnection(SQLiteAsyncConnection connection)
		{
			if (_asyncConnection == null)
			{
				_asyncConnection = connection;
			}
		}
	}
}