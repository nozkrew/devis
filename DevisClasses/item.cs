using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevisClasses
{
    //Classe item pour pouvoir attribuer un texte et une valeur dans les combobox
    public class item
    {
        private string _Texte = string.Empty;
        private Object _Valeur = null;

        //Constructeur 
        public item(string text, Object p_val)
        {
            _Texte = text;
            _Valeur = p_val;
        }

        //Get et Set pour le text
        public string Text
        {
            get { return _Texte; }
            set { _Texte = value; }
        }

        //Get et set pour la valeur
        public Object Value
        {
            get { return _Valeur; }
            set { _Valeur = value; }
        }

        //Méthode pour convertir en String
        public override string ToString()
        {
            return _Texte;
        }

    }
}
