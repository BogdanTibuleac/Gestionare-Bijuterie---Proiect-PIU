using LibrarieModele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAccesDate
{
    public interface IStocareClienti
    {
        void AddClient(Client c);
        void UpdateFisierClienti(List<Client> clienti);
        List<Client> GetClienti();
        Client GetClient(string nume, string prenume);

    }
}
