using System;

namespace Messenger.Core.Models
{
    public class Message
    {
		public User Author { get; set; }

		public string Content { get; set; }

		public int Id { get; set; }

		public bool IsDeleted { get; set; }

		public DateTime SendDate { get; set; }
    }
}