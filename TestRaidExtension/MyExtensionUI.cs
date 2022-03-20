using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestRaidExtension
{
    public partial class MyExtensionUI : Form
    {
        public MyExtensionUI()
        {
            InitializeComponent();
            InvalidateViewLabel();
            MyBackgroundService.CurrentViewKeyChanged += MyBackgroundService_CurrentViewKeyChanged;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            e.Cancel = true;
            notifyIcon1.Visible = true;
            Hide();
        }

        private void MyBackgroundService_CurrentViewKeyChanged(object sender, EventArgs e)
        {
            InvalidateViewLabel();
        }

        private void InvalidateViewLabel()
        {
            StringBuilder sb = new();
            foreach (var (processId, label) in MyBackgroundService.CurrentViewKey)
            {
                sb.AppendLine($"Process #{processId}: {label.ToString()}");
            }
            currentViewLabel.Text = sb.ToString();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            Show();
        }
    }
}
