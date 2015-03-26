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

        public Form_Menu()
        {
            InitializeComponent();
            Paquet paquet = new Paquet();
            CB_Joueur1.SelectedItem = "Humain";
            CB_Joueur2.SelectedItem = "Humain";
        }

        private void BTN_CommencerPartie_Click(object sender, EventArgs e)
        {
            RechercherDifficulte(1);
            RechercherDifficulte(2);

            if (Difficulté1 == "Erreur")
                MessageBox.Show("Erreur, veuillez entrer une difficulté pour le joueur 1!");
            else if (Difficulté2 == "Erreur")
                MessageBox.Show("Erreur, veuillez entrer une difficulté pour le joueur 2!");
            else
            {
                Jeu jeu = new Jeu();
                jeu.ShowDialog();
            }
        }

        private void CB_Joueur1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        private void CB_Joueur2_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void RechercherDifficulte(int Joueur)
        {
            if(Joueur == 1 && CB_Joueur1.SelectedItem.ToString() == "Ordinateur")
            {
                if (RB_Courageux1.Checked)
                    Difficulté1 = RB_Courageux1.Text;
                else if (RB_Moyen1.Checked)
                    Difficulté1 = RB_Moyen1.Text;
                else if (RB_Prudent1.Checked)
                    Difficulté1 = RB_Prudent1.Text;
                else
                    Difficulté1 = "Erreur";

                if (CB_Compte1.Checked)
                    Compte1 = true;
                else
                    Compte1 = false;
            }
            else if (Joueur == 2 && CB_Joueur2.SelectedItem.ToString() == "Ordinateur")
            {
                if (RB_Courageux2.Checked)
                    Difficulté2 = RB_Courageux1.Text;
                else if (RB_Moyen2.Checked)
                    Difficulté2 = RB_Moyen1.Text;
                else if (RB_Prudent2.Checked)
                    Difficulté2 = RB_Prudent1.Text;
                else
                    Difficulté2 = "Erreur";

                if (CB_Compte2.Checked)
                    Compte2 = true;
                else
                    Compte2 = false;
            }
        }
    }
}
