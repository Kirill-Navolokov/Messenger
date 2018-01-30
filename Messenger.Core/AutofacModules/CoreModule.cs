using Autofac;
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

			base.Load(builder);
		}
	}
}