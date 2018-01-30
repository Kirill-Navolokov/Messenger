using SQLite;
using System.Threading.Tasks;

namespace Messenger.Core.Interfaces
{
	public interface ISqlLiteConnectionFactory
    {
		void SetConnection(SQLiteAsyncConnection connection);

		Task Initialize();

		SQLiteAsyncConnection Connection { get; }
    }
}