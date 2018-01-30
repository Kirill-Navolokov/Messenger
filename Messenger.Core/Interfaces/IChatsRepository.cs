using Messenger.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Messenger.Core.Interfaces
{
	public interface IChatsRepository
    {
		Task<Chat> CreateChatAsync(Chat chat);
		
		Task DeleteChatAsync(int id);

		Task<IEnumerable<Chat>> GetChatsAsync();

		Task<Chat> GetChatAsync(int id);
    }
}