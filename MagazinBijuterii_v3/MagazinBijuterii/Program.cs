using System;
using System.Configuration;
using LibrarieModele;
using NivelAccesDate;
using NivelStocareDate;

namespace Evidenta_Consola
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


            Persoana p = new Persoana();
            string numeFisier2 = ConfigurationManager.AppSettings["Persoane.txt"];
            AdministrarePersoane_FisierText adminPersoane = new AdministrarePersoane_FisierText("Persoane.txt");
            int nrPersoane = 0;
            adminPersoane.GetPersoane(out nrPersoane);


            string optiune;
            do
            {
                Console.WriteLine("_________________________________________________\n");
                Console.WriteLine("I. Introducere informatii OBIECT");
                Console.WriteLine("A. Afisare informatii despre ultimul OBIECT");
                Console.WriteLine("F. Afisare OBIECTE din fisier");
                Console.WriteLine("S. Salvare OBIECT in fisier");
                Console.WriteLine("N. Cauta dupa anumite criterii un OBIECT\n");

                Console.WriteLine("IP. Introducere informatii PERSOANA");
                Console.WriteLine("AP. Afisare informatii despre ultima PERSOANA");
                Console.WriteLine("FP. Afisare PERSOANA din fisier");
                Console.WriteLine("SP. Salvare PERSOANA in fisier");

                Console.WriteLine("X. Inchidere program\n");
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {

                    case "IP":
                        p = Persoana.CitesteDateTastatura();
                        break;

                    case "AP":
                        p.AfiseazaPersoana();
                        break;

                    case "FP":
                        Persoana[] pers = adminPersoane.GetPersoane(out nrPersoane);
                        AfisarePersoane(pers, nrPersoane);
                        //Persoana[] persoane = adminPersoane.GetPersoane(out nrPersoane);
                        //AfisarePersoane(persoane, nrPersoane);
                        break;
                    case "SP":
                        adminPersoane.AddPersoana(p);
                        nrPersoane += 1;
                        //adminPersoane.AddPersoana(p);
                        //nrPersoane = nrPersoane + 1;
                        break;


                    case "I":
                        obiect = Bijuterie.CitesteDateTastatura();
                        break;

                    case "A":
                        obiect.AfiseazaBijuterie();
                        break;

                    case "F":
                        Bijuterie[] obiecte = adminBijuterie.GetBijuterie(out nrBijuterii);
                        AfisareBijuterii(obiecte, nrBijuterii);
                        break;

                    case "S":
                        adminBijuterie.AddBijuterie(obiect);
                        nrBijuterii += 1;
                        break;

                    case "N":
                        Bijuterie[] Bijuterii = adminBijuterie.GetBijuterie(out nrBijuterii);
                        Console.WriteLine("Puteti alege dupa urmatoarele criterii:  Tip | Material | Pret");
                        Cautare(Console.ReadLine(), nrBijuterii, Bijuterii);
                        break;

                    case "X":
                        return;

                    default:
                        Console.WriteLine("Optiunea nu exista!\n");
                        break;

                }
            } while (optiune.ToUpper() != "X");
            Console.ReadKey();
        }


        public static void AfisarePersoana(Persoana p)
        {
            string string_afisare = string.Format("Persoana are CNP {0} \tNume: {1} \tPrenume: {2}\n",
                p.GetCNP(),
                p.GetNume(),
                p.GetPrenume());
            Console.WriteLine(string_afisare);
        }

        public static void AfisarePersoane(Persoana[] persoane, int nrPersoane)
        {
            Console.WriteLine("Persoanele sunt : ");
            for (int i = 0; i < nrPersoane; i++)
            {
                AfisarePersoana(persoane[i]);
            }
        }


        public static void AfisareBijuterie(Bijuterie obiect)
        {
            string string_afisare = string.Format("Tip: {0} \tMaterial: {1} \tPietre pretioase: {2} \tIn Stoc: {3} \tPret: {4}",
                obiect.GetTip(),
                obiect.GetMaterial(),
                obiect.GetPietrePretioase(),
                obiect.GetStoc(),
                obiect.GetPret());
            Console.WriteLine(string_afisare);
        }

        public static void AfisareBijuterii(Bijuterie[] obiecte, int nrBijuterii) 
        {
            Console.WriteLine("Bijuteriile sunt : ");
            for (int i = 0; i < nrBijuterii; i++)
            {
                AfisareBijuterie(obiecte[i]);
            }
        }

        public static void Cautare(string criteriu, int nrBijuterii, Bijuterie[] bijuterii)
        {
            switch(criteriu)
            {
                case "Tip":
                    Console.WriteLine("Introduceti tipul obiectelor pentru cautare: ");
                    string date = Console.ReadLine();
                    Console.WriteLine("S-au gasit urmatoarele obiecte cu proprietati similare: ");
                    for (int i = 0; i < nrBijuterii; i++)
                        if (bijuterii[i].GetTip() == date)
                            Console.WriteLine(bijuterii[i].Info());
                    break;

                case "Material":
                    Console.WriteLine("Introduceti materialul obiectelor pentru cautare: ");
                     date = Console.ReadLine();
                    Console.WriteLine("S-au gasit urmatoarele obiecte cu proprietati similare: ");
                    for (int i = 0; i < nrBijuterii; i++)
                        if (bijuterii[i].GetMaterial() == date)
                            Console.WriteLine(bijuterii[i].Info());
                    break;

                case "Pret":
                    Console.WriteLine("Introduceti bugetul dvs: ");
                    date = Console.ReadLine();
                    Console.WriteLine("S-au gasit urmatoarele obiecte ce se incadreaza in bugetul selectat: ");
                    for (int i = 0; i < nrBijuterii; i++)
                        if (bijuterii[i].GetPret() <= Convert.ToInt32(date))
                            Console.WriteLine(bijuterii[i].Info());
                    break;
                default:
                    Console.WriteLine("Optiunea nu exista!");
                    break;
            }
        }
    }
}