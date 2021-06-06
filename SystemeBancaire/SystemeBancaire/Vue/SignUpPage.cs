using System;
using System.Windows.Forms;
using SystemeBancaire.Controller;

namespace SystemeBancaire
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void CreationCompte_Click(object sender, EventArgs e)
        {
            String identifiant = TextBoxIdentifiant.Text;
            String mdp = TextBoxMdp.Text;

            LinkDB db = new LinkDB();
            db.createCredencial(identifiant,mdp);
        }
    }
}