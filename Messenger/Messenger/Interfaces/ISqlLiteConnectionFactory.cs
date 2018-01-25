using SQLite;
using System.Threading.Tasks;

namespace Messenger.Interfaces
{
	public interface ISqlLiteConnectionFactory
	{
		void SetDbConnection(SQLiteAsyncConnection connection);

		Task Initialize();
	}
}