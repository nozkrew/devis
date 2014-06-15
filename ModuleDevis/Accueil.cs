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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void buttonCreerDevis_Click(object sender, EventArgs e)
        {
            CreationDevis formDevis = new CreationDevis();
            formDevis.ShowDialog();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            devisManager devisManage = new devisManager();
            List<devis> listeDevis = devisManage.listeDevis();  

            foreach (devis unDevis in listeDevis)
            {
                clientManager clientManage = new clientManager();
                client unClient = clientManage.getUnclient(unDevis.getId());

                string texte = unDevis.getId() + " - " + unDevis.getDate() + " - " + unClient.getNom() + " " + unClient.getPrenom();
                int valeur = unDevis.getId();
                item unItem = new item(texte, valeur);

                comboListeDevis.Items.Add(unItem);
            }
        }

        private void buttonDevis_Click(object sender, EventArgs e)
        {
            if (comboListeDevis.SelectedItem == null)
            {
                MessageBox.Show("Choississez un devis.");
            }
            else
            {
                item itemSectionne = (item)comboListeDevis.Items[comboListeDevis.SelectedIndex];
                feuilleDevis uneFeuilleDevis = new feuilleDevis((int)itemSectionne.Value);
                uneFeuilleDevis.ShowDialog();
            }
        }

        private void buttonAjoutPiece_Click(object sender, EventArgs e)
        {
            ajoutPieces ajoutPiece = new ajoutPieces();
            ajoutPiece.ShowDialog();
        }
    }
}
