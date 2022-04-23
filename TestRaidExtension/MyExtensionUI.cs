using System;
using System.ComponentModel;
using System.Text;
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
    }
}
