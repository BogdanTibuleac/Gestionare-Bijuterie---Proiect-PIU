using LibrarieModele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAccesDate
{
    public interface IStocareBijuterii
    {
        void AddBijuterie(Bijuterie obiect);
        void UpdateFisierBijuterii(List<Bijuterie> obiecte);

        List<Bijuterie> GetBijuterii();

        Bijuterie GetBijuterie(int id);
    }
}
