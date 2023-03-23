using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bijuterii
{
    class Bijuterie
    {
        string tip; //inel, cercei, medalion,pandantiv, etc
        string producator;
        string material; //aur, argint, bronz, aliaj
        long pret_per_unitate;
        long cantitate;

        public string getTip()
        {
            return tip;
        }

        public string getProducator()
        {
            return producator;
        }

        public string getMaterial()
        {
            return material;
        }

        public long getPret()
        {
            return pret_per_unitate;
        }

        public long getCantitate()
        {
            return cantitate;
        }

        public Bijuterie()
        {
            tip = string.Empty;
            producator = string.Empty;
            material = string.Empty;
            pret_per_unitate = 0;
            cantitate = 0;
        }
        public Bijuterie(string _tip, string _producator, string _material, long _pret_per_unitate, long _cantitate)
        {
            tip = _tip;
            producator = _producator;
            material = _material;
            pret_per_unitate = _pret_per_unitate;
            cantitate = _cantitate;

        }

        public Bijuterie(string sir)
        {
            int i = 0;
            string[] date = sir.Split(',');
            foreach (var cuvant in date)
            {
                if (i == 0)
                {
                    tip = cuvant;
                }
                if (i == 1)
                {
                    producator = cuvant;
                }
                if (i == 2)
                {
                    material = cuvant;
                }
                if (i == 3)
                {
                    pret_per_unitate = Convert.ToInt64(cuvant);
                }
                if (i == 4)
                {
                    cantitate = Convert.ToInt64(cuvant);
                }
                i++;
            }
        }
        public string afisare()
        {
            return string.Format("Bijuterie: {0}, producator: {1}, material: {2}, pret pe unitate: {3}, cantitate: {4}\n", tip, producator, material, pret_per_unitate, cantitate);
        }
        public int verifPret(long buget)
        {
            if (buget >= pret_per_unitate)
                return 1;
            else
                return 0;
        }

    }
}