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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Annee3_PFR
{
    public partial class MainWindow : Window
    {
        Administration zombillenium = new Administration();

        AjoutSorcier addsorcier;
        AjoutDemon adddemon;
        AjoutVampire addvampire;
        AjoutFantome addghost;
        AjoutZombie addzombie;
        AjoutLoupGarou addwerewolf;
        AjoutDarkRide adddarkride;
        AjoutRollerCoaster addrollercoaster;
        AjoutSpectacle addshow;
        AjoutBoutique addshop;
        Liste newlist;

        public MainWindow()
        {
            InitializeComponent();

            addsorcier = new AjoutSorcier();
            adddemon = new AjoutDemon();
            addvampire = new AjoutVampire();
            addghost = new AjoutFantome();
            addzombie = new AjoutZombie();
            addwerewolf = new AjoutLoupGarou();
            adddarkride = new AjoutDarkRide();
            addrollercoaster = new AjoutRollerCoaster();
            addshow = new AjoutSpectacle();
            addshop = new AjoutBoutique();
            newlist = new Liste();

            zombillenium.Lire("Listing.csv");
        }

        private void AjouterPerso_Click(object sender, RoutedEventArgs e)
        {
            AjouterSorcier.Visibility = Visibility.Visible;
            AjouterDemon.Visibility = Visibility.Visible;
            AjouterVampire.Visibility = Visibility.Visible;
            AjouterFantome.Visibility = Visibility.Visible;
            AjouterZombie.Visibility = Visibility.Visible;
            AjouterLoupGarou.Visibility = Visibility.Visible;
        }

        private void AjouterAttraction_Click(object sender, RoutedEventArgs e)
        {
            AjouterDarkRide.Visibility = Visibility.Visible;
            AjouterRollerCoaster.Visibility = Visibility.Visible;
            AjouterSpectacle.Visibility = Visibility.Visible;
            AjouterBoutique.Visibility = Visibility.Visible;
        }

        private void AfficherPersonnel_Click(object sender, RoutedEventArgs e)
        {
            //newlist.listBox.Items.Clear();
            newlist.listBox.Items.Add("Liste du personnel");
            foreach(Personnel p in zombillenium.ToutlePersonnel)
            {
                newlist.listBox.Items.Add(p);
            }
            newlist.Show();
        }

        private void AfficherAttraction_Click(object sender, RoutedEventArgs e)
        {
            //newlist.listBox.Items.Clear();
            newlist.listBox.Items.Add("Liste des attractions");
            foreach (Attraction a in zombillenium.Attractions)
            {
                newlist.listBox.Items.Add(a);
            }
            newlist.Show();
        }

        private void AddWizard(object sender, RoutedEventArgs e)
        {
                Personnel sorcier = new Sorcier(Convert.ToInt32(addsorcier.saisiMatricule.Text), addsorcier.saisiNom.Text, addsorcier.saisiPrenom.Text, Administration.RetournerSexe(addsorcier.saisiSexe.Text), addsorcier.saisiFonction.Text, Administration.RetournerGrade(addsorcier.saisiGrade.Text), addsorcier.Pouvoirs);
                zombillenium.AjouterPersonnel(sorcier);
        }

        private void AjouterSorcier_Click(object sender, RoutedEventArgs e)
        {
            addsorcier.Show();
            addsorcier.Valid.Click += AddWizard;
        }

        private void AddDemon(object sender, RoutedEventArgs e)
        {
            Personnel demon = new Demon(Convert.ToInt32(adddemon.saisiMatricule.Text), adddemon.saisiNom.Text, adddemon.saisiPrenom.Text, Administration.RetournerSexe(adddemon.saisiSexe.Text), adddemon.saisiFonction.Text, Convert.ToInt32(adddemon.saisiCagnotte.Text), adddemon.saisiAffectation.Text, Convert.ToInt32(adddemon.saisiForce.Text));
            zombillenium.AjouterPersonnel(demon);
        }

        private void AjouterDemon_Click(object sender, RoutedEventArgs e)
        {
            adddemon.Show();
            adddemon.Valid.Click += AddDemon;
        }

        private void AddVampire(object sender, RoutedEventArgs e)
        {
            Personnel vampire = new Vampire(Convert.ToInt32(addvampire.saisiMatricule.Text), addvampire.saisiNom.Text, addvampire.saisiPrenom.Text, Administration.RetournerSexe(addvampire.saisiSexe.Text), addvampire.saisiFonction.Text, Convert.ToInt32(addvampire.saisiCagnotte.Text), addvampire.saisiAffectation.Text, Convert.ToDouble(addvampire.saisiLuminosite.Text));
            zombillenium.AjouterPersonnel(vampire);
        }

        private void AjouterVampire_Click(object sender, RoutedEventArgs e)
        {
            addvampire.Show();
            addvampire.Valid.Click += AddVampire;
        }

        private void AddFantome(object sender, RoutedEventArgs e)
        {
            Personnel fantome = new Fantome(Convert.ToInt32(addghost.saisiMatricule.Text), addghost.saisiNom.Text, addghost.saisiPrenom.Text, Administration.RetournerSexe(addghost.saisiSexe.Text), addghost.saisiFonction.Text, Convert.ToInt32(addghost.saisiCagnotte.Text), addghost.saisiAffectation.Text);
            zombillenium.AjouterPersonnel(fantome);
        }

        private void AjouterFantome_Click(object sender, RoutedEventArgs e)
        {
            addghost.Show();
            addghost.Valid.Click += AddFantome;
        }

        private void AddZombie(object sender, RoutedEventArgs e)
        {
            Personnel zombie = new Zombie(Convert.ToInt32(addzombie.saisiMatricule.Text), addzombie.saisiNom.Text, addzombie.saisiPrenom.Text, Administration.RetournerSexe(addzombie.saisiSexe.Text), addzombie.saisiFonction.Text, Convert.ToInt32(addzombie.saisiCagnotte.Text), addzombie.saisiAffectation.Text, Convert.ToInt32(addzombie.saisiDecomposition.Text), Administration.RetournerCouleur(addzombie.saisiTeint.Text));
            zombillenium.AjouterPersonnel(zombie);
        }

        private void AjouterZombie_Click(object sender, RoutedEventArgs e)
        {
            addzombie.Show();
            addzombie.Valid.Click += AddZombie;
        }

        private void AddLoupGarou(object sender, RoutedEventArgs e)
        {
            Personnel loupgarou = new LoupGarou(Convert.ToInt32(addwerewolf.saisiMatricule.Text), addwerewolf.saisiNom.Text, addwerewolf.saisiPrenom.Text, Administration.RetournerSexe(addwerewolf.saisiSexe.Text), addwerewolf.saisiFonction.Text, Convert.ToInt32(addwerewolf.saisiCagnotte.Text), addwerewolf.saisiAffectation.Text, Convert.ToDouble(addwerewolf.saisiCruaute.Text));
            zombillenium.AjouterPersonnel(loupgarou);
        }

        private void AjouterLoupGarou_Click(object sender, RoutedEventArgs e)
        {
            addzombie.Show();
            addzombie.Valid.Click += AddLoupGarou;
        }

        private void AddDarkRide(object sender, RoutedEventArgs e)
        {
            Attraction darkride = new DarkRide(Convert.ToInt32(adddarkride.saisiIdentifiant.Text), adddarkride.saisiNom.Text, Convert.ToInt32(adddarkride.saisiMonstres.Text), Convert.ToBoolean(adddarkride.saisiBesoins.Text), adddarkride.saisiTypes.Text, TimeSpan.Parse(adddarkride.saisiDuree.Text), Convert.ToBoolean(adddarkride.saisiVehicule.Text));
            zombillenium.AjouterAttraction(darkride);
        }

        private void AjouterDarkRide_Click(object sender, RoutedEventArgs e)
        {
            adddarkride.Show();
            adddarkride.Valid.Click += AddDarkRide;
        }

        private void AddRollerCoaster(object sender, RoutedEventArgs e)
        {
            Attraction rollercoaster = new RollerCoaster(Convert.ToInt32(addrollercoaster.saisiIdentifiant.Text), addrollercoaster.saisiNom.Text, Convert.ToInt32(addrollercoaster.saisiMonstres.Text), Convert.ToBoolean(addrollercoaster.saisiBesoins.Text), addrollercoaster.saisiTypes.Text, Administration.RetournerCategorie(addrollercoaster.saisiCategorie.Text), Convert.ToInt32(addrollercoaster.saisiAgeMinimum.Text), Convert.ToDouble(addrollercoaster.saisiTailleMinimum.Text));
            zombillenium.AjouterAttraction(rollercoaster);
        }

        private void AjouterRollerCoaster_Click(object sender, RoutedEventArgs e)
        {
            addrollercoaster.Show();
            addrollercoaster.Valid.Click += AddRollerCoaster;
        }

        private void AddSpectacle(object sender, RoutedEventArgs e)
        {
            Attraction spectacle = new Spectacle(Convert.ToInt32(addshow.saisiIdentifiant.Text), addshow.saisiNom.Text, Convert.ToInt32(addshow.saisiMonstres.Text), Convert.ToBoolean(addshow.saisiBesoins.Text), addshow.saisiTypes.Text, addshow.saisiNomSalle.Text, Convert.ToInt32(addshow.saisiNombrePlace.Text), addshow.Horaires);
            zombillenium.AjouterAttraction(spectacle);
        }

        private void AjouterSpectacle_Click(object sender, RoutedEventArgs e)
        {
            addshow.Show();
            addshow.Valid.Click += AddSpectacle;
        }

        private void AddBoutique(object sender, RoutedEventArgs e)
        {
            Attraction boutique = new Boutique(Convert.ToInt32(addshop.saisiIdentifiant.Text), addshop.saisiNom.Text, Convert.ToInt32(addshop.saisiMonstres.Text), Convert.ToBoolean(addshop.saisiBesoins.Text), addshop.saisiTypes.Text, Administration.RetournerBoutique(addshop.saisiTypeBoutique.Text));
            zombillenium.AjouterAttraction(boutique);
        }

        private void AjouterBoutique_Click(object sender, RoutedEventArgs e)
        {
            addshop.Show();
            addshop.Valid.Click += AddBoutique;
        }


    }
}
