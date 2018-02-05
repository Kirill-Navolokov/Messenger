using System;

namespace Messenger.Core.Models
{
    public class Message :BaseModel
    {
		public virtual User Author { get; set; }

		public string Content { get; set; }
		
		public DateTime SendDate { get; set; }
    }
}