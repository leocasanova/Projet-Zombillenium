using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annee3_PFR
{
    class Fantome : Monstre
    {
        //public Fantome() : base() { }

        public Fantome(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, string affectation) : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation) { }

        public override string ToString()
        {
            return base.ToString() + "\nType de monstre : Fantome";
        }
    }
}
