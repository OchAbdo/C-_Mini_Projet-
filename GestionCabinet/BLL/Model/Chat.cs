﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public class Chat : Animal
    {
        public string CouleurPelage { get; set; } // Exemple : Noir, Blanc, Tigré
        public bool EstDomestique { get; set; } // Indique si le chat est domestique ou sauvage


        public Chat(string nom, string genre, int age, double poids, double taille, string etatSante, string cp, bool ed) : base(nom, genre, age, poids, taille, etatSante)
        {
            CouleurPelage = cp;
            EstDomestique = ed;

        }

    }
}
