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
    public partial class ajoutPieces : Form
    {
        public ajoutPieces()
        {
            InitializeComponent();
        }

        private void ajoutPieces_Load(object sender, EventArgs e)
        {
            tvaManager tvaManage = new tvaManager();
            tva uneTva = tvaManage.uneTva();

            item item = new item(uneTva.getTaux().ToString(), uneTva.getId());
            comboTva.Items.Add(item);
        }

        private void buttonAjoutPiece_Click(object sender, EventArgs e)
        {
            if (textLibellePiece.Text == "" || textPrixHt.Text == "" || comboTva.SelectedItem == null )
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
            }
            else
            {
                string libelle = textLibellePiece.Text;
                float prixHT = float.Parse(textPrixHt.Text);
                item itemSectionne = (item)comboTva.Items[comboTva.SelectedIndex];

                piece unePiece = new piece(0, (int)itemSectionne.Value, prixHT, libelle);

                piecesManager pieceManage = new piecesManager();
                pieceManage.ajoutPiece(unePiece);

                MessageBox.Show("Pièces ajoutée.");

                textLibellePiece.Clear();
                textPrixHt.Clear();
            }
        }

        private void textPrixHt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',' || char.IsControl(e.KeyChar))
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
