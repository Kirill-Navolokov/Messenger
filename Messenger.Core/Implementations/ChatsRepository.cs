using System.Collections.Generic;
using System.Threading.Tasks;
using Messenger.Core.Interfaces;
using Messenger.Core.Models;
using SQLite;

namespace Messenger.Core.Implementations
{
	public class ChatsRepository : IChatsRepository
	{
		private SQLiteAsyncConnection _connection;

		public ChatsRepository(ISqlLiteConnectionFactory sqlLiteConnectionFactory)
		{
			_connection = sqlLiteConnectionFactory.Connection;
		}

		public Task<Chat> CreateChatAsync(Chat chat)
		{
			var lastId = GetLastChatId();
			chat.Id = lastId + 1;
			_connection.InsertAsync(chat);

			return GetChatAsync(chat.Id);
		}

		public async Task DeleteChatAsync(int id)
		{
			var chat = await GetChatAsync(id);

			await _connection.DeleteAsync(chat);
		}

		public async Task<Chat> GetChatAsync(int id)
		{
			return await _connection.Table<Chat>()
									.Where(chat => chat.Id == id)
									.FirstAsync();
		}

		public async Task<IEnumerable<Chat>> GetChatsAsync()
		{
			return await _connection.Table<Chat>().ToListAsync();
		}

		private int GetLastChatId()
		{
			return _connection.Table<Chat>()
							  .OrderByDescending(chat => chat.Id)
							  .FirstAsync().Id;
		}
	}
}