using Messenger.Core.Interfaces;
using Messenger.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Messenger.Core.Implementations
{
    public class DefaultDataProvider : IDefaultDataProvider
	{
        private readonly IChatsRepository _chatsRepository;

        private User _firstUser;

		private User _secondUser;

		private Message _firstMessage;

		private Message _secondMessage;
        
		public DefaultDataProvider(IChatsRepository chatsRepository)
		{
            _chatsRepository = chatsRepository;
		}

        private List<Chat> _defaultChats { get; set; } = new List<Chat>();

        public async Task CheckAndCreateDefaultChat()
		{
            var defaultChats = await _chatsRepository.GetAllAsync();

			if (_defaultChats.Count == 0)
			{
				await CreateChatAsync();
			}
		}

		private async Task CreateChatAsync()
		{
			await CreateUsers();

			await CreateMessages();

			var chat = new Chat();
			chat.Name = "First";
			chat.Members.Add(_firstUser);
			chat.Members.Add(_secondUser);
			chat.Messages.Add(_firstMessage);
			chat.Messages.Add(_secondMessage);

            await _chatsRepository.CreateAsync(chat);
		}

		private async Task CreateUsers()
		{
			await Task.Run(() =>
			{
				_firstUser = new User
				{
					Name = "Kirill",
					Surname = "Navolokov"
				};

				_secondUser = new User
				{
					Name = "Elon",
					Surname = "Mask"
				};
			});
		}

		private async Task CreateMessages()
		{
			await Task.Run(() =>
			{
				_firstMessage = new Message
				{
					Author = _firstUser,
					Content = "Hello! How are I you?",
					SendDate = DateTime.UtcNow
				};

				_secondMessage = new Message
				{
					Author = _secondUser,
					Content = "I'm fine! U?",
					SendDate = DateTime.UtcNow.AddMinutes(10)
				};
			});
		}
	}
}