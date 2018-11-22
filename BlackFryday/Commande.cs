using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackFryday
{
    class Commande
    {
        private List<Article> articles = new List<Article>();
        public List<Article> Articles
        {
            get { return  articles; }
            set {  articles = value; }
        }
        private float prixTotal;

        public float PrixTotal
        {
            get { return calculateTotalPrice(); }
            set {  }
        }
        public void ajouterArticle(Article articleCli)
        {
            this.articles.Add(articleCli);
        }
        private float calculateTotalPrice()
        {
            float priceHt = 0;
            float tva   = 0;
            float totalPrice = 0;
            float priceAdd = 0;
            foreach (Article aArticle in this.articles)
            {
                priceHt = aArticle.PrixUnitaireHt;
                tva = aArticle.Tva;
                priceAdd = (priceHt * tva)/100;
                totalPrice += priceHt + priceAdd;
            }
            return totalPrice;
        }

    }
}
