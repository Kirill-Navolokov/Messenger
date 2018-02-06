using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ReactiveUI;
using Messenger.Core.ViewModels;
using Messenger.Core.Interfaces;
using Autofac;

namespace Messenger.Droid.Views.ChatsPage
{
	[Activity(MainLauncher = true)]
	public class ChatsPageView : ReactiveActivity<ChatsPageViewModel>
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.chats_page);

			var dbInitializer = App.Container.Resolve<IDbInitialier>();
			dbInitializer.FillDatabaseWithDefaultData();
		}
	}
}