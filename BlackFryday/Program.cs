using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackFryday
{
    class Program
    {
        static void Main(string[] args)
        {
            Article art1 = new Article("123456789",100,20);
            Article art2 = new Article("123456710",250,20);
            Article art3 = new Article("123456100",25,10);

            Commande com = new Commande();
            com.ajouterArticle(art1);
            com.ajouterArticle(art2);
            com.ajouterArticle(art3);

            
            string[] adresse = new string[3];
            adresse[0] = "795 rue de truc";
            adresse[1] = "MaVille";
            adresse[2] = "76100";

            Client cli = new Client("nomClient1", "prenomClient1", adresse, "123");
            cli.ajouterCommande(com);
            // un com
            Console.WriteLine(com.PrixTotal);
            
            Console.ReadKey();
        }
    }
}
