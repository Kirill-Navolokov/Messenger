using Messenger.Core.Interfaces;

namespace Messenger.Core.Implementations
{
    public class MessagesRepository
    {
		private IDbConnection _dbConnection;

		public MessagesRepository(IDbConnection dbConnection)
		{
			_dbConnection = dbConnection;
		}
    }
}