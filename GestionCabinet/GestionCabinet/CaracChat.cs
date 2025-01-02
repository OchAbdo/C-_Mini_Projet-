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
    public partial class CaracChat : Form
    {
        public CaracChat(Chat c)
        {
            InitializeComponent();
            label7.Text = c.Genre;
            label8.Text = $"{c.Age}";
            label9.Text = $"{c.Poids}";
            label10.Text = $"{c.Taille}";
            label11.Text = c.CouleurPelage;
            label12.Text = c.EstDomestique;
        }

        private void CaracChat_Load(object sender, EventArgs e)
        {

        }
    }
}
