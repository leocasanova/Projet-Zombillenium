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
    public partial class AjoutDarkRide : Window
    {
        DarkRide darkride;

        public AjoutDarkRide()
        {
            InitializeComponent();

            darkride = new DarkRide(123, "nom", 1, false, "besoin", new TimeSpan(0,0,2,30), false);
            DataContext = darkride;
        }

        private void Valid_Click(object sender, RoutedEventArgs e)
        {
            darkride.Identifiant = Convert.ToInt32(saisiIdentifiant.Text);
            darkride.Nom = saisiNom.Text;
            darkride.NbMinMonstre = Convert.ToInt32(saisiMonstres.Text);
            darkride.BesoinSpecifique = Convert.ToBoolean(saisiBesoins.Text);
            darkride.TypeDeBesoin = saisiTypes.Text;
            darkride.Duree = TimeSpan.Parse(saisiDuree.Text);
            darkride.Vehicule = Convert.ToBoolean(saisiVehicule.Text);

            MessageBox.Show("Attraction : " + darkride);
        }

        private void Init_Click(object sender, RoutedEventArgs e)
        {
            darkride.Identifiant = 0;
            darkride.Nom = "";
            darkride.NbMinMonstre = 0;
            darkride.BesoinSpecifique = false;
            darkride.TypeDeBesoin = "";
            darkride.Duree = new TimeSpan(0);
            darkride.Vehicule = false;

            MessageBox.Show("Attraction : " + darkride);
        }
    }
}
