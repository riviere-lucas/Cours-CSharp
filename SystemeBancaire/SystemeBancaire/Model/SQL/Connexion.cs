using System;
using MySql.Data.MySqlClient;

namespace SystemeBancaire.Model.SQL
{
    public class Connexion
    {
        
        public static MySqlConnection GetDBConnection( )
        {
            string host = "127.0.0.1";
            int port = 3306;
            string database = "banque";
            string username = "root";

            return GetDBConnection(host, port, database, username);
        }
        
        
        public static MySqlConnection
            GetDBConnection(string host, int port, string database, string username)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                                + ";port=" + port + ";User Id=" + username;
 
            MySqlConnection conn = new MySqlConnection(connString);
 
            return conn;
        }
        
    }
    
}