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
        AdherantDao verif = new AdherantDao();
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
            String nom = txt_nom_utilisateur.Text;
            string mdp = txt_mdp.Text;

            Form_admin frm = new Form_admin();
            Form_adherant frma = new Form_adherant();
            Int32 Droit = verif.verifUtilisateur(nom, mdp);//stockage de la valeur de droit du gars qui se co
            if (Droit == 1)
            {
                frm.Show();
            }

            else
            {
                frma.Show();
            }
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
