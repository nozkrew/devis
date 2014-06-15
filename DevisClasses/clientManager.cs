using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DevisClasses
{
    public class clientManager
    {
        private MySqlConnection connexion;

        //Get pour la connexion
        public clientManager()
        {
            Bdd bdd = new Bdd();
            this.connexion = bdd.getConnexion();
        }

        public client getUnclient(int p_idDevis)
        {
            this.connexion.Open();
            string query = "SELECT cli_id, cli_nom, cli_prenom, cli_adr1, cli_adr2, cli_ville, cli_CP FROM clients, vehicules, devis WHERE veh_clientId = cli_id  AND dev_vehiculeId = veh_immat AND dev_id = " + p_idDevis;

            MySqlCommand cmd = new MySqlCommand(query, connexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id = (int)reader["cli_id"];
            int CP = (int)reader["cli_CP"];
            string nom = reader["cli_nom"].ToString();
            string prenom = reader["cli_prenom"].ToString();
            string adr1 = reader["cli_adr1"].ToString();
            string adr2 = reader["cli_adr2"].ToString();
            string ville = reader["cli_ville"].ToString();

            client unClient = new client(id, nom, prenom, adr1, adr2, CP, ville);

            return unClient;

        }
    }
}
