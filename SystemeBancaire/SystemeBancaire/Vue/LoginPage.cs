using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemeBancaire.Controller;

namespace SystemeBancaire
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Connexion_Click(object sender, EventArgs e)
        {
            String identifiant = TextBoxIdentifiant.Text;
            String mdp = TextBoxMdp.Text;

            LinkDB db = new LinkDB();
            db.checkCredencial(identifiant, mdp);
        }
    }
}