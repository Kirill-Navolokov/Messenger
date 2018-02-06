using System;

using Android.App;
using Android.Runtime;
using Autofac;
using Messenger.Droid.AutofacModules;
using Messenger.Core.AutofacModules;
using Messenger.Core.Interfaces;
using System.Threading.Tasks;
using Messenger.Core.DbInitializing;

namespace Messenger.Droid
{
	[Application(HardwareAccelerated = true)]
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

		private void Initialize()
		{
			RegisterIoCmodules();

			//SetUpDatabaseConnection();
		}

		private void RegisterIoCmodules()
		{
			var builder = new ContainerBuilder();
			builder.RegisterModule<DroidModule>();
			builder.RegisterModule<CoreModule>();

			Container = builder.Build();
		}

		private async void SetUpDatabaseConnection()
		{
			await Task.Run(async() =>
			{
				//var dbConnection = Container.Resolve<IDbConnection>();
				//var connectionString = dbConnection.GetConnection();
				
				
			});
		}
	}
}