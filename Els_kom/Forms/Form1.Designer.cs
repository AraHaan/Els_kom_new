
using System.Windows.Forms;

namespace Els_kom
{
	partial class Form1
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
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		public System.Windows.Forms.Button Command5;
		public System.Windows.Forms.Timer Timer6;
		public System.Windows.Forms.Button Command4;
		public System.Windows.Forms.Button Command3;
		public System.Windows.Forms.Timer Timer2;
		public System.Windows.Forms.Timer Timer1;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.Button Command2;
		public System.Windows.Forms.Button Command1;
		public System.Windows.Forms.Label Label2;
		#region "Windows Form Designer generated code "
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.Command5 = new System.Windows.Forms.Button();
			this.Timer6 = new System.Windows.Forms.Timer(this.components);
			this.Command4 = new System.Windows.Forms.Button();
			this.Command3 = new System.Windows.Forms.Button();
			this.Timer2 = new System.Windows.Forms.Timer(this.components);
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Command2 = new System.Windows.Forms.Button();
			this.Command1 = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.PackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.UnpackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.TestModsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LauncherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Timer3 = new System.Windows.Forms.Timer(this.components);
			this.Timer4 = new System.Windows.Forms.Timer(this.components);
			this.timer5 = new System.Windows.Forms.Timer(this.components);
			this.Frame1.SuspendLayout();
			this.ContextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Command5
			// 
			this.Command5.BackColor = System.Drawing.Color.Transparent;
			this.Command5.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Command5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command5.Location = new System.Drawing.Point(8, 104);
			this.Command5.Name = "Command5";
			this.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command5.Size = new System.Drawing.Size(65, 21);
			this.Command5.TabIndex = 7;
			this.Command5.Text = "Launcher";
			this.Command5.UseVisualStyleBackColor = false;
			this.Command5.Click += new System.EventHandler(this.Command5_Click);
			this.Command5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Command5_MouseMove);
			// 
			// Timer6
			// 
			this.Timer6.Enabled = true;
			this.Timer6.Interval = 1;
			this.Timer6.Tick += new System.EventHandler(this.Timer6_Tick);
			// 
			// Command4
			// 
			this.Command4.BackColor = System.Drawing.Color.Transparent;
			this.Command4.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Command4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command4.Location = new System.Drawing.Point(8, 80);
			this.Command4.Name = "Command4";
			this.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command4.Size = new System.Drawing.Size(65, 21);
			this.Command4.TabIndex = 6;
			this.Command4.Text = "Test Mods";
			this.Command4.UseVisualStyleBackColor = false;
			this.Command4.Click += new System.EventHandler(this.Command4_Click);
			this.Command4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Command4_MouseMove);
			// 
			// Command3
			// 
			this.Command3.BackColor = System.Drawing.Color.Transparent;
			this.Command3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Command3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command3.Location = new System.Drawing.Point(8, 56);
			this.Command3.Name = "Command3";
			this.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command3.Size = new System.Drawing.Size(65, 21);
			this.Command3.TabIndex = 5;
			this.Command3.Text = "About";
			this.Command3.UseVisualStyleBackColor = false;
			this.Command3.Click += new System.EventHandler(this.Command3_Click);
			this.Command3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Command3_MouseMove);
			// 
			// Timer2
			// 
			this.Timer2.Interval = 1;
			this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
			// 
			// Timer1
			// 
			this.Timer1.Interval = 1;
			this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// Frame1
			// 
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.Label1);
			this.Frame1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(80, 0);
			this.Frame1.Name = "Frame1";
			this.Frame1.Padding = new System.Windows.Forms.Padding(0);
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(217, 137);
			this.Frame1.TabIndex = 2;
			this.Frame1.TabStop = false;
			// 
			// Label1
			// 
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(8, 8);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(203, 122);
			this.Label1.TabIndex = 3;
			this.Label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseMove);
			// 
			// Command2
			// 
			this.Command2.BackColor = System.Drawing.Color.Transparent;
			this.Command2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command2.Location = new System.Drawing.Point(8, 32);
			this.Command2.Name = "Command2";
			this.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command2.Size = new System.Drawing.Size(65, 21);
			this.Command2.TabIndex = 1;
			this.Command2.Text = "Unpack";
			this.Command2.UseVisualStyleBackColor = false;
			this.Command2.Click += new System.EventHandler(this.Command2_Click);
			this.Command2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Command2_MouseMove);
			// 
			// Command1
			// 
			this.Command1.BackColor = System.Drawing.Color.Transparent;
			this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command1.Location = new System.Drawing.Point(8, 8);
			this.Command1.Name = "Command1";
			this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command1.Size = new System.Drawing.Size(65, 21);
			this.Command1.TabIndex = 0;
			this.Command1.Text = "Pack";
			this.Command1.UseVisualStyleBackColor = false;
			this.Command1.Click += new System.EventHandler(this.Command1_Click);
			this.Command1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Command1_MouseMove);
			// 
			// Label2
			// 
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(0, 128);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(81, 17);
			this.Label2.TabIndex = 4;
			// 
			// NotifyIcon1
			// 
			this.NotifyIcon1.ContextMenuStrip = this.ContextMenuStrip1;
			this.NotifyIcon1.Visible = true;
			this.NotifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseClick);
			// 
			// ContextMenuStrip1
			// 
			this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PackToolStripMenuItem,
            this.UnpackToolStripMenuItem,
            this.ToolStripMenuItem3,
            this.SettingsToolStripMenuItem,
            this.ToolStripMenuItem1,
            this.TestModsToolStripMenuItem,
            this.LauncherToolStripMenuItem,
            this.ToolStripMenuItem2,
            this.ExitToolStripMenuItem});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			this.ContextMenuStrip1.Size = new System.Drawing.Size(130, 154);
			// 
			// PackToolStripMenuItem
			// 
			this.PackToolStripMenuItem.Name = "PackToolStripMenuItem";
			this.PackToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.PackToolStripMenuItem.Text = "Pack";
			this.PackToolStripMenuItem.Click += new System.EventHandler(this.PackToolStripMenuItem_Click);
			// 
			// UnpackToolStripMenuItem
			// 
			this.UnpackToolStripMenuItem.Name = "UnpackToolStripMenuItem";
			this.UnpackToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.UnpackToolStripMenuItem.Text = "Unpack";
			this.UnpackToolStripMenuItem.Click += new System.EventHandler(this.UnpackToolStripMenuItem_Click);
			// 
			// ToolStripMenuItem3
			// 
			this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
			this.ToolStripMenuItem3.Size = new System.Drawing.Size(126, 6);
			// 
			// SettingsToolStripMenuItem
			// 
			this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
			this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.SettingsToolStripMenuItem.Text = "Settings";
			this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
			// 
			// ToolStripMenuItem1
			// 
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			this.ToolStripMenuItem1.Size = new System.Drawing.Size(126, 6);
			// 
			// TestModsToolStripMenuItem
			// 
			this.TestModsToolStripMenuItem.Name = "TestModsToolStripMenuItem";
			this.TestModsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.TestModsToolStripMenuItem.Text = "Test Mods";
			this.TestModsToolStripMenuItem.Click += new System.EventHandler(this.TestModsToolStripMenuItem_Click);
			// 
			// LauncherToolStripMenuItem
			// 
			this.LauncherToolStripMenuItem.Name = "LauncherToolStripMenuItem";
			this.LauncherToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.LauncherToolStripMenuItem.Text = "Launcher";
			this.LauncherToolStripMenuItem.Click += new System.EventHandler(this.LauncherToolStripMenuItem_Click);
			// 
			// ToolStripMenuItem2
			// 
			this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
			this.ToolStripMenuItem2.Size = new System.Drawing.Size(126, 6);
			// 
			// ExitToolStripMenuItem
			// 
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.ExitToolStripMenuItem.Text = "Exit";
			this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// Timer3
			// 
			this.Timer3.Interval = 1;
			this.Timer3.Tick += new System.EventHandler(this.Timer3_Tick);
			// 
			// Timer4
			// 
			this.Timer4.Interval = 1;
			this.Timer4.Tick += new System.EventHandler(this.Timer4_Tick);
			// 
			// timer5
			// 
			this.timer5.Interval = 1;
			this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(304, 146);
			this.Controls.Add(this.Command5);
			this.Controls.Add(this.Command4);
			this.Controls.Add(this.Command3);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.Command2);
			this.Controls.Add(this.Command1);
			this.Controls.Add(this.Label2);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Location = new System.Drawing.Point(3, 23);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Els_kom v1.4.9.6";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.Frame1.ResumeLayout(false);
			this.ContextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		internal NotifyIcon NotifyIcon1;
		internal ContextMenuStrip ContextMenuStrip1;
		internal ToolStripMenuItem PackToolStripMenuItem;
		internal ToolStripMenuItem UnpackToolStripMenuItem;
		internal ToolStripSeparator ToolStripMenuItem1;
		internal ToolStripMenuItem TestModsToolStripMenuItem;
		internal ToolStripMenuItem LauncherToolStripMenuItem;
		internal ToolStripSeparator ToolStripMenuItem2;
		internal ToolStripMenuItem ExitToolStripMenuItem;
		internal ToolStripSeparator ToolStripMenuItem3;
		internal ToolStripMenuItem SettingsToolStripMenuItem;
		internal Timer Timer3;
		internal Timer Timer4;
		#endregion

		private Timer timer5;
	}
}