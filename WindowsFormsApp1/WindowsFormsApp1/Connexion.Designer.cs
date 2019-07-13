namespace Overview
{
    partial class Connexion
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
            this.LB_Username = new System.Windows.Forms.Label();
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.LB_Password = new System.Windows.Forms.Label();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TLM_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BT_Connect = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Username
            // 
            this.LB_Username.AutoSize = true;
            this.LB_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LB_Username.Location = new System.Drawing.Point(12, 52);
            this.LB_Username.Name = "LB_Username";
            this.LB_Username.Size = new System.Drawing.Size(145, 20);
            this.LB_Username.TabIndex = 0;
            this.LB_Username.Text = "Nom d\'utilisateur: ";
            // 
            // TB_Username
            // 
            this.TB_Username.Location = new System.Drawing.Point(202, 54);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(158, 20);
            this.TB_Username.TabIndex = 1;
            // 
            // LB_Password
            // 
            this.LB_Password.AutoSize = true;
            this.LB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LB_Password.Location = new System.Drawing.Point(12, 89);
            this.LB_Password.Name = "LB_Password";
            this.LB_Password.Size = new System.Drawing.Size(115, 20);
            this.LB_Password.TabIndex = 2;
            this.LB_Password.Text = "Mot de passe:";
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(202, 91);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(158, 20);
            this.TB_Password.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TLM_Exit,
            this.TSM_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(372, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TLM_Exit
            // 
            this.TLM_Exit.Name = "TLM_Exit";
            this.TLM_Exit.Size = new System.Drawing.Size(38, 20);
            this.TLM_Exit.Text = "Exit";
            this.TLM_Exit.Click += new System.EventHandler(this.TLM_Exit_Click);
            // 
            // TSM_Help
            // 
            this.TSM_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.TSM_Help.Name = "TSM_Help";
            this.TSM_Help.Size = new System.Drawing.Size(44, 20);
            this.TSM_Help.Text = "Help";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // BT_Connect
            // 
            this.BT_Connect.Location = new System.Drawing.Point(109, 147);
            this.BT_Connect.Name = "BT_Connect";
            this.BT_Connect.Size = new System.Drawing.Size(139, 23);
            this.BT_Connect.TabIndex = 5;
            this.BT_Connect.Text = "Connexion";
            this.BT_Connect.UseVisualStyleBackColor = true;
            this.BT_Connect.Click += new System.EventHandler(this.BT_Connect_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 182);
            this.Controls.Add(this.BT_Connect);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.LB_Password);
            this.Controls.Add(this.TB_Username);
            this.Controls.Add(this.LB_Username);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Connexion";
            this.Text = "Menu de connexion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Connexion_FormClosing);
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Username;
        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.Label LB_Password;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TLM_Exit;
        private System.Windows.Forms.ToolStripMenuItem TSM_Help;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Button BT_Connect;
    }
}