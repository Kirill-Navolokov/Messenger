using Autofac;
using Messenger.Droid.Implementations;
using Messenger.Core.Interfaces;

namespace Messenger.Droid.AutofacModules
{
	public class DroidModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<DbConnection>().As<IDbConnection>();
			base.Load(builder);
		}
	}
}