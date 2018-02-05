using Messenger.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Messenger.Core.DbInitializing
{
	public class MessengerContext : DbContext
	{
		private string _databasePath;

		public MessengerContext(string databasePath)
		{
			_databasePath = databasePath;
		}

		public DbSet<Chat> Chats { get; set; }

		public DbSet<Message> Messages { get; set; }

		public DbSet<User> Users { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite($"Filename={_databasePath}");
		}
	}
}
