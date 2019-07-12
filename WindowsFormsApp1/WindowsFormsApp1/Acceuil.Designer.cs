namespace WindowsFormsApp1
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
            this.Anime = new System.Windows.Forms.Button();
            this.Film = new System.Windows.Forms.Button();
            this.Série = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Anime
            // 
            this.Anime.AutoSize = true;
            this.Anime.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Anime.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anime.Location = new System.Drawing.Point(47, 222);
            this.Anime.Name = "Anime";
            this.Anime.Size = new System.Drawing.Size(207, 120);
            this.Anime.TabIndex = 0;
            this.Anime.Text = "Anime";
            this.Anime.UseVisualStyleBackColor = false;
            this.Anime.Click += new System.EventHandler(this.Anime_Click);
            // 
            // Film
            // 
            this.Film.AutoSize = true;
            this.Film.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Film.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Film.Location = new System.Drawing.Point(332, 220);
            this.Film.Name = "Film";
            this.Film.Size = new System.Drawing.Size(215, 122);
            this.Film.TabIndex = 1;
            this.Film.Text = "Film";
            this.Film.UseVisualStyleBackColor = false;
            this.Film.Click += new System.EventHandler(this.Film_Click);
            // 
            // Série
            // 
            this.Série.AutoSize = true;
            this.Série.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Série.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Série.Location = new System.Drawing.Point(610, 220);
            this.Série.Name = "Série";
            this.Série.Size = new System.Drawing.Size(200, 120);
            this.Série.TabIndex = 2;
            this.Série.Text = "Série";
            this.Série.UseVisualStyleBackColor = false;
            this.Série.Click += new System.EventHandler(this.Série_Click);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(115, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(589, 68);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Welcome on Overview !!";
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(876, 433);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Série);
            this.Controls.Add(this.Film);
            this.Controls.Add(this.Anime);
            this.Name = "Overview";
            this.Text = "OverView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Anime;
        private System.Windows.Forms.Button Film;
        private System.Windows.Forms.Button Série;
        private System.Windows.Forms.TextBox textBox1;
    }
}

