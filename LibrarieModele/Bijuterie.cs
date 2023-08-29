using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LibrarieModele
{
    public class Bijuterie
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ',';
        private const int ID_BIJUTERIE = 0;
        private const int DENUMIRE = 1;
        private const int MATERIAL = 2;
        private const int STOC = 3;
        private const int PIETREPRETIOASE = 4;
        private const int TIP = 5;
        private const int PRET = 6;

        public static int IdUltimaBijuterie { get; set; } = 0;
        public int ID_bijuterie { get; set; }
        public string Denumire { get; set; }
        public string Material { get; set; }

        public int Stoc { get; set; }
        public TipBijuterie Tip { get; set; }
        public PietrePretioaseBijuterie PietrePretioase { get; set; }
        public int Pret { get; set; }


        public Bijuterie(string _date)
        {
            string[] dateAsArrayOfStrings = _date.Split(SEPARATOR_PRINCIPAL_FISIER);

            ID_bijuterie = int.Parse(dateAsArrayOfStrings[ID_BIJUTERIE]);
            Denumire = dateAsArrayOfStrings[DENUMIRE];
            Material = dateAsArrayOfStrings[MATERIAL];

            if (int.TryParse(dateAsArrayOfStrings[STOC], out int stoc))
            {
                Stoc = stoc;
            }

            Tip = (TipBijuterie)int.Parse(dateAsArrayOfStrings[TIP]);

            PietrePretioase = (PietrePretioaseBijuterie)0;
            string[] pietrepretioase = dateAsArrayOfStrings[PIETREPRETIOASE].Split('-');
            foreach (string piatrapretioasa in pietrepretioase)
            {
                PietrePretioase |= (PietrePretioaseBijuterie)int.Parse(piatrapretioasa);
            }

            if (int.TryParse(dateAsArrayOfStrings[PRET], out int pret))
            {
                Pret = pret;
            }

        }
        public string ConversieLaSir()
        {
            string sf = "{0,-4} {1,-10} {2,-8} {3,-5} {4,-25} {5,-10} {6,5} {7,-4} ";

            return string.Format(sf, ID_bijuterie, Denumire, Material, Stoc, PietrePretioase, Tip, Pret, "lei");
        }

        static public string HeaderInfo()
        {
            string sf = "{0,-4} {1,-10} {2,-8} {3,-5} {4,-25} {5,-10} {6,5}";

            return string.Format(sf, "ID", "Denumire", "Material", "Stoc", "PietrePretioase", "Tip", "Pret");
        }


        public string ConversieLaSir_PentruScriereInFisier()
        {
            string dateForDisplay = $"{ID_bijuterie},{Denumire},{Material},{Stoc},{(int)PietrePretioase},{(int)Tip},{Pret}";

            return dateForDisplay;
        }
    }
}


