﻿namespace ModuleDevis
{
    partial class ajoutPieces
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
            this.textLibellePiece = new System.Windows.Forms.TextBox();
            this.textPrixHt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTva = new System.Windows.Forms.ComboBox();
            this.buttonAjoutPiece = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libellé :";
            // 
            // textLibellePiece
            // 
            this.textLibellePiece.Location = new System.Drawing.Point(94, 17);
            this.textLibellePiece.Name = "textLibellePiece";
            this.textLibellePiece.Size = new System.Drawing.Size(223, 20);
            this.textLibellePiece.TabIndex = 1;
            // 
            // textPrixHt
            // 
            this.textPrixHt.Location = new System.Drawing.Point(94, 54);
            this.textPrixHt.Name = "textPrixHt";
            this.textPrixHt.Size = new System.Drawing.Size(100, 20);
            this.textPrixHt.TabIndex = 2;
            this.textPrixHt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrixHt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prix HT :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Taux TVA :";
            // 
            // comboTva
            // 
            this.comboTva.FormattingEnabled = true;
            this.comboTva.Location = new System.Drawing.Point(94, 90);
            this.comboTva.Name = "comboTva";
            this.comboTva.Size = new System.Drawing.Size(121, 21);
            this.comboTva.TabIndex = 5;
            // 
            // buttonAjoutPiece
            // 
            this.buttonAjoutPiece.Location = new System.Drawing.Point(94, 142);
            this.buttonAjoutPiece.Name = "buttonAjoutPiece";
            this.buttonAjoutPiece.Size = new System.Drawing.Size(166, 38);
            this.buttonAjoutPiece.TabIndex = 6;
            this.buttonAjoutPiece.Text = "Ajouter";
            this.buttonAjoutPiece.UseVisualStyleBackColor = true;
            this.buttonAjoutPiece.Click += new System.EventHandler(this.buttonAjoutPiece_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "€";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "%";
            // 
            // ajoutPieces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 206);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAjoutPiece);
            this.Controls.Add(this.comboTva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPrixHt);
            this.Controls.Add(this.textLibellePiece);
            this.Controls.Add(this.label1);
            this.Name = "ajoutPieces";
            this.Text = "Ajout d\'une pièce";
            this.Load += new System.EventHandler(this.ajoutPieces_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLibellePiece;
        private System.Windows.Forms.TextBox textPrixHt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboTva;
        private System.Windows.Forms.Button buttonAjoutPiece;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}