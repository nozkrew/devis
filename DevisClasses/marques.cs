using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevisClasses
{
    public class marques
    {
        private int id;
        private string libelle;

        public marques(int p_id, string p_libelle)
        {
            this.id = setId(p_id);
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
        public string setLibelle(string p_libelle)
        {
            return this.libelle = p_libelle;
        }
    }
}
