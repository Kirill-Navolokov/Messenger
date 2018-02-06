using System.Threading.Tasks;
using Messenger.Core.Interfaces;
using Messenger.Core.Models;

namespace Messenger.Core.Implementations
{
    public class MessagesRepository : IMessagesRepository
    {
		private IDbConnection _dbConnection;

		public MessagesRepository(IDbConnection dbConnection)
		{
			_dbConnection = dbConnection;
		}

		public Task CreateMessageAsync(int chatId, Message message)
		{
			throw new System.NotImplementedException();
		}

		public Task DeleteMessageAsync(int chatId, int messageId)
		{
			throw new System.NotImplementedException();
		}
	}
}