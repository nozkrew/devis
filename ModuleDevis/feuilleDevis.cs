using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevisClasses;

namespace ModuleDevis
{
    public partial class feuilleDevis : Form
    {

        private double calculTotalTTC()
        {
            double totalTTC = 0;
            foreach (ListViewItem unItem in listViewPiece.Items)
            {
                totalTTC += Convert.ToDouble(unItem.SubItems[5].Text);
            }

            return totalTTC;
        }

        private int idDevis;

        public feuilleDevis(int p_idDevis)
        {
            InitializeComponent();
            this.idDevis = p_idDevis;
        }

        private void feuilleDevis_Load(object sender, EventArgs e)
        {
            //On recupère les infos client
            clientManager clientManage = new clientManager();
            client leClient = clientManage.getUnclient(idDevis);

            //On récupère la date
            devisManager devisManage = new devisManager();
            DateTime laDate = devisManage.getDate(idDevis);

            //On récupere l'immatriculation
            vehiculesManager vehiculeManage = new vehiculesManager();
            string immat = vehiculeManage.getImmat(idDevis);

            //On récupère la TVA
            tvaManager tvaManage = new tvaManager();
            tva laTva = tvaManage.uneTva();

            //On affiche les informartion du client
            labelNomClient.Text = leClient.getNom();
            labelPrenomClient.Text = leClient.getPrenom();
            labelAdresse1.Text = leClient.getAdr1();
            labelAdresse2.Text = leClient.getAdr2();
            labelCP.Text = leClient.getCP().ToString();
            labelVille.Text = leClient.getVille();

            //On affiche la date
            labelDate.Text = laDate.ToString();

            //on affiche l'immatriculation
            labelImmat.Text = immat;

            //On affiche la tva
            labelTauxTva.Text = laTva.getTaux().ToString() + "%";

            //On affiche la liste des pieces
            repareManager repareManage = new repareManager();
            List<repare> listeRepare = repareManage.getListeRepare(idDevis);
            foreach (repare uneReparation in listeRepare)
            {
                piecesManager pieceManage = new piecesManager();
                int idPiece = uneReparation.getPieceId();
                piece unePiece = pieceManage.getPiece(idPiece);

                double prixTTC = (float)unePiece.getPrixHT() * (1 + (float)laTva.getTaux() / 100);
                prixTTC = Math.Round(prixTTC, 2);

                double totalTTC = prixTTC * uneReparation.getQuantite();

                ListViewItem item = new ListViewItem(unePiece.getId().ToString());
                item.SubItems.Add(unePiece.getLibelle());
                item.SubItems.Add(uneReparation.getQuantite().ToString());
                item.SubItems.Add(unePiece.getPrixHT().ToString());
                item.SubItems.Add(prixTTC.ToString());
                item.SubItems.Add(totalTTC.ToString());

                listViewPiece.Items.Add(item);
            }


            labelTotalTTC.Text = calculTotalTTC().ToString() + " €"; 

        }


    }
}
