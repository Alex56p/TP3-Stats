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
            this.PB_J1 = new System.Windows.Forms.PictureBox();
            this.LB_Score1 = new System.Windows.Forms.Label();
            this.LB_Score2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_J1)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_J1
            // 
            this.PB_J1.Image = global::TP3_Stats.Properties.Resources.Dos_Carte_J1;
            this.PB_J1.Location = new System.Drawing.Point(395, 430);
            this.PB_J1.Name = "PB_J1";
            this.PB_J1.Size = new System.Drawing.Size(211, 314);
            this.PB_J1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_J1.TabIndex = 0;
            this.PB_J1.TabStop = false;
            this.PB_J1.Click += new System.EventHandler(this.PB_J1_Click);
            // 
            // LB_Score1
            // 
            this.LB_Score1.AutoSize = true;
            this.LB_Score1.Location = new System.Drawing.Point(341, 113);
            this.LB_Score1.Name = "LB_Score1";
            this.LB_Score1.Size = new System.Drawing.Size(13, 13);
            this.LB_Score1.TabIndex = 1;
            this.LB_Score1.Text = "0";
            // 
            // LB_Score2
            // 
            this.LB_Score2.AutoSize = true;
            this.LB_Score2.Location = new System.Drawing.Point(593, 113);
            this.LB_Score2.Name = "LB_Score2";
            this.LB_Score2.Size = new System.Drawing.Size(13, 13);
            this.LB_Score2.TabIndex = 2;
            this.LB_Score2.Text = "0";
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1060, 806);
            this.Controls.Add(this.LB_Score2);
            this.Controls.Add(this.LB_Score1);
            this.Controls.Add(this.PB_J1);
            this.Name = "Jeu";
            this.Text = "Jeu";
            ((System.ComponentModel.ISupportInitialize)(this.PB_J1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_J1;
        private System.Windows.Forms.Label LB_Score1;
        private System.Windows.Forms.Label LB_Score2;
    }
}