using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevisClasses
{
    public class client
    {
        //Déclaration variable privée
        private int id, CP;
        private string nom, prenom, adr1, adr2, ville;

        public client(int p_id, string p_nom, string p_prenom, string p_adr1, string p_adr2, int p_CP, string p_ville)
        {
            this.id = setId(p_id);
            this.nom = setNom(p_nom);
            this.prenom = setPrenom(p_prenom);
            this.adr1 = setAdr1(p_adr1);
            this.adr2 = setAdr2(p_adr2);
            this.CP = setCP(p_CP);
            this.ville = this.setVille(p_ville);
        }

        //Get et set pour l'id
        public int getId()
        {
            return this.id;
        }
        public int setId(int p_id)
        {
            return this.id = p_id;
        }

        //Get et Set pour le nom
        public int getCP()
        {
            return this.CP;
        }
        public int setCP(int p_CP)
        {
            return this.CP = p_CP;
        }

        //get et set pour le nom
        public string getNom()
        {
            return this.nom;    
        }
        public string setNom(string p_nom)
        {
            return this.nom = p_nom;    
        }

        //Get et Set pour le prenom
        public string getPrenom()
        {
            return this.prenom;
        }
        public string setPrenom(string p_prenom)
        {
            return this.prenom = p_prenom;
        }

        //Get et Set pour l'adresse 1
        public string getAdr1()
        {
            return this.adr1;
        }
        public string setAdr1(string p_adr1)
        {
            return this.adr1 = p_adr1;
        }

        //Get et Set pour l'adresse 2
        public string getAdr2()
        {
            return this.adr2;
        }
        public string setAdr2(string p_adr2)
        {
            return this.adr2 = p_adr2;  
        }

        //Get et Set pour la ville
        public string getVille()
        {
            return this.ville;
        }
        public string setVille(string p_ville)
        {
            return this.ville = p_ville;    
        }
    }
}
