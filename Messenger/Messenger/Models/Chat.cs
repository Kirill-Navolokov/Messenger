using System.Collections.Generic;

namespace Messenger.Models
{
	public class Chat
	{
		public bool IsPrivate { get; set; }

		public List<User> Members { get; set; } = new List<User>();

		public List<Message> Messages { get; set; } = new List<Message>();

		public string Name { get; set; }
	}
}