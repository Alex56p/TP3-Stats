using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TP3_Stats
{
    class Carte
    {
        // Attributs
        public String Description_;
        public Image Image_;
        public int Valeur_;
        public int ValeurAs_;
        public bool Utilisée_;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="description"></param>
        /// <param name="image"></param>
        /// <param name="valeur"></param>
        public Carte(string description, Image image, int valeur)
        {
            // Affecter les valeurs aux attributs
            Description_ = description;
            Image_ = image;
            Valeur_ = valeur;

            // Mettre Utilisée_ à false puisqu'elle n'est pas encore pigée, elle est seulement initialisée
            Utilisée_ = false;
        }

        public Carte(string description, Image image, int valeur, int valeurAs)
        {
            // Affecter les valeurs aux attributs
            Description_ = description;
            Image_ = image;
            Valeur_ = valeur;
            ValeurAs_ = valeurAs;

            // Mettre Utilisée_ à false puisqu'elle n'est pas encore pigée, elle est seulement initialisée
            Utilisée_ = false;
        }

        /// <summary>
        /// UtiliserCarte
        /// Permet de changer la valriable Utilisée_ à false
        /// </summary>
        public void UtiliserCarte()
        {
            Utilisée_ = true;
        }

        /// <summary>
        /// ReinitialiserUtilisation
        /// Permet de changer la variable Utilisée_ pour que la carte puisse être pigée à nouveau
        /// </summary>
        public void ReinitialiserUtilisation()
        {
            Utilisée_ = false;
        }
    }
}
