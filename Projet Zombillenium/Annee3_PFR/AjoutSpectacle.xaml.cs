using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Annee3_PFR
{
    public partial class AjoutSpectacle : Window
    {
        Spectacle spectacle;
        List<DateTime> horaires = new List<DateTime>();

        public AjoutSpectacle()
        {
            InitializeComponent();

            spectacle = new Spectacle(123, "nom", 1, false, "besoin", "nom", 50, new List<DateTime>());
            DataContext = spectacle;
        }

        public List<DateTime> Horaires
        {
            get { return horaires; }
            set { horaires = value; }
        }

        private void Valid_Click(object sender, RoutedEventArgs e)
        {
            spectacle.Identifiant = Convert.ToInt32(saisiIdentifiant.Text);
            spectacle.Nom = saisiNom.Text;
            spectacle.NbMinMonstre = Convert.ToInt32(saisiMonstres.Text);
            spectacle.BesoinSpecifique = Convert.ToBoolean(saisiBesoins.Text);
            spectacle.TypeDeBesoin = saisiTypes.Text;
            spectacle.NomSalle = saisiNomSalle.Text;
            spectacle.NombrePlace = Convert.ToInt32(saisiNombrePlace.Text);
            horaires.Add(Convert.ToDateTime(saisiHoraire.Text));
            spectacle.Horaire = horaires;

            MessageBox.Show("Attraction : " + spectacle);
        }

        private void Init_Click(object sender, RoutedEventArgs e)
        {
            spectacle.Identifiant = 0;
            spectacle.Nom = "";
            spectacle.NbMinMonstre = 0;
            spectacle.BesoinSpecifique = false;
            spectacle.TypeDeBesoin = "";
            spectacle.NomSalle = "";
            spectacle.NombrePlace = 0;
            spectacle.Horaire = new List<DateTime>() ;

            MessageBox.Show("Attraction : " + spectacle);
        }
    }
}
