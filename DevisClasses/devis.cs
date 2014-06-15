using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevisClasses
{
    public class devis
    {
        private int id;
        private String date;
        private string vehiculeImmat;

        //Constructeur
        public devis(int p_id, String p_date, string p_vehiculeImmat)
        {
            this.id = setId(p_id);
            this.date = setDate(p_date);
            this.vehiculeImmat = setVehiculeImmat(p_vehiculeImmat);
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

        //Get et Set pour la date
        public String getDate()
        {
            return this.date;
        }
        public String setDate(String p_date)
        {
            return this.date = p_date;
        }

        //Get et Set pour l'immatriculation du vehicule
        public String getVehiculeImmat()
        {
            return this.vehiculeImmat;
        }
        public String setVehiculeImmat(String p_vehiculeImmat)
        {
            return this.vehiculeImmat = p_vehiculeImmat;
        }
    }
}
