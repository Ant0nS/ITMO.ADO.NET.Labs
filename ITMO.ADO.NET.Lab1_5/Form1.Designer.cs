
namespace ITMO.ADO.NET.Lab1_2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBDisconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDBToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuDBToolStripMenuItem
            // 
            this.menuDBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBConnectToolStripMenuItem,
            this.dBDisconnectToolStripMenuItem,
            this.listConnectionToolStripMenuItem});
            this.menuDBToolStripMenuItem.Name = "menuDBToolStripMenuItem";
            this.menuDBToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.menuDBToolStripMenuItem.Text = "MenuDB";
            // 
            // dBConnectToolStripMenuItem
            // 
            this.dBConnectToolStripMenuItem.Name = "dBConnectToolStripMenuItem";
            this.dBConnectToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dBConnectToolStripMenuItem.Text = "DBConnect";
            this.dBConnectToolStripMenuItem.Click += new System.EventHandler(this.dBConnectToolStripMenuItem_Click);
            // 
            // dBDisconnectToolStripMenuItem
            // 
            this.dBDisconnectToolStripMenuItem.Name = "dBDisconnectToolStripMenuItem";
            this.dBDisconnectToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dBDisconnectToolStripMenuItem.Text = "DBDisconnect";
            this.dBDisconnectToolStripMenuItem.Click += new System.EventHandler(this.dBDisconnectToolStripMenuItem_Click);
            // 
            // listConnectionToolStripMenuItem
            // 
            this.listConnectionToolStripMenuItem.Name = "listConnectionToolStripMenuItem";
            this.listConnectionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listConnectionToolStripMenuItem.Text = "ListConnection";
            this.listConnectionToolStripMenuItem.Click += new System.EventHandler(this.listConnectionToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBDisconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listConnectionToolStripMenuItem;
    }
}

