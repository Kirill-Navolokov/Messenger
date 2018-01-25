using System.Collections.Generic;

namespace Messenger.Models
{
	public class User
	{
		public string Name { get; set; }

		public string Surname { get; set; }

		public List<Chat> ChatsList { get; set; } = new List<Chat>();
	}
}