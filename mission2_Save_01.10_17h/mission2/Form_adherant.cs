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
        public Form_adherant()
        {
            InitializeComponent();
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
    }
}
