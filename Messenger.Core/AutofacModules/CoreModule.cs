using Autofac;
using Messenger.Core.DbInitializing;
using Messenger.Core.Implementations;
using Messenger.Core.Interfaces;

namespace Messenger.Core.AutofacModules
{
	public class CoreModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<DefaultDataProvider>().As<IDefaultDataProvider>();
			builder.RegisterType<DbInitializer>().As<IDbInitialier>();
			builder.RegisterType<ChatsRepository>().As<IChatsRepository>();
			builder.RegisterType<MessagesRepository>().As<IMessagesRepository>();
			builder.Register(context =>
			{
				var dbConnection = context.Resolve<IDbConnection>();
				return new MessengerContext(dbConnection.GetConnection());
			}).AsSelf().InstancePerLifetimeScope();

			base.Load(builder);
		}
	}
}