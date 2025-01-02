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
using BLL_P.Model;

namespace GestionCabinet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //RemplirListchat();
        }

        public void RemplirListchat()
        {
            
                ChatDAO chatDAO = new ChatDAO();
                listBox1.Items.Clear();

                foreach (var chat in chatDAO.AfficheChat())
                {
                    listBox1.Items.Add(chat);
                }
            
        }

        public void RemplirListchien()
        {

            ChienDAO chienDAO = new ChienDAO();
            listBox1.Items.Clear();

            foreach (var chien in chienDAO.AfficheChien())
            {
                listBox1.Items.Add(chien);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true) 
            {
                
                AjoutChat ajoutChat = new AjoutChat();
                if (ajoutChat.ShowDialog() == DialogResult.OK) 
                {
                    MessageBox.Show("Ajout success chat!");
                    RemplirListchat();
                }
         

            }
            else if (radioButton2.Checked == true)
            {
                AjoutChien ajoutChien = new AjoutChien();
                if (ajoutChien.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Ajout success chien !");
                    RemplirListchien();
                }

            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            RemplirListchat();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            RemplirListchien();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (radioButton1.Checked == true)
                {
                    ChatDAO chatDAO = new ChatDAO();
                    Chat c = listBox1.SelectedItem as Chat;
                    chatDAO.SupprimeChat(c);
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
                else if (radioButton2.Checked == true)
                {
                    ChienDAO chienDAO = new ChienDAO();
                    Chien c = listBox1.SelectedItem as Chien;
                    chienDAO.SupprimeChien(c);
                    listBox1.Items.Remove(listBox1.SelectedItem);

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null)
            {
                if (radioButton1.Checked == true)
                {
                    Chat c = listBox1.SelectedItem as Chat;
                    label4.Text = c.Nom;
                    label5.Text = c.EtatSante;
                }else if(radioButton2.Checked == true) 
                {
                    Chien c = listBox1.SelectedItem as Chien;
                    label4.Text = c.Nom;
                    label5.Text = c.EtatSante;
                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (radioButton1.Checked == true)
                {
                    Chat chat = listBox1.SelectedItem as Chat;
                    CaracChat caracChat = new CaracChat(chat);
                    caracChat.ShowDialog();
                }
                else if (radioButton2.Checked == true) 
                {
                    Chien chien = listBox1.SelectedItem as Chien;
                    CaracChien caracChien = new CaracChien(chien);
                    caracChien.ShowDialog();
                }
            }
        }
    }
}
