namespace Overview
{
    partial class Overview
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            this.BT_Anime = new System.Windows.Forms.Button();
            this.BT_Film = new System.Windows.Forms.Button();
            this.BT_Serie = new System.Windows.Forms.Button();
            this.LB_Welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_Anime
            // 
            this.BT_Anime.AutoSize = true;
            this.BT_Anime.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BT_Anime.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Anime.Location = new System.Drawing.Point(50, 220);
            this.BT_Anime.Name = "BT_Anime";
            this.BT_Anime.Size = new System.Drawing.Size(207, 120);
            this.BT_Anime.TabIndex = 0;
            this.BT_Anime.Text = "Anime";
            this.BT_Anime.UseVisualStyleBackColor = false;
            this.BT_Anime.Click += new System.EventHandler(this.Anime_Click);
            // 
            // BT_Film
            // 
            this.BT_Film.AutoSize = true;
            this.BT_Film.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BT_Film.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Film.Location = new System.Drawing.Point(320, 220);
            this.BT_Film.Name = "BT_Film";
            this.BT_Film.Size = new System.Drawing.Size(207, 120);
            this.BT_Film.TabIndex = 1;
            this.BT_Film.Text = "Film";
            this.BT_Film.UseVisualStyleBackColor = false;
            this.BT_Film.Click += new System.EventHandler(this.Film_Click);
            // 
            // BT_Serie
            // 
            this.BT_Serie.AutoSize = true;
            this.BT_Serie.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BT_Serie.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Serie.Location = new System.Drawing.Point(590, 220);
            this.BT_Serie.Name = "BT_Serie";
            this.BT_Serie.Size = new System.Drawing.Size(207, 120);
            this.BT_Serie.TabIndex = 2;
            this.BT_Serie.Text = "Série";
            this.BT_Serie.UseVisualStyleBackColor = false;
            this.BT_Serie.Click += new System.EventHandler(this.Série_Click);
            // 
            // LB_Welcome
            // 
            this.LB_Welcome.AutoSize = true;
            this.LB_Welcome.BackColor = System.Drawing.Color.White;
            this.LB_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.LB_Welcome.Location = new System.Drawing.Point(219, 97);
            this.LB_Welcome.Name = "LB_Welcome";
            this.LB_Welcome.Size = new System.Drawing.Size(433, 44);
            this.LB_Welcome.TabIndex = 3;
            this.LB_Welcome.Text = "Welcome on Overview !!";
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(856, 433);
            this.Controls.Add(this.LB_Welcome);
            this.Controls.Add(this.BT_Serie);
            this.Controls.Add(this.BT_Film);
            this.Controls.Add(this.BT_Anime);
            this.Name = "Overview";
            this.Text = "OverView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Anime;
        private System.Windows.Forms.Button BT_Film;
        private System.Windows.Forms.Button BT_Serie;
        private System.Windows.Forms.Label LB_Welcome;
    }
}

