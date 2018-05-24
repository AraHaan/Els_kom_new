// Copyright (c) 2014-2018, Els_kom org.
// https://github.com/Elskom/
// All rights reserved.
// license: MIT, see LICENSE for more details.

namespace Els_kom_Core.Controls
{
    partial class AboutControl
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

        /// <summary>
        /// Ok button on the Control.
        /// </summary>
        public System.Windows.Forms.Button CmdOK;
        /// <summary>
        /// Icon Picture on the Control.
        /// </summary>
        public System.Windows.Forms.PictureBox picIcon;


        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Text1 = new System.Windows.Forms.TextBox();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblDisclaimer = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.CmdOK = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Text1
            // 
            this.Text1.AcceptsReturn = true;
            this.Text1.BackColor = System.Drawing.SystemColors.Control;
            this.Text1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text1.Location = new System.Drawing.Point(8, 74);
            this.Text1.MaxLength = 0;
            this.Text1.Multiline = true;
            this.Text1.Name = "Text1";
            this.Text1.ReadOnly = true;
            this.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Text1.Size = new System.Drawing.Size(361, 61);
            this.Text1.TabIndex = 7;
            this.Text1.Text = "This version of Els_kom can test mods and update the game when a maintenance happens. It has also gone through a lot of changes including the removal of the stubs that used to handle the testing of mods and the updating of the game.";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.picIcon.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.picIcon.Location = new System.Drawing.Point(18, 15);
            this.picIcon.Name = "picIcon";
            this.picIcon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.picIcon.Size = new System.Drawing.Size(48, 48);
            this.picIcon.TabIndex = 1;
            this.picIcon.TabStop = false;
            // 
            // lblDisclaimer
            // 
            this.lblDisclaimer.BackColor = System.Drawing.SystemColors.Control;
            this.lblDisclaimer.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDisclaimer.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisclaimer.ForeColor = System.Drawing.Color.Black;
            this.lblDisclaimer.Location = new System.Drawing.Point(8, 149);
            this.lblDisclaimer.Name = "lblDisclaimer";
            this.lblDisclaimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDisclaimer.Size = new System.Drawing.Size(249, 31);
            this.lblDisclaimer.TabIndex = 6;
            this.lblDisclaimer.Text = "Visit my Forum topic here if you would like to post something about my Els_kom.";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(74, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(259, 16);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Els_kom v1.4.9.8";
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.Location = new System.Drawing.Point(72, 45);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescription.Size = new System.Drawing.Size(282, 30);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "This tool allows you to Edit koms freely. Also this is a tool that replaces gPatc" +
    "her but with some limitations. l0l";
            // 
            // CmdOK
            // 
            this.CmdOK.BackColor = System.Drawing.Color.Transparent;
            this.CmdOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.CmdOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdOK.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CmdOK.Location = new System.Drawing.Point(280, 181);
            this.CmdOK.Name = "CmdOK";
            this.CmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdOK.Size = new System.Drawing.Size(84, 21);
            this.CmdOK.TabIndex = 2;
            this.CmdOK.Text = "OK";
            this.CmdOK.UseVisualStyleBackColor = false;
            this.CmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // linkLabel1
            //
            this.linkLabel1.Location = new System.Drawing.Point(256, 149);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 15);
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Topic Here";
            this.linkLabel1.Click += new System.EventHandler(this.LinkLabel1_Click);
            this.linkLabel1.MouseEnter += new System.EventHandler(this.LinkLabel1_MouseEnter);
            this.linkLabel1.MouseLeave += new System.EventHandler(this.LinkLabel1_MouseLeave);
            //
            // AboutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.lblDisclaimer);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.CmdOK);
            this.Name = "AboutControl";
            this.Size = new System.Drawing.Size(382, 207);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AboutControl_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal System.Windows.Forms.TextBox Text1;
        internal System.Windows.Forms.Label lblDisclaimer;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.Label lblDescription;
        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
