using Raid.Toolkit.Extensibility;
using Client.App;
using Client.RaidApp;
using System;
using System.Windows.Forms;

namespace TestRaidExtension
{
	public class MyExtension : IExtensionPackage
	{
		private IDisposable m_backgroundServiceHandle;
		private MyExtensionUI m_userInterface;
		public void Dispose()
		{
			m_userInterface?.Dispose();
			m_userInterface = null;
		}

		public void OnActivate(IExtensionHost host)
		{
			m_backgroundServiceHandle = host.RegisterBackgroundService<MyBackgroundService>();
			m_userInterface = host.CreateInstance<MyExtensionUI>();
			m_userInterface.Show();
		}

		public void OnDeactivate(IExtensionHost host)
		{
			m_userInterface?.Dispose();
			m_userInterface = null;

			m_backgroundServiceHandle?.Dispose();
			m_backgroundServiceHandle = null;
		}

		public void OnInstall(IExtensionHost host)
		{
		}

		public void OnUninstall(IExtensionHost host)
		{
		}
	}
}
