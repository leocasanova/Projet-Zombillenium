using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annee3_PFR
{
    class LoupGarou : Monstre
    {
        private double indiceCruaute;

        //public LoupGarou() : base()
        //{
        //    this.indiceCruaute = 2.5;
        //}

        public LoupGarou(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, string affectation, double indiceCruaute) : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {
            this.indiceCruaute = indiceCruaute;
        }

        public double IndiceCruaute
        {
            get { return indiceCruaute; }
            set { indiceCruaute = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "\nType de monstre : Loup-garou" + "\nIndice de cruaute : " + indiceCruaute;
        }
    }
}
