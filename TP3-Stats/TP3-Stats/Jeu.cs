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
        Paquet paquet = new Paquet(true);

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
            if(Tour == 1)
            {
                if (Form_Menu.Difficulté1 == "" || 21 - int.Parse(LB_Score1.Text) > 10)
                    PigerCarte();
                else if (Form_Menu.Difficulté1 == "Courageux")
                    PigerCourageux();
                else if (Form_Menu.Difficulté1 == "Moyen")
                    PigerMoyen();
                else if (Form_Menu.Difficulté1 == "Prudent")
                    PigerPrudent();
            }
            else
            {
                if (Form_Menu.Difficulté2 == "" || 21 - int.Parse(LB_Score2.Text) > 10)
                    PigerCarte();
                else if (Form_Menu.Difficulté2 == "Courageux")
                    PigerCourageux();
                else if (Form_Menu.Difficulté2 == "Moyen")
                    PigerMoyen();
                else if (Form_Menu.Difficulté2 == "Prudent")
                    PigerPrudent();
            }
        }

        private void ChangerTour()
        {
            if (Tour == 1 && !J2_Fini)
            {
                Tour = 2;
                LB_J1.BackColor = System.Drawing.Color.Transparent;
                LB_J2.BackColor = System.Drawing.Color.AntiqueWhite;
            }
            else if(Tour == 2 && !J1_Fini)
            {
                Tour = 1;
                LB_J1.BackColor = System.Drawing.Color.AntiqueWhite;
                LB_J2.BackColor = System.Drawing.Color.Transparent;
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
                if (int.Parse(LB_Score1.Text) == 21 )
                {
                    J1_Fini = true;
                }
                if (int.Parse(LB_Score2.Text) == 21)
                {
                    J2_Fini = true;
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
                else
                {
                    MessageBox.Show("Partie nulle!");
                    this.Close();
                }
            }

            if(J1_Fini)
                LB_CartesJ1.Items.Add("Passé");
            if(J2_Fini)
                LB_CartesJ2.Items.Add("Passé");
        }

        private void BTN_Passer_Click(object sender, EventArgs e)
        {
            if (Tour == 1)
            {
                J1_Fini = true;
            }
            else
            {
                J2_Fini = true;
            }
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
            {
                if(carte.Valeur_ == 1)
                {
                    if (Form_Menu.Difficulté1 == "")
                    {
                        ChoisirValeurAs Choisir = new ChoisirValeurAs();
                        Choisir.ShowDialog();
                        carte.Valeur_ = Choisir.Valeur;
                    }
                    else
                    {
                        if (LB_Score1.Text == "10")
                            carte.Valeur_ = 11;
                    }
                }
                

                LB_Score1.Text = (int.Parse(LB_Score1.Text) + carte.Valeur_).ToString();
                LB_CartesJ1.Items.Add(carte.Description_);
            }
            else 
            {
                if (carte.Valeur_ == 1)
                {
                    if (Form_Menu.Difficulté1 == "")
                    {
                        ChoisirValeurAs Choisir = new ChoisirValeurAs();
                        Choisir.ShowDialog();
                        carte.Valeur_ = Choisir.Valeur;
                    }
                    else
                    {
                        if (LB_Score2.Text == "10")
                            carte.Valeur_ = 11;
                    }
                }
                LB_Score2.Text = (int.Parse(LB_Score2.Text) + carte.Valeur_).ToString();
                LB_CartesJ2.Items.Add(carte.Description_);
            }

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
            if(Tour == 1)
            {
                if (Form_Menu.Compte1)
                {
                    if (CalculerProbabiliteCompte() >= 0.5f || (int.Parse(LB_Score2.Text) > int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        MessageBox.Show("Le joueur 1 passe.");
                        J1_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
                else
                {
                    if (CalculerProbabiliteSansCompte() >= 0.5f || (int.Parse(LB_Score2.Text) > int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        MessageBox.Show("Le joueur 1 passe.");
                        J1_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
            }
            else if (Tour == 2)
            {
                if (Form_Menu.Compte2)
                {
                    if (CalculerProbabiliteCompte() >= 0.5f || (int.Parse(LB_Score2.Text) < int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        MessageBox.Show("Le joueur 2 passe.");
                        J2_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
                else
                {
                    if (CalculerProbabiliteSansCompte() >= 0.5f || (int.Parse(LB_Score2.Text) < int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        MessageBox.Show("Le joueur 2 passe.");
                        J2_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
            }
        }

        private void PigerMoyen()
        {
            if (Tour == 1)
            {
                if (Form_Menu.Compte1)
                {
                    if (CalculerProbabiliteCompte() >= 0.65f || ( int.Parse(LB_Score2.Text) > int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        MessageBox.Show("Le joueur 1 passe.");
                        J1_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
                else
                {
                    if (CalculerProbabiliteSansCompte() >= 0.65f || (int.Parse(LB_Score2.Text) > int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        MessageBox.Show("Le joueur 1 passe.");
                        J1_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
            }
            else if (Tour == 2)
            {
                if (Form_Menu.Compte2)
                {
                    if (CalculerProbabiliteCompte() >= 0.65f || (int.Parse(LB_Score2.Text) < int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        MessageBox.Show("Le joueur 2 passe.");
                        J2_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
                else
                {
                    if (CalculerProbabiliteSansCompte() >= 0.65f || ( int.Parse(LB_Score2.Text) < int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        MessageBox.Show("Le joueur 2 passe.");
                        J2_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
            }
        }

        private void PigerPrudent()
        {
            if (Tour == 1)
            {
                if (Form_Menu.Compte1)
                {
                    if (CalculerProbabiliteCompte() >= 0.8f || (int.Parse(LB_Score2.Text) > int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        MessageBox.Show("Le joueur 1 passe.");
                        J1_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
                else
                {
                    if (CalculerProbabiliteSansCompte() >= 0.8f || (int.Parse(LB_Score2.Text) > int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        MessageBox.Show("Le joueur 1 passe.");
                        J1_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
            }
            else if (Tour == 2)
            {
                if (Form_Menu.Compte2)
                {
                    if (CalculerProbabiliteCompte() >= 0.8f || (int.Parse(LB_Score2.Text) < int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        MessageBox.Show("Le joueur 2 passe.");
                        J2_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
                else
                {
                    if (CalculerProbabiliteSansCompte() >= 0.8f || (int.Parse(LB_Score2.Text) < int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        MessageBox.Show("Le joueur 2 passe.");
                        J2_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
            }
        }

        private float CalculerProbabiliteCompte()
        {
            Paquet paquetRestant = CréerPaquetRestant();

            float NbCartesBonnes = 0;
            if(Tour == 1)
            {
                NbCartesBonnes = paquetRestant.GetNbCartesBonnes(int.Parse(LB_Score1.Text));
            }
            else
            {
                NbCartesBonnes = paquetRestant.GetNbCartesBonnes(int.Parse(LB_Score2.Text));
            }

            TB_NbCartesRéussites.Text = NbCartesBonnes.ToString();
            TB_CarteTotale.Text = paquetRestant.Paquet_.Count.ToString();
            float prob = NbCartesBonnes / paquetRestant.Paquet_.Count;
            TB_Probabilité.Text = prob.ToString();
            return prob;
        }

        private float CalculerProbabiliteSansCompte()
        {
            float NbCartesBonnes = 0;
            if (Tour == 1)
            {
                NbCartesBonnes = paquet.GetNbCartesBonnes(int.Parse(LB_Score1.Text));
            }
            else
            {
                NbCartesBonnes = paquet.GetNbCartesBonnes(int.Parse(LB_Score2.Text));
            }
            TB_NbCartesRéussites.Text = NbCartesBonnes.ToString();
            TB_CarteTotale.Text = paquet.Paquet_.Count.ToString();
            float prob = NbCartesBonnes / paquet.Paquet_.Count;
            TB_Probabilité.Text = prob.ToString();
            return prob;
        }

        private Paquet CréerPaquetRestant()
        {
            Paquet paquetRestant = new Paquet();
            for(int i = 0; i < paquet.Paquet_.Count; i++)
            {
                if (paquet.Paquet_[i].Utilisée_ == false)
                    paquetRestant.Paquet_.Add(paquet.Paquet_[i]);
            }
            return paquetRestant;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
