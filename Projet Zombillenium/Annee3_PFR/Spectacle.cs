using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annee3_PFR
{
    class Spectacle : Attraction
    {
        private List<DateTime> horaire;
        private int nombrePlace;
        private string nomSalle;

        //public Spectacle() : base()
        //{
        //    horaire = new List<DateTime>();
        //    nombrePlace = 120;
        //    nomSalle = "Zeubiland";
        //}

        public Spectacle(int identifiant, string nom, int nbMinMonstre, bool besoinSpecifique, string typeDeBesoin, string nomSalle, int nombrePlace, List<DateTime> horaire) : base(identifiant, nom, nbMinMonstre, besoinSpecifique, typeDeBesoin)
        {
            this.nomSalle = nomSalle;
            this.nombrePlace = nombrePlace;
            this.horaire = horaire;
        }

        public List<DateTime> Horaire
        {
            get { return horaire; }
            set { horaire = value; }
        }

        public int NombrePlace
        {
            get { return nombrePlace; }
            set { nombrePlace = value; }
        }

        public string NomSalle
        {
            get { return nomSalle; }
            set { nomSalle = value; }
        }

        public string AfficherHoraires(List<DateTime> horaire)
        {
            string listH = "";
            foreach (DateTime h in horaire)
            {
                listH += h + " - ";
            }
            return listH;
        }

        public override string ToString()
        {
            string hours = AfficherHoraires(horaire);
            return base.ToString() + "\n\nType d'attraction : Spectacle" + "\nHoraires : " + hours + "\nNom de la salle : " + nomSalle + "\nNombre de places : " + nombrePlace;
        }
    }
}
