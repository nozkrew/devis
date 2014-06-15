using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace DevisClasses
{
    public class devisManager
    {
        private MySqlConnection connexion;

        //Get pour la connexion
        public devisManager()
        {
            Bdd bdd = new Bdd();
            this.connexion = bdd.getConnexion();
        }

        public long editeDevis(devis p_unDevis)
        {
            String laDate = p_unDevis.getDate();
            String vehiculeId = p_unDevis.getVehiculeImmat();

            this.connexion.Open();

            String query = "INSERT INTO devis (dev_date, dev_vehiculeId) VALUES ('" + laDate + "' ,'" + vehiculeId + "')";
            MySqlCommand cmd = new MySqlCommand(query, connexion);
            cmd.ExecuteNonQuery();

            long dernierId = cmd.LastInsertedId;
            return dernierId;
        }

        public DateTime getDate(int p_idDevis)
        {
            this.connexion.Open();

            string query = "SELECT dev_date FROM devis WHERE dev_id = " + p_idDevis;
            MySqlCommand cmd = new MySqlCommand(query, connexion);
            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            DateTime laDate = Convert.ToDateTime(reader["dev_date"]);

            return laDate;
        }

        public List<devis> listeDevis()
        {
            List<devis> listeDevis = new List<devis>();
            this.connexion.Open();
            string query = "SELECT * FROM devis ORDER BY dev_date DESC";
            MySqlCommand cmd = new MySqlCommand(query, connexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader["dev_id"];
                String date = reader["dev_date"].ToString();
                string vehImmat = reader["dev_vehiculeId"].ToString();

                devis unDevis = new devis(id, date, vehImmat);
                listeDevis.Add(unDevis);
            }

            return listeDevis;
        }
    }
}
