using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LibrarieModele
{
    public class Persoana
    {
        private const char SEPARATOR = '/';

        private const int CNP_POZ = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;
 

        public string CNP { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }



        public Persoana()
        {
            CNP = string.Empty;
            Nume = string.Empty;
            Prenume = string.Empty;
        }

        public Persoana(string _cnp, string _nume, string _prenume)
        {
            CNP = _cnp;
            Nume = _nume;
            Prenume = _prenume;
        }

        public Persoana(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR);
            CNP = dateFisier[CNP_POZ];
            Nume = dateFisier[NUME];
            Prenume = dateFisier[PRENUME];
        }

        public static Persoana CitesteDateTastatura()
        {
            Console.WriteLine("Dati CNP :");
            string CNP = Console.ReadLine();

            Console.WriteLine("Dati nume :");
            string nume = Console.ReadLine();

            Console.WriteLine("Dati prenume:");
            string prenume = Console.ReadLine();

            

            return new Persoana(CNP, nume, prenume);
        }
        public string GetCNP()
        {
            return CNP;
        }

        public string GetNume()
        {
            return Nume;
        }

        public string GetPrenume()
        {
            return Prenume;
        }

        
        public void AfiseazaPersoana()
        {
            string string_afisare = string.Format("Persoana are CNP {0} \tNume: {1} \tPrenume: {2}\n",
                GetCNP(),
                GetNume(),
                GetPrenume());

            Console.WriteLine(string_afisare);
        }
        public string Info()
        {
            string info = string.Format("Persoana are CNP {0} \tNume: {1} \tPrenume: {2}",
                GetCNP(),
                GetNume(),
                GetPrenume());
            return info;
        }
        public string ConversieLaSir_PentruFisier()
        {
            string string_fisier = string.Format("{1}{0}{2}{0}{3}",
                SEPARATOR,
                GetCNP(),
                GetNume(),
                GetPrenume());
            return string_fisier;
        }
    }
}
