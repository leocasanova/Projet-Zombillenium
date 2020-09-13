using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annee3_PFR
{
    class RollerCoaster : Attraction
    {
        private TypeCategorie categorie;
        private int ageMinimum;
        private double tailleMinimum;

        //public RollerCoaster() : base()
        //{
        //    categorie = TypeCategorie.Assise;
        //    ageMinimum = 11;
        //    tailleMinimum = 1.32;
        //}

        public RollerCoaster(int identifiant, string nom, int nbMinMonstre, bool besoinSpecifique, string typeDeBesoin, TypeCategorie categorie, int ageMinimum, double tailleMinimum) : base(identifiant, nom, nbMinMonstre, besoinSpecifique, typeDeBesoin)
        {
            this.categorie = categorie;
            this.ageMinimum = ageMinimum;
            this.tailleMinimum = tailleMinimum;
        }

        public TypeCategorie Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }

        public int AgeMinimum
        {
            get { return ageMinimum; }
            set { ageMinimum = value; }
        }

        public double TailleMinimum
        {
            get { return tailleMinimum; }
            set { tailleMinimum = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "\n\nType d'attraction : RollerCoaster" + "\nCategorie : " + categorie + "\nAge minimum : " + ageMinimum + "\nTaille minimum : " + tailleMinimum;
        }
    }
}
