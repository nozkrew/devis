using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DevisClasses
{
    public class Bdd
    {
        private MySqlConnection connexion;
        private string server;
        private string database;
        private string uid;
        private string password;

        // Constructeur
        public Bdd()
        {
            Initialize();
        }

        //Initialise valeurs
        private void Initialize()
        {
            server = "localhost";
            database = "garage_ppe";
            uid = "root";
            password = "thomasbdd";
            string connexionString;
            connexionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connexion = new MySqlConnection(connexionString);
        }

        public MySqlConnection getConnexion()
        {
            return this.connexion;
        }
    }
}
