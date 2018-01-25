using System;

namespace Messenger.Models
{
	public class Message
	{
		public string Author { get; set; }

		public string Content { get; set; }

		public DateTime SendDate { get; set; }
	}
}