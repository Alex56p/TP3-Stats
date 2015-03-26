namespace TP3_Stats
{
    partial class Jeu
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
            this.PB_Paquet = new System.Windows.Forms.PictureBox();
            this.LB_Score1 = new System.Windows.Forms.Label();
            this.LB_Score2 = new System.Windows.Forms.Label();
            this.LB_J1 = new System.Windows.Forms.Label();
            this.LB_J2 = new System.Windows.Forms.Label();
            this.BTN_Passer = new System.Windows.Forms.Button();
            this.TB_Probabilité = new System.Windows.Forms.TextBox();
            this.LB_Probabilité = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_CartesJ1 = new System.Windows.Forms.ListBox();
            this.LB_CartesJ2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_CarteTotale = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_NbCartesRéussites = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Paquet)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Paquet
            // 
            this.PB_Paquet.Image = global::TP3_Stats.Properties.Resources.Dos_Carte_J1;
            this.PB_Paquet.Location = new System.Drawing.Point(150, 186);
            this.PB_Paquet.Name = "PB_Paquet";
            this.PB_Paquet.Size = new System.Drawing.Size(211, 314);
            this.PB_Paquet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Paquet.TabIndex = 0;
            this.PB_Paquet.TabStop = false;
            this.PB_Paquet.Click += new System.EventHandler(this.PB_Paquet_Click);
            // 
            // LB_Score1
            // 
            this.LB_Score1.AutoSize = true;
            this.LB_Score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Score1.Location = new System.Drawing.Point(69, 67);
            this.LB_Score1.Name = "LB_Score1";
            this.LB_Score1.Size = new System.Drawing.Size(24, 25);
            this.LB_Score1.TabIndex = 1;
            this.LB_Score1.Text = "0";
            // 
            // LB_Score2
            // 
            this.LB_Score2.AutoSize = true;
            this.LB_Score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Score2.Location = new System.Drawing.Point(466, 67);
            this.LB_Score2.Name = "LB_Score2";
            this.LB_Score2.Size = new System.Drawing.Size(24, 25);
            this.LB_Score2.TabIndex = 2;
            this.LB_Score2.Text = "0";
            // 
            // LB_J1
            // 
            this.LB_J1.AutoSize = true;
            this.LB_J1.Location = new System.Drawing.Point(12, 76);
            this.LB_J1.Name = "LB_J1";
            this.LB_J1.Size = new System.Drawing.Size(51, 13);
            this.LB_J1.TabIndex = 3;
            this.LB_J1.Text = "Joueur1: ";
            // 
            // LB_J2
            // 
            this.LB_J2.AutoSize = true;
            this.LB_J2.Location = new System.Drawing.Point(409, 76);
            this.LB_J2.Name = "LB_J2";
            this.LB_J2.Size = new System.Drawing.Size(51, 13);
            this.LB_J2.TabIndex = 3;
            this.LB_J2.Text = "Joueur2: ";
            // 
            // BTN_Passer
            // 
            this.BTN_Passer.Location = new System.Drawing.Point(216, 157);
            this.BTN_Passer.Name = "BTN_Passer";
            this.BTN_Passer.Size = new System.Drawing.Size(75, 23);
            this.BTN_Passer.TabIndex = 4;
            this.BTN_Passer.Text = "Passer";
            this.BTN_Passer.UseVisualStyleBackColor = true;
            this.BTN_Passer.Click += new System.EventHandler(this.BTN_Passer_Click);
            // 
            // TB_Probabilité
            // 
            this.TB_Probabilité.Location = new System.Drawing.Point(273, 128);
            this.TB_Probabilité.Name = "TB_Probabilité";
            this.TB_Probabilité.Size = new System.Drawing.Size(100, 20);
            this.TB_Probabilité.TabIndex = 5;
            // 
            // LB_Probabilité
            // 
            this.LB_Probabilité.AutoSize = true;
            this.LB_Probabilité.Location = new System.Drawing.Point(208, 128);
            this.LB_Probabilité.Name = "LB_Probabilité";
            this.LB_Probabilité.Size = new System.Drawing.Size(59, 13);
            this.LB_Probabilité.TabIndex = 6;
            this.LB_Probabilité.Text = "Probabilité:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = "BLACK JACK";
            // 
            // LB_CartesJ1
            // 
            this.LB_CartesJ1.FormattingEnabled = true;
            this.LB_CartesJ1.Location = new System.Drawing.Point(13, 93);
            this.LB_CartesJ1.Name = "LB_CartesJ1";
            this.LB_CartesJ1.Size = new System.Drawing.Size(111, 95);
            this.LB_CartesJ1.TabIndex = 9;
            // 
            // LB_CartesJ2
            // 
            this.LB_CartesJ2.FormattingEnabled = true;
            this.LB_CartesJ2.Location = new System.Drawing.Point(379, 95);
            this.LB_CartesJ2.Name = "LB_CartesJ2";
            this.LB_CartesJ2.Size = new System.Drawing.Size(111, 95);
            this.LB_CartesJ2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Arrêter le jeu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cartes Totales:";
            // 
            // TB_CarteTotale
            // 
            this.TB_CarteTotale.Location = new System.Drawing.Point(273, 102);
            this.TB_CarteTotale.Name = "TB_CarteTotale";
            this.TB_CarteTotale.Size = new System.Drawing.Size(100, 20);
            this.TB_CarteTotale.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre de cartes pour réussir:";
            // 
            // TB_NbCartesRéussites
            // 
            this.TB_NbCartesRéussites.Location = new System.Drawing.Point(273, 76);
            this.TB_NbCartesRéussites.Name = "TB_NbCartesRéussites";
            this.TB_NbCartesRéussites.Size = new System.Drawing.Size(100, 20);
            this.TB_NbCartesRéussites.TabIndex = 14;
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(502, 530);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_NbCartesRéussites);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_CarteTotale);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LB_CartesJ2);
            this.Controls.Add(this.LB_CartesJ1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_Probabilité);
            this.Controls.Add(this.TB_Probabilité);
            this.Controls.Add(this.BTN_Passer);
            this.Controls.Add(this.LB_J2);
            this.Controls.Add(this.LB_J1);
            this.Controls.Add(this.LB_Score2);
            this.Controls.Add(this.LB_Score1);
            this.Controls.Add(this.PB_Paquet);
            this.Name = "Jeu";
            this.Text = "Jeu";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Paquet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Paquet;
        private System.Windows.Forms.Label LB_Score1;
        private System.Windows.Forms.Label LB_Score2;
        private System.Windows.Forms.Label LB_J1;
        private System.Windows.Forms.Label LB_J2;
        private System.Windows.Forms.Button BTN_Passer;
        private System.Windows.Forms.TextBox TB_Probabilité;
        private System.Windows.Forms.Label LB_Probabilité;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LB_CartesJ1;
        private System.Windows.Forms.ListBox LB_CartesJ2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_CarteTotale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_NbCartesRéussites;
    }
}