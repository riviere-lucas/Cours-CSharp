using System.ComponentModel;

namespace SystemeBancaire
{
    partial class SignUpPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.TextBoxMdp = new System.Windows.Forms.TextBox();
            this.TextBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.LabelMdp = new System.Windows.Forms.Label();
            this.LabelIdentifiant = new System.Windows.Forms.Label();
            this.CreationCompte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxMdp
            // 
            this.TextBoxMdp.Location = new System.Drawing.Point(154, 128);
            this.TextBoxMdp.Name = "TextBoxMdp";
            this.TextBoxMdp.PasswordChar = '*';
            this.TextBoxMdp.Size = new System.Drawing.Size(210, 20);
            this.TextBoxMdp.TabIndex = 11;
            // 
            // TextBoxIdentifiant
            // 
            this.TextBoxIdentifiant.Location = new System.Drawing.Point(154, 76);
            this.TextBoxIdentifiant.Name = "TextBoxIdentifiant";
            this.TextBoxIdentifiant.Size = new System.Drawing.Size(210, 20);
            this.TextBoxIdentifiant.TabIndex = 10;
            // 
            // LabelMdp
            // 
            this.LabelMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LabelMdp.Location = new System.Drawing.Point(34, 128);
            this.LabelMdp.Name = "LabelMdp";
            this.LabelMdp.Size = new System.Drawing.Size(114, 33);
            this.LabelMdp.TabIndex = 9;
            this.LabelMdp.Text = "Mot de Passe";
            // 
            // LabelIdentifiant
            // 
            this.LabelIdentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LabelIdentifiant.Location = new System.Drawing.Point(60, 69);
            this.LabelIdentifiant.Name = "LabelIdentifiant";
            this.LabelIdentifiant.Size = new System.Drawing.Size(88, 33);
            this.LabelIdentifiant.TabIndex = 8;
            this.LabelIdentifiant.Text = "Identifiant";
            this.LabelIdentifiant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreationCompte
            // 
            this.CreationCompte.Location = new System.Drawing.Point(124, 224);
            this.CreationCompte.Name = "CreationCompte";
            this.CreationCompte.Size = new System.Drawing.Size(161, 55);
            this.CreationCompte.TabIndex = 7;
            this.CreationCompte.Text = "Creation compte";
            this.CreationCompte.UseVisualStyleBackColor = true;
            this.CreationCompte.Click += new System.EventHandler(this.CreationCompte_Click);
            // 
            // SignUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 328);
            this.Controls.Add(this.TextBoxMdp);
            this.Controls.Add(this.TextBoxIdentifiant);
            this.Controls.Add(this.LabelMdp);
            this.Controls.Add(this.LabelIdentifiant);
            this.Controls.Add(this.CreationCompte);
            this.Name = "SignUpPage";
            this.Text = "SignUpPage";
            this.Load += new System.EventHandler(this.SignUpPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox TextBoxMdp;
        private System.Windows.Forms.TextBox TextBoxIdentifiant;
        private System.Windows.Forms.Label LabelMdp;
        private System.Windows.Forms.Label LabelIdentifiant;
        private System.Windows.Forms.Button CreationCompte;

        #endregion
    }
}