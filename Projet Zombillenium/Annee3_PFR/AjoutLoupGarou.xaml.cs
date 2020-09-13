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
    public partial class AjoutLoupGarou : Window
    {
        LoupGarou loupgarou;

        public AjoutLoupGarou()
        {
            InitializeComponent();

            loupgarou = new LoupGarou(123, "nom", "prenom", TypeSexe.Autre, "fonction", 100, null, 3.2);
            DataContext = loupgarou;
        }

        private void Valid_Click(object sender, RoutedEventArgs e)
        {
            loupgarou.Matricule = Convert.ToInt32(saisiMatricule.Text);
            loupgarou.Nom = saisiNom.Text;
            loupgarou.Prenom = saisiPrenom.Text;
            loupgarou.Sexe = Administration.RetournerSexe(saisiSexe.Text);
            loupgarou.Fonction = saisiFonction.Text;
            loupgarou.Cagnotte = Convert.ToInt32(saisiCagnotte.Text);
            loupgarou.Affectation = saisiAffectation.Text;
            loupgarou.IndiceCruaute = Convert.ToDouble(saisiCruaute.Text);

            MessageBox.Show("Identite : " + loupgarou);
        }

        private void Init_Click(object sender, RoutedEventArgs e)
        {
            loupgarou.Matricule = 0;
            loupgarou.Nom = "";
            loupgarou.Prenom = "";
            loupgarou.Sexe = TypeSexe.Autre;
            loupgarou.Fonction = "";
            loupgarou.Cagnotte = 0;
            loupgarou.Affectation = "";
            loupgarou.IndiceCruaute= 0;

            MessageBox.Show("Identite : " + loupgarou);
        }
    }
}
