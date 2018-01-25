using SQLite;

namespace Messenger.Core.Interfaces
{
	public interface IDbConnection
    {
		SQLiteAsyncConnection GetConnection();
    }
}