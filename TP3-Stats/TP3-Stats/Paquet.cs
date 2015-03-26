using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TP3_Stats
{
    class Paquet
    {
        // Attributs
        public List<Carte> Paquet_ = new List<Carte>();

        /// <summary>
        /// Constructeur
        /// </summary>
        public Paquet (bool complet = false)
        {
            if(complet)
                DeclarerCartes();
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        public void DeclarerCartes()
        {
            // As
            Paquet_.Add(new Carte("As De Coeur", Properties.Resources.ace_of_hearts, 1, 11));
            Paquet_.Add(new Carte("As De Carreau", Properties.Resources.ace_of_diamonds, 1, 11));
            Paquet_.Add(new Carte("As De Trèfle", Properties.Resources.ace_of_clubs, 1, 11));
            Paquet_.Add(new Carte("As De Pique", Properties.Resources.ace_of_spades, 1, 11));

            // 2
            Paquet_.Add(new Carte("2 De Coeur", Properties.Resources._2_of_hearts, 2));
            Paquet_.Add(new Carte("2 De Carreau", Properties.Resources._2_of_diamonds, 2));
            Paquet_.Add(new Carte("2 De Trèfle", Properties.Resources._2_of_clubs, 2));
            Paquet_.Add(new Carte("2 De Pique", Properties.Resources._2_of_spades, 2));

            // 3
            Paquet_.Add(new Carte("3 De Coeur", Properties.Resources._3_of_hearts, 3));
            Paquet_.Add(new Carte("3 De Carreau", Properties.Resources._3_of_diamonds, 3));
            Paquet_.Add(new Carte("3 De Trèfle", Properties.Resources._3_of_clubs, 3));
            Paquet_.Add(new Carte("3 De Pique", Properties.Resources._3_of_spades, 3));

            // 4
            Paquet_.Add(new Carte("4 De Coeur", Properties.Resources._4_of_hearts, 4));
            Paquet_.Add(new Carte("4 De Carreau", Properties.Resources._4_of_diamonds, 4));
            Paquet_.Add(new Carte("4 De Trèfle", Properties.Resources._4_of_clubs, 4));
            Paquet_.Add(new Carte("4 De Pique", Properties.Resources._4_of_spades, 4));

            // 5
            Paquet_.Add(new Carte("5 De Coeur", Properties.Resources._5_of_hearts, 5));
            Paquet_.Add(new Carte("5 De Carreau", Properties.Resources._5_of_diamonds, 5));
            Paquet_.Add(new Carte("5 De Trèfle", Properties.Resources._5_of_clubs, 5));
            Paquet_.Add(new Carte("5 De Pique", Properties.Resources._5_of_spades, 5));

            // 6
            Paquet_.Add(new Carte("6 De Coeur", Properties.Resources._6_of_hearts, 6));
            Paquet_.Add(new Carte("6 De Carreau", Properties.Resources._6_of_diamonds, 6));
            Paquet_.Add(new Carte("6 De Trèfle", Properties.Resources._6_of_clubs, 6));
            Paquet_.Add(new Carte("6 De Pique", Properties.Resources._6_of_spades, 6));

            // 7
            Paquet_.Add(new Carte("7 De Coeur", Properties.Resources._7_of_hearts, 7));
            Paquet_.Add(new Carte("7 De Carreau", Properties.Resources._7_of_diamonds, 7));
            Paquet_.Add(new Carte("7 De Trèfle", Properties.Resources._7_of_clubs, 7));
            Paquet_.Add(new Carte("7 De Pique", Properties.Resources._7_of_spades, 7));

            // 8
            Paquet_.Add(new Carte("8 De Coeur", Properties.Resources._8_of_hearts, 8));
            Paquet_.Add(new Carte("8 De Carreau", Properties.Resources._8_of_diamonds, 8));
            Paquet_.Add(new Carte("8 De Trèfle", Properties.Resources._8_of_clubs, 8));
            Paquet_.Add(new Carte("8 De Pique", Properties.Resources._8_of_spades, 8));

            // 9
            Paquet_.Add(new Carte("9 De Coeur", Properties.Resources._9_of_hearts, 9));
            Paquet_.Add(new Carte("9 De Carreau", Properties.Resources._9_of_diamonds, 9));
            Paquet_.Add(new Carte("9 De Trèfle", Properties.Resources._9_of_clubs, 9));
            Paquet_.Add(new Carte("9 De Pique", Properties.Resources._9_of_spades, 9));

            // 10
            Paquet_.Add(new Carte("10 De Coeur", Properties.Resources._10_of_hearts, 10));
            Paquet_.Add(new Carte("10 De Carreau", Properties.Resources._10_of_diamonds, 10));
            Paquet_.Add(new Carte("10 De Trèfle", Properties.Resources._10_of_clubs, 10));
            Paquet_.Add(new Carte("10 De Pique", Properties.Resources._10_of_spades, 10));

            // Valet
            Paquet_.Add(new Carte("Valet De Coeur", Properties.Resources.jack_of_hearts2, 10));
            Paquet_.Add(new Carte("Valet De Carreau", Properties.Resources.jack_of_diamonds2, 10));
            Paquet_.Add(new Carte("Valet De Trèfle", Properties.Resources.jack_of_clubs2, 10));
            Paquet_.Add(new Carte("Valet De Pique", Properties.Resources.jack_of_spades2, 10));

            // Rène
            Paquet_.Add(new Carte("Reine De Coeur", Properties.Resources.queen_of_hearts2, 10));
            Paquet_.Add(new Carte("Reine De Carreau", Properties.Resources.queen_of_diamonds2, 10));
            Paquet_.Add(new Carte("Reine De Trèfle", Properties.Resources.queen_of_clubs2, 10));
            Paquet_.Add(new Carte("Reine De Pique", Properties.Resources.queen_of_spades2, 10));

            // Roi
            Paquet_.Add(new Carte("Roi De Coeur", Properties.Resources.king_of_hearts2, 10));
            Paquet_.Add(new Carte("Roi De Carreau", Properties.Resources.king_of_diamonds2, 10));
            Paquet_.Add(new Carte("Roi De Trèfle", Properties.Resources.king_of_clubs2, 10));
            Paquet_.Add(new Carte("Roi De Pique", Properties.Resources.king_of_spades2, 10));
        }

        public Carte PigerCarte()
        {
            Random rand = new Random();
            int valeur;

            if(VérifierSiResteCarte())
            {
                do
                {
                    valeur = rand.Next(1, Paquet_.Count);
                }
                while (Paquet_[valeur].Utilisée_);

                // mettre utilisé à true
                Paquet_[valeur].UtiliserCarte();

                return Paquet_[valeur];
            }

            return null;
        }

        public bool VérifierSiResteCarte()
        {
            for (int i = 0; i < Paquet_.Count; i++)
            {
                if(!Paquet_[i].Utilisée_)
                {
                    return true;
                }
            }
            return false;
        }


        public float GetNbCartesBonnes(int Score)
        {
            int NbMax = 21 - Score;

            return GetNbCartesVoulues(NbMax);
        }
        
        public float GetNbCartesVoulues(int NbMax)
        {
            float NbCartes = 0;
            for(int i = 0; i < Paquet_.Count; i++)
            {
                if(Paquet_[i].Valeur_ <= NbMax)
                {
                    NbCartes++;
                }
            }

            return NbCartes;
        }
    }
}
