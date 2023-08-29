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
    public partial class UCCautareAngajat : UserControl
    {
        List<Angajat> angajati;
        IStocareAngajati adminAngajati = StocareFactory.GetAdministratorStocareAngajati();

        public UCCautareAngajat()
        {
            InitializeComponent();
        }


        private void UCCautareAngajat_Load(object sender, EventArgs e)
        {
            angajati = adminAngajati.GetAngajati();
        }

        private void BtnCautaAngajat_Click(object sender, EventArgs e)
        {
            string nume = TxtNumeAngajatCautat.Text;
            string prenume = TxtPrenumeAngajatCautat.Text;

            Angajat angajatAfisare = adminAngajati.GetAngajat(nume, prenume);
            if (angajatAfisare == null)
            {
                LblAvertismentCautare.Text = "Acest angajat nu a fost gasit in baza de date.";
                PnlAfisareAngajatCautat.Visible = false;
            }
            else
            {
                LblAvertismentCautare.Text = "";
                PnlAfisareAngajatCautat.Visible = true;
                LblHeaderInfo.Text = Angajat.HeaderInfo() + "   ";
                //LblHeaderInfo.ForeColor = Color.Black;
                LblAngajatCautat.Text = angajatAfisare.ConversieLaSir();
                //LblAngajatCautat.ForeColor = Color.Black;
            }
        }

        private void UCCautareAngajat_VisibleChanged(object sender, EventArgs e)
        {
            LblAvertismentCautare.Text = "";
        }

        private void PnlCautareAngajat_VisibleChanged(object sender, EventArgs e)
        {
            LblAvertismentCautare.Text = "";
        }
    }
}