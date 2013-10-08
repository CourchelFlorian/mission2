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
        public Form_admin()
        {
            InitializeComponent();
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


       
    }
}
