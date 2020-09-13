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
    public partial class AjoutBoutique : Window
    {
        Boutique boutique;

        public AjoutBoutique()
        {
            InitializeComponent();

            boutique = new Boutique(0, "", 0, false, "", TypeBoutique.BarbeAPapa);
            DataContext = boutique;
        }

        private void Valid_Click(object sender, RoutedEventArgs e)
        {
            boutique.Identifiant = Convert.ToInt32(saisiIdentifiant.Text);
            boutique.Nom = saisiNom.Text;
            boutique.NbMinMonstre = Convert.ToInt32(saisiMonstres.Text);
            boutique.BesoinSpecifique = Convert.ToBoolean(saisiBesoins.Text);
            boutique.TypeDeBesoin = saisiTypes.Text;
            boutique.Type = Administration.RetournerBoutique(saisiTypeBoutique.Text);

            MessageBox.Show("Attraction : " + boutique);
        }

        private void Init_Click(object sender, RoutedEventArgs e)
        {
            boutique.Identifiant = 0;
            boutique.Nom = "";
            boutique.NbMinMonstre = 0;
            boutique.BesoinSpecifique = false;
            boutique.TypeDeBesoin = "";
            boutique.Type = TypeBoutique.BarbeAPapa;

            MessageBox.Show("Attraction : " + boutique);
        }
    }
}
