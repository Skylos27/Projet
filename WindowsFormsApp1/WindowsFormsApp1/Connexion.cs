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
    public partial class Connexion : Form
    {
        private const string _ConnexionString = "Server=51.75.23.80;Database=Overview;User Id=sa;Password=12345aA*";
        public SqlConnection _SqlConnection;


        public Connexion()
        {
            InitializeComponent();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            try
            {
                _SqlConnection = new SqlConnection(_ConnexionString);
                _SqlConnection.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur: " + err.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TLM_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Quitter", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                this.Close();   
        }

        private void BT_Connect_Click(object sender, EventArgs e)
        {
            string Username = this.TB_Username.Text;
            string Password = this.TB_Password.Text;

            try
            {
                if (checkUser(Username, Password))
                {
                    Overview newWind = new Overview(_SqlConnection);   // On instancie la fenètre principale
                    newWind.Show();
                } else
                {
                    MessageBox.Show("Erreur: Mauvais Utilisateur ou mot de passe!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur: " + err.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkUser(string username, string password)
        {
            bool res = false;
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM users", _SqlConnection);
            DataSet dataSet = new DataSet();
            DataRow[] Rows;

            dataAdapter.Fill(dataSet);
            Rows = dataSet.Tables[0].Select();

            if (Rows == null)
                return res;
            for (int index = 0; index < Rows.Length; index += 1)
            {
                if (Rows[index]["password"].ToString() == password && Rows[index]["username"].ToString() == username)
                {
                    res = true;
                    break;
                }
            }
            return res;
        }

        private void Connexion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Quitter", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
        }
    }
}
