namespace TestRaidExtension
{
	partial class MyExtensionUI
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyExtensionUI));
			this.currentViewLabel = new System.Windows.Forms.Label();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.SuspendLayout();
			// 
			// currentViewLabel
			// 
			this.currentViewLabel.AutoSize = true;
			this.currentViewLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.currentViewLabel.Location = new System.Drawing.Point(12, 9);
			this.currentViewLabel.Name = "currentViewLabel";
			this.currentViewLabel.Size = new System.Drawing.Size(264, 45);
			this.currentViewLabel.TabIndex = 0;
			this.currentViewLabel.Text = "currentViewLabel";
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "MyExtension";
			this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
			// 
			// MyExtensionUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 381);
			this.Controls.Add(this.currentViewLabel);
			this.Name = "MyExtensionUI";
			this.Text = "MyExtensionUI";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label currentViewLabel;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
	}
}