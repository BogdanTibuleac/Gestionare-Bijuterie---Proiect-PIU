using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Client : Persoana
    {
        public string NrTelefon { get; set; }
        public string DetaliiProdus { get; set; }
        public DateTime DataActualizare { get; set; }
        public static int IdUltimClient { get; set; } = 0;


        private const char SEPARATOR_PRINCIPAL_FISIER = ',';
        private const int NRTELEFON = 3;
        private const int DETALIIPRODUS = 4;
        private const int DATA_ACTUALIZARE = 5;

        public Client(string _date) : base(_date)
        {
            string[] dateAsArrayOfStrings = _date.Split(SEPARATOR_PRINCIPAL_FISIER);
            NrTelefon = dateAsArrayOfStrings[NRTELEFON];
            DetaliiProdus = dateAsArrayOfStrings[DETALIIPRODUS];
            DataActualizare = DateTime.Parse(dateAsArrayOfStrings[DATA_ACTUALIZARE]);
        }

        static public string HeaderInfo()
        {
            string sf = "{0,-15}{1,-10}{2,-10} {3,-10} {4,-20} {5, 15}";

            return string.Format(sf, "CNP", "Nume", "Prenume", "NrTelefon", "Detalii Produs", "Data Actualizare");
        }

        public override string ConversieLaSir()
        {
            string sf = "{0,-15}{1,-10}{2,-10} {3,-10} {4,-20} {5, 15}";
            string dateForDisplay = string.Format(sf, CNP, Nume, Prenume, NrTelefon, DetaliiProdus, DataActualizare);

            return dateForDisplay;
        }

        public string ConversieLaSir_PentruScriereInFisier()
        {
            string dateForDisplay = $"{CNP},{Nume},{Prenume},{NrTelefon},{DetaliiProdus},{DataActualizare}";

            return dateForDisplay;
        }
    }
}
