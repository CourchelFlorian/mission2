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
            this.btn_editer_fact = new System.Windows.Forms.Button();
            this.lab_test = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_consulter_demande
            // 
            this.btn_consulter_demande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulter_demande.Location = new System.Drawing.Point(53, 45);
            this.btn_consulter_demande.Name = "btn_consulter_demande";
            this.btn_consulter_demande.Size = new System.Drawing.Size(172, 40);
            this.btn_consulter_demande.TabIndex = 0;
            this.btn_consulter_demande.Text = "Consulter les demandes";
            this.btn_consulter_demande.UseVisualStyleBackColor = true;
            this.btn_consulter_demande.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_editer_fact
            // 
            this.btn_editer_fact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editer_fact.Location = new System.Drawing.Point(359, 45);
            this.btn_editer_fact.Name = "btn_editer_fact";
            this.btn_editer_fact.Size = new System.Drawing.Size(162, 40);
            this.btn_editer_fact.TabIndex = 1;
            this.btn_editer_fact.Text = "Editer les factures";
            this.btn_editer_fact.UseVisualStyleBackColor = true;
            // 
            // lab_test
            // 
            this.lab_test.AutoSize = true;
            this.lab_test.Location = new System.Drawing.Point(61, 124);
            this.lab_test.Name = "lab_test";
            this.lab_test.Size = new System.Drawing.Size(24, 13);
            this.lab_test.TabIndex = 2;
            this.lab_test.Text = "test";
            this.lab_test.Visible = false;
            this.lab_test.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 371);
            this.Controls.Add(this.lab_test);
            this.Controls.Add(this.btn_editer_fact);
            this.Controls.Add(this.btn_consulter_demande);
            this.Name = "Form_admin";
            this.Text = "Form_admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_consulter_demande;
        private System.Windows.Forms.Button btn_editer_fact;
        private System.Windows.Forms.Label lab_test;
    }
}