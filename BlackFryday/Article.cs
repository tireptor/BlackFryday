using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackFryday
{
    class Article
    {
        public Article(string reference, float prixUnitaireHt, float tva)
        {
            this.reference = reference;
            this.prixUnitaireHt = prixUnitaireHt;
            this.tva = tva;
        }
        private string reference;

        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }
        private float prixUnitaireHt;

        public float PrixUnitaireHt
        {
            get { return prixUnitaireHt; }
            set { prixUnitaireHt = value; }
        }

        private float tva;

        public float Tva
        {
            get { return tva; }
            set { tva = value; }
        }

    }
}
