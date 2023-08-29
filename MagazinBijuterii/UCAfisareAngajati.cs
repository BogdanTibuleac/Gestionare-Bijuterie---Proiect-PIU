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
    public partial class UCAfisareAngajati : UserControl
    {

        List<Angajat> angajati;
        IStocareAngajati adminAngajati = StocareFactory.GetAdministratorStocareAngajati();

        public UCAfisareAngajati()
        {
            InitializeComponent();
        }

        private void UCAfisareAngajati_Load(object sender, EventArgs e)
        {
            angajati = adminAngajati.GetAngajati();
        }

        private void PnlAfisareAngajati_VisibleChanged(object sender, EventArgs e)
        {
            if (PnlAfisareAngajati.Visible == true)
            {
                angajati = adminAngajati.GetAngajati();
                LsBxAfisareAngajati.Items.Clear();
                LsBxAfisareAngajati.Items.Add(Angajat.HeaderInfo());
                foreach (Angajat angajat in angajati)
                {
                    LsBxAfisareAngajati.Items.Add(angajat.ConversieLaSir());
                    LsBxAfisareAngajati.ForeColor = Color.Black;
                }
            }
        }

        private void LsBxAfisareAngajati_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LsBxAfisareAngajati.SelectedIndex == 0)
                BtnStergeAngajat.Enabled = false;
            else
            {
                BtnStergeAngajat.Enabled = true;
            }
        }

        private void BtnStergeAngajat_Click(object sender, EventArgs e)
        {
            angajati = adminAngajati.GetAngajati();
            angajati.RemoveAll(r => r.ConversieLaSir() == LsBxAfisareAngajati.SelectedItem.ToString());
            adminAngajati.UpdateFisierAngajati(angajati);
            LsBxAfisareAngajati.Items.Clear();
            LsBxAfisareAngajati.Items.Add(Angajat.HeaderInfo());
            foreach (Angajat angajat in angajati)
            {
                LsBxAfisareAngajati.Items.Add(angajat.ConversieLaSir());
            }
        }

        private void PnlAfisareAngajati_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

