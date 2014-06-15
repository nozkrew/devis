namespace ModuleDevis
{
    partial class Accueil
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
            this.buttonCreerDevis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboListeDevis = new System.Windows.Forms.ComboBox();
            this.buttonDevis = new System.Windows.Forms.Button();
            this.buttonAjoutPiece = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreerDevis
            // 
            this.buttonCreerDevis.Location = new System.Drawing.Point(15, 26);
            this.buttonCreerDevis.Name = "buttonCreerDevis";
            this.buttonCreerDevis.Size = new System.Drawing.Size(368, 46);
            this.buttonCreerDevis.TabIndex = 0;
            this.buttonCreerDevis.Text = "Créer un devis";
            this.buttonCreerDevis.UseVisualStyleBackColor = true;
            this.buttonCreerDevis.Click += new System.EventHandler(this.buttonCreerDevis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des devis";
            // 
            // comboListeDevis
            // 
            this.comboListeDevis.FormattingEnabled = true;
            this.comboListeDevis.Location = new System.Drawing.Point(95, 166);
            this.comboListeDevis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboListeDevis.Name = "comboListeDevis";
            this.comboListeDevis.Size = new System.Drawing.Size(289, 21);
            this.comboListeDevis.TabIndex = 2;
            // 
            // buttonDevis
            // 
            this.buttonDevis.Location = new System.Drawing.Point(95, 208);
            this.buttonDevis.Name = "buttonDevis";
            this.buttonDevis.Size = new System.Drawing.Size(288, 38);
            this.buttonDevis.TabIndex = 3;
            this.buttonDevis.Text = "Voir le devis";
            this.buttonDevis.UseVisualStyleBackColor = true;
            this.buttonDevis.Click += new System.EventHandler(this.buttonDevis_Click);
            // 
            // buttonAjoutPiece
            // 
            this.buttonAjoutPiece.Location = new System.Drawing.Point(15, 96);
            this.buttonAjoutPiece.Name = "buttonAjoutPiece";
            this.buttonAjoutPiece.Size = new System.Drawing.Size(368, 46);
            this.buttonAjoutPiece.TabIndex = 4;
            this.buttonAjoutPiece.Text = "Ajouter des pièces";
            this.buttonAjoutPiece.UseVisualStyleBackColor = true;
            this.buttonAjoutPiece.Click += new System.EventHandler(this.buttonAjoutPiece_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(404, 309);
            this.Controls.Add(this.buttonAjoutPiece);
            this.Controls.Add(this.buttonDevis);
            this.Controls.Add(this.comboListeDevis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreerDevis);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreerDevis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboListeDevis;
        private System.Windows.Forms.Button buttonDevis;
        private System.Windows.Forms.Button buttonAjoutPiece;
    }
}