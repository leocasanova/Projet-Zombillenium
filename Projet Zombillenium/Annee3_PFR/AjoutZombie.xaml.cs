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
    public partial class AjoutZombie : Window
    {
        Zombie zombie;

        public AjoutZombie()
        {
            InitializeComponent();

            zombie = new Zombie(123, "nom", "prenom", TypeSexe.Autre, "fonction", 100, null, 3, CouleurZ.Grisatre);
            DataContext = zombie;
        }

        private void Valid_Click(object sender, RoutedEventArgs e)
        {
            zombie.Matricule = Convert.ToInt32(saisiMatricule.Text);
            zombie.Nom = saisiNom.Text;
            zombie.Prenom = saisiPrenom.Text;
            zombie.Sexe = Administration.RetournerSexe(saisiSexe.Text);
            zombie.Fonction = saisiFonction.Text;
            zombie.Cagnotte = Convert.ToInt32(saisiCagnotte.Text);
            zombie.Affectation = saisiAffectation.Text;
            zombie.DegreDecompostion = Convert.ToInt32(saisiDecomposition.Text);
            zombie.Teint = Administration.RetournerCouleur(saisiTeint.Text);

            MessageBox.Show("Identite : " + zombie);
        }

        private void Init_Click(object sender, RoutedEventArgs e)
        {
            zombie.Matricule = 0;
            zombie.Nom = "";
            zombie.Prenom = "";
            zombie.Sexe = TypeSexe.Autre;
            zombie.Fonction = "";
            zombie.Cagnotte = 0;
            zombie.Affectation = "";
            zombie.DegreDecompostion = 0;
            zombie.Teint = CouleurZ.Grisatre;

            MessageBox.Show("Identite : " + zombie);
        }
    }
}
