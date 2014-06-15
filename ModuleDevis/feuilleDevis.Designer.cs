namespace ModuleDevis
{
    partial class feuilleDevis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNomClient = new System.Windows.Forms.Label();
            this.labelPrenomClient = new System.Windows.Forms.Label();
            this.labelAdresse1 = new System.Windows.Forms.Label();
            this.labelAdresse2 = new System.Windows.Forms.Label();
            this.labelCP = new System.Windows.Forms.Label();
            this.labelVille = new System.Windows.Forms.Label();
            this.listViewPiece = new System.Windows.Forms.ListView();
            this.columnRef = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLibelle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrixHT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrixTTC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTotalTTC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTauxTva = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelImmat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTotalTTC = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auto-tech +";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "18 rue Laville";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "33000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bordeaux";
            // 
            // labelNomClient
            // 
            this.labelNomClient.AutoSize = true;
            this.labelNomClient.Location = new System.Drawing.Point(495, 133);
            this.labelNomClient.Name = "labelNomClient";
            this.labelNomClient.Size = new System.Drawing.Size(61, 13);
            this.labelNomClient.TabIndex = 4;
            this.labelNomClient.Text = "NomClient";
            // 
            // labelPrenomClient
            // 
            this.labelPrenomClient.AutoSize = true;
            this.labelPrenomClient.Location = new System.Drawing.Point(552, 133);
            this.labelPrenomClient.Name = "labelPrenomClient";
            this.labelPrenomClient.Size = new System.Drawing.Size(76, 13);
            this.labelPrenomClient.TabIndex = 5;
            this.labelPrenomClient.Text = "PrenomClient";
            // 
            // labelAdresse1
            // 
            this.labelAdresse1.AutoSize = true;
            this.labelAdresse1.Location = new System.Drawing.Point(495, 146);
            this.labelAdresse1.Name = "labelAdresse1";
            this.labelAdresse1.Size = new System.Drawing.Size(53, 13);
            this.labelAdresse1.TabIndex = 6;
            this.labelAdresse1.Text = "Adresse1";
            // 
            // labelAdresse2
            // 
            this.labelAdresse2.AutoSize = true;
            this.labelAdresse2.Location = new System.Drawing.Point(495, 159);
            this.labelAdresse2.Name = "labelAdresse2";
            this.labelAdresse2.Size = new System.Drawing.Size(53, 13);
            this.labelAdresse2.TabIndex = 7;
            this.labelAdresse2.Text = "Adresse2";
            // 
            // labelCP
            // 
            this.labelCP.AutoSize = true;
            this.labelCP.Location = new System.Drawing.Point(495, 176);
            this.labelCP.Name = "labelCP";
            this.labelCP.Size = new System.Drawing.Size(20, 13);
            this.labelCP.TabIndex = 8;
            this.labelCP.Text = "CP";
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Location = new System.Drawing.Point(495, 189);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(29, 13);
            this.labelVille.TabIndex = 9;
            this.labelVille.Text = "Ville";
            // 
            // listViewPiece
            // 
            this.listViewPiece.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnRef,
            this.columnLibelle,
            this.columnQuantite,
            this.columnPrixHT,
            this.columnPrixTTC,
            this.columnTotalTTC});
            this.listViewPiece.Location = new System.Drawing.Point(15, 307);
            this.listViewPiece.Name = "listViewPiece";
            this.listViewPiece.Size = new System.Drawing.Size(656, 177);
            this.listViewPiece.TabIndex = 10;
            this.listViewPiece.UseCompatibleStateImageBehavior = false;
            this.listViewPiece.View = System.Windows.Forms.View.Details;
            // 
            // columnRef
            // 
            this.columnRef.Text = "Réf";
            // 
            // columnLibelle
            // 
            this.columnLibelle.Text = "Libelle Pièce";
            this.columnLibelle.Width = 322;
            // 
            // columnQuantite
            // 
            this.columnQuantite.Text = "Quantité";
            // 
            // columnPrixHT
            // 
            this.columnPrixHT.Text = "Prix Un. HT";
            this.columnPrixHT.Width = 69;
            // 
            // columnPrixTTC
            // 
            this.columnPrixTTC.Text = "Prix Un. TTC";
            this.columnPrixTTC.Width = 81;
            // 
            // columnTotalTTC
            // 
            this.columnTotalTTC.Text = "Total TTC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Devis édité le :";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(95, 282);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 12;
            this.labelDate.Text = "date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Taux de TVA :";
            // 
            // labelTauxTva
            // 
            this.labelTauxTva.AutoSize = true;
            this.labelTauxTva.Location = new System.Drawing.Point(95, 504);
            this.labelTauxTva.Name = "labelTauxTva";
            this.labelTauxTva.Size = new System.Drawing.Size(48, 13);
            this.labelTauxTva.TabIndex = 14;
            this.labelTauxTva.Text = "tauxTVA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Propriétaire du véhicule immatriculé :";
            // 
            // labelImmat
            // 
            this.labelImmat.AutoSize = true;
            this.labelImmat.Location = new System.Drawing.Point(215, 251);
            this.labelImmat.Name = "labelImmat";
            this.labelImmat.Size = new System.Drawing.Size(87, 13);
            this.labelImmat.TabIndex = 16;
            this.labelImmat.Text = "immatriculation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(552, 504);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total TTC :";
            // 
            // labelTotalTTC
            // 
            this.labelTotalTTC.AutoSize = true;
            this.labelTotalTTC.Location = new System.Drawing.Point(619, 504);
            this.labelTotalTTC.Name = "labelTotalTTC";
            this.labelTotalTTC.Size = new System.Drawing.Size(48, 13);
            this.labelTotalTTC.TabIndex = 18;
            this.labelTotalTTC.Text = "totalTTC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 40);
            this.label9.TabIndex = 19;
            this.label9.Text = "Devis";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // feuilleDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 560);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelTotalTTC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelImmat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelTauxTva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listViewPiece);
            this.Controls.Add(this.labelVille);
            this.Controls.Add(this.labelCP);
            this.Controls.Add(this.labelAdresse2);
            this.Controls.Add(this.labelAdresse1);
            this.Controls.Add(this.labelPrenomClient);
            this.Controls.Add(this.labelNomClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "feuilleDevis";
            this.Text = "Récapitulatif du devis";
            this.Load += new System.EventHandler(this.feuilleDevis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNomClient;
        private System.Windows.Forms.Label labelPrenomClient;
        private System.Windows.Forms.Label labelAdresse1;
        private System.Windows.Forms.Label labelAdresse2;
        private System.Windows.Forms.Label labelCP;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.ListView listViewPiece;
        private System.Windows.Forms.ColumnHeader columnRef;
        private System.Windows.Forms.ColumnHeader columnLibelle;
        private System.Windows.Forms.ColumnHeader columnQuantite;
        private System.Windows.Forms.ColumnHeader columnPrixHT;
        private System.Windows.Forms.ColumnHeader columnPrixTTC;
        private System.Windows.Forms.ColumnHeader columnTotalTTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTauxTva;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelImmat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTotalTTC;
        private System.Windows.Forms.Label label9;
    }
}