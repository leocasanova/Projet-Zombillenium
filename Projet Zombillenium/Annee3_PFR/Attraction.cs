using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annee3_PFR
{
    public abstract class Attraction
    {
        protected bool besoinSpecifique;
        protected TimeSpan dureeMaintenance;
        protected List<Monstre> equipe;
        protected int identifiant;
        protected bool maintenance;
        protected string natureMaintenance;
        protected int nbMinMonstre;
        protected string nom;
        protected bool ouvert;
        protected string typeDeBesoin;

        //public Attraction() : this(2345, "ZOO", 4, false, "Aucune") { }

        public Attraction(int identifiant, string nom, int nbMinMonstre, bool besoinSpecifique, string typeDeBesoin)
        {
            this.identifiant = identifiant;
            this.nom = nom;
            this.nbMinMonstre = nbMinMonstre;
            this.besoinSpecifique = besoinSpecifique;
            this.typeDeBesoin = typeDeBesoin;
        }

        public Attraction(int identifiant, string nom, int nbMinMonstre, bool besoinSpecifique, string typeDeBesoin, TimeSpan dureeMaintenance, List<Monstre> equipe, bool maintenance, string natureMaintenance, bool ouvert)
        {
            this.identifiant = identifiant;
            this.nom = nom;
            this.nbMinMonstre = nbMinMonstre;
            this.besoinSpecifique = besoinSpecifique;
            this.typeDeBesoin = typeDeBesoin;
            this.dureeMaintenance = dureeMaintenance;
            this.equipe = equipe;
            this.maintenance = maintenance;
            this.natureMaintenance = natureMaintenance;
            this.ouvert = ouvert;
        }

        public int Identifiant
        {
            get { return identifiant; }
            set { identifiant = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public int NbMinMonstre
        {
            get { return nbMinMonstre; }
            set { nbMinMonstre = value; }
        }

        public bool BesoinSpecifique
        {
            get { return besoinSpecifique; }
            set { besoinSpecifique = value; }
        }

        public string TypeDeBesoin
        {
            get { return typeDeBesoin; }
            set { typeDeBesoin = value; }
        }

        public override string ToString()
        {
            return "\n------------------------------------------------------------------------\n\nIdentifiant : " + identifiant + "\nNom : " + nom + "\nNombre minimum de monstres : " + nbMinMonstre + "\nBesoin specifique : " + besoinSpecifique + "\nType de besoin : " + typeDeBesoin;
        }
    }
}
