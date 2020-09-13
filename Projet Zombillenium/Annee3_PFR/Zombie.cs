using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annee3_PFR
{
    class Zombie : Monstre
    {
        private int degreDecomposition;
        private CouleurZ teint;

        //public Zombie() : base()
        //{
        //    this.degreDecomposition = 4;
        //    this.teint = CouleurZ.Bleuatre;
        //}

        public Zombie(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, string affectation, int degreDecomposition, CouleurZ teint) : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {
            this.degreDecomposition = degreDecomposition;
            this.teint = teint;
        }

        public int DegreDecompostion
        {
            get { return degreDecomposition; }
            set { degreDecomposition = value; }
        }

        public CouleurZ Teint
        {
            get { return teint; }
            set { teint = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "\nType de monstre : Zombie" + "\nDegre de decomposition : " + degreDecomposition + "\nTeinte : " + teint;
        }
    }
}
