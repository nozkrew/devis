using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevisClasses
{
    public class repare
    {
        private int devisId, pieceId, quantite;

        //Constructeur
        public repare(int p_devisId, int p_pieceId, int p_quantite)
        {
            this.devisId = setDevisId(p_devisId);
            this.pieceId = setPieceId(p_pieceId);
            this.quantite = setQuantite(p_quantite);
        }

        //Get et Set pour l'id du devis
        public int getDevisId()
        {
            return this.devisId;
        }
        public int setDevisId(int p_devisId)
        {
            return this.devisId = p_devisId;
        }

        //Get et Set pour l'id de la piece
        public int getPieceId()
        {
            return this.pieceId;
        }
        public int setPieceId(int p_pieceId)
        {
            return this.pieceId = p_pieceId;
        }

        //Get et Set pour la quantité
        public int getQuantite()
        {
            return this.quantite;
        }
        public int setQuantite(int p_quantite)
        {
            return this.quantite = p_quantite;
        }
    }
}
