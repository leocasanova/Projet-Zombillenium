using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annee3_PFR
{
    public class Monstre : Personnel
    {
        //protected Attraction affectation;
        protected string affectation;
        protected int cagnotte;

        //public Monstre() : base()
        //{
        //    this.affectation = Attraction.RollerCoaster;
        //    this.cagnotte = 232;
        //}

        public Monstre(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, string affectation) : base(matricule, nom, prenom, sexe, fonction)
        {
            this.affectation = affectation;
            this.cagnotte = cagnotte;
        }

        public string Affectation
        {
            get { return affectation; }
            set { affectation = value; }
        }

        public int Cagnotte
        {
            get { return cagnotte; }
            set { cagnotte = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "\n\nMonstre" + "\nAffectation : " + affectation + "\nCagnotte : " + cagnotte;
        }
    }
}
