using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Anime_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrir_Anime));
            monthread.Start();
            this.Close();
        }

        private void Film_Click(object sender, EventArgs e)
        {

        }

        private void Série_Click(object sender, EventArgs e)
        {

        }

        private void ouvrir_Anime()
        {
            Application.Run(new Anime());
        }

        
    }
}
