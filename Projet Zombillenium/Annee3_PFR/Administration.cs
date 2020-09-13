using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Annee3_PFR
{
    class Administration
    {
        private List<Attraction> attractions;
        private List<Personnel> toutlePersonnel;

        public Administration()
        {
            attractions = new List<Attraction>();
            toutlePersonnel = new List<Personnel>();
        }

        #region Proprietes
        public List<Attraction> Attractions
        {
            get { return attractions; }
            set { attractions = value; }
        }

        public List<Personnel> ToutlePersonnel
        {
            get { return toutlePersonnel; }
            set { toutlePersonnel = value; }
        }
        #endregion

        #region Ajouter
        public void AjouterAttraction(Attraction a)
        {
            attractions.Add(a);
            Console.WriteLine("\n\nL'attraction suivante a bien ete ajoutee." + a);
        }

        public void AjouterPersonnel(Personnel p)
        {
            toutlePersonnel.Add(p);
            Console.WriteLine("\n\nLe personnel suivant a bien ete ajoute." + p);
        }
        #endregion

        #region Affichage
        public void AffichePersonnel(List<Personnel> liste)
        {
            foreach (Personnel p in liste)
            {
                Console.WriteLine(p);
            }
        }

        public void AfficheAttraction(List<Attraction> liste)
        {
            foreach (Attraction a in liste)
            {
                Console.WriteLine(a);
            }
        }
        #endregion

        #region Tri
        public List<Personnel> TriParVampire(List<Personnel> liste)
        {
            List<Personnel> newlist = new List<Personnel>();
            foreach (Personnel p in liste)
            {
                if (p is Vampire)
                {
                    newlist.Add(p);
                }
            }
            return newlist;
        }

        public List<Personnel> TriParCagnotte(List<Personnel> liste)
        {
            List<Personnel> newlist = new List<Personnel>();
            List<Zombie> zlist = new List<Zombie>();
            foreach (Personnel p in liste)
            {
                if (p is Monstre)
                {
                    Monstre m = (p as Monstre);
                    {
                        if (m is Zombie)
                        {
                            Zombie z = (m as Zombie);
                            zlist.Add(z);
                        }
                    }
                }
            }
            zlist = zlist.OrderBy(z => z.Cagnotte).ToList();
            foreach (Zombie z in zlist)
            {
                newlist.Add(z);
            }
            return newlist;
        }
        #endregion

        #region Ecriture
        public void EcriturePersoCSV(string fichier, List<Personnel> liste)
        {
            StreamWriter file = new StreamWriter(fichier);
            foreach (Personnel p in liste)
            {
                file.WriteLine(p);
            }
            file.Close();
        }
        #endregion

        #region Methodes
        public static TypeSexe RetournerSexe(string sexe)
        {
            TypeSexe sex = TypeSexe.Autre;

            if (sexe == "male")
            {
                sex = TypeSexe.Male;
            }
            if (sexe == "femelle")
            {
                sex = TypeSexe.Femelle;
            }

            return sex;
        }

        public static Grade RetournerGrade(string grade)
        {
            Grade grad = Grade.Novice;

            if (grade == "mega")
            {
                grad = Grade.Mega;
            }
            if (grade == "giga")
            {
                grad = Grade.Giga;
            }
            if (grade == "strata")
            {
                grad = Grade.Strata;
            }

            return grad;
        }

        public static CouleurZ RetournerCouleur(string couleur)
        {
            CouleurZ color = CouleurZ.Bleuatre;
            if (couleur == "grisatre")
            {
                color = CouleurZ.Grisatre;
            }

            return color;
        }

        public static TypeBoutique RetournerBoutique(string boutique)
        {
            TypeBoutique shop = TypeBoutique.BarbeAPapa;

            if (boutique == "souvenir")
            {
                shop = TypeBoutique.Souvenir;
            }
            if (boutique == "nourriture")
            {
                shop = TypeBoutique.Nourriture;
            }

            return shop;
        }

        public static TypeCategorie RetournerCategorie(string categorie)
        {
            TypeCategorie cat = TypeCategorie.Bobsleigh;

            if (categorie == "assise")
            {
                cat = TypeCategorie.Assise;
            }
            if (categorie == "inversee")
            {
                cat = TypeCategorie.Inversee;
            }

            return cat;
        }

        public static DateTime[] RetournerTableau(string[] tableau)
        {
            DateTime[] tab = new DateTime[tableau.Length];

            for (int i = 0; i < tableau.Length; i++)
            {
                tab[i] = Convert.ToDateTime(tableau[i]);
            }

            return tab;
        }
        #endregion

        #region Variation Cagnotte
        public void AugmenterCagnotte(Monstre mstr, int e)
        {
            mstr.Cagnotte += e;
        }

        public void DiminuerCagnotte(Monstre mstr, int e)
        {
            mstr.Cagnotte -= e;
        }

        public void AffectationEnFctDeCagnotte(List<Personnel> liste)
        {
            foreach (Personnel p in liste)
            {
                if (p is Monstre)
                {
                    Monstre m = (p as Monstre);
                    if (m.Cagnotte < 50)
                    {
                        m.Affectation = "Stand barbe a papa";
                    }
                    if ((m is Zombie || m is Demon) && m.Cagnotte > 500)
                    {
                        m.Affectation = "parc";
                    }
                }
            }
        }

        #endregion

        #region Lire CSV
        public void Lire(string fichier)
        {
            int counter = 0;
            string line;
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(fichier);
                while ((line = file.ReadLine()) != null)
                {
                    string[] values = line.Split(';');

                    if (values[0] == "Sorcier")
                    {
                        TypeSexe s = RetournerSexe(values[4]);
                        Grade g = RetournerGrade(values[6]);
                        List<string> pouvoirsDuSorcier = new List<string>();
                        string[] pouvoirs = values[7].Split('-');
                        for (int i = 0; i < pouvoirs.Length; i++)
                        {
                            pouvoirsDuSorcier.Add(pouvoirs[i]);
                        }
                        Sorcier wizard = new Sorcier(Convert.ToInt32(values[1]), values[2], values[3], s, values[5], g, pouvoirsDuSorcier);
                        toutlePersonnel.Add(wizard);
                    }

                    if (values[0] == "Monstre")
                    {
                        TypeSexe s = RetournerSexe(values[4]);
                        Monstre monster = new Monstre(Convert.ToInt32(values[1]), values[2], values[3], s, values[5], Convert.ToInt32(values[6]), values[7]);
                        toutlePersonnel.Add(monster);
                    }

                    if (values[0] == "Demon")
                    {
                        TypeSexe s = RetournerSexe(values[4]);
                        Demon dem = new Demon(Convert.ToInt32(values[1]), values[2], values[3], s, values[5], Convert.ToInt32(values[6]), values[7], Convert.ToInt32(values[8]));
                        toutlePersonnel.Add(dem);
                    }

                    if (values[0] == "Fantome")
                    {
                        TypeSexe s = RetournerSexe(values[4]);
                        Fantome fant = new Fantome(Convert.ToInt32(values[1]), values[2], values[3], s, values[5], Convert.ToInt32(values[6]), values[7]);
                        toutlePersonnel.Add(fant);
                    }

                    if (values[0] == "LoupGarou")
                    {
                        TypeSexe s = RetournerSexe(values[4]);
                        LoupGarou loup = new LoupGarou(Convert.ToInt32(values[1]), values[2], values[3], s, values[5], Convert.ToInt32(values[6]), values[7], Convert.ToDouble(values[8]));
                        toutlePersonnel.Add(loup);
                    }

                    if (values[0] == "Vampire")
                    {
                        TypeSexe s = RetournerSexe(values[4]);
                        Vampire vamp = new Vampire(Convert.ToInt32(values[1]), values[2], values[3], s, values[5], Convert.ToInt32(values[6]), values[7], Convert.ToDouble(values[8]));
                        toutlePersonnel.Add(vamp);
                    }

                    if (values[0] == "Zombie")
                    {
                        TypeSexe s = RetournerSexe(values[4]);
                        CouleurZ c = RetournerCouleur(values[8]);
                        Zombie zomb = new Zombie(Convert.ToInt32(values[1]), values[2], values[3], s, values[5], Convert.ToInt32(values[6]), values[7], Convert.ToInt32(values[9]), c);
                        toutlePersonnel.Add(zomb);
                    }

                    if (values[0] == "Boutique")
                    {
                        TypeBoutique b = RetournerBoutique(values[6]);
                        Boutique shop = new Boutique(Convert.ToInt32(values[1]), values[2], Convert.ToInt32(values[3]), Convert.ToBoolean(values[4]), values[5], b);
                        attractions.Add(shop);
                    }

                    if (values[0] == "DarkRide")
                    {
                        DarkRide dk = new DarkRide(Convert.ToInt32(values[1]), values[2], Convert.ToInt32(values[3]), Convert.ToBoolean(values[4]), values[5], TimeSpan.Parse(values[6]), Convert.ToBoolean(values[7]));
                        attractions.Add(dk);
                    }

                    if (values[0] == "RollerCoaster")
                    {
                        TypeCategorie cat = RetournerCategorie(values[6]);
                        RollerCoaster rc = new RollerCoaster(Convert.ToInt32(values[1]), values[2], Convert.ToInt32(values[3]), Convert.ToBoolean(values[4]), values[5], cat, Convert.ToInt32(values[7]), Convert.ToDouble(values[8]));
                        attractions.Add(rc);
                    }

                    else if (values[0] == "Spectacle")
                    {
                        List<DateTime> horaires = new List<DateTime>();
                        string[] heures = values[8].Split(' ');
                        DateTime[] t = RetournerTableau(heures);
                        for (int i = 0; i < t.Length; i++)
                        {
                            horaires.Add(t[i]);
                        }

                        Spectacle spec = new Spectacle(Convert.ToInt32(values[1]), values[2], Convert.ToInt32(values[3]), Convert.ToBoolean(values[4]), values[5], values[6], Convert.ToInt32(values[7]), horaires);
                        attractions.Add(spec);
                    }
                    counter++;
                }
                file.Close();
                System.Console.WriteLine("Il y a {0} entites.", counter);
            }

            catch (Exception e)
            {
                Console.WriteLine("Erreur de chargement du fichier: '{0}'", e);
            }
        }
        #endregion
    }
}
