using LibrarieModele;
using MagazinBijuterii;
using NivelAccesDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazinBijuterii
{
    public partial class UCCautareClient : UserControl
    {
        List<Client> clienti;
        IStocareClienti adminClienti = StocareFactory.GetAdministratorStocareClienti();

        public UCCautareClient()
        {
            InitializeComponent();
        }

        private void UCCautareClient_Load(object sender, EventArgs e)
        {
            clienti = adminClienti.GetClienti();
        }

        private void BtnCautaClient_Click(object sender, EventArgs e)
        {
            string nume = TxtNumeClientCautat.Text;
            string prenume = TxtPrenumeClientCautat.Text;

            Client clientAfisare = adminClienti.GetClient(nume, prenume);
            if (clientAfisare == null)
            {
                LblAvertismentCautare.Text = "Acest client nu a fost gasit in baza de date.";
                PnlAfisareClientCautat.Visible = false;
            }
            else
            {
                LblAvertismentCautare.Text = "";
                PnlAfisareClientCautat.Visible = true;
                LblHeaderInfo.Text = Client.HeaderInfo() + "   ";
                LblClientCautat.Text = clientAfisare.ConversieLaSir();
            }
        }
    }
}
