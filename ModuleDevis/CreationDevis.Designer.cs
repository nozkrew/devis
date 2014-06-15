namespace ModuleDevis
{
    partial class CreationDevis
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
            this.comboSelectVehicule = new System.Windows.Forms.ComboBox();
            this.comboSelectPiece = new System.Windows.Forms.ComboBox();
            this.labelSelectVehicule = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.textQuantite = new System.Windows.Forms.TextBox();
            this.buttonAjout = new System.Windows.Forms.Button();
            this.listPiece = new System.Windows.Forms.ListView();
            this.columnLibelle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrixHt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrixTTC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelPrixTTC = new System.Windows.Forms.Label();
            this.buttonEditer = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTauxTva = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboSelectVehicule
            // 
            this.comboSelectVehicule.FormattingEnabled = true;
            this.comboSelectVehicule.Location = new System.Drawing.Point(199, 47);
            this.comboSelectVehicule.Name = "comboSelectVehicule";
            this.comboSelectVehicule.Size = new System.Drawing.Size(204, 21);
            this.comboSelectVehicule.TabIndex = 0;
            this.comboSelectVehicule.SelectedIndexChanged += new System.EventHandler(this.comboSelectVehicule_SelectedIndexChanged);
            // 
            // comboSelectPiece
            // 
            this.comboSelectPiece.FormattingEnabled = true;
            this.comboSelectPiece.Location = new System.Drawing.Point(199, 93);
            this.comboSelectPiece.Name = "comboSelectPiece";
            this.comboSelectPiece.Size = new System.Drawing.Size(204, 21);
            this.comboSelectPiece.TabIndex = 1;
            // 
            // labelSelectVehicule
            // 
            this.labelSelectVehicule.AutoSize = true;
            this.labelSelectVehicule.Location = new System.Drawing.Point(12, 50);
            this.labelSelectVehicule.Name = "labelSelectVehicule";
            this.labelSelectVehicule.Size = new System.Drawing.Size(139, 13);
            this.labelSelectVehicule.TabIndex = 2;
            this.labelSelectVehicule.Text = "Sélectionner un véhicule :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sélectionner une pièce :";
            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Location = new System.Drawing.Point(439, 96);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(58, 13);
            this.labelQuantite.TabIndex = 4;
            this.labelQuantite.Text = "Quantité :";
            // 
            // textQuantite
            // 
            this.textQuantite.Location = new System.Drawing.Point(523, 93);
            this.textQuantite.Name = "textQuantite";
            this.textQuantite.Size = new System.Drawing.Size(81, 22);
            this.textQuantite.TabIndex = 5;
            this.textQuantite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textQuantite_KeyPress);
            // 
            // buttonAjout
            // 
            this.buttonAjout.Location = new System.Drawing.Point(661, 91);
            this.buttonAjout.Name = "buttonAjout";
            this.buttonAjout.Size = new System.Drawing.Size(75, 23);
            this.buttonAjout.TabIndex = 6;
            this.buttonAjout.Text = "Ajouter";
            this.buttonAjout.UseVisualStyleBackColor = true;
            this.buttonAjout.Click += new System.EventHandler(this.buttonAjout_Click);
            // 
            // listPiece
            // 
            this.listPiece.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnLibelle,
            this.columnQuantite,
            this.columnPrixHt,
            this.columnPrixTTC,
            this.columnTotal});
            this.listPiece.GridLines = true;
            this.listPiece.Location = new System.Drawing.Point(12, 150);
            this.listPiece.Name = "listPiece";
            this.listPiece.Size = new System.Drawing.Size(770, 182);
            this.listPiece.TabIndex = 7;
            this.listPiece.UseCompatibleStateImageBehavior = false;
            this.listPiece.View = System.Windows.Forms.View.Details;
            // 
            // columnLibelle
            // 
            this.columnLibelle.Text = "Libelle";
            this.columnLibelle.Width = 414;
            // 
            // columnQuantite
            // 
            this.columnQuantite.Text = "Quantité";
            this.columnQuantite.Width = 82;
            // 
            // columnPrixHt
            // 
            this.columnPrixHt.Text = "Prix Un. HT";
            this.columnPrixHt.Width = 87;
            // 
            // columnPrixTTC
            // 
            this.columnPrixTTC.Text = "Prix Un. TTC";
            this.columnPrixTTC.Width = 87;
            // 
            // columnTotal
            // 
            this.columnTotal.Text = "Total TTC";
            this.columnTotal.Width = 69;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(62, 358);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(58, 13);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "Total TTC :";
            // 
            // labelPrixTTC
            // 
            this.labelPrixTTC.AutoSize = true;
            this.labelPrixTTC.Location = new System.Drawing.Point(129, 358);
            this.labelPrixTTC.Name = "labelPrixTTC";
            this.labelPrixTTC.Size = new System.Drawing.Size(13, 13);
            this.labelPrixTTC.TabIndex = 9;
            this.labelPrixTTC.Text = "0";
            // 
            // buttonEditer
            // 
            this.buttonEditer.Location = new System.Drawing.Point(523, 353);
            this.buttonEditer.Name = "buttonEditer";
            this.buttonEditer.Size = new System.Drawing.Size(259, 45);
            this.buttonEditer.TabIndex = 11;
            this.buttonEditer.Text = "Editer le devis";
            this.buttonEditer.UseVisualStyleBackColor = true;
            this.buttonEditer.Click += new System.EventHandler(this.buttonEditer_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(661, 121);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.buttonSupprimer.TabIndex = 12;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Taux TVA :";
            // 
            // labelTauxTva
            // 
            this.labelTauxTva.AutoSize = true;
            this.labelTauxTva.Location = new System.Drawing.Point(279, 358);
            this.labelTauxTva.Name = "labelTauxTva";
            this.labelTauxTva.Size = new System.Drawing.Size(13, 13);
            this.labelTauxTva.TabIndex = 14;
            this.labelTauxTva.Text = "0";
            // 
            // CreationDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(794, 410);
            this.Controls.Add(this.labelTauxTva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonEditer);
            this.Controls.Add(this.labelPrixTTC);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.listPiece);
            this.Controls.Add(this.buttonAjout);
            this.Controls.Add(this.textQuantite);
            this.Controls.Add(this.labelQuantite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSelectVehicule);
            this.Controls.Add(this.comboSelectPiece);
            this.Controls.Add(this.comboSelectVehicule);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "CreationDevis";
            this.Text = "Creation d\'un devis";
            this.Load += new System.EventHandler(this.CreationDevis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSelectVehicule;
        private System.Windows.Forms.ComboBox comboSelectPiece;
        private System.Windows.Forms.Label labelSelectVehicule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelQuantite;
        private System.Windows.Forms.TextBox textQuantite;
        private System.Windows.Forms.Button buttonAjout;
        private System.Windows.Forms.ListView listPiece;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelPrixTTC;
        private System.Windows.Forms.Button buttonEditer;
        private System.Windows.Forms.ColumnHeader columnLibelle;
        private System.Windows.Forms.ColumnHeader columnQuantite;
        private System.Windows.Forms.ColumnHeader columnPrixHt;
        private System.Windows.Forms.ColumnHeader columnPrixTTC;
        private System.Windows.Forms.ColumnHeader columnTotal;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTauxTva;
    }
}