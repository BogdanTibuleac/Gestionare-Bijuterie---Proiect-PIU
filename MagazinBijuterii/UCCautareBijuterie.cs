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
    public partial class UCCautareBijuterie : UserControl
    {

        List<Bijuterie> obiecte = new List<Bijuterie>();
        IStocareBijuterii adminBijuterii = StocareFactory.GetAdministratorStocareBijuterii();
        public UCCautareBijuterie()
        {
            InitializeComponent();
            LblAvertismentCautare.Visible = false;

        }

        private void UCCautareBijuterie_Load(object sender, EventArgs e)
        {
            obiecte = adminBijuterii.GetBijuterii();
        }


        private void BtnCautaBijuterie_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (TxtIDBijuterie.Text == "")
            {
                LblAvertismentCautare.Visible = true;
            }
            else
            {
                id = int.Parse(TxtIDBijuterie.Text);
            }

            if (ValidateID(id))
            {

                Bijuterie bijuterieAfisare = adminBijuterii.GetBijuterie(id);
                if (bijuterieAfisare == null)
                {
                    PnlAfisareBijuterieCautata.Visible = false;
                }
                else
                {
                    LblAvertismentCautare.Visible = false;
                    PnlAfisareBijuterieCautata.Visible = true;
                    LblHeaderInfo.Text = Bijuterie.HeaderInfo() + "   ";
                    LblHeaderInfo.ForeColor = Color.Black;
                    LblBijuterieCautata.Text = bijuterieAfisare.ConversieLaSir();
                    LblBijuterieCautata.ForeColor = Color.Black;
                }
            }
            else
            {
                LblAvertismentCautare.Visible = true;
            }
        }
        private bool ValidateID(int id)
        {
            foreach (Bijuterie bijuterie in obiecte)
            {
                if (bijuterie.ID_bijuterie == id)
                {
                    return true; // ID found, validation successful
                }
            }
            return false; // ID not found, validation failed
        }


        private void TxtIDBijuterie_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblTitluCautaBijuterii_Click(object sender, EventArgs e)
        {

        }
    }
}
