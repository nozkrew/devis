using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DevisClasses
{
    public class piecesManager
    {
        private MySqlConnection connexion;

        //Get pour la connexion
        public piecesManager()
        {
            Bdd bdd = new Bdd();
            this.connexion = bdd.getConnexion();
        }

        public piece unePiece(String p_libelle)
        {
            this.connexion.Open();
            string query = "SELECT * FROM pieces WHERE pie_libelle = '" + p_libelle + "'";

            MySqlCommand cmd = new MySqlCommand(query, connexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id = Convert.ToInt32(reader["pie_id"]);
            String libelle = reader["pie_libelle"].ToString();
            float prixHT = (float)reader["pie_prixHT"];
            int tvaId = Convert.ToInt32(reader["pie_tvaId"]);

            piece unePiece = new piece(id, tvaId, prixHT, libelle);
            return unePiece;
        }

        public List<piece> listePiece()
        {
            List<piece> listePiece = new List<piece>();

            this.connexion.Open();
            string query = "SELECT * FROM pieces ORDER BY pie_libelle ASC";

            MySqlCommand cmd = new MySqlCommand(query, connexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["pie_id"]);
                String libelle = reader["pie_libelle"].ToString();
                float prixHT = (float)reader["pie_prixHT"];
                int tvaId = Convert.ToInt32(reader["pie_tvaId"]);

                piece unePiece = new piece(id, tvaId, prixHT, libelle);
                listePiece.Add(unePiece);
            }

            return listePiece;
        }

        public piece getPiece(int p_idPiece)
        {
            this.connexion.Open();
            String query = "SELECT * FROM pieces WHERE pie_id = " + p_idPiece;
            MySqlCommand cmd = new MySqlCommand(query, connexion);
            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            int id = (int)reader["pie_id"];
            string libelle = reader["pie_libelle"].ToString();
            float prixHT = (float)reader["pie_prixHT"];
            int tvaId = (int)reader["pie_tvaId"];

            piece unePiece = new piece(id, tvaId, prixHT, libelle);
            return unePiece;
        }

        public void ajoutPiece(piece p_unePiece)
        {
            this.connexion.Open();
            String remplacePrixHT = p_unePiece.getPrixHT().ToString().Replace(",",".");
            string query = "INSERT INTO pieces (pie_libelle, pie_prixHT, pie_tvaId) VALUES ('" + p_unePiece.getLibelle() + "', '" + remplacePrixHT + "', " + p_unePiece.getTvaId() + ")";
            MySqlCommand cmd = new MySqlCommand(query, connexion);
            cmd.ExecuteNonQuery();
        }

    }
}
