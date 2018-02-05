using System.Collections.Generic;
using System.Threading.Tasks;
using Messenger.Core.Interfaces;
using Messenger.Core.Models;
using Messenger.Core.DbInitializing;
using Microsoft.EntityFrameworkCore;

namespace Messenger.Core.Implementations
{
	public class ChatsRepository : IChatsRepository
	{
		private MessengerContext _dbContext;

		public ChatsRepository(MessengerContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<Chat> CreateChatAsync(Chat chat)
		{
			await _dbContext.Chats.AddAsync(chat);

			await _dbContext.SaveChangesAsync();

			var lastId = GetLastChatId();
			
			return await GetChatAsync(lastId);
		}

		public async Task DeleteChatAsync(int id)
		{
			var chat = await GetChatAsync(id);
			chat.IsDeleted = true;

			 _dbContext.Chats.Update(chat);

			await _dbContext.SaveChangesAsync();
		}

		public Task<Chat> GetChatAsync(int id)
		{
			return _dbContext.Chats.FindAsync(id);
		}

		public async Task<IEnumerable<Chat>> GetChatsAsync()
		{
			return await _dbContext.Chats.ToListAsync();
		}

		private int GetLastChatId()
		{
			return _dbContext.Chats.LastAsync(x => !x.IsDeleted).Id;
		}
	}
}