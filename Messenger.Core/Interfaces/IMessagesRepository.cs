using Messenger.Core.Models;
using System.Threading.Tasks;

namespace Messenger.Core.Interfaces
{
	public interface IMessagesRepository
    {
		Task CreateMessageAsync(int chatId, Message message);

		Task DeleteMessageAsync(int chatId, int messageId);
    }
}