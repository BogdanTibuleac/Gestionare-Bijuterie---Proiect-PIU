using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LibrarieModele
{
    public class Bijuterie
    {
        private const char SEPARATOR = '/';

        private const int TIP = 0;
        private const int MATERIAL = 1;
        private const int PIETRE_PRETIOASE = 2;
        private const int IN_STOC = 3;
        private const int PRET = 4;

        public string Tip { get; set; }
        public string Material { get; set; }
        public bool PietrePretioase { get; set; }
        public bool InStoc { get; set; }
        public int Pret { get; set; }


        public Bijuterie() 
        {
            Tip =  string.Empty;
            Material = string.Empty;
            PietrePretioase = false;
            InStoc = true;
            Pret = 0;
        }

        public Bijuterie(string _tip, string _material, bool _pietrepretioase, bool _instoc, int _pret)
        {
            Tip = _tip;
            Material = _material;
            PietrePretioase= _pietrepretioase;
            InStoc = _instoc;
            Pret = _pret;
        }

        public Bijuterie(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR);
            Tip = dateFisier[TIP];
            Material = dateFisier[MATERIAL];
            InStoc = Convert.ToBoolean(dateFisier[IN_STOC]);
            PietrePretioase = Convert.ToBoolean(dateFisier[PIETRE_PRETIOASE]);
            Pret = Convert.ToInt32(dateFisier[PRET]);
        }
        
        public static Bijuterie CitesteDateTastatura()
        {
            Console.WriteLine("Dati tipul bijuteriei:");
            string tip = Console.ReadLine();

            Console.WriteLine("Dati materialul bijuteriei:");
            string material = Console.ReadLine();

            Console.WriteLine("Introduceti (true/false) daca bijuteria are pietre pretioase :");
            bool pietrepretioase = bool.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti (true/false) daca bijuteria este in stoc :");
            bool instoc = bool.Parse(Console.ReadLine());

            Console.WriteLine("Dati pretul bijuteriei:");
            int pret = int.Parse(Console.ReadLine());

            return new Bijuterie(tip, material, pietrepretioase, instoc, pret);
        }
        public string GetTip()
        {
            return Tip;
        }

        public string GetMaterial()
        {
            return Material;
        }

        public int GetPret()
        {
            return Pret;
        }

        public bool GetPietrePretioase()
        {
            return PietrePretioase;
        }

        public bool GetStoc()
        {
            return InStoc;
        }
        public void AfiseazaBijuterie()     
        {
            string string_afisare = string.Format("Bijuteria este de :\n" +
                "Tip: {0} \tMaterial: {1} \tPietre pretioase {2} \tIn Stoc: {3} \tPret: {4}",
                GetTip(),
                GetMaterial(),
                GetPietrePretioase(),
                GetStoc(),
                GetPret());
            Console.WriteLine(string_afisare);
        }
        public string Info()
        {
            string info = string.Format("Tip: {0} \tMaterial: {1} \tPietre pretioase: {2} \tIn Stoc: {3} \tPret: {4}",
                GetTip(),
                GetMaterial(),
                GetPietrePretioase(),
                GetStoc(),
                GetPret());
            return info;
        }
        public string ConversieLaSir_PentruFisier() 
        {
            string string_fisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}",
                SEPARATOR,
                GetTip(),
                GetMaterial(),
                GetPietrePretioase(),
                GetStoc(),
                GetPret());
            return string_fisier;
        }
    }
}
        