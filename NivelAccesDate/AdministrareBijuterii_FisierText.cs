using LibrarieModele;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace NivelAccesDate
{
    public class AdministrareBijuterii_FisierText : IStocareBijuterii
    {
        //private const int NR_MAX = 500;
        string NumeFisierBijuterii { get; set; }

        public AdministrareBijuterii_FisierText(string NumeFisierBijuterii)
        {

            this.NumeFisierBijuterii = NumeFisierBijuterii;
            Stream streamFisierText = File.Open(NumeFisierBijuterii, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }


        public void AddBijuterie(Bijuterie obiect)
        {
            try
            {
                using (StreamWriter streamWriterFisierText = new StreamWriter(NumeFisierBijuterii, true))
                {
                    streamWriterFisierText.WriteLine(obiect.ConversieLaSir_PentruScriereInFisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului Bijuterii. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

        }

        public void UpdateFisierBijuterii(List<Bijuterie> obiecte)
        {
            using (StreamWriter swFisierTextCamere = new StreamWriter(NumeFisierBijuterii, false))
            {
                foreach (Bijuterie obiect in obiecte)
                    swFisierTextCamere.WriteLine(obiect.ConversieLaSir_PentruScriereInFisier());
            }
        }

        public List<Bijuterie> GetBijuterii()
        {
            List<Bijuterie> obiecte = new List<Bijuterie>();


            try
            {
                using (StreamReader sr = new StreamReader(NumeFisierBijuterii))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Bijuterie bijDinFisier = new Bijuterie(line);
                        obiecte.Add(bijDinFisier);
                        Bijuterie.IdUltimaBijuterie = bijDinFisier.ID_bijuterie;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului Bijuterii. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return obiecte;
        }

        public Bijuterie GetBijuterie(int id)
        {

            try
            {
                using (StreamReader sr = new StreamReader(NumeFisierBijuterii))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {

                        Bijuterie bijDinFisier = new Bijuterie(line);
                        if (bijDinFisier.ID_bijuterie == id)
                            return bijDinFisier;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului Bijuterii. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;

        }

    }
}