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
    public partial class CreationDevis : Form
    {
        //Fonction qui compte le total TTC
        private double compteTotalTTC()
        {
            double totalTTC = 0;
            foreach (ListViewItem unItem in listPiece.Items)
            {
                totalTTC += Convert.ToDouble(unItem.SubItems[4].Text);
            }

            return totalTTC;
        }

        public CreationDevis()
        {
            InitializeComponent();
        }

        private void CreationDevis_Load(object sender, EventArgs e)
        {
            //Pour remplir le combobox des véhicules à réparer
            vehiculesManager vehiculeManage = new vehiculesManager();
            List<vehicules> lesVehicules = new List<vehicules>();
            lesVehicules = vehiculeManage.listeVehicules();

            tvaManager tvaManage = new tvaManager();
            tva laTva = tvaManage.uneTva();

            labelTauxTva.Text = laTva.getTaux() + " %";

            foreach (vehicules unVehicule in lesVehicules)
            {
                comboSelectVehicule.Items.Add(unVehicule.getImmat());
            }

            //Pour remplir le combobox des pieces
            piecesManager pieceManage = new piecesManager();
            List<piece> lesPieces = new List<piece>();
            lesPieces = pieceManage.listePiece();

            foreach (piece unePiece in lesPieces)
            {
                comboSelectPiece.Items.Add(unePiece.getLibelle());
            }
        }

        private void buttonAjout_Click(object sender, EventArgs e)
        {
            if (comboSelectVehicule.SelectedItem == null || textQuantite.Text == "" || comboSelectPiece.SelectedItem == null )
            {
                MessageBox.Show("Veuillez renseigner tous les champs");
            }
            else
            {
                //Pour remplir la listeView
                piecesManager pieceManage = new piecesManager();
                tvaManager tvaManage = new tvaManager();
                piece unePiece = pieceManage.unePiece(comboSelectPiece.SelectedItem.ToString());
                tva uneTva = tvaManage.uneTva();

                double prixTTC = (float)unePiece.getPrixHT() * (1 + (float)uneTva.getTaux() / 100);
                prixTTC = Math.Round(prixTTC, 2);
                double prixTotal = Convert.ToInt32(textQuantite.Text) * prixTTC;

                ListViewItem item = new ListViewItem(unePiece.getLibelle().ToString());
                item.SubItems.Add(textQuantite.Text);
                item.SubItems.Add(unePiece.getPrixHT().ToString());
                item.SubItems.Add(prixTTC.ToString());
                item.SubItems.Add(prixTotal.ToString());
                
                listPiece.Items.Add(item);

                textQuantite.Clear();
                comboSelectPiece.SelectedIndex = -1;
            }

            labelPrixTTC.Text = compteTotalTTC().ToString() + " €";
        }

        //Lorsque l'on change de véhicule, on néttoie la liste et le prix total TTC.
        private void comboSelectVehicule_SelectedIndexChanged(object sender, EventArgs e)
        {
            listPiece.Items.Clear();
            labelPrixTTC.Text = "0 €";
        }

        private void buttonEditer_Click(object sender, EventArgs e)
        {
            if (comboSelectVehicule.SelectedItem == null || listPiece.Items.Count <= 0)
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            else
            {
                //On créé un nouveau devis avec la date et l'immatriculation
                String laDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                String immat = comboSelectVehicule.SelectedItem.ToString();

                devis unDevis = new devis(0, laDate, immat);
                devisManager devisManage = new devisManager();

                //Id du dernier devis.
                long dernierId = devisManage.editeDevis(unDevis);

                foreach (ListViewItem unItem in listPiece.Items)
                {
                    //On récupere la quantité
                    int quantite = Convert.ToInt32(unItem.SubItems[1].Text);
                    //On créer une piece pour avoir l'id
                    piecesManager pieceManage = new piecesManager();
                    piece unePiece = pieceManage.unePiece(unItem.SubItems[0].Text.ToString());

                    repareManager repareManage = new repareManager();
                    repareManage.ajouteRepare((int)dernierId, unePiece.getId(), quantite);
                }
                MessageBox.Show("Le devis à été édité.");

                feuilleDevis feuilleDevis = new feuilleDevis((int)dernierId);
                this.Close();
                feuilleDevis.ShowDialog();
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (listPiece.Items.Count <= 0)
            {
                MessageBox.Show("Aucune pièce n'a été ajoutée");
            }
            else
            {
                listPiece.Items.RemoveAt(0);
                labelPrixTTC.Text = compteTotalTTC().ToString() + " €";
            }
            
        }

        private void textQuantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
