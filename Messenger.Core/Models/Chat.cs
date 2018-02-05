using System.Collections.Generic;

namespace Messenger.Core.Models
{
    public class Chat : BaseModel
    {
		public bool IsPrivate { get; set; }

		public virtual ICollection<User> Members { get; set; } = new List<User>();

		public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

		public string Name { get; set; }
    }
}