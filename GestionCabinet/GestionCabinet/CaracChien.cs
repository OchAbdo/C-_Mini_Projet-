using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_P.Model;

namespace GestionCabinet
{
    public partial class CaracChien : Form
    {
        public CaracChien(Chien c)
        {
            InitializeComponent();
            label7.Text = c.Genre;
            label8.Text = $"{c.Age}";
            label9.Text = $"{c.Poids}";
            label10.Text = $"{c.Taille}";
            label11.Text = c.Race;
            label12.Text = c.EstDresse;
        }

        private void CaracChien_Load(object sender, EventArgs e)
        {

        }
    }
}
