using System;
using System.Data;
using System.Linq.Expressions;
using System.Windows.Forms;
using SystemeBancaire.Model;
using SystemeBancaire.Model.SQL;
using MySql.Data.MySqlClient;

namespace SystemeBancaire.Controller
{
    public class LinkDB
    {
        public MySqlConnection connexion()
        {
            MySqlConnection conn = Connexion.GetDBConnection();

            try
            {
                MessageBox.Show("Openning Connection ...");
                conn.Open();
                MessageBox.Show("Connection successful!");
                return conn;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

            return null;
        }

        public void createCredencial(String identifiant, String mdp)
        {
            MySqlConnection conn;
            conn = connexion();

            try
            {
                // Commande Insert
                String Rqt = "INSERT INTO login (ID,Mdp) values(@id, @mdp);";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = Rqt;

                //Creation objet Parameter
                MySqlParameter idParam = new MySqlParameter("@id", MySqlDbType.VarChar);
                idParam.Value = identifiant;
                cmd.Parameters.Add(idParam);

                MySqlParameter mdpParam = new MySqlParameter("@mdp", MySqlDbType.VarChar);
                Hashage hash = new Hashage();
                mdpParam.Value = hash.HashMdp(mdp);
                cmd.Parameters.Add(mdpParam);

                int rowCount = cmd.ExecuteNonQuery();
                MessageBox.Show("Row Count affected : " + rowCount);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e);
                MessageBox.Show(e.StackTrace);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }

        public void checkCredencial(String identifiant, String mdp)
        {
            
        }

    }

    public class SqlCommand
    {
    }
}
    