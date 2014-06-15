using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DevisClasses
{
    public class vehiculesManager
    {
        private MySqlConnection connexion;

        //Get pour la connexion
        public vehiculesManager()
        {
            Bdd bdd = new Bdd();
            this.connexion = bdd.getConnexion();
        }

        public List<vehicules> listeVehicules()
        {
            List<vehicules> lesVehicules = new List<vehicules>();

            this.connexion.Open();
            String query = "SELECT * FROM vehicules WHERE veh_repare = 0 AND veh_clientId IS NOT NULL";

            MySqlCommand cmd = new MySqlCommand(query, connexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String immat = reader["veh_immat"].ToString();
                int annee = Convert.ToInt32(reader["veh_annee"]);
                int repare = Convert.ToInt32(reader["veh_repare"]);
                int km = Convert.ToInt32(reader["veh_km"]);
                int modId = Convert.ToInt32(reader["veh_modId"]);
                int energieId = Convert.ToInt32(reader["veh_energie"]);

                vehicules unVehicule = new vehicules(immat, annee, repare, km, modId, energieId);
                lesVehicules.Add(unVehicule);

            }
            return lesVehicules;
        }

        public string getImmat(int p_idDevis)
        {
            this.connexion.Open();
            string query = "SELECT veh_immat FROM vehicules, devis WHERE dev_vehiculeId = veh_immat AND dev_id = "+ p_idDevis;

            MySqlCommand cmd = new MySqlCommand(query, connexion);
            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            string immat = reader["veh_immat"].ToString();

            return immat;
        }
    }
}
