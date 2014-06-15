using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DevisClasses
{
    public class repareManager
    {
        private MySqlConnection connexion;

        //Get pour la connexion
        public repareManager()
        {
            Bdd bdd = new Bdd();
            this.connexion = bdd.getConnexion();
        }

        public void ajouteRepare(int p_idDevis, int p_idPiece, int p_quantite)
        {
            this.connexion.Open();
            string query = "INSERT INTO repare (rep_devisId, rep_pieceId, rep_quantite) VALUES (" + p_idDevis + ", " + p_idPiece + ", " + p_quantite + ")";
            MySqlCommand cmd = new MySqlCommand(query, connexion);
            cmd.ExecuteNonQuery();
        }

        public List<repare> getListeRepare(int p_idDevis)
        {
            List<repare> listeRepare = new List<repare>();

            this.connexion.Open();
            string query = "SELECT * FROM repare WHERE rep_devisId = " + p_idDevis;

            MySqlCommand cmd = new MySqlCommand(query, connexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int devisId = (int)reader["rep_devisId"];
                int pieceId = (int)reader["rep_pieceId"];
                int quantite = (int)reader["rep_quantite"];

                repare rep = new repare(devisId, pieceId, quantite);
                listeRepare.Add(rep);
            }

            return listeRepare;
        }
    }
}
