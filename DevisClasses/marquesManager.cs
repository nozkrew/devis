using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace DevisClasses
{
    public class marquesManager
    {

        private MySqlConnection connexion;

        //Get pour la connexion
        public marquesManager()
        {
            Bdd bdd = new Bdd();
            this.connexion = bdd.getConnexion();
        }

        //Voir une marque
        public List<marques> selectMarque()
        {
            List<marques> lesMarques = new List<marques>();

            //Ouverture de la BDD
            this.connexion.Open();

            String query = "SELECT mar_libelle, mar_id FROM marques";
            MySqlCommand cmd = new MySqlCommand(query, connexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["mar_id"]);
                String libelle = reader["mar_libelle"].ToString();
                marques laMarque = new marques(id, libelle);
                lesMarques.Add(laMarque);
            }

            return lesMarques;
        }
    }
}
