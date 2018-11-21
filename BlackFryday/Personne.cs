using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackFryday
{
    abstract class Personne
    {
        private string nom;
        private string prenom;
        private string [] adresse;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string  [] Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
    }
}
