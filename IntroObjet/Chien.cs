using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroObjet
{
    class Chien
    {
        private string _nom;
        private string _race;
        private int _age;


        public Chien(string nom, string race, int age)
        {
            this._nom = nom;
            this._race = race;
            this._age = age;
        }

        public string AfficherCaracteristiques()
        {
            return "Nom : " + this._nom + " Age" + this._age + " Race : " + this._race;   
        }

        public int AfficheAge() { return this._age; }
    }
}
