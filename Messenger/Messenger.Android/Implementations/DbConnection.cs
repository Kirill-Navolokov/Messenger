using Messenger.Core.Interfaces;
using Messenger.Core.Settings;
using SQLite;
using System.IO;

namespace Messenger.Droid.Implementations
{
	public class DbConnection : IDbConnection
	{
		public SQLiteAsyncConnection GetConnection()
		{
			var dbName = Settings.DatabaseName;
			var personalFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			var path = Path.Combine(personalFolder, dbName);

			return new SQLiteAsyncConnection(path);
		}
	}
}