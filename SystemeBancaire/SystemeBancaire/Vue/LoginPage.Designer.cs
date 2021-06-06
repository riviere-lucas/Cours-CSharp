namespace SystemeBancaire
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.Connexion = new System.Windows.Forms.Button();
            this.LabelIdentifiant = new System.Windows.Forms.Label();
            this.LabelMdp = new System.Windows.Forms.Label();
            this.TextBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.TextBoxMdp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Connexion
            // 
            this.Connexion.Location = new System.Drawing.Point(118, 230);
            this.Connexion.Name = "Connexion";
            this.Connexion.Size = new System.Drawing.Size(161, 55);
            this.Connexion.TabIndex = 0;
            this.Connexion.Text = "Connexion";
            this.Connexion.UseVisualStyleBackColor = true;
            this.Connexion.Click += new System.EventHandler(this.Connexion_Click);
            // 
            // LabelIdentifiant
            // 
            this.LabelIdentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LabelIdentifiant.Location = new System.Drawing.Point(54, 75);
            this.LabelIdentifiant.Name = "LabelIdentifiant";
            this.LabelIdentifiant.Size = new System.Drawing.Size(88, 33);
            this.LabelIdentifiant.TabIndex = 1;
            this.LabelIdentifiant.Text = "Identifiant";
            this.LabelIdentifiant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelIdentifiant.Click += new System.EventHandler(this.Connexion_Click);
            // 
            // LabelMdp
            // 
            this.LabelMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LabelMdp.Location = new System.Drawing.Point(28, 134);
            this.LabelMdp.Name = "LabelMdp";
            this.LabelMdp.Size = new System.Drawing.Size(114, 33);
            this.LabelMdp.TabIndex = 3;
            this.LabelMdp.Text = "Mot de Passe";
            // 
            // TextBoxIdentifiant
            // 
            this.TextBoxIdentifiant.Location = new System.Drawing.Point(148, 82);
            this.TextBoxIdentifiant.Name = "TextBoxIdentifiant";
            this.TextBoxIdentifiant.Size = new System.Drawing.Size(210, 20);
            this.TextBoxIdentifiant.TabIndex = 5;
            // 
            // TextBoxMdp
            // 
            this.TextBoxMdp.Location = new System.Drawing.Point(148, 134);
            this.TextBoxMdp.Name = "TextBoxMdp";
            this.TextBoxMdp.Size = new System.Drawing.Size(210, 20);
            this.TextBoxMdp.TabIndex = 6;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 306);
            this.Controls.Add(this.TextBoxMdp);
            this.Controls.Add(this.TextBoxIdentifiant);
            this.Controls.Add(this.LabelMdp);
            this.Controls.Add(this.LabelIdentifiant);
            this.Controls.Add(this.Connexion);
            this.Name = "LoginPage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label LabelMdp;
        private System.Windows.Forms.Label LabelIdentifiant;
        
        private System.Windows.Forms.TextBox TextBoxMdp;
        private System.Windows.Forms.TextBox TextBoxIdentifiant;
        
        private System.Windows.Forms.Button Connexion;

        #endregion
    }
}