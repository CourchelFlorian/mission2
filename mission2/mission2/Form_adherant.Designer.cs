namespace mission2
{
    partial class Form_adherant
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
            this.lab_realiser_demande = new System.Windows.Forms.Label();
            this.lab_services = new System.Windows.Forms.Label();
            this.m2lCKDataSet = new mission2.m2lCKDataSet();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new mission2.m2lCKDataSetTableAdapters.ServiceTableAdapter();
            this.typeServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeServiceTableAdapter = new mission2.m2lCKDataSetTableAdapters.TypeServiceTableAdapter();
            this.ligueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ligueTableAdapter = new mission2.m2lCKDataSetTableAdapters.LigueTableAdapter();
            this.combo_services = new System.Windows.Forms.ComboBox();
            this.fKServiceTypeServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab_Quantitée = new System.Windows.Forms.Label();
            this.txt_Quantitée = new System.Windows.Forms.TextBox();
            this.btn_Quantitée = new System.Windows.Forms.Button();
            this.btn_Quitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m2lCKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKServiceTypeServiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_realiser_demande
            // 
            this.lab_realiser_demande.AutoSize = true;
            this.lab_realiser_demande.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_realiser_demande.Location = new System.Drawing.Point(69, 21);
            this.lab_realiser_demande.Name = "lab_realiser_demande";
            this.lab_realiser_demande.Size = new System.Drawing.Size(441, 46);
            this.lab_realiser_demande.TabIndex = 1;
            this.lab_realiser_demande.Text = "Réaliser une demande :";
            this.lab_realiser_demande.Click += new System.EventHandler(this.lab_connexion_Click);
            // 
            // lab_services
            // 
            this.lab_services.AutoSize = true;
            this.lab_services.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_services.Location = new System.Drawing.Point(137, 132);
            this.lab_services.Name = "lab_services";
            this.lab_services.Size = new System.Drawing.Size(99, 25);
            this.lab_services.TabIndex = 2;
            this.lab_services.Text = "Services :";
            this.lab_services.Click += new System.EventHandler(this.lab_nom_utilisateur_Click);
            // 
            // m2lCKDataSet
            // 
            this.m2lCKDataSet.DataSetName = "m2lCKDataSet";
            this.m2lCKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.m2lCKDataSet;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // typeServiceBindingSource
            // 
            this.typeServiceBindingSource.DataMember = "TypeService";
            this.typeServiceBindingSource.DataSource = this.m2lCKDataSet;
            // 
            // typeServiceTableAdapter
            // 
            this.typeServiceTableAdapter.ClearBeforeFill = true;
            // 
            // ligueBindingSource
            // 
            this.ligueBindingSource.DataMember = "Ligue";
            this.ligueBindingSource.DataSource = this.m2lCKDataSet;
            // 
            // ligueTableAdapter
            // 
            this.ligueTableAdapter.ClearBeforeFill = true;
            // 
            // combo_services
            // 
            this.combo_services.DataSource = this.typeServiceBindingSource;
            this.combo_services.DisplayMember = "libelle";
            this.combo_services.FormattingEnabled = true;
            this.combo_services.Location = new System.Drawing.Point(255, 136);
            this.combo_services.Name = "combo_services";
            this.combo_services.Size = new System.Drawing.Size(121, 21);
            this.combo_services.TabIndex = 5;
            this.combo_services.ValueMember = "numero";
            this.combo_services.SelectedIndexChanged += new System.EventHandler(this.combo_services_SelectedIndexChanged);
            // 
            // fKServiceTypeServiceBindingSource
            // 
            this.fKServiceTypeServiceBindingSource.DataMember = "FK_Service_TypeService";
            this.fKServiceTypeServiceBindingSource.DataSource = this.typeServiceBindingSource;
            // 
            // lab_Quantitée
            // 
            this.lab_Quantitée.AutoSize = true;
            this.lab_Quantitée.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Quantitée.Location = new System.Drawing.Point(128, 176);
            this.lab_Quantitée.Name = "lab_Quantitée";
            this.lab_Quantitée.Size = new System.Drawing.Size(108, 25);
            this.lab_Quantitée.TabIndex = 7;
            this.lab_Quantitée.Text = "Quantitée :";
            // 
            // txt_Quantitée
            // 
            this.txt_Quantitée.Location = new System.Drawing.Point(255, 181);
            this.txt_Quantitée.Name = "txt_Quantitée";
            this.txt_Quantitée.Size = new System.Drawing.Size(121, 20);
            this.txt_Quantitée.TabIndex = 8;
            // 
            // btn_Quantitée
            // 
            this.btn_Quantitée.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quantitée.Location = new System.Drawing.Point(255, 268);
            this.btn_Quantitée.Name = "btn_Quantitée";
            this.btn_Quantitée.Size = new System.Drawing.Size(121, 35);
            this.btn_Quantitée.TabIndex = 9;
            this.btn_Quantitée.Text = "Envoyer";
            this.btn_Quantitée.UseVisualStyleBackColor = true;
            this.btn_Quantitée.Click += new System.EventHandler(this.btn_Quantitée_Click);
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Location = new System.Drawing.Point(505, 410);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(73, 37);
            this.btn_Quitter.TabIndex = 10;
            this.btn_Quitter.Text = "Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // Form_adherant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 459);
            this.Controls.Add(this.btn_Quitter);
            this.Controls.Add(this.btn_Quantitée);
            this.Controls.Add(this.txt_Quantitée);
            this.Controls.Add(this.lab_Quantitée);
            this.Controls.Add(this.combo_services);
            this.Controls.Add(this.lab_services);
            this.Controls.Add(this.lab_realiser_demande);
            this.Name = "Form_adherant";
            this.Text = "Form_adherant";
            this.Load += new System.EventHandler(this.Form_adherant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m2lCKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKServiceTypeServiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_realiser_demande;
        private System.Windows.Forms.Label lab_services;
        private m2lCKDataSet m2lCKDataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private m2lCKDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.BindingSource typeServiceBindingSource;
        private m2lCKDataSetTableAdapters.TypeServiceTableAdapter typeServiceTableAdapter;
        private System.Windows.Forms.BindingSource ligueBindingSource;
        private m2lCKDataSetTableAdapters.LigueTableAdapter ligueTableAdapter;
        private System.Windows.Forms.ComboBox combo_services;
        private System.Windows.Forms.BindingSource fKServiceTypeServiceBindingSource;
        private System.Windows.Forms.Label lab_Quantitée;
        private System.Windows.Forms.TextBox txt_Quantitée;
        private System.Windows.Forms.Button btn_Quantitée;
        private System.Windows.Forms.Button btn_Quitter;

    }
}