using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class frmLab1 : Form
    {
        public frmLab1()
        {
            InitializeComponent();
        }

        private void btnHexa_Click(object sender, EventArgs e)
        {
            //convert.toInt
            //modulo
            //Valeur = Entree / 16
            //Reste = Entree modulo 16
            //résultat = résultat + Reste (gauche à droite)
        }

        private void btnBinaire_Click(object sender, EventArgs e)
        {
            //Valeur = Entree / 2 (et ainsi de suite)
            //Reste = Entree modulo 2
            //résultat = Reste + résultat (droite à gauche)
            //valeur != 0
        }
    }
}
