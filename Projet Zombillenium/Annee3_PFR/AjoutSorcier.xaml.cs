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
    public partial class AjoutSorcier : Window
    {
        Sorcier sorcier;
        List<string> pouvoirs = new List<string>();

        public AjoutSorcier()
        {
            InitializeComponent();

            sorcier = new Sorcier(123, "nom", "prenom", TypeSexe.Autre, "fonction", Grade.Giga, pouvoirs);
            DataContext = sorcier;
        }

        public List<string> Pouvoirs
        {
            get { return pouvoirs; }
            set { pouvoirs = value; }
        }

        //private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        //{
        //    // ... A List.
        //    List<string> data = new List<string>();
        //    data.Add("Male");
        //    data.Add("Femelle");
        //    data.Add("Autre");

        //    // ... Get the ComboBox reference.
        //    var comboBox = sender as ComboBox;

        //    // ... Assign the ItemsSource to the List.
        //    comboBox.ItemsSource = data;

        //    // ... Make the first item selected.
        //    comboBox.SelectedIndex = 0;
        //}

        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    // ... Get the ComboBox.
        //    var comboBox = sender as ComboBox;

        //    // ... Set SelectedItem as Window Title.
        //    string value = comboBox.SelectedItem as string;
        //    this.Title = "Selected: " + value;
        //}

        private void Valid_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
                sorcier.Matricule = Convert.ToInt32(saisiMatricule.Text);
                sorcier.Nom = saisiNom.Text;
                sorcier.Prenom = saisiPrenom.Text;
                sorcier.Sexe = Administration.RetournerSexe(saisiSexe.Text);
                sorcier.Fonction = saisiFonction.Text;
                pouvoirs.Add(saisiPouvoir.Text);
                sorcier.Pouvoirs = pouvoirs;

                MessageBox.Show("Identite : " + sorcier);
            //}
            //catch (Exception x)
            //{
            //    MessageBox.Show("Veuillez remplir tous les champs.");
            //}
        }

        private void Init_Click(object sender, RoutedEventArgs e)
        {
            sorcier.Matricule = 0;
            sorcier.Nom = "";
            sorcier.Prenom = "";
            sorcier.Sexe = TypeSexe.Autre;
            sorcier.Fonction = "";
            sorcier.Pouvoirs = null;

            MessageBox.Show("Identite : " + sorcier);
        }
    }
}
