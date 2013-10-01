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
            this.btn_realiser_demande = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_realiser_demande
            // 
            this.btn_realiser_demande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_realiser_demande.Location = new System.Drawing.Point(22, 32);
            this.btn_realiser_demande.Name = "btn_realiser_demande";
            this.btn_realiser_demande.Size = new System.Drawing.Size(219, 47);
            this.btn_realiser_demande.TabIndex = 0;
            this.btn_realiser_demande.Text = "Réaliser une demande";
            this.btn_realiser_demande.UseVisualStyleBackColor = true;
            // 
            // Form_adherant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_realiser_demande);
            this.Name = "Form_adherant";
            this.Text = "Form_adherant";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_realiser_demande;
    }
}