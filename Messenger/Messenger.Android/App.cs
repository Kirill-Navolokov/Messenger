using System;

using Android.App;
using Android.Runtime;
using Autofac;
using Messenger.Droid.AutofacModules;
using Messenger.Core.AutofacModules;
using Messenger.Core.Interfaces;
using System.Threading.Tasks;

namespace Messenger.Droid
{
	[Application]
	public class App : Application
	{
		public App(IntPtr handle, JniHandleOwnership ownerShip) : base(handle, ownerShip)
		{
		}

		public static IContainer Container { get; set; }

		public override void OnCreate()
		{
			Initialize();

			base.OnCreate();
		}

		private async  void Initialize()
		{
			RegisterIoCmodules();

			await SetUpDatabaseConnection();
		}

		private void RegisterIoCmodules()
		{
			var builder = new ContainerBuilder();
			builder.RegisterModule<DroidModule>();
			builder.RegisterModule<CoreModule>();

			Container = builder.Build();
		}

		private Task SetUpDatabaseConnection()
		{
			var sqlLiteConnection = Container.Resolve<IDbConnection>();
			var sqLiteConnectionFactory = Container.Resolve<ISqlLiteConnectionFactory>();
			var connection = sqlLiteConnection.GetConnection();

			sqLiteConnectionFactory.SetConnection(connection);
			return sqLiteConnectionFactory.Initialize();
		}
	}
}