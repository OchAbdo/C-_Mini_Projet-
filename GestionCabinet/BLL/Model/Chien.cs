using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public class Chien : Animal
    {
        public string Race { get; set; } // Exemple : Labrador, Berger allemand
        public bool EstDresse { get; set; } // Indique si le chien est dressé

        public Chien(string nom, string genre, int age, double poids, double taille, string etatSante, string race, bool ed) : base(nom, genre, age, poids, taille, etatSante)
        {
            Race = race;
            EstDresse = ed;

        }

    }
}
