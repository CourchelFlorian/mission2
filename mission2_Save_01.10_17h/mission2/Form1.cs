using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mission2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_se_connecter_Click(object sender, EventArgs e)
        {
            // Si verifUtilisateur retourne 2 alors il a planté
            //Ouvre un autre formulaire 
            Form_adherant frm = new Form_adherant();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
