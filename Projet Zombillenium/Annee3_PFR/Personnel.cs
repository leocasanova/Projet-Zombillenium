using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annee3_PFR
{
    public abstract class Personnel
    {
        protected string fonction;
        protected int matricule;
        protected string nom;
        protected string prenom;
        protected TypeSexe sexe;

        //public Personnel() : this(1234, "Dupont", "Jean", TypeSexe.Male, "Reparateur") { }

        public Personnel(int matricule, string nom, string prenom, TypeSexe sexe, string fonction)
        {
            this.fonction = fonction;
            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
        }

        public int Matricule
        {
            get { return matricule; }
            set { matricule = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public TypeSexe Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }

        public string Fonction
        {
            get { return fonction; }
            set { fonction = value; }
        }

        public override string ToString()
        {
            return "\n------------------------------------------------------------------------\n\nMatricule : " + matricule + "\nNom : " + nom + "\nPrenom : " + prenom + "\nSexe : " + sexe + "\nFonction : " + fonction;
        }
    }
}
