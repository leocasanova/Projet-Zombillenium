using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annee3_PFR
{
    class Sorcier : Personnel
    {
        private List<string> pouvoirs;
        private Grade tatouage;

        //public Sorcier() : base()
        //{
        //    this.pouvoirs = new List<string>();
        //    this.tatouage = Grade.Strata;
        //}

        public Sorcier(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, Grade tatouage, List<string> pouvoirs) : base(matricule, nom, prenom, sexe, fonction)
        {
            this.pouvoirs = pouvoirs;
            this.tatouage = tatouage;
        }

        public List<string> Pouvoirs
        {
            get { return pouvoirs; }
            set { pouvoirs = value; }
        }

        public Grade Tatouage
        {
            get { return tatouage; }
            set { tatouage = value; }
        }

        public string AfficherPouvoirs(List<string> pouvoirs)
        {
            string listP = "";
            foreach (string p in pouvoirs)
            {
                listP += p + " - ";
            }
            return listP;
        }

        public override string ToString()
        {
            string powers = AfficherPouvoirs(pouvoirs);
            return base.ToString() + "\n\nSorcier" + "\nPouvoirs : " + powers + "\nGrade : " + tatouage;
        }
    }
}
