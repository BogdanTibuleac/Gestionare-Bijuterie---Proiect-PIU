using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieModele;
using NivelAccesDate;

namespace InterfataUtilizator_WindowsForms
{
    public partial class Form1 : Form
    {

        //Set as Startup Project to comute between Console and WinF
        private const int LATIME_CONTROL = 150;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 170;
        public Form1()
        {
            string numeFisier1 = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie1 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier1 = locatieFisierSolutie1 + "\\" + numeFisier1;
            AdministrareBijuterii_FisierText adminBijuterie = new AdministrareBijuterii_FisierText(caleCompletaFisier1);
            int nrBijuterii = 0;
            Bijuterie[] obiecte = adminBijuterie.GetBijuterie(out nrBijuterii);


            InitializeComponent();

            Label lblTitlu = new Label();
            lblTitlu.Width = LATIME_CONTROL;
            this.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTitlu.Text = "Tip";
            lblTitlu.BackColor = Color.LightSteelBlue;
            this.Controls.Add(lblTitlu);

            Label lblNume = new Label();
            lblNume.Width = LATIME_CONTROL;
            lblNume.Text = "Material"; ;
            lblNume.Left = DIMENSIUNE_PAS_X;
            lblNume.BackColor = Color.LightSteelBlue;
            this.Controls.Add(lblNume);

            Label lblNote = new Label();
            lblNote.Width = LATIME_CONTROL;
            lblNote.Text = "Pret"; ;
            lblNote.Left = 2 * DIMENSIUNE_PAS_X;
            lblNote.BackColor = Color.LightSteelBlue;
            this.Controls.Add(lblNote);

            Label lblStudent1_Nume = new Label();
            lblStudent1_Nume.Width = LATIME_CONTROL;
            lblStudent1_Nume.Text = obiecte[0].Tip;
            lblStudent1_Nume.Top = DIMENSIUNE_PAS_Y;
            lblStudent1_Nume.BackColor = Color.LightYellow;
            this.Controls.Add(lblStudent1_Nume);

            Label lblStudent1_Prenume = new Label();
            lblStudent1_Prenume.Width = LATIME_CONTROL;
            lblStudent1_Prenume.Text = obiecte[0].Material;
            lblStudent1_Prenume.Location = new Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y);
            lblStudent1_Prenume.BackColor = Color.LightYellow;
            this.Controls.Add(lblStudent1_Prenume);

            Label lblStudent1_Note = new Label();
            lblStudent1_Note.Width = LATIME_CONTROL;
            lblStudent1_Note.Text = obiecte[0].Pret.ToString();
            lblStudent1_Note.Location = new Point(2 * DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y);
            lblStudent1_Note.BackColor = Color.LightYellow;
            this.Controls.Add(lblStudent1_Note);

        }
    }
}
