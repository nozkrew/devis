using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevisClasses
{
    public class tva
    {
        private int id;
        private float taux;

        public tva(int p_id, float p_taux)
        {
            this.id = setId(p_id);
            this.taux = setTaux(p_taux);
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
        public float getTaux()
        {
            return this.taux;
        }
        public float setTaux(float p_taux)
        {
            return this.taux = p_taux;
        }
    }
}
