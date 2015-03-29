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
    public partial class Form_Menu : Form
    {
        // Attributs pour la difficulté des ordinateurs (S'il y a lieu)
        public static string Difficulté1 = "";
        public static string Difficulté2 = "";
        public static bool Compte1;
        public static bool Compte2;

        /// <summary>
        /// Constructeur
        /// </summary>
        public Form_Menu()
        {
            InitializeComponent();
            Paquet paquet = new Paquet();
            CB_Joueur1.SelectedItem = "Humain";
            CB_Joueur2.SelectedItem = "Humain";
        }

        /// <summary>
        /// BTN_CommencerPartie_Click
        /// Permet de commencer une nouvelle partie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CommencerPartie_Click(object sender, EventArgs e)
        {
            // rechercher les difficultés des ordinateurs (S'il y a lieu)
            RechercherDifficulte(1);
            RechercherDifficulte(2);

            // S'il manque des informations
            if (Difficulté1 == "Erreur")
                MessageBox.Show("Erreur, veuillez entrer une difficulté pour le joueur 1!");
            else if (Difficulté2 == "Erreur")
                MessageBox.Show("Erreur, veuillez entrer une difficulté pour le joueur 2!");
            else // Commencer la partie
            {
                Jeu jeu = new Jeu();
                jeu.ShowDialog();
            }
        }

        /// <summary>
        /// CB_Joueur1_SelectedIndexChanged
        /// Si l'utilisateur change le mode du joueur 1 
        /// (Ordinateur ou joueur)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CB_Joueur1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si c'est un ordinateur
            if (CB_Joueur1.SelectedItem.ToString() == "Ordinateur")
            {
                GB_Ordinateur1.Enabled = true;
                CB_Compte1.Enabled = true;
                RechercherDifficulte(1);
            }
            else
            {
                GB_Ordinateur1.Enabled = false;
                CB_Compte1.Enabled = false;
                Difficulté1 = "";
            }
        }

        /// <summary>
        /// CB_Joueur2_SelectedIndexChanged
        /// Si l'utilisateur change le mode du joueur 2
        /// (Ordinateur ou joueur)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CB_Joueur2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si c'est un ordinateur
            if (CB_Joueur2.SelectedItem.ToString() == "Ordinateur")
            {
                GB_Ordinateur2.Enabled = true;
                CB_Compte2.Enabled = true;
                RechercherDifficulte(2);
            }
            else
            {
                GB_Ordinateur2.Enabled = false;
                CB_Compte2.Enabled = false;
                Difficulté2 = "";
            }
        }

        /// <summary>
        /// RechercerDifficulté
        /// Regarder quelle difficulté ont les ordinateurs
        /// </summary>
        /// <param name="Joueur"></param>
        private void RechercherDifficulte(int Joueur)
        {
            // Si le joueur 1 est un ordinateur
            if(Joueur == 1 && CB_Joueur1.SelectedItem.ToString() == "Ordinateur")
            {
                // Regarder s'il est Courageux, moyen ou prudent
                if (RB_Courageux1.Checked)
                    Difficulté1 = RB_Courageux1.Text;
                else if (RB_Moyen1.Checked)
                    Difficulté1 = RB_Moyen1.Text;
                else if (RB_Prudent1.Checked)
                    Difficulté1 = RB_Prudent1.Text;
                else // S'Il n'a pas de difficulté choisi
                    Difficulté1 = "Erreur";

                // Si l'ordinateur compte les cartes
                if (CB_Compte1.Checked)
                    Compte1 = true;
                else
                    Compte1 = false;
            }
                // Si le joueur 2 est un ordinateur
            else if (Joueur == 2 && CB_Joueur2.SelectedItem.ToString() == "Ordinateur")
            {
                // regarder s'il est Courageux, moyen ou prudent
                if (RB_Courageux2.Checked)
                    Difficulté2 = RB_Courageux1.Text;
                else if (RB_Moyen2.Checked)
                    Difficulté2 = RB_Moyen1.Text;
                else if (RB_Prudent2.Checked)
                    Difficulté2 = RB_Prudent1.Text;
                else // S'il n'a pas de difficulté
                    Difficulté2 = "Erreur";

                // Si l'ordinateur compte les cartes
                if (CB_Compte2.Checked)
                    Compte2 = true;
                else
                    Compte2 = false;
            }
        }
    }
}
