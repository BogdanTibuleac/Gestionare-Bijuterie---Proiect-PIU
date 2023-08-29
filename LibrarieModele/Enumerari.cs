using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public enum TipBijuterie
    {
        inel = 0,
        pandantiv = 1,
        colier = 2,
        bratara = 3,
        cercei = 4
    }

    [Flags]
    public enum PietrePretioaseBijuterie
    {
        Niciuna = 0,
        Diamant = 1,
        Smarald = 2,
        Rubin = 4,
        Cristal = 8,
        Safir = 16,
        Perle = 32
    };

}
