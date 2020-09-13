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
    public partial class AjoutFantome : Window
    {
        Fantome fantome;

        public AjoutFantome()
        {
            InitializeComponent();

            fantome = new Fantome(123, "nom", "prenom", TypeSexe.Autre, "fonction", 100, null);
            DataContext = fantome;
        }

        private void Valid_Click(object sender, RoutedEventArgs e)
        {
            fantome.Matricule = Convert.ToInt32(saisiMatricule.Text);
            fantome.Nom = saisiNom.Text;
            fantome.Prenom = saisiPrenom.Text;
            fantome.Sexe = Administration.RetournerSexe(saisiSexe.Text);
            fantome.Fonction = saisiFonction.Text;
            fantome.Cagnotte = Convert.ToInt32(saisiCagnotte.Text);
            fantome.Affectation = saisiAffectation.Text;

            MessageBox.Show("Identite : " + fantome);
        }

        private void Init_Click(object sender, RoutedEventArgs e)
        {
            fantome.Matricule = 0;
            fantome.Nom = "";
            fantome.Prenom = "";
            fantome.Sexe = TypeSexe.Autre;
            fantome.Fonction = "";
            fantome.Cagnotte = 0;
            fantome.Affectation = "";

            MessageBox.Show("Identite : " + fantome);
        }
    }
}
