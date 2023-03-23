using LibrarieModele;
using System;
using System.IO;

namespace NivelAccesDate
{
    public class AdministrareBijuterii_FisierText
    {
        private const int NR_MAX = 50;
        private string numeFisier;

        public AdministrareBijuterii_FisierText(string numeFisier)
        {
            if (numeFisier == null)
            {
                throw new ArgumentNullException(nameof(numeFisier), "File name cannot be null.");
            }

            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }


        public void AddBijuterie(Bijuterie obiect)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(obiect.ConversieLaSir_PentruFisier());
            }
        }

        public Bijuterie[] GetBijuterie(out int nrBijuterii)
        {
            Bijuterie[] obiect = new Bijuterie[NR_MAX];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrBijuterii = 0;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    obiect[nrBijuterii++] = new Bijuterie(linieFisier);
                }
            }

            return obiect;
        }
    }
}