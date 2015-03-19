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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Paquet paquet = new Paquet();
        }

        private void BTN_CommencerPartie_Click(object sender, EventArgs e)
        {
            Jeu jeu = new Jeu();
            jeu.ShowDialog();
        }
    }
}
