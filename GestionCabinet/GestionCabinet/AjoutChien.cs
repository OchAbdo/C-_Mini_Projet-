using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace GestionCabinet
{
    public partial class AjoutChien : Form
    {
        public AjoutChien()
        {
            InitializeComponent();
        }
        public bool ControleSaisir()
        {
            int entier;
            int decimal1, decimal2;
            bool rst = true;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Le champ 'Nom' est obligatoire.", "Erreur");
                rst = false;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Le champ 'Genre' est obligatoire.", "Erreur");
                rst = false;
            }

            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Le champ 'Race' est obligatoire.", "Erreur");
                rst = false;
            }

            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Le champ 'Etat de santé' est obligatoire.", "Erreur");
                rst = false;
            }

            if (!int.TryParse(textBox3.Text, out entier))
            {
                MessageBox.Show("Le champ 'Age' doit contenir un nombre entier.", "Erreur");
                rst = false;
            }

            if (!int.TryParse(textBox4.Text, out decimal1))
            {
                MessageBox.Show("Le champ 'Poids' doit contenir un nombre décimal.", "Erreur");
                rst = false;
            }

            if (!int.TryParse(textBox5.Text, out decimal2))
            {
                MessageBox.Show("Le champ 'Taille' doit contenir un nombre décimal.", "Erreur");
                rst = false;
            }

            return rst;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ControleSaisir() == true)
            {
                ChienDAO c = new ChienDAO();
                c.AjoutChienM(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), double.Parse(textBox4.Text), double.Parse(textBox5.Text), textBox7.Text, textBox6.Text, (radioButton1.Checked) ? "oui" : "non");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
