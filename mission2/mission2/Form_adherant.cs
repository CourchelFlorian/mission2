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
    public partial class Form_adherant : Form
    {
        AdherantDao adherant = new AdherantDao();
        Int32 numUtil = 0;
        public Form_adherant()
        {
            InitializeComponent();
            numUtil = 0;
        }

        public Form_adherant(Int32 pNumUtil)
        {
            InitializeComponent();
            numUtil = pNumUtil;
        }


        private void lab_connexion_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lab_nom_utilisateur_Click(object sender, EventArgs e)
        {

        }

        private void Form_adherant_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'm2lCKDataSet.Ligue'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.ligueTableAdapter.Fill(this.m2lCKDataSet.Ligue);
            // TODO: cette ligne de code charge les données dans la table 'm2lCKDataSet.TypeService'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.typeServiceTableAdapter.Fill(this.m2lCKDataSet.TypeService);
            // TODO: cette ligne de code charge les données dans la table 'm2lCKDataSet.Service'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.serviceTableAdapter.Fill(this.m2lCKDataSet.Service);

        }

        private void combo_services_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Quantitée_Click(object sender, EventArgs e)
        {
            Int32 Type = (Int32)combo_services.SelectedValue;
            Int32 Quantitée = Convert.ToInt32(txt_Quantitée.Text);
            adherant.ajouterDemande(Quantitée, Type, numUtil);
            txt_Quantitée.Text = "";
            MessageBox.Show("demande enregistrée");

        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
