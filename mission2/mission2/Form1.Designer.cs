namespace mission2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_connexion = new System.Windows.Forms.Label();
            this.lab_nom_utilisateur = new System.Windows.Forms.Label();
            this.txt_nom_utilisateur = new System.Windows.Forms.TextBox();
            this.lab_mdp = new System.Windows.Forms.Label();
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.btn_se_connecter = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_connexion
            // 
            this.lab_connexion.AutoSize = true;
            this.lab_connexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_connexion.Location = new System.Drawing.Point(199, 30);
            this.lab_connexion.Name = "lab_connexion";
            this.lab_connexion.Size = new System.Drawing.Size(213, 46);
            this.lab_connexion.TabIndex = 0;
            this.lab_connexion.Text = "Connexion";
            this.lab_connexion.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_nom_utilisateur
            // 
            this.lab_nom_utilisateur.AutoSize = true;
            this.lab_nom_utilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nom_utilisateur.Location = new System.Drawing.Point(131, 129);
            this.lab_nom_utilisateur.Name = "lab_nom_utilisateur";
            this.lab_nom_utilisateur.Size = new System.Drawing.Size(151, 25);
            this.lab_nom_utilisateur.TabIndex = 1;
            this.lab_nom_utilisateur.Text = "Nom utilisateur :";
            // 
            // txt_nom_utilisateur
            // 
            this.txt_nom_utilisateur.Location = new System.Drawing.Point(290, 132);
            this.txt_nom_utilisateur.Name = "txt_nom_utilisateur";
            this.txt_nom_utilisateur.Size = new System.Drawing.Size(168, 20);
            this.txt_nom_utilisateur.TabIndex = 2;
            // 
            // lab_mdp
            // 
            this.lab_mdp.AutoSize = true;
            this.lab_mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_mdp.Location = new System.Drawing.Point(135, 175);
            this.lab_mdp.Name = "lab_mdp";
            this.lab_mdp.Size = new System.Drawing.Size(141, 25);
            this.lab_mdp.TabIndex = 3;
            this.lab_mdp.Text = "Mot de passe :";
            this.lab_mdp.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txt_mdp
            // 
            this.txt_mdp.Location = new System.Drawing.Point(290, 179);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.Size = new System.Drawing.Size(167, 20);
            this.txt_mdp.TabIndex = 4;
            // 
            // btn_se_connecter
            // 
            this.btn_se_connecter.Location = new System.Drawing.Point(221, 239);
            this.btn_se_connecter.Name = "btn_se_connecter";
            this.btn_se_connecter.Size = new System.Drawing.Size(165, 40);
            this.btn_se_connecter.TabIndex = 5;
            this.btn_se_connecter.Text = "Se connecter";
            this.btn_se_connecter.UseVisualStyleBackColor = true;
            this.btn_se_connecter.Click += new System.EventHandler(this.btn_se_connecter_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(444, 348);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(151, 41);
            this.btn_quitter.TabIndex = 6;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 411);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_se_connecter);
            this.Controls.Add(this.txt_mdp);
            this.Controls.Add(this.lab_mdp);
            this.Controls.Add(this.txt_nom_utilisateur);
            this.Controls.Add(this.lab_nom_utilisateur);
            this.Controls.Add(this.lab_connexion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_connexion;
        private System.Windows.Forms.Label lab_nom_utilisateur;
        private System.Windows.Forms.TextBox txt_nom_utilisateur;
        private System.Windows.Forms.Label lab_mdp;
        private System.Windows.Forms.TextBox txt_mdp;
        private System.Windows.Forms.Button btn_se_connecter;
        private System.Windows.Forms.Button btn_quitter;

    }
}

