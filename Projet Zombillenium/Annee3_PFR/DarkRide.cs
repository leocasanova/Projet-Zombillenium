using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annee3_PFR
{
    class DarkRide : Attraction
    {
        private TimeSpan duree;
        private bool vehicule;

        //public DarkRide() : base()
        //{
        //    this.duree = new TimeSpan(0, 2, 34);
        //    this.vehicule = false;
        //}

        public DarkRide(int identifiant, string nom, int nbMinMonstre, bool besoinSpecifique, string typeDeBesoin, TimeSpan duree, bool vehicule) : base(identifiant, nom, nbMinMonstre, besoinSpecifique, typeDeBesoin)
        {
            this.duree = duree;
            this.vehicule = vehicule;
        }

        public TimeSpan Duree
        {
            get { return duree; }
            set { duree = value; }
        }

        public bool Vehicule
        {
            get { return vehicule; }
            set { vehicule = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "\n\nType d'attraction : DarkRide" + "\nDurée : " + duree + "\nVéhicule : " + vehicule;
        }
    }
}
