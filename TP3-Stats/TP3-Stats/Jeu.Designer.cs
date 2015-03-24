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
            ((System.ComponentModel.ISupportInitialize)(this.PB_Paquet)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Paquet
            // 
            this.PB_Paquet.Image = global::TP3_Stats.Properties.Resources.Dos_Carte_J1;
            this.PB_Paquet.Location = new System.Drawing.Point(140, 214);
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
            this.LB_Score1.Location = new System.Drawing.Point(194, 104);
            this.LB_Score1.Name = "LB_Score1";
            this.LB_Score1.Size = new System.Drawing.Size(24, 25);
            this.LB_Score1.TabIndex = 1;
            this.LB_Score1.Text = "0";
            // 
            // LB_Score2
            // 
            this.LB_Score2.AutoSize = true;
            this.LB_Score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Score2.Location = new System.Drawing.Point(327, 104);
            this.LB_Score2.Name = "LB_Score2";
            this.LB_Score2.Size = new System.Drawing.Size(24, 25);
            this.LB_Score2.TabIndex = 2;
            this.LB_Score2.Text = "0";
            // 
            // LB_J1
            // 
            this.LB_J1.AutoSize = true;
            this.LB_J1.Location = new System.Drawing.Point(137, 113);
            this.LB_J1.Name = "LB_J1";
            this.LB_J1.Size = new System.Drawing.Size(51, 13);
            this.LB_J1.TabIndex = 3;
            this.LB_J1.Text = "Joueur1: ";
            // 
            // LB_J2
            // 
            this.LB_J2.AutoSize = true;
            this.LB_J2.Location = new System.Drawing.Point(270, 113);
            this.LB_J2.Name = "LB_J2";
            this.LB_J2.Size = new System.Drawing.Size(51, 13);
            this.LB_J2.TabIndex = 3;
            this.LB_J2.Text = "Joueur2: ";
            // 
            // BTN_Passer
            // 
            this.BTN_Passer.Location = new System.Drawing.Point(211, 185);
            this.BTN_Passer.Name = "BTN_Passer";
            this.BTN_Passer.Size = new System.Drawing.Size(75, 23);
            this.BTN_Passer.TabIndex = 4;
            this.BTN_Passer.Text = "Passer";
            this.BTN_Passer.UseVisualStyleBackColor = true;
            this.BTN_Passer.Click += new System.EventHandler(this.BTN_Passer_Click);
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(502, 530);
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
    }
}