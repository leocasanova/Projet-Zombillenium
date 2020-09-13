using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annee3_PFR
{
    class Demon : Monstre
    {
        private int force;

        //public Demon() : base()
        //{
        //    this.force = 16;
        //}

        public Demon(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, string affectation, int force) : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {
            this.force = force;
        }

        public int Force
        {
            get { return force; }
            set { force = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "\nType de monstre : Demon" + "\nForce : " + force;
        }
    }
}
