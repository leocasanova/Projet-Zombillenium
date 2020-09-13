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
    public partial class AjoutRollerCoaster : Window
    {
        RollerCoaster rollercoaster;

        public AjoutRollerCoaster()
        {
            InitializeComponent();

            rollercoaster = new RollerCoaster(123, "nom", 1, false, "besoin", TypeCategorie.Assise, 8, 1.5);
            DataContext = rollercoaster;
        }

        private void Valid_Click(object sender, RoutedEventArgs e)
        {
            rollercoaster.Identifiant = Convert.ToInt32(saisiIdentifiant.Text);
            rollercoaster.Nom = saisiNom.Text;
            rollercoaster.NbMinMonstre = Convert.ToInt32(saisiMonstres.Text);
            rollercoaster.BesoinSpecifique = Convert.ToBoolean(saisiBesoins.Text);
            rollercoaster.TypeDeBesoin = saisiTypes.Text;
            rollercoaster.Categorie = Administration.RetournerCategorie(saisiCategorie.Text);
            rollercoaster.AgeMinimum = Convert.ToInt32(saisiAgeMinimum.Text);
            rollercoaster.TailleMinimum = Convert.ToDouble(saisiTailleMinimum.Text);

            MessageBox.Show("Attraction : " + rollercoaster);
        }

        private void Init_Click(object sender, RoutedEventArgs e)
        {
            rollercoaster.Identifiant = 0;
            rollercoaster.Nom = "";
            rollercoaster.NbMinMonstre = 0;
            rollercoaster.BesoinSpecifique = false;
            rollercoaster.TypeDeBesoin = "";
            rollercoaster.Categorie = TypeCategorie.Assise;
            rollercoaster.AgeMinimum = 0;
            rollercoaster.TailleMinimum = 0;

            MessageBox.Show("Attraction : " + rollercoaster);
        }
    }
}
