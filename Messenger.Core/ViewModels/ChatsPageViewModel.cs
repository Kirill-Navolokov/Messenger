using Messenger.Core.Interfaces;
using Messenger.Core.Models;
using ReactiveUI;
using System.Collections.Generic;

namespace Messenger.Core.ViewModels
{
    public class ChatsPageViewModel : BaseViewModel
    {
		private IChatsRepository _chatsRepository;

		private ReactiveCommand _setChatsCommand;

		public ChatsPageViewModel(IChatsRepository chatsRepository)
		{
			_chatsRepository = chatsRepository;

			_setChatsCommand = ReactiveCommand.Create(async () =>
			{
				var chats = await _chatsRepository.GetChatsAsync();
				Chats.AddRange(chats);
			});
		}

		public ReactiveList<Chat> Chats { get; set; } = new ReactiveList<Chat> { ChangeTrackingEnabled = true };
    }
}