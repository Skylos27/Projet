using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Overview
{
    public partial class Overview : Form
    {
        private SqlConnection _sqlConnection;

        public Overview(SqlConnection sqlConnection)
        {
            InitializeComponent();
            _sqlConnection = sqlConnection;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Anime_Click(object sender, EventArgs e)
        {
            Anime newWind = new Anime(_sqlConnection);   // On instancie la fenètre principale
            newWind.Show();
        }

        private void Film_Click(object sender, EventArgs e)
        {

        }

        private void Série_Click(object sender, EventArgs e)
        {

        }

        private void ouvrir_Anime()
        {
            Application.Run(new Anime(_sqlConnection));
        }

        
    }
}
