using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public class Animal
    {
        public string Nom { get; set; }
        public string Genre { get; set; } // Mâle ou Femelle
        public int Age { get; set; }
        public double Poids { get; set; } // en kg
        public double Taille { get; set; } // en mètres
        public string EtatSante { get; set; }



        public Animal(string nom, string genre, int age, double poids, double taille, string etatSante)
        {
            Nom = nom;
            Genre = genre;
            Age = age;
            Poids = poids;
            Taille = taille;
            EtatSante = etatSante;
        }

    }
}
