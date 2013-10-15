namespace mission2
{
    partial class Form_admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_consulter_demande = new System.Windows.Forms.Button();
            this.tableau_demande = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_Edition = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_mois = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableau_demande)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_consulter_demande
            // 
            this.btn_consulter_demande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulter_demande.Location = new System.Drawing.Point(342, 31);
            this.btn_consulter_demande.Name = "btn_consulter_demande";
            this.btn_consulter_demande.Size = new System.Drawing.Size(172, 40);
            this.btn_consulter_demande.TabIndex = 0;
            this.btn_consulter_demande.Text = "Consulter les demandes";
            this.btn_consulter_demande.UseVisualStyleBackColor = true;
            this.btn_consulter_demande.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableau_demande
            // 
            this.tableau_demande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau_demande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Service,
            this.Quantité,
            this.prix,
            this.Etat,
            this.Date});
            this.tableau_demande.Location = new System.Drawing.Point(122, 110);
            this.tableau_demande.Name = "tableau_demande";
            this.tableau_demande.Size = new System.Drawing.Size(663, 150);
            this.tableau_demande.TabIndex = 2;
            this.tableau_demande.Visible = false;
            this.tableau_demande.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableau_demande_CellContentClick);
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Service
            // 
            this.Service.HeaderText = "Service";
            this.Service.Name = "Service";
            // 
            // Quantité
            // 
            this.Quantité.HeaderText = "Quantité";
            this.Quantité.Name = "Quantité";
            // 
            // prix
            // 
            this.prix.HeaderText = "prix";
            this.prix.Name = "prix";
            // 
            // Etat
            // 
            this.Etat.HeaderText = "Etat";
            this.Etat.Name = "Etat";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(938, 455);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.btnQuitter);
            this.tabPage1.Controls.Add(this.lbl_Edition);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.lbl_mois);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(930, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Editer les faquetures";
            // 
            // lbl_Edition
            // 
            this.lbl_Edition.AutoSize = true;
            this.lbl_Edition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Edition.Location = new System.Drawing.Point(342, 15);
            this.lbl_Edition.Name = "lbl_Edition";
            this.lbl_Edition.Size = new System.Drawing.Size(191, 25);
            this.lbl_Edition.TabIndex = 2;
            this.lbl_Edition.Text = "Edition de factures";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lbl_mois
            // 
            this.lbl_mois.AutoSize = true;
            this.lbl_mois.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mois.Location = new System.Drawing.Point(31, 102);
            this.lbl_mois.Name = "lbl_mois";
            this.lbl_mois.Size = new System.Drawing.Size(60, 24);
            this.lbl_mois.TabIndex = 0;
            this.lbl_mois.Text = "mois :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.btn_quitter);
            this.tabPage2.Controls.Add(this.btn_consulter_demande);
            this.tabPage2.Controls.Add(this.tableau_demande);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(930, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulter les demandes";
            // 
            // btn_quitter
            // 
            this.btn_quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitter.Location = new System.Drawing.Point(748, 379);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(172, 40);
            this.btn_quitter.TabIndex = 4;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click_1);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(748, 379);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(172, 40);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Form_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 453);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_admin";
            this.Text = "Form_admin";
            ((System.ComponentModel.ISupportInitialize)(this.tableau_demande)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_consulter_demande;
        private System.Windows.Forms.DataGridView tableau_demande;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantité;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.Label lbl_mois;
        private System.Windows.Forms.Label lbl_Edition;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnQuitter;
    }
}