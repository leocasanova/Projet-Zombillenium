using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annee3_PFR
{
    class Boutique : Attraction
    {
        private TypeBoutique type;

        //public Boutique() : base()
        //{
        //    this.type = TypeBoutique.Souvenir;
        //}

        public Boutique(int identifiant, string nom, int nbMinMonstre, bool besoinSpecifique, string typeDeBesoin, TypeBoutique type) : base(identifiant, nom, nbMinMonstre, besoinSpecifique, typeDeBesoin)
        {
            this.type = type;
        }

        public TypeBoutique Type
        {
            get { return type; }
            set { type = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "\n\nType d'attraction : Boutique" + "\nType de boutique : " + type;
        }
    }
}
