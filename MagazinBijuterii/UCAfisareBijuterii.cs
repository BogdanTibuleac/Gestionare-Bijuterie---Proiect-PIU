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
    public partial class UCAfisareBijuterii : UserControl
    {


        List<Bijuterie> obiecte;
        IStocareBijuterii adminBijuterii = StocareFactory.GetAdministratorStocareBijuterii();

        public UCAfisareBijuterii()
        {
            InitializeComponent();
            LsBxAfisareBijuterii.DrawItem += listBox1_DrawItem;

            if (LsBxAfisareBijuterii.SelectedItem == null || LsBxAfisareBijuterii.SelectedIndex == 0)
                BtnStergeBijuterii.Enabled = false;
        }

        private void PnlAfisareBijuterii_VisibleChanged(object sender, EventArgs e)
        {
            if (PnlAfisareBijuterii.Visible == true)
            {
                obiecte = adminBijuterii.GetBijuterii();
                LsBxAfisareBijuterii.Items.Clear();
                LsBxAfisareBijuterii.Items.Add(Bijuterie.HeaderInfo());
                foreach (Bijuterie obiect in obiecte)
                {
                    LsBxAfisareBijuterii.Items.Add(obiect.ConversieLaSir());
                }
            }
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                // Determine the color based on the item's content or index
                Color textColor = e.Index == 0 ? Color.Red : Color.Black;

                // Draw the background
                e.DrawBackground();

                // Draw the item's text with the specified color
                using (Brush brush = new SolidBrush(textColor))
                {
                    e.Graphics.DrawString(LsBxAfisareBijuterii.Items[e.Index].ToString(),
                                          e.Font,
                                          brush,
                                          e.Bounds,
                                          StringFormat.GenericDefault);
                }

                // Draw the focus rectangle if needed
                e.DrawFocusRectangle();
            }
        }

        private void UCAfisareBijuterii_Load(object sender, EventArgs e)
        {
            obiecte = adminBijuterii.GetBijuterii();
        }
        private void LsBxAfisareBijuterii_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LsBxAfisareBijuterii.SelectedIndex == 0)
                BtnStergeBijuterii.Enabled = false;
            else
            {
                BtnStergeBijuterii.Enabled = true;
            }
        }
        private void BtnStergeBijuterii_Click(object sender, EventArgs e)
        {
            obiecte = adminBijuterii.GetBijuterii();
            string[] date = LsBxAfisareBijuterii.SelectedItem.ToString().Split(' ');
            int id = int.Parse(date[0]);
            obiecte.RemoveAll(r => r.ID_bijuterie == id);
            adminBijuterii.UpdateFisierBijuterii(obiecte);
            LsBxAfisareBijuterii.Items.Clear();
            LsBxAfisareBijuterii.Items.Add(Bijuterie.HeaderInfo());
            foreach (Bijuterie obiect in obiecte)
            {
                LsBxAfisareBijuterii.Items.Add(obiect.ConversieLaSir());
            }
        }
    }
}