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
    public partial class UCAdaugareAngajat : UserControl
    {
        private const int CNP_LENGTH = 13;
        private const int LIMIT = 0;
        List<Angajat> angajati;
        IStocareAngajati adminAngajati = StocareFactory.GetAdministratorStocareAngajati();

        public UCAdaugareAngajat()
        {
            InitializeComponent();
            cbxFunctieAngajat.SelectedItem = null;
        }

        private void UCAdaugareAngajat_Load(object sender, EventArgs e)
        {
            angajati = adminAngajati.GetAngajati();
        }

        private void BtnAdaugaAngajat_Click(object sender, EventArgs e)
        {
            angajati = adminAngajati.GetAngajati();
            if (DateValide())
            {
                if (Exista(TxtNumeAngajat.Text, TxtPrenumeAngajat.Text, TxtCNPAngajat.Text))
                {
                    LblAdaugareAngajatAvertisment.Text = "*Angajatul este deja introdus in sistem!";
                    return;
                }

                string line = $"{TxtCNPAngajat.Text},{TxtNumeAngajat.Text},{TxtPrenumeAngajat.Text},{cbxFunctieAngajat.SelectedItem},{TxtSalariuAngajat.Text},{DateTime.Now.ToString()}";

                angajati.Add(new Angajat(line));
                adminAngajati.AddAngajat(new Angajat(line));
                ResetareControale();
                LblAdaugareAngajatAvertisment.Text = "Angajatul a fost adaugat cu succes!";
            }

        }

        private bool Exista(string nume, string prenume, string _CNP)
        {
            return angajati.Any(s => s.Nume == nume && s.Prenume == prenume && s.CNP == _CNP);
        }

        bool DateValide()
        {
            LblAdaugareAngajatAvertisment.ForeColor = Color.Firebrick;
            if (TxtNumeAngajat.Text == "" || TxtPrenumeAngajat.Text == "" || TxtCNPAngajat.Text == "" || TxtSalariuAngajat.Text == "" || cbxFunctieAngajat.SelectedItem == null)
            {
                LblAdaugareAngajatAvertisment.Text = "*Trebuie completate toate campurile!";
                return false;
            }
            if (!Functii.OnlyLetters(TxtNumeAngajat.Text))
            {
                LblAdaugareAngajatAvertisment.Text = "*Numele trebuie sa contina doar litere!";
                return false;
            }
            if (!Functii.OnlyDigits(TxtCNPAngajat.Text))
            {
                LblAdaugareAngajatAvertisment.Text = "*CNP-ul trebuie sa contina doar cifre!";
                return false;
            }
            if (!Functii.OnlyLetters(TxtNumeAngajat.Text))
            {
                LblAdaugareAngajatAvertisment.Text = "*Numele trebuie sa contina doar litere!";
                return false;
            }
            if (!Functii.OnlyLetters(TxtPrenumeAngajat.Text))
            {
                LblAdaugareAngajatAvertisment.Text = "*Prenumele trebuie sa contina doar litere!";
                return false;
            }
            if (TxtCNPAngajat.TextLength != CNP_LENGTH)
            {
                LblAdaugareAngajatAvertisment.Text = "*CNP-ul trebuie sa aiba lungimea 13!";
                return false;
            }
            if (!Functii.OnlyDigits(TxtCNPAngajat.Text))
            {
                LblAdaugareAngajatAvertisment.Text = "*CNP-ul trebuie sa contina doar cifre!";
                return false;
            }
            if (!Functii.IsFloatNumber(TxtSalariuAngajat.Text))
            {
                LblAdaugareAngajatAvertisment.Text = "*Salariul introdus este invalid!";
                return false;
            }
            if (float.Parse(TxtSalariuAngajat.Text) < LIMIT)
            {
                LblAdaugareAngajatAvertisment.Text = "*Salariul introdus nu poate fi negativ!";
                return false;
            }
            LblAdaugareAngajatAvertisment.ForeColor = Color.White;
            return true;
        }

        void ResetareControale()
        {
            TxtNumeAngajat.Text = "";
            TxtPrenumeAngajat.Text = "";
            TxtCNPAngajat.Text = "";
            TxtSalariuAngajat.Text = "";
            cbxFunctieAngajat.SelectedItem = null;
        }
    }
}
