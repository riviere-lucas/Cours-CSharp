using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemeBancaire.Model.SQL;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace SystemeBancaire
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginPage());
            
            
            
        //     Console.WriteLine("Getting Connection ...");
        //     MySqlConnection conn = Connexion.GetDBConnection();
        //
        //     try
        //     {
        //         MessageBox.Show("Openning Connection ...");
        //
        //         conn.Open();
        //
        //         MessageBox.Show("Connection successful!");
        //     }
        //     catch(Exception e)
        //     {
        //         MessageBox.Show("Error: " + e.Message);
        //     }
        //
        //     Console.Read();
        }
    }
}