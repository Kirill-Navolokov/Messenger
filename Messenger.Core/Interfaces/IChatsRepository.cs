using Messenger.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Messenger.Core.Interfaces
{
	public interface IChatsRepository
    {
		Task<Chat> CreateAsync(Chat chat);
		
		Task DeleteAsync(int id);

		Task<IEnumerable<Chat>> GetAllAsync();

		Task<Chat> GetAsync(int id);
    }
}