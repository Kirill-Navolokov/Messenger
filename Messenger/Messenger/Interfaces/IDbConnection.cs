using SQLite;

namespace Messenger.Interfaces
{
	public interface IDbConnection
	{
		SQLiteAsyncConnection GetConnection();
	}
}