using System;
using System.Data;
using System.Data.Common;
using System.Linq.Expressions;
using System.Windows.Forms;
using SystemeBancaire.Model;
using SystemeBancaire.Model.SQL;
using Microsoft.VisualBasic;
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
            MySqlConnection conn;
            conn = connexion();

            try
            {
                // Commande Insert
                String Rqt = "SELECT ID,Mdp FROM login;";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = Rqt;

                cmd.ExecuteNonQuery();
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                     
                        while (reader.Read())
                        {
                            // Récupérez l'index de Column id dans l'instruction de requête SQL.
                            int IdIndex = reader.GetOrdinal("Id"); // 0
                         
 
                            String id =  reader.GetString(0);
                         
                            // L'index de colonne mdp
                            string password = reader.GetString(1);

                            Hashage hash = new Hashage();
                            if (identifiant == id && password == hash.HashMdp(mdp))
                            {
                                MessageBox.Show("Connexion Reussit");
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Erreur lors de la connexion, l'identifiant et ou le mot de passe sont incorrect");
                            }
                        }
                    }
                }
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

    }
}
    