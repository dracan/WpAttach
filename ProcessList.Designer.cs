namespace WpAttach
{
	partial class ProcessList
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
			if(disposing && (components != null))
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
			this.lbProcesses = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// lbProcesses
			// 
			this.lbProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbProcesses.FormattingEnabled = true;
			this.lbProcesses.Location = new System.Drawing.Point(0, 0);
			this.lbProcesses.Name = "lbProcesses";
			this.lbProcesses.Size = new System.Drawing.Size(328, 262);
			this.lbProcesses.TabIndex = 0;
			this.lbProcesses.DoubleClick += new System.EventHandler(this.lbProcesses_DoubleClick);
			this.lbProcesses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbProcesses_KeyPress);
			// 
			// ProcessList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 262);
			this.Controls.Add(this.lbProcesses);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "ProcessList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Select Process to Attach To";
			this.Load += new System.EventHandler(this.ProcessList_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbProcesses;
	}
}