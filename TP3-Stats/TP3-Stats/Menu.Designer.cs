namespace TP3_Stats
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_CommencerPartie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_CommencerPartie
            // 
            this.BTN_CommencerPartie.Location = new System.Drawing.Point(198, 282);
            this.BTN_CommencerPartie.Name = "BTN_CommencerPartie";
            this.BTN_CommencerPartie.Size = new System.Drawing.Size(133, 23);
            this.BTN_CommencerPartie.TabIndex = 0;
            this.BTN_CommencerPartie.Text = "Commencer la partie...";
            this.BTN_CommencerPartie.UseVisualStyleBackColor = true;
            this.BTN_CommencerPartie.Click += new System.EventHandler(this.BTN_CommencerPartie_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 317);
            this.Controls.Add(this.BTN_CommencerPartie);
            this.Name = "Menu";
            this.Text = "Menu Principal...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_CommencerPartie;
    }
}

