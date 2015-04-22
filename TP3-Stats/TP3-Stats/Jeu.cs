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
        /// <summary>
        /// Variables
        /// </summary>
        #region Variables
        Paquet paquet = new Paquet(true);

        int Tour = 1;

        bool J1_Fini = false;
        bool J2_Fini = false;
        #endregion

        /// <summary>
        /// Constructeur
        /// </summary>
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
            // Regarder c'est quel joueur qui est en train de jouer
            if(Tour == 1)
            {
                if (Form_Menu.Difficulté1 == "" || 21 - int.Parse(LB_Score1.Text) > 10)     // Si ce n'est pas un ordinateur  
                    PigerCarte();                               
                else if (Form_Menu.Difficulté1 == "Courageux")                              // Si c'est un courageux
                    PigerCourageux();
                else if (Form_Menu.Difficulté1 == "Moyen")                                  // Si c'est un moyen
                    PigerMoyen();       
                else if (Form_Menu.Difficulté1 == "Prudent")                                // Si c'est un Prudent
                    PigerPrudent();
            }
            else
            {
                if (Form_Menu.Difficulté2 == "" || 21 - int.Parse(LB_Score2.Text) > 10)     // Si ce n'est pas un ordinateur  
                    PigerCarte();
                else if (Form_Menu.Difficulté2 == "Courageux")                              // Si c'est un courageux
                    PigerCourageux();
                else if (Form_Menu.Difficulté2 == "Moyen")                                  // Si c'est un moyen
                    PigerMoyen();
                else if (Form_Menu.Difficulté2 == "Prudent")                                // Si c'est un Prudent
                    PigerPrudent();
            }
        }

        /// <summary>
        /// ChangerTour
        /// Permet de changer le tour du joueur 1 au 2 et vis versa
        /// </summary>
        private void ChangerTour()
        {
            if (Tour == 1 && !J2_Fini)      // Si c'est au tour du joueur 1
            {
                Tour = 2;
                LB_J1.BackColor = System.Drawing.Color.Transparent;
                LB_J2.BackColor = System.Drawing.Color.AntiqueWhite;
            }
            else if(Tour == 2 && !J1_Fini)  // Si c'est le tour du joueur 2
            {
                Tour = 1;
                LB_J1.BackColor = System.Drawing.Color.AntiqueWhite;
                LB_J2.BackColor = System.Drawing.Color.Transparent;
            }
        }
        
        /// <summary>
        /// VérifierVictoire
        /// Permet de retourner si un joueur à gagné ou non
        /// </summary>
        private void VérifierVictoire()
        {
            // Si les 2 joueurs ont 21
            if (int.Parse(LB_Score1.Text) == 21 && int.Parse(LB_Score2.Text) == 21)
            {
                MessageBox.Show("Match nul!");
                this.Close();
            }
            else  // Si un des 2 joueurs a 21 points
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
            // Si le joueur 1 est au dessus de 21
            if (int.Parse(LB_Score1.Text) > 21)
            {
                MessageBox.Show("Victoire du joueur 2!");
                this.Close();
            }
            else if (int.Parse(LB_Score2.Text) > 21) // Si le joueurs 2 est au dessus de 21 points
            {
                MessageBox.Show("Victoire du joueur 1!");
                this.Close();
            }
            else if (J1_Fini && J2_Fini)    // Si les 2 joueurs décident de passer
            {
                // Si le joueur a un plus grand score que l'autre
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
                else // Si les 2 joueurs ont le même score
                {
                    MessageBox.Show("Partie nulle!");
                    this.Close();
                }
            }

            // Afficher si les joueurs passent
            if(J1_Fini)
                LB_CartesJ1.Items.Add("Passé");
            if(J2_Fini)
                LB_CartesJ2.Items.Add("Passé");
        }

        /// <summary>
        /// BTN_Passer_Click
        /// Permet d'arrêter de jouer quand le joueur décide 
        /// qu'il ne prend pas de chance d'aller au dessus de 21
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Passer_Click(object sender, EventArgs e)
        {
            // regarder c'est quel joueur
            if (Tour == 1)
            {
                J1_Fini = true;
            }
            else
            {
                J2_Fini = true;
            }

            // Si les 2 joueurs passent
            // Vérifier qui a gagné
            if (J1_Fini && J2_Fini)
                VérifierVictoire();

            // Changer le tour
            ChangerTour();
        }

        /// <summary>
        /// PigerCarte
        /// Permet de piger une carte au hasard dans les cartes restantes
        /// </summary>
        private void PigerCarte()
        {
            // Carte au hasard
            Carte carte = paquet.PigerCarte();

            // Afficher la carte
            PB_Paquet.Image = carte.Image_;

            // Vérifier c'est qui qui joue
            if (Tour == 1)
            {
                if(carte.Valeur_ == 1)
                {
                    // Regarder si c'est un ordinateur
                    if (Form_Menu.Difficulté1 == "")    // Joueur
                    {
                        // Choisir la valeur de l'As
                        ChoisirValeurAs Choisir = new ChoisirValeurAs();
                        Choisir.ShowDialog();
                        carte.Valeur_ = Choisir.Valeur;
                    }
                    else                                // Ordinateur
                    {
                        // Regarder si l'ordinateur prend quelle valeur s'il pige un As
                        if (int.Parse(LB_Score1.Text) + 11 <= 21)
                            carte.Valeur_ = 11;
                        else
                            carte.Valeur_ = 1;
                    }
                }
                
                // Afficher le résultat
                LB_Score1.Text = (int.Parse(LB_Score1.Text) + carte.Valeur_).ToString();
                LB_CartesJ1.Items.Add(carte.Description_);
            }
            else // Joueur 2
            {
                if (carte.Valeur_ == 1)
                {
                    // Regarder si c'est un ordinateur
                    if (Form_Menu.Difficulté1 == "")    // Joueur
                    {
                        // Choisir la valeur de l'As
                        ChoisirValeurAs Choisir = new ChoisirValeurAs();
                        Choisir.ShowDialog();
                        carte.Valeur_ = Choisir.Valeur;
                    }
                    else                                // Ordinateur
                    {
                        // Choisir la valeur de l'As
                        if (int.Parse(LB_Score1.Text) + 11 <= 21)
                            carte.Valeur_ = 11;
                        else
                            carte.Valeur_ = 1;
                    }
                }

                // Afficher le résultat
                LB_Score2.Text = (int.Parse(LB_Score2.Text) + carte.Valeur_).ToString();
                LB_CartesJ2.Items.Add(carte.Description_);
            }

            // Vérifier si un joueur a gagné
            VérifierVictoire();
            // Changer de tour
            ChangerTour();
        }
        #endregion

        /// <summary>
        /// Ordinateurs
        /// Regroupement des AI
        /// </summary>
        #region Ordinateurs

        /// <summary>
        /// PigerCourageux
        /// Intelligence de l'ordinateur Courageux
        /// </summary>
        private void PigerCourageux()
        {
            // Si c'est le joueur 1
            if(Tour == 1)
            {
                // Si l'ordinateur 1 compte les cartes
                if (Form_Menu.Compte1)
                {
                    // Regarder si les probabilités sont au dessus de 50%
                    if (CalculerProbabiliteCompte() >= 0.42f || (int.Parse(LB_Score2.Text) > int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        // Passer
                        MessageBox.Show("Le joueur 1 passe.");
                        J1_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
                else // Si l'ordinateur ne compte pas les cartes
                {
                    // Calculer si la probabilité est au dessus de 50%
                    if (CalculerProbabiliteSansCompte() >= 0.42f || (int.Parse(LB_Score2.Text) > int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        // Passer
                        MessageBox.Show("Le joueur 1 passe.");
                        J1_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
            }
            else if (Tour == 2) // Si c'est au tour de joueur 2
            {
                // Regarder si l'ordinateur compte les cartes
                if (Form_Menu.Compte2)
                {
                    // Calculer si la probabilité est au dessus de 50%
                    if (CalculerProbabiliteCompte() >= 0.42f || (int.Parse(LB_Score2.Text) < int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        // Passer
                        MessageBox.Show("Le joueur 2 passe.");
                        J2_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
                else
                {
                    // Calculer si la probabilité est au dessus de 50%
                    if (CalculerProbabiliteSansCompte() >= 0.42f || (int.Parse(LB_Score2.Text) < int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        // Passer
                        MessageBox.Show("Le joueur 2 passe.");
                        J2_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
            }
        }

        /// <summary>
        /// PigerMoyen
        /// Intelligence de l'ordinateur Moyen
        /// </summary>
        private void PigerMoyen()
        {
            // Si c'est au tour du joueur 1
            if (Tour == 1)
            {
                // Regarder si l'ordinateur compte les cartes
                if (Form_Menu.Compte1)
                {
                    // Calculer si la probabilité est au dessus de 65%
                    if (CalculerProbabiliteCompte() >= 0.65f || ( int.Parse(LB_Score2.Text) > int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        // Passer
                        MessageBox.Show("Le joueur 1 passe.");
                        J1_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
                else // Si l'ordinateur ne compte pas les cartes
                {
                    // Calculer si la probabilité est au dessus de 65%
                    if (CalculerProbabiliteSansCompte() >= 0.65f || (int.Parse(LB_Score2.Text) > int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        // Passer
                        MessageBox.Show("Le joueur 1 passe.");
                        J1_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
            }
            else if (Tour == 2) // Si c'est au tour du joueur 2
            {
                // Regarder si l'ordinateur compte les cartes
                if (Form_Menu.Compte2)
                {
                    // Calculer si la probabilité est au dessus de 65%
                    if (CalculerProbabiliteCompte() >= 0.65f || (int.Parse(LB_Score2.Text) < int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        // Passer
                        MessageBox.Show("Le joueur 2 passe.");
                        J2_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
                else // Si c'est au tour du joueur 2
                {
                    // Calculer si la probabilité est au dessus de 65%
                    if (CalculerProbabiliteSansCompte() >= 0.65f || ( int.Parse(LB_Score2.Text) < int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        // Passer
                        MessageBox.Show("Le joueur 2 passe.");
                        J2_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
            }
        }

        /// <summary>
        /// PigerPrudent
        /// Intelligence de l'ordinateur Prudent
        /// </summary>
        private void PigerPrudent()
        {
            // Si c'est au tour du joueur 1
            if (Tour == 1)
            {
                // Regarder si l'ordinateur compte les cartes
                if (Form_Menu.Compte1)
                {
                    // Calculer si la probabilité est au dessus de 80%
                    if (CalculerProbabiliteCompte() >= 0.8f || (int.Parse(LB_Score2.Text) > int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        // Passer
                        MessageBox.Show("Le joueur 1 passe.");
                        J1_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
                else
                {
                    // Calculer si la probabilité est au dessus de 80%
                    if (CalculerProbabiliteSansCompte() >= 0.8f || (int.Parse(LB_Score2.Text) > int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        // Passer
                        MessageBox.Show("Le joueur 1 passe.");
                        J1_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
            }
            else if (Tour == 2) // Si c'est au tour du joueur 2
            {
                // Regarder si l'ordinateur compte les cartes
                if (Form_Menu.Compte2)
                {
                    // Calculer si la probabilité est au dessus de 80%
                    if (CalculerProbabiliteCompte() >= 0.8f || (int.Parse(LB_Score2.Text) < int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        // Passer
                        MessageBox.Show("Le joueur 2 passe.");
                        J2_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
                else // Si c'est au tour du joueur 2
                {
                    // Calculer si la probabilité est au dessus de 80%
                    if (CalculerProbabiliteSansCompte() >= 0.8f || (int.Parse(LB_Score2.Text) < int.Parse(LB_Score1.Text)))
                        PigerCarte();
                    else
                    {
                        // Passer
                        MessageBox.Show("Le joueur 2 passe.");
                        J2_Fini = true;
                        VérifierVictoire();
                        ChangerTour();
                    }
                }
            }
        }

        /// <summary>
        /// CalculerProbabilitéCompte
        /// </summary>
        /// <returns></returns>
        private float CalculerProbabiliteCompte()
        {
            // Création d'un paquet avec les cartes restantes
            Paquet paquetRestant = CréerPaquetRestant();

            // Nombre de cartes qui permet d'avoir un score au dessous de 21
            float NbCartesBonnes = 0;

            // Si c'est le tour du joueur 1
            if(Tour == 1)
            {
                // Regarder combien de cartes sont bonnes
                NbCartesBonnes = paquetRestant.GetNbCartesBonnes(int.Parse(LB_Score1.Text));
            }
            else // Si c'est au tour du joueur 2
            {
                // regarder combien de cartes sont bonnes
                NbCartesBonnes = paquetRestant.GetNbCartesBonnes(int.Parse(LB_Score2.Text));
            }

            // Afficher les résultats
            TB_NbCartesRéussites.Text = NbCartesBonnes.ToString();
            TB_CarteTotale.Text = paquetRestant.Paquet_.Count.ToString();

            // Calculer la probabilité
            float prob = NbCartesBonnes / paquetRestant.Paquet_.Count;
            // Afficher et retourner la probabilité
            TB_Probabilité.Text = prob.ToString();
            return prob;
        }

        /// <summary>
        /// CalculerProbabilitéSansCompte
        /// Permet de calculer la probabilité sans le comptage de cartes
        /// </summary>
        /// <returns></returns>
        private float CalculerProbabiliteSansCompte()
        {
            // Nombre de cartes qui permet d'avoir un score au dessous de 21
            float NbCartesBonnes = 0;

            // Si c'est au tour du joueur 1
            if (Tour == 1)
            {
                // Calculer le nombre de bonne cartes
                NbCartesBonnes = paquet.GetNbCartesBonnes(int.Parse(LB_Score1.Text));
            }
            else // Si c'est au tour du joueur 2
            {
                // Calculer le nombre de bonne cartes
                NbCartesBonnes = paquet.GetNbCartesBonnes(int.Parse(LB_Score2.Text));
            }
            
            // Afficher les résultats
            TB_NbCartesRéussites.Text = NbCartesBonnes.ToString();
            TB_CarteTotale.Text = paquet.Paquet_.Count.ToString();
            
            // Calculer la probabilité
            float prob = NbCartesBonnes / paquet.Paquet_.Count;

            // Afficher et retourner le résultat
            TB_Probabilité.Text = prob.ToString();
            return prob;
        }

        /// <summary>
        /// CréerPaquetRestant
        /// Permet de créer un paquet avec toutes les cartes qui ne sont pas utilisées
        /// </summary>
        /// <returns></returns>
        private Paquet CréerPaquetRestant()
        {
            // Création du paquet
            Paquet paquetRestant = new Paquet();

            // Mettre les cartes pas utilisés dans le paquet
            for(int i = 0; i < paquet.Paquet_.Count; i++)
            {
                if (paquet.Paquet_[i].Utilisée_ == false)
                    paquetRestant.Paquet_.Add(paquet.Paquet_[i]);
            }

            // Retourner le paquet
            return paquetRestant;
        }
        #endregion

        /// <summary>
        /// button1_Click
        /// Permet de quitter la partie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
