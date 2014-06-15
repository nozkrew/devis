using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace DevisClasses
{
    public class tvaManager
    {
        private MySqlConnection connexion;

        //Get pour la connexion
        public tvaManager()
        {
            Bdd bdd = new Bdd();
            this.connexion = bdd.getConnexion();
        }

        public tva uneTva()
        {
            this.connexion.Open();
            string query = "SELECT * FROM tva WHERE tva_id = 1";

            MySqlCommand cmd = new MySqlCommand(query, connexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id = Convert.ToInt32(reader["tva_id"]);
            float taux = (float)reader["tva_taux"];

            tva uneTva = new tva(id, taux);

            return uneTva;
        }


    }
}
