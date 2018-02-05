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
			builder.RegisterType<SqlLiteConnectionFactory>().As<ISqlLiteConnectionFactory>();
			builder.RegisterType<DefaultDataProvider>().As<IDefaultDataProvider>();
			builder.RegisterType<MessengerContext>().AsSelf().InstancePerRequest();

			base.Load(builder);
		}
	}
}