using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevisClasses
{
    public class piece
    {
        private int id, tvaId;
        private float prixHT;
        private string libelle;

        public piece(int p_id, int p_tvaId, float p_prixHT, string p_libelle)
        {
            this.id = setId(p_id);
            this.tvaId = setTvaId(p_tvaId);
            this.prixHT = setPrixHT(p_prixHT);
            this.libelle = setLibelle(p_libelle);
        }

        //Get et Set pour l'id 
        public int getId()
        {
            return this.id;
        }
        public int setId(int p_id)
        {
            return this.id = p_id;
        }

        //Get et Set pour le prix HT
        public float getPrixHT()
        {
            return this.prixHT;
        }
        public float setPrixHT(float p_prixHT)
        {
            return this.prixHT = p_prixHT;  
        }

        //Get et Set pour le libelle
        public String getLibelle()
        {
            return this.libelle;
        }
        public String setLibelle(String p_libelle)
        {
            return this.libelle = p_libelle;
        }

        //Get et Set pour l'id de la TVA
        public int getTvaId()
        {
            return this.tvaId;
        }
        public int setTvaId(int p_id)
        {
            return this.tvaId = p_id;
        }
    }
}
