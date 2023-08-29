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
    public partial class Form1 : Form
    {

        Point locatie = new Point(15, 50);


        UCAdaugareBijuterie PnlAdaugareBijuterie = new UCAdaugareBijuterie();
        UCAfisareBijuterii PnlAfisareBijuterii = new UCAfisareBijuterii();
        UCCautareBijuterie PnlCautareBijuterii = new UCCautareBijuterie();
        UCModificareBijuterie PnlModificareBijuterie = new UCModificareBijuterie();

        UCAdaugareAngajat PnlAdaugareAngajat = new UCAdaugareAngajat();
        UCAfisareAngajati PnlAfisareAngajati = new UCAfisareAngajati();
        UCCautareAngajat PnlCautareAngajat = new UCCautareAngajat();
        UCModificareAngajat PnlModificareAngajat = new UCModificareAngajat();

        UCAdaugareClient PnlAdaugareClient = new UCAdaugareClient();
        UCAfisareClienti PnlAfisareClienti = new UCAfisareClienti();
        //UCModificareClient PnlModificareClient = new UCModificareClient();
        UCCautareClient PnlCautareClient = new UCCautareClient();


        List<Angajat> angajati;
        List<Bijuterie> obiecte;
        List<Client> clienti;


        IStocareBijuterii adminBijuterii = StocareFactory.GetAdministratorStocareBijuterii();
        IStocareAngajati adminAngajati = StocareFactory.GetAdministratorStocareAngajati();
        IStocareParola adminParola = StocareFactory.GetAdministratorStocareParola();
        IStocareClienti adminClienti = StocareFactory.GetAdministratorStocareClienti();

        string Password { set; get; }
        public Form1()
        {
            InitializeComponent();

            PnlAdaugareBijuterie.Location = locatie;
            PnlAfisareBijuterii.Location = locatie;
            PnlCautareBijuterii.Location = locatie;
            PnlModificareBijuterie.Location = locatie;

            PnlAdaugareAngajat.Location = locatie;
            PnlAfisareAngajati.Location = locatie;
            PnlCautareAngajat.Location = locatie;
            PnlModificareAngajat.Location = locatie;

            PnlAdaugareClient.Location = locatie;
            PnlAfisareClienti.Location = locatie;
            //PnlModificareClient.Location = locatie;
            PnlCautareClient.Location = locatie;

            PnlAdaugareBijuterie.Visible = true;
            PnlAfisareBijuterii.Visible = false;
            PnlCautareBijuterii.Visible = false;
            PnlModificareBijuterie.Visible = false;

            PnlAdaugareAngajat.Visible = true;
            PnlAfisareAngajati.Visible = false;
            PnlCautareAngajat.Visible = false;
            PnlModificareAngajat.Visible = false;

            PnlAdaugareClient.Visible = true;
            PnlAfisareClienti.Visible = false;
            //PnlModificareClient.Visible = false;
            PnlCautareClient.Visible = false;

            PanelBijuterii.Controls.Add(PnlAdaugareBijuterie);
            PanelBijuterii.Controls.Add(PnlAfisareBijuterii);
            PanelBijuterii.Controls.Add(PnlCautareBijuterii);
            PanelBijuterii.Controls.Add(PnlModificareBijuterie);

            PanelAngajati.Controls.Add(PnlAdaugareAngajat);
            PanelAngajati.Controls.Add(PnlAfisareAngajati);
            PanelAngajati.Controls.Add(PnlCautareAngajat);
            PanelAngajati.Controls.Add(PnlModificareAngajat);

            PanelClienti.Controls.Add(PnlAdaugareClient);
            PanelClienti.Controls.Add(PnlAfisareClienti);
            PanelClienti.Controls.Add(PnlCautareClient);
            //PanelClienti.Controls.Add(PnlModificareClient);

            PanelAcasa.Visible = true;
            PanelBijuterii.Visible = false;
            PanelAngajati.Visible = false;
            PanelClienti.Visible = false;
            PanelSetari.Visible = false;

            //LblAvertismentParola.Visible = false;

            if (adminParola.GetPassword() != null)
            {
                Password = adminParola.GetPassword();
            }
            else
            {
                Password = "password";
                adminParola.SetPassword(Password);
            }

        }


        int mov;
        int movX;
        int movY;

        private void Navbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }

        private void Navbar_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Navbar_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TxtBxParola_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtBxParola.Text == Password)
                {
                    PanelLogare.Visible = false;
                    MainPanel.Visible = true;
                    PanelAcasa.Visible = true;
                }
                else
                {
                    MesajParola.Text = "*Parola incorecta";
                    TxtBxParola.Text = "";
                }
            }
        }

        private void BtnActualizeazaParola_Click(object sender, EventArgs e)
        {
            if (DateValide())
            {
                Password = TxtParolaNoua.Text;
                adminParola.SetPassword(Password);
                //ResetareControale();
            }
        }

        bool DateValide()
        {
            Password = adminParola.GetPassword();
            if (TxtParolaActuala.Text == "" || TxtParolaNoua.Text == "" )
            {
                LblModificareParolaAvertisment.Text = "*Trebuie completate toate campurile";
                return false;
            }
            if (TxtParolaActuala.Text == TxtParolaNoua.Text)
            {
                LblModificareParolaAvertisment.Text = "*Noua parola trebuie sa fie diferita de cea actuala";
                return false;
            }
            if (TxtParolaActuala.Text != Password)
            {
                LblModificareParolaAvertisment.Text = "*Parola actuala introdusa gresit";
                return false;
            }
            return true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panelBijuterii_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButonAdaugareBijuterie_Click(object sender, EventArgs e)
        {
            PnlAdaugareBijuterie.Visible = true;
            PnlAfisareBijuterii.Visible = false;
            PnlCautareBijuterii.Visible = false;
            PnlModificareBijuterie.Visible = false;

        }

        private void ButonAfisareBijuterie_Click(object sender, EventArgs e)
        {
            PnlAdaugareBijuterie.Visible = false;
            PnlAfisareBijuterii.Visible = true;
            PnlCautareBijuterii.Visible = false;
            PnlModificareBijuterie.Visible = false;

        }
        private void ButonCautareBijuterie_Click(object sender, EventArgs e)
        {
            PnlAdaugareBijuterie.Visible = false;
            PnlAfisareBijuterii.Visible = false;
            PnlCautareBijuterii.Visible = true;
            PnlModificareBijuterie.Visible = false;
        }
        private void BtnModificareBijuterie_Click(object sender, EventArgs e)
        {
            PnlAdaugareBijuterie.Visible = false;
            PnlAfisareBijuterii.Visible = false;
            PnlCautareBijuterii.Visible = false;
            PnlModificareBijuterie.Visible = true;
        }

        private void BtnAdaugareAngajat_Click(object sender, EventArgs e)
        {
            PnlAdaugareAngajat.Visible = true;
            PnlAfisareAngajati.Visible = false;
            PnlCautareAngajat.Visible = false;
            PnlModificareAngajat.Visible = false;
        }

        private void BtnAfisareAngajati_Click(object sender, EventArgs e)
        {
            PnlAdaugareAngajat.Visible = false;
            PnlAfisareAngajati.Visible = true;
            PnlCautareAngajat.Visible = false;
            PnlModificareAngajat.Visible = false;
        }

        private void BtnCautareAngajat_Click(object sender, EventArgs e)
        {
            PnlAdaugareAngajat.Visible = false;
            PnlAfisareAngajati.Visible = false;
            PnlCautareAngajat.Visible = true;
            PnlModificareAngajat.Visible = false;
        }
        private void BtnModificareAngajat_Click(object sender, EventArgs e)
        {
            PnlAdaugareAngajat.Visible = false;
            PnlAfisareAngajati.Visible = false;
            PnlCautareAngajat.Visible = false;
            PnlModificareAngajat.Visible = true;
        }
        private void BtnAcasa_Click(object sender, EventArgs e)
        {
            PanelAcasa.Visible = true;
            PanelBijuterii.Visible = false;
            PanelAngajati.Visible = false;
            PanelClienti.Visible = false;
            PanelSetari.Visible = false;

        }
        private void BtnBijuterii_Click(object sender, EventArgs e)
        {
            PanelAcasa.Visible = false;
            PanelBijuterii.Visible = true;
            PanelAngajati.Visible = false;
            PanelClienti.Visible = false;
            PanelSetari.Visible = false;

        }
        private void BtnAngajati_Click(object sender, EventArgs e)
        {
            PanelAcasa.Visible = false;
            PanelBijuterii.Visible = false;
            PanelAngajati.Visible = true;
            PanelClienti.Visible = false;
            PanelSetari.Visible = false;


        }

        private void BtnClienti_Click(object sender, EventArgs e)
        {
            PanelAcasa.Visible = false;
            PanelBijuterii.Visible = false;
            PanelAngajati.Visible = false;
            PanelClienti.Visible = true;
            PanelSetari.Visible = false;


        }
        private void BtnSetari_Click(object sender, EventArgs e)
        {
            PanelAcasa.Visible = false;
            PanelBijuterii.Visible = false;
            PanelAngajati.Visible = false;
            PanelClienti.Visible = false;
            PanelSetari.Visible = true;


        }
        private void BtnAdaugareClient_Click(object sender, EventArgs e)
        {
            PnlAdaugareClient.Visible = true;
            PnlAfisareClienti.Visible = false;
            PnlCautareClient.Visible = false;
            //PnlModificareClient.Visible = false;
        }

        private void BtnAfisareClienti_Click(object sender, EventArgs e)
        {
            PnlAdaugareClient.Visible = false;
            PnlAfisareClienti.Visible = true;
            PnlCautareClient.Visible = false;
            //PnlModificareClient.Visible = false;
        }

        private void BtnCautareeClienti_Click(object sender, EventArgs e)
        {
            PnlAdaugareClient.Visible = false;
            PnlAfisareClienti.Visible = false;
            PnlCautareClient.Visible = true;
            //PnlModificareClient.Visible = false;
        }

    }
}
