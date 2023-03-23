using System;
using System.Configuration;
using LibrarieModele;
using NivelAccesDate;

namespace EvidentaStudenti_Consola
{
    class Program
    {
        static void Main()
        {
            Bijuterie obiect = new Bijuterie();
            string numeFisier = ConfigurationManager.AppSettings["Arhiva.txt"];
            AdministrareBijuterii_FisierText adminBijuterie = new AdministrareBijuterii_FisierText("Arhiva.txt");
            int nrBijuterii = 0;
            adminBijuterie.GetBijuterie(out nrBijuterii);

            string optiune;
            do
            {
                Console.WriteLine("I. Introducere informatii OBIECT pretios");
                Console.WriteLine("F. Afisare OBIECTE din fisier");
                Console.WriteLine("S. Salvare OBIECT in fisier");
                Console.WriteLine("N. Cauta si afiseaza cel mai ieftin OBIECT");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "I":
                        obiect = CitireBijuterieTastatura();

                        break;
                    case "F":
                        Bijuterie[] obiecte = adminBijuterie.GetBijuterie(out nrBijuterii);
                        AfisareBijuterie(obiecte, nrBijuterii);

                        break;
                    case "S":

                        adminBijuterie.AddBijuterie(obiect);

                        nrBijuterii = nrBijuterii + 1;

                        break;
                    case "N":
                        if (nrBijuterii > 0)
                        {
                            Bijuterie bijuterieCuCelMaiMicPret = obiecte[0];

                            for (int i = 1; i < nrBijuterii; i++)
                            {
                                if (obiecte[i].GetPret() < bijuterieCuCelMaiMicPret.GetPret())
                                {
                                    bijuterieCuCelMaiMicPret = obiecte[i];
                                }
                            }

                            Console.WriteLine($"Bijuterie cu cel mai mic pret:\nTip: {bijuterieCuCelMaiMicPret.GetTip()}\nMaterial: {bijuterieCuCelMaiMicPret.GetMaterial()}\nPret: {bijuterieCuCelMaiMicPret.GetPret()}");
                        }
                        else
                        {
                            Console.WriteLine("Nu s-au gasit bijuterii.");
                        }
                        
                        break;
                    case "X":

                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");

                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }

        public static void AfisareBijuterie(Bijuterie obiect)
        {
            string infoBijuterie = string.Format("Bijuteria costa {0} este de tip {1}, material {2}",
                   obiect.GetPret(),
                   obiect.GetTip() ?? " NECUNOSCUT ",
                   obiect.GetMaterial() ?? " NECUNOSCUT ");

            Console.WriteLine(infoBijuterie);
        }

        public static void AfisareBijuterie(Bijuterie[] obiecte, int nrBijuterii)
        {
            Console.WriteLine("Bijuteriile in stoc sunt:");
            for (int contor = 0; contor < nrBijuterii; contor++)
            {
                AfisareBijuterie(obiecte[contor]);
            }
        }

        public static Bijuterie CitireBijuterieTastatura()
        {
            Console.WriteLine("Introduceti tip");
            string tip = Console.ReadLine();

            Console.WriteLine("Introduceti material");
            string material = Console.ReadLine();

            Console.WriteLine("Introduceti pret");
            string pret = Console.ReadLine();

            Bijuterie obiect = new Bijuterie (tip, material, Convert.ToInt32(pret));

            return obiect;
        }
    }
}
