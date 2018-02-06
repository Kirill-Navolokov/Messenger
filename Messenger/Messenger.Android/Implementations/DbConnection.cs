using Messenger.Core.Interfaces;
using Messenger.Core.Settings;
using System.IO;

namespace Messenger.Droid.Implementations
{
	public class DbConnection : IDbConnection
	{
		public string GetConnection()
		{
			var dbName = Settings.DatabaseName;
			var personalFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			var connectionString = Path.Combine(personalFolder, dbName);

			return connectionString;
		}
	}
}