using LibrarieModele;
using System;
using System.IO;

namespace NivelStocareDate
{
    public class AdministrarePersoane_FisierText
    {
        private const int NR_MAX = 500;
        private string numeFisier;

        public AdministrarePersoane_FisierText(string numeFisier)
        {
            if (numeFisier == null)
            {
                throw new ArgumentNullException(nameof(numeFisier), "File name cannot be null.");
            }

            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }


        public void AddPersoana(Persoana p)
        {

            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(p.ConversieLaSir_PentruFisier());
            }
        }

        public Persoana[] GetPersoane(out int nrPersoane)
        {
            Persoana[] persoane = new Persoana[NR_MAX];

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrPersoane = 0;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    persoane[nrPersoane++] = new Persoana(linieFisier);
                }
            }

            return persoane;
        }
    }
}