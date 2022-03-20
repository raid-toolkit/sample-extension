using Client.App;
using Client.RaidApp;
using Client.ViewModel.DTO;
using Raid.Toolkit.Extensibility;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestRaidExtension
{
	internal class MyBackgroundService : IBackgroundService
	{
		private readonly static TimeSpan kPollInterval = new(0, 0, 0, 0, 100);
		public TimeSpan PollInterval => kPollInterval;

		public static readonly Dictionary<int, ViewKey> CurrentViewKey = new();
		public static event EventHandler<EventArgs> CurrentViewKeyChanged;

		public Task Tick(IGameInstance instance)
		{
			RaidApplication app = Application.GetStaticFields(instance.Runtime)._instance as RaidApplication;
			RaidViewMaster viewMaster = app._viewMaster as RaidViewMaster;
			ViewMeta topmostView = viewMaster._views[^1];
			CurrentViewKey[instance.Token] = topmostView.Key;
			CurrentViewKeyChanged?.Invoke(this, new EventArgs());
			return Task.CompletedTask;
		}
	}
}
