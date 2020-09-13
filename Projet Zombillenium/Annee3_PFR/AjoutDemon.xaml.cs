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
    public partial class AjoutDemon : Window
    {
        Demon demon;

        public AjoutDemon()
        {
            InitializeComponent();

            demon = new Demon(123, "nom", "prenom", TypeSexe.Autre, "fonction", 100, null, 10);
            DataContext = demon;
        }

        private void Valid_Click(object sender, RoutedEventArgs e)
        {
            demon.Matricule = Convert.ToInt32(saisiMatricule.Text);
            demon.Nom = saisiNom.Text;
            demon.Prenom = saisiPrenom.Text;
            demon.Sexe = Administration.RetournerSexe(saisiSexe.Text);
            demon.Fonction = saisiFonction.Text;
            demon.Cagnotte = Convert.ToInt32(saisiCagnotte.Text);
            demon.Affectation = saisiAffectation.Text;
            demon.Force = Convert.ToInt32(saisiForce.Text);

            MessageBox.Show("Identite : " + demon);
        }

        private void Init_Click(object sender, RoutedEventArgs e)
        {
            demon.Matricule = 0;
            demon.Nom = "";
            demon.Prenom = "";
            demon.Sexe = TypeSexe.Autre;
            demon.Fonction = "";
            demon.Cagnotte = 0;
            demon.Affectation = "";
            demon.Force = 0;

            MessageBox.Show("Identite : " + demon);
        }
    }
}
