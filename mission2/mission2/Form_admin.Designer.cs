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
            this.components = new System.ComponentModel.Container();
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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lbl_Edition = new System.Windows.Forms.Label();
            this.combo_mois = new System.Windows.Forms.ComboBox();
            this.lbl_mois = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.m2lCKDataSet = new mission2.m2lCKDataSet();
            this.m2lCKDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_Ligues = new System.Windows.Forms.Label();
            this.combo_ligues = new System.Windows.Forms.ComboBox();
            this.ligueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ligueTableAdapter = new mission2.m2lCKDataSetTableAdapters.LigueTableAdapter();
            this.btnValider = new System.Windows.Forms.Button();
            this.tableau_Facture = new System.Windows.Forms.DataGridView();
            this.Adhérent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColonneService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColonnePrixU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_titre_total = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_Envoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableau_demande)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m2lCKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2lCKDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableau_Facture)).BeginInit();
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
            this.tabPage1.Controls.Add(this.btn_Envoi);
            this.tabPage1.Controls.Add(this.lbl_total);
            this.tabPage1.Controls.Add(this.lbl_titre_total);
            this.tabPage1.Controls.Add(this.tableau_Facture);
            this.tabPage1.Controls.Add(this.btnValider);
            this.tabPage1.Controls.Add(this.combo_ligues);
            this.tabPage1.Controls.Add(this.lbl_Ligues);
            this.tabPage1.Controls.Add(this.btnQuitter);
            this.tabPage1.Controls.Add(this.lbl_Edition);
            this.tabPage1.Controls.Add(this.combo_mois);
            this.tabPage1.Controls.Add(this.lbl_mois);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(930, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Editer les faquetures";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
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
            // combo_mois
            // 
            this.combo_mois.FormattingEnabled = true;
            this.combo_mois.Location = new System.Drawing.Point(99, 107);
            this.combo_mois.Name = "combo_mois";
            this.combo_mois.Size = new System.Drawing.Size(121, 21);
            this.combo_mois.TabIndex = 1;
            this.combo_mois.SelectedIndexChanged += new System.EventHandler(this.combo_mois_SelectedIndexChanged);
            // 
            // lbl_mois
            // 
            this.lbl_mois.AutoSize = true;
            this.lbl_mois.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mois.Location = new System.Drawing.Point(33, 102);
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
            // m2lCKDataSet
            // 
            this.m2lCKDataSet.DataSetName = "m2lCKDataSet";
            this.m2lCKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m2lCKDataSetBindingSource
            // 
            this.m2lCKDataSetBindingSource.DataSource = this.m2lCKDataSet;
            this.m2lCKDataSetBindingSource.Position = 0;
            // 
            // lbl_Ligues
            // 
            this.lbl_Ligues.AutoSize = true;
            this.lbl_Ligues.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ligues.Location = new System.Drawing.Point(31, 153);
            this.lbl_Ligues.Name = "lbl_Ligues";
            this.lbl_Ligues.Size = new System.Drawing.Size(61, 24);
            this.lbl_Ligues.TabIndex = 6;
            this.lbl_Ligues.Text = "ligue :";
            // 
            // combo_ligues
            // 
            this.combo_ligues.DataSource = this.ligueBindingSource;
            this.combo_ligues.DisplayMember = "nom";
            this.combo_ligues.FormattingEnabled = true;
            this.combo_ligues.Location = new System.Drawing.Point(99, 155);
            this.combo_ligues.Name = "combo_ligues";
            this.combo_ligues.Size = new System.Drawing.Size(121, 21);
            this.combo_ligues.TabIndex = 7;
            this.combo_ligues.ValueMember = "numero";
            // 
            // ligueBindingSource
            // 
            this.ligueBindingSource.DataMember = "Ligue";
            this.ligueBindingSource.DataSource = this.m2lCKDataSetBindingSource;
            // 
            // ligueTableAdapter
            // 
            this.ligueTableAdapter.ClearBeforeFill = true;
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(121, 233);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(68, 38);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // tableau_Facture
            // 
            this.tableau_Facture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau_Facture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adhérent,
            this.ColonneService,
            this.ColonnePrixU,
            this.qtte,
            this.colonneDate});
            this.tableau_Facture.Location = new System.Drawing.Point(286, 102);
            this.tableau_Facture.Name = "tableau_Facture";
            this.tableau_Facture.Size = new System.Drawing.Size(606, 240);
            this.tableau_Facture.TabIndex = 9;
            // 
            // Adhérent
            // 
            this.Adhérent.HeaderText = "Adhérent";
            this.Adhérent.Name = "Adhérent";
            // 
            // ColonneService
            // 
            this.ColonneService.HeaderText = "Service";
            this.ColonneService.Name = "ColonneService";
            // 
            // ColonnePrixU
            // 
            this.ColonnePrixU.HeaderText = "Prix Unitaire";
            this.ColonnePrixU.Name = "ColonnePrixU";
            // 
            // qtte
            // 
            this.qtte.HeaderText = "Quantité";
            this.qtte.Name = "qtte";
            // 
            // colonneDate
            // 
            this.colonneDate.HeaderText = "Date";
            this.colonneDate.Name = "colonneDate";
            // 
            // lbl_titre_total
            // 
            this.lbl_titre_total.AutoSize = true;
            this.lbl_titre_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre_total.Location = new System.Drawing.Point(286, 358);
            this.lbl_titre_total.Name = "lbl_titre_total";
            this.lbl_titre_total.Size = new System.Drawing.Size(53, 24);
            this.lbl_titre_total.TabIndex = 10;
            this.lbl_titre_total.Text = "total :";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_total.Location = new System.Drawing.Point(345, 358);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 24);
            this.lbl_total.TabIndex = 11;
            // 
            // btn_Envoi
            // 
            this.btn_Envoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Envoi.Location = new System.Drawing.Point(570, 379);
            this.btn_Envoi.Name = "btn_Envoi";
            this.btn_Envoi.Size = new System.Drawing.Size(172, 40);
            this.btn_Envoi.TabIndex = 12;
            this.btn_Envoi.Text = "envoyer la facture";
            this.btn_Envoi.UseVisualStyleBackColor = true;
            this.btn_Envoi.Click += new System.EventHandler(this.btn_Envoi_Click);
            // 
            // Form_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 453);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_admin";
            this.Text = "Form_admin";
            this.Load += new System.EventHandler(this.Form_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau_demande)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m2lCKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2lCKDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableau_Facture)).EndInit();
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
        private System.Windows.Forms.ComboBox combo_mois;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ComboBox combo_ligues;
        private System.Windows.Forms.Label lbl_Ligues;
        private m2lCKDataSet m2lCKDataSet;
        private System.Windows.Forms.BindingSource m2lCKDataSetBindingSource;
        private System.Windows.Forms.BindingSource ligueBindingSource;
        private m2lCKDataSetTableAdapters.LigueTableAdapter ligueTableAdapter;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.DataGridView tableau_Facture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adhérent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColonneService;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColonnePrixU;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneDate;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_titre_total;
        private System.Windows.Forms.Button btn_Envoi;
    }
}