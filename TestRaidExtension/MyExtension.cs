using System;
using Raid.Toolkit.Extensibility;

namespace TestRaidExtension
{
	public class MyExtension : ExtensionPackage
	{
        private IExtensionHost Host;
		public override void OnActivate(IExtensionHost host)
		{
			Disposables.Add(host.RegisterBackgroundService<MyBackgroundService>());
			Host = host;
			MenuEntry menuEntry = new() { DisplayName = "Topmost View Sample", IsEnabled = true, IsVisible = true };
			menuEntry.Activate += OnShowUI;
			Disposables.Add(host.RegisterMenuEntry(menuEntry));
		}

		private void OnShowUI(object sender, EventArgs eventArgs)
		{
			MyExtensionUI dialog = Host.CreateInstance<MyExtensionUI>();
			Disposables.Add(dialog);
			dialog.Show();
			dialog.FormClosed += (s, e) =>
			{
				dialog.Dispose();
				Disposables.Remove(dialog);
			};
		}
	}
}
