using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevisClasses
{
    public class modeles
    {
        private int id, marqueId;
        private String libelle;

        public modeles(int p_id, int p_marqueId, String p_libelle)
        {
            this.id = setId(p_id);
            this.marqueId = setMarqueId(p_marqueId);
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

        //Get et Set pour le libelle
        public string getLibelle()
        {
            return this.libelle;
        }
        public String setLibelle(String p_libelle)
        {
            return this.libelle = p_libelle;
        }

        //Get et Set pour l'id de la marque
        public int getMarqueId()
        {
            return this.marqueId;
        }
        public int setMarqueId(int p_marqueId)
        {
            return this.marqueId = p_marqueId;
        }


    }
}
