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
    public partial class UCAdaugareBijuterie : UserControl
    {
        private const int LIMIT = 0;
        List<Bijuterie> obiecte;

        IStocareBijuterii adminBijuterii = StocareFactory.GetAdministratorStocareBijuterii();
        PietrePretioaseBijuterie PPSelectate = new PietrePretioaseBijuterie();

        public UCAdaugareBijuterie()
        {
            InitializeComponent();
            //LblAdaugareBijuterieAvertisment.Visible = false;
        }

        private void BtnAdaugaBijuterie_Click(object sender, EventArgs e)
        {
            if (DateValide())
            {

                if (Exista(TxtDenumireBijuterie.Text, TxtMaterialBijuterie.Text, float.Parse(TxtPretBijuterie.Text), Convert.ToInt32(TxtStocBijuterie.Text)))
                {
                    LblAdaugareBijuterieAvertisment.Text = "*Acest obiect exista deja in baza de date!!";
                    return;
                }
                obiecte = adminBijuterii.GetBijuterii();
                if (obiecte.Count == 0)
                    Bijuterie.IdUltimaBijuterie = 0;
                TipBijuterie t = new TipBijuterie();
                if (RBtnBratara.Checked)
                    t = TipBijuterie.bratara;
                else if (RBtnCercei.Checked)
                    t = TipBijuterie.cercei;
                else if (RBtnColier.Checked)
                    t = TipBijuterie.colier;
                else if (RBtnInel.Checked)
                    t = TipBijuterie.inel;
                else if (RBtnPandantiv.Checked)
                    t = TipBijuterie.pandantiv;

                Bijuterie.IdUltimaBijuterie++;

                string line = $"{Bijuterie.IdUltimaBijuterie},{TxtDenumireBijuterie.Text},{TxtMaterialBijuterie.Text},{TxtStocBijuterie.Text},{(int)PPSelectate}, {(int)t},{TxtPretBijuterie.Text}";

                obiecte.Add(new Bijuterie(line));
                adminBijuterii.AddBijuterie(new Bijuterie(line));
                ResetareControale();
                LblAdaugareBijuterieAvertisment.Text = "Bijuteria a fost adaugata!";

            }
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


        private void UCAdaugareBijuterie_Load(object sender, EventArgs e)
        {
            obiecte = adminBijuterii.GetBijuterii();
            PPSelectate = 0;
        }



        void ResetareControale()
        {
            TxtMaterialBijuterie.Text = "";
            TxtPretBijuterie.Text = "";
            TxtDenumireBijuterie.Text = "";
            TxtStocBijuterie.Text = "";
            
            ChBxCristal.Checked = false;
            ChBxDiamant.Checked = false;
            ChBxSafir.Checked = false;
            ChBxPerle.Checked = false;
            ChBxSmarald.Checked = false;
            ChBxRubin.Checked = false;

            RBtnBratara.Checked = false;
            RBtnInel.Checked = false;
            RBtnCercei.Checked = false;
            RBtnColier.Checked = false;
            RBtnPandantiv.Checked = false;

            LblAdaugareBijuterieAvertisment.Text = "";


        }
        private bool Exista(string denumire, string material, float pret, int stoc)
        {
            return obiecte.Any(s => s.Denumire == denumire && s.Material == material && s.Pret == pret && s.Stoc == stoc);
        }

        bool DateValide()
        {
            LblAdaugareBijuterieAvertisment.ForeColor = Color.Firebrick;
            if (TxtMaterialBijuterie.Text == "" || TxtPretBijuterie.Text == "" || TxtDenumireBijuterie.Text == "" || TxtStocBijuterie.Text == "")
            {
                LblAdaugareBijuterieAvertisment.Text = "*Trebuie completate toate campurile!";
                return false;
            }
            if (!Functii.IsFloatNumber(TxtPretBijuterie.Text))
            {
                LblAdaugareBijuterieAvertisment.Text = "*Pretul introdus este invalid!";
                return false;
            }
            if (float.Parse(TxtPretBijuterie.Text) < LIMIT)
            {
                LblAdaugareBijuterieAvertisment.Text = "*Pretul introdus este invalid!";
                return false;
            }
            if (!Functii.IsIntNumber(TxtStocBijuterie.Text))
            {
                LblAdaugareBijuterieAvertisment.Text = "*Valoarea stocului este invalida!";
                return false;
            }
            if (Convert.ToInt32(TxtStocBijuterie.Text) < LIMIT)
            {
                LblAdaugareBijuterieAvertisment.Text = "*Stocul introdus este invalid!";
                return false;
            }
            if (RBtnBratara.Checked == false && RBtnCercei.Checked == false && RBtnColier.Checked == false && RBtnInel.Checked == false && RBtnPandantiv.Checked == false)
            {
                LblAdaugareBijuterieAvertisment.Text = "*Trebuie sa selectati un tip!";
                return false;
            }
            LblAdaugareBijuterieAvertisment.ForeColor = Color.White;
            return true;
        }

        private void LblTitluAdaugaBijuterie_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
