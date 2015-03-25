using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_Stats
{
    public partial class Jeu : Form
    {
        Paquet paquet = new Paquet();

        int Tour = 1;

        bool J1_Fini = false;
        bool J2_Fini = false;

        public Jeu()
        {
            InitializeComponent();
            LB_J1.BackColor = System.Drawing.Color.AntiqueWhite;
        }

        /// <summary>
        /// Jeu
        /// Regrouppement de tous les éléments du jeu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Jeu
        private void PB_Paquet_Click(object sender, EventArgs e)
        {
            if (Tour == 1 && Form_Menu.Difficulté1 == "")
                PigerCarte();
            else if (Form_Menu.Difficulté2 == "")
                PigerCarte();
        }

        private void ChangerTour()
        {
            if (Tour == 1)
            {
                if(!J2_Fini)
                {
                    Tour = 2;
                    LB_J1.BackColor = System.Drawing.Color.Transparent;
                    LB_J2.BackColor = System.Drawing.Color.AntiqueWhite;

                    if (Form_Menu.Difficulté1 == "Courageux")
                        PigerCourageux();
                    else if (Form_Menu.Difficulté1 == "Moyen")
                        PigerMoyen();
                    else if (Form_Menu.Difficulté1 == "Prudent")
                        PigerPrudent();
                }
            }
            else if(Tour == 2 && !J1_Fini)
            {
                if(!J1_Fini)
                {
                    Tour = 1;
                    LB_J1.BackColor = System.Drawing.Color.AntiqueWhite;
                    LB_J2.BackColor = System.Drawing.Color.Transparent;

                    if (Form_Menu.Difficulté2 == "Courageux")
                        PigerCourageux();
                    else if (Form_Menu.Difficulté2 == "Moyen")
                        PigerMoyen();
                    else if (Form_Menu.Difficulté2 == "Prudent")
                        PigerPrudent();
                }
            }
        }
        
        private void VérifierVictoire()
        {
            if (int.Parse(LB_Score1.Text) == 21 && int.Parse(LB_Score2.Text) == 21)
            {
                MessageBox.Show("Match nul!");
                this.Close();
            }
            else
            {
                if (int.Parse(LB_Score1.Text) == 21)
                {
                    if(Tour == 2)
                    {
                       MessageBox.Show("Victoire du joueur 1!");
                       this.Close();
                    }
                }
                if (int.Parse(LB_Score2.Text) == 21)
                {
                       MessageBox.Show("Victoire du joueur 2!");
                       this.Close();
                }
            }
            
            if (int.Parse(LB_Score1.Text) > 21)
            {
                MessageBox.Show("Victoire du joueur 2!");
                this.Close();
            }
            else if (int.Parse(LB_Score2.Text) > 21)
            {
                MessageBox.Show("Victoire du joueur 1!");
                this.Close();
            }
            else if (J1_Fini && J2_Fini)
            {
                if(int.Parse(LB_Score1.Text) > int.Parse(LB_Score2.Text))
                {
                    MessageBox.Show("Victoire du joueur 1!");
                    this.Close();
                }
                else if (int.Parse(LB_Score1.Text) < int.Parse(LB_Score2.Text))
                {
                    MessageBox.Show("Victoire du joueur 2!");
                    this.Close();
                }
            }
        }

        private void BTN_Passer_Click(object sender, EventArgs e)
        {
            if (Tour == 1)
                J1_Fini = true;
            else
                J2_Fini = true;
            if (J1_Fini && J2_Fini)
                VérifierVictoire();
            ChangerTour();
        }

        private void PigerCarte()
        {
            // Carte au hasard
            Carte carte = paquet.PigerCarte();

            PB_Paquet.Image = carte.Image_;

            if (Tour == 1)
                LB_Score1.Text = (int.Parse(LB_Score1.Text) + carte.Valeur_).ToString();
            else
                LB_Score2.Text = (int.Parse(LB_Score2.Text) + carte.Valeur_).ToString();

            VérifierVictoire();
            ChangerTour();
        }
        #endregion

        /// <summary>
        /// Ordinateurs
        /// Regroupement des AI
        /// </summary>
        #region Ordinateurs
        private void PigerCourageux()
        {
            // TEMPORAIRE
            MessageBox.Show("Courageux");
            PigerCarte();
        }

        private void PigerMoyen()
        {
            // TEMPORAIRE
            MessageBox.Show("Moyen");
            PigerCarte();
        }

        private void PigerPrudent()
        {
            // TEMPORAIRE
            MessageBox.Show("Prudent");
            PigerCarte();
        }
        #endregion
    }
}
