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
    public partial class UCModificareBijuterie : UserControl
    {

        List<Bijuterie> obiecte;
        IStocareBijuterii adminBijuterii = StocareFactory.GetAdministratorStocareBijuterii();
        int nrBijuterii;
        PietrePretioaseBijuterie PPSelectate = new PietrePretioaseBijuterie();
        public UCModificareBijuterie()
        {
            InitializeComponent();
            PnlDateBijuterie.Visible = false;

        }

        private void BtnCautaBijuterie_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtIDBijuterie.Text);

            Bijuterie bijuterieAfisare = adminBijuterii.GetBijuterie(id);
            if (bijuterieAfisare == null)
            {
                LblAvertismentCautareBijuterie.Text = "*Aceasta bijuterie nu a fost gasita in baza de date.";
                PnlDateBijuterie.Visible = false;
            }
            else
            {
                LblAvertismentCautareBijuterie.Text = "";
                PnlDateBijuterie.Visible = true;
                TxtDenumireBijuterie.Text = bijuterieAfisare.Denumire;
                TxtMaterialBijuterie.Text = bijuterieAfisare.Material;
                TxtPretBijuterie.Text = "" + bijuterieAfisare.Pret;
                TxtStocBijuterie.Text = "" + bijuterieAfisare.Stoc;


            }
            if (bijuterieAfisare.Tip.ToString() == RBtnBratara.Text)
                RBtnBratara.Checked = true;
            else if (bijuterieAfisare.Tip.ToString() == RBtnInel.Text)
                RBtnInel.Checked = true;
            else if (bijuterieAfisare.Tip.ToString() == RBtnPandantiv.Text)
                RBtnPandantiv.Checked = true;
            else if (bijuterieAfisare.Tip.ToString() == RBtnCercei.Text)
                RBtnCercei.Checked = true;
            else if (bijuterieAfisare.Tip.ToString() == RBtnColier.Text)
                RBtnColier.Checked = true;

            string ppstring = bijuterieAfisare.PietrePretioase.ToString();
            if (ppstring.Contains(ChBxCristal.Text))
                ChBxCristal.Checked = true;
            else
                ChBxCristal.Checked = false;

            if (ppstring.Contains(ChBxDiamant.Text))
                ChBxDiamant.Checked = true;
            else
                ChBxDiamant.Checked = false;

            if (ppstring.Contains(ChBxPerle.Text))
                ChBxPerle.Checked = true;
            else
                ChBxPerle.Checked = false;

            if (ppstring.Contains(ChBxRubin.Text))
                ChBxRubin.Checked = true;
            else
                ChBxRubin.Checked = false;

            if (ppstring.Contains(ChBxSafir.Text))
                ChBxSafir.Checked = true;
            else
                ChBxSafir.Checked = false;

            if (ppstring.Contains(ChBxSmarald.Text))
                ChBxSmarald.Checked = true;
            else
                ChBxSmarald.Checked = false;


        }

        private void BtnModificaBijuterie_Click(object sender, EventArgs e)
        {
            obiecte = adminBijuterii.GetBijuterii();
            int id = int.Parse(TxtIDBijuterie.Text);
            Bijuterie bijuterieAfisare = adminBijuterii.GetBijuterie(id);

            if (TxtDenumireBijuterie.Text != "" &&
                TxtMaterialBijuterie.Text != "" &&
                TxtPretBijuterie.Text != "" &&
                TxtStocBijuterie.Text != "")
            {
                TipBijuterie t = new TipBijuterie();
                if (RBtnBratara.Checked) t = TipBijuterie.bratara;
                else if (RBtnCercei.Checked) t = TipBijuterie.cercei;
                else if (RBtnColier.Checked) t = TipBijuterie.colier;
                else if (RBtnInel.Checked) t = TipBijuterie.inel;
                else if (RBtnPandantiv.Checked) t = TipBijuterie.pandantiv;

                int i = 0;
                while (obiecte[i].ID_bijuterie != bijuterieAfisare.ID_bijuterie)
                { i++; }

                obiecte[i].Denumire = TxtDenumireBijuterie.Text;
                obiecte[i].Material = TxtMaterialBijuterie.Text;
                obiecte[i].Pret = int.Parse(TxtPretBijuterie.Text);
                obiecte[i].Stoc = int.Parse(TxtStocBijuterie.Text);
                obiecte[i].Tip = t;
                obiecte[i].PietrePretioase = PPSelectate;

                TxtIDBijuterie.Text = "";
                TxtDenumireBijuterie.Text = "";
                TxtMaterialBijuterie.Text = "";
                TxtPretBijuterie.Text = "";
                TxtStocBijuterie.Text = "";
                PnlDateBijuterie.Visible = false;
                LblModificareAvertisment.Text = "";
            }
            else
            {
                LblModificareAvertisment.Text = "*Trebuie completate toate campurile!";
            }
            adminBijuterii.UpdateFisierBijuterii(obiecte);
        }

        private void CkbPP_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; //operator 'as'

            int optiuneSelectata = (int)Enum.Parse(typeof(PietrePretioaseBijuterie), checkBoxControl.Text);
            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                PPSelectate = (PietrePretioaseBijuterie)((int)PPSelectate + optiuneSelectata);
            else
                PPSelectate = (PietrePretioaseBijuterie)((int)PPSelectate - optiuneSelectata);
        }


        private void UCModificareBijuterie_Load(object sender, EventArgs e)
        {
            obiecte = adminBijuterii.GetBijuterii();
            nrBijuterii = obiecte.Count;
            Bijuterie.IdUltimaBijuterie = nrBijuterii;
            PPSelectate = (PietrePretioaseBijuterie)0;
        }

    }
}
