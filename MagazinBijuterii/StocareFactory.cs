using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NivelAccesDate;

namespace MagazinBijuterii
{
    public static class StocareFactory
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER_BIJUTERII = "NumeFisierBijuterii";
        private const string NUME_FISIER_ANGAJATI = "NumeFisierAngajati";
        private const string NUME_FISIER_CLIENTI = "NumeFisierClienti";
        private const string NUME_FISIER_PAROLA = "NumeFisierParola";


        public static IStocareParola GetAdministratorStocareParola()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisierParola = ConfigurationManager.AppSettings[NUME_FISIER_PAROLA];

            if (formatSalvare != null)
            {
                return new AdministrareParola_FisierText($"{numeFisierParola}.{formatSalvare}");
            }

            return null;
        }
        public static IStocareBijuterii GetAdministratorStocareBijuterii()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisierBijuterii = ConfigurationManager.AppSettings[NUME_FISIER_BIJUTERII];

            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "txt":
                        return new AdministrareBijuterii_FisierText($"{numeFisierBijuterii}.{formatSalvare}");
                }
            }

            return null;
        }

        public static IStocareClienti GetAdministratorStocareClienti()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisierClienti = ConfigurationManager.AppSettings[NUME_FISIER_CLIENTI];

            if (formatSalvare != null)
            {
                return new AdministrareClienti_FisierText($"{numeFisierClienti}.{formatSalvare}");
            }

            return null;
        }
        public static IStocareAngajati GetAdministratorStocareAngajati()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisierAngajati = ConfigurationManager.AppSettings[NUME_FISIER_ANGAJATI];

            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "txt":
                        return new AdministrareAngajati_FisierText($"{numeFisierAngajati}.{formatSalvare}");
                }
            }

            return null;
        }
    }
}
