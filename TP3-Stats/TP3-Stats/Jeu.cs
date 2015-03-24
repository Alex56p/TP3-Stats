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

        public Jeu()
        {
            InitializeComponent();
        }

        private void PB_J1_Click(object sender, EventArgs e)
        {
           // Carte au hasard
            Carte carte = paquet.PigerCarte();

            PB_J1.Image = carte.Image_;

            if(Tour == 1)
                LB_Score1.Text = (int.Parse(LB_Score1.Text) + carte.Valeur_).ToString();
            else
                LB_Score2.Text = (int.Parse(LB_Score2.Text) + carte.Valeur_).ToString();

            ChangerTour();
            VérifierVictoire();
        }

        private void ChangerTour()
        {
            if (Tour == 1)
                Tour = 2;
            else
                Tour = 1;
        }
        
        private void VérifierVictoire()
        {
            if (int.Parse(LB_Score1.Text) > 21)
                MessageBox.Show("Victoire du joueur 2!");
            else if (int.Parse(LB_Score1.Text) == 21)
                MessageBox.Show("Victoire du joueur 1!");
            else if (int.Parse(LB_Score2.Text) > 21)
                MessageBox.Show("Victoire du joueur 1!");
            else if (int.Parse(LB_Score2.Text) == 21)
                MessageBox.Show("Victoire du joueur 2!");
        }
    }
}
