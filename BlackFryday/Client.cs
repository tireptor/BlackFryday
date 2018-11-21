using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackFryday
{
    class Client : Personne
    {
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
        private void ajouterCommande (Commande commandeCli)
        {
            this.commandes.Add(commandeCli);
        }
        private Client ajouterClient(string nomCli, string prenomCli, string [] adresseCli, string codeCli)
        {
            Client cli = new Client();
            cli.Nom = nomCli;
            cli.Nom = prenomCli;
            cli.Adresse = adresseCli;
            cli.code = codeCli;
            return cli;
        }
    }
}
