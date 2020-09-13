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
    public partial class AjoutVampire : Window
    {
        Vampire vampire;

        public AjoutVampire()
        {
            InitializeComponent();

            vampire = new Vampire(123, "nom", "prenom", TypeSexe.Autre, "fonction", 100, null, 5.4);
            DataContext = vampire;
        }

        private void Valid_Click(object sender, RoutedEventArgs e)
        {
            vampire.Matricule = Convert.ToInt32(saisiMatricule.Text);
            vampire.Nom = saisiNom.Text;
            vampire.Prenom = saisiPrenom.Text;
            vampire.Sexe = Administration.RetournerSexe(saisiSexe.Text);
            vampire.Fonction = saisiFonction.Text;
            vampire.Cagnotte = Convert.ToInt32(saisiCagnotte.Text);
            vampire.Affectation = saisiAffectation.Text;
            vampire.IndiceLuminosite = Convert.ToDouble(saisiLuminosite.Text);

            MessageBox.Show("Identite : " + vampire);
        }

        private void Init_Click(object sender, RoutedEventArgs e)
        {
            vampire.Matricule = 0;
            vampire.Nom = "";
            vampire.Prenom = "";
            vampire.Sexe = TypeSexe.Autre;
            vampire.Fonction = "";
            vampire.Cagnotte = 0;
            vampire.Affectation = "";
            vampire.IndiceLuminosite = 0;

            MessageBox.Show("Identite : " + vampire);
        }
    }
}
