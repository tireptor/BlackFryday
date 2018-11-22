using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackFryday
{
    class Client : Personne
    {
        public Client(string nomCli, string prenomCli, string[] adresseCli, string codeCli)
        {
            this.Nom = nomCli;
            this.Nom = prenomCli;
            this.Adresse = adresseCli;
            this.code = codeCli;
        }
        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        private List<Commande> commandes = new List<Commande>();

        public List<Commande> Commandes
        {
            get { return commandes; }
            set { commandes = value; }
        }
        public void ajouterCommande (Commande commandeCli)
        {
            this.commandes.Add(commandeCli);
        }
    }
}
