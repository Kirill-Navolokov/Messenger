using System;
using System.Collections.Generic;
using System.Text;

namespace Messenger.Core.Models
{
    public class Chat
    {
		public int Id { get; set; }

		public bool IsDeleted { get; set; }

		public bool IsPrivate { get; set; }

		public List<User> Members { get; set; } = new List<User>();

		public List<Message> Messages { get; set; } = new List<Message>();

		public string Name { get; set; }
    }
}