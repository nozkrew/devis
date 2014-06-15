using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevisClasses
{
    public class vehicules
    {
        private String immatriculation;
        private int annee, repare, km, modId, energieId;

        public vehicules(String p_immat, int p_annee, int p_repare, int p_km, int p_modId, int p_energieId)
        {
            this.immatriculation = setImmat(p_immat);
            this.annee = setAnnee(p_annee);
            this.repare = setRepare(p_repare);
            this.km = setKm(p_km);
            this.modId = setModId(p_modId);
            this.energieId = setEnergieId(p_energieId);
        }

        //Get et Set pour l'immatriculation
        public String getImmat()
        {
            return this.immatriculation;
        }
        public String setImmat(String p_immat)
        {
            return this.immatriculation = p_immat; 
        }

        //Get et Set pour l'annee
        public int getAnnee()
        {
            return this.annee;
        }
        public int setAnnee(int p_annee)
        {
            return this.annee = p_annee;
        }

        //Get et Set pour repare
        public int getRepare()
        {
            return this.repare;
        }
        public int setRepare(int p_repare)
        {
            return this.repare = p_repare;
        }

        //Get et Set pour km
        public int getKm()
        {
            return this.km;
        }
        public int setKm(int p_km)
        {
            return this.km = p_km;
        }

        //Get et Set pour l'id du modèle
        public int getModId()
        {
            return this.modId;
        }
        public int setModId(int p_modId)
        {
            return this.modId = p_modId;
        }

        //Get et set pour l'id de l'energie
        public int getEnergieId()
        {
            return this.energieId;
        }
        public int setEnergieId(int p_energieId)
        {
            return this.energieId = p_energieId;
        }
    }
}
