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
    public partial class Form_admin : Form
    {
        Int32 i, numUtil, mois, numLigue;
        public Form_admin()
        {
            InitializeComponent();
            numUtil = 0;
        }
        public Form_admin(Int32 pNumUtil)
        {
            InitializeComponent();
            numUtil = pNumUtil;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableau_demande.Visible = true;
            ServiceDao liste = new ServiceDao();
            liste.listerServices(tableau_demande);
        }

        private void tableau_demande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_quitter_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_admin_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'm2lCKDataSet.Ligue'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.ligueTableAdapter.Fill(this.m2lCKDataSet.Ligue);
            //ajout des mois
            combo_mois.Items.Insert(0, "Janvier");
            combo_mois.Items.Insert(1, "Février");
            combo_mois.Items.Insert(2, "Mars");
            combo_mois.Items.Insert(3, "Avril");
            combo_mois.Items.Insert(4, "Mais");
            combo_mois.Items.Insert(5, "Juin");
            combo_mois.Items.Insert(6, "Juillet");
            combo_mois.Items.Insert(7, "Aout");
            combo_mois.Items.Insert(8, "Septembre");
            combo_mois.Items.Insert(9, "Octobre");
            combo_mois.Items.Insert(10, "Novembre");
            combo_mois.Items.Insert(11, "Décembre");
        }

        private void combo_mois_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            tableau_Facture.Rows.Clear();
            ServiceDao liste = new ServiceDao();
            mois = combo_mois.SelectedIndex+1;
            numLigue = (Int32)combo_ligues.SelectedValue;
            liste.getFacture(mois, numLigue, tableau_Facture);
            lbl_total.Text = ""+liste.getTotal(mois, numLigue)+"€";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Envoi_Click(object sender, EventArgs e)
        {
            ServiceDao liste = new ServiceDao();
            mois = combo_mois.SelectedIndex + 1;
            numLigue = (Int32)combo_ligues.SelectedValue;
            liste.setFacturer(mois, numLigue);

            MessageBox.Show("Ces demandes sont maintenant notifiée comme ''facturée''");

        }
       
    }
}
