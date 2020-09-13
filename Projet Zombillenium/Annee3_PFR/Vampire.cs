using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annee3_PFR
{
    class Vampire : Monstre
    {
        private double indiceLuminosite;

        //public Vampire() : base()
        //{
        //    this.indiceLuminosite = 3.5;
        //}

        public Vampire(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, string affectation, double indiceLuminosite) : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {
            this.indiceLuminosite = indiceLuminosite;
        }

        public double IndiceLuminosite
        {
            get { return indiceLuminosite; }
            set { indiceLuminosite = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "\nType de monstre : Vampire" + "\nIndice de luminosite : " + indiceLuminosite;
        }
    }
}
