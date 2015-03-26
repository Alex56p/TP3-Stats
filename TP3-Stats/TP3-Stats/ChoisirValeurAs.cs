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
    public partial class ChoisirValeurAs : Form
    {
        public int Valeur = 0;
        public ChoisirValeurAs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckButton()
        {
            if (RB_1.Checked || RB_11.Checked)
                BTN_OK.Enabled = true;
            else
                BTN_OK.Enabled = false;
        }

        private void RB_1_CheckedChanged(object sender, EventArgs e)
        {
            Valeur = 1;
            CheckButton();
        }

        private void RB_11_CheckedChanged(object sender, EventArgs e)
        {
            Valeur = 11;
            CheckButton();
        }
    }
}
