using System;

namespace LibrarieModele
{
    public class Bijuterie
    {
        //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int TIP = 0;
        private const int MATERIAL = 1;
        private const int PRET = 2;

        private int pret; 
        private string tip;
        private string material;

        //contructor implicit
        public Bijuterie()
        {
            tip = material = string.Empty;
        }

        //constructor cu parametri
        public Bijuterie(string tip, string material, int pret)
        {
            this.pret = pret;
            this.tip = tip;
            this.material = material;
        }

        //constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public Bijuterie(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            tip = dateFisier[TIP];
            material = dateFisier[MATERIAL];
            pret = Convert.ToInt32(dateFisier[PRET]);

        }

        public string Info()
        {
            string info = string.Format("TIP:{0} MATERIAL:{1} PRET: {2}",
                (tip ?? " NECUNOSCUT "),
                (material ?? " NECUNOSCUT "),
                pret.ToString());

            return info;
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectStudentPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                (tip ?? " NECUNOSCUT "),
                (material ?? " NECUNOSCUT "),
                pret.ToString());

            return obiectStudentPentruFisier;
        }

        public int GetPret()
        {
            return pret;
        }

        public string GetTip()
        {
            return tip;
        }

        public string GetMaterial()
        {
            return material ;
        }

    }
}
