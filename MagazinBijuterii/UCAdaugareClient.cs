using LibrarieModele;
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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using MagazinBijuterii;
using System.Xml.Linq;

namespace MagazinBijuterii
{
    public partial class UCAdaugareClient : UserControl
    {
        List<Client> clienti;
        IStocareClienti adminClienti = StocareFactory.GetAdministratorStocareClienti();
        static int numar_factura = 0;
         
        //problema este ca de fiecare data cand aplicatia este rulata, counterul se reseteaza la 0 si suprascrie pdf-urile existente

        public UCAdaugareClient()
        {
            InitializeComponent();
        }

        private void UCAdaugareClient_Load(object sender, EventArgs e)
        {
            clienti = adminClienti.GetClienti();
        }

        private void BtnAdaugaClient_Click(object sender, EventArgs e)
        {
            clienti = adminClienti.GetClienti();
            if (DateValide())
            {
                string line = $"{TxtCNPClient.Text},{TxtNumeClient.Text},{TxtPrenumeClient.Text},{TxtNrTelefonClient.Text},{TxtDetaliiProdusClient.Text},{DateTime.Now.ToString()}";
                Client newClient = new Client(line);
                clienti.Add(newClient);
                adminClienti.AddClient(newClient);
                ResetareControale();
                LblAdaugareClientAvertisment.Text = "Clientul a fost adaugat cu succes!";

                GeneratePDF(newClient); // Generate PDF for the new client
            }

        }

        bool DateValide()
        {
            LblAdaugareClientAvertisment.ForeColor = Color.Firebrick;
            if (TxtNumeClient.Text == "" || TxtPrenumeClient.Text == "" || TxtNrTelefonClient.Text == "" || TxtDetaliiProdusClient.Text == "")
            {
                LblAdaugareClientAvertisment.Text = "*Trebuie completate toate campurile!";
                return false;
            }
            if (!Functii.OnlyLetters(TxtNumeClient.Text))
            {
                LblAdaugareClientAvertisment.Text = "*Numele trebuie sa contina doar litere!";
                return false;
            }
            if (!Functii.OnlyLetters(TxtPrenumeClient.Text))
            {
                LblAdaugareClientAvertisment.Text = "*Prenumele trebuie sa contina doar litere!";
                return false;
            }
            if (TxtNrTelefonClient.TextLength != 10)
            {
                LblAdaugareClientAvertisment.Text = "*Numarul de telefon trebuie sa aiba lungimea 10!";
                return false;
            }

            if (!Functii.OnlyDigits(TxtNrTelefonClient.Text))
            {
                LblAdaugareClientAvertisment.Text = "*Numarul de telefon trebuie sa contina doar cifre!";
                return false;
            }
            LblAdaugareClientAvertisment.ForeColor = Color.White;
            return true;
        }

        void ResetareControale()
        {
            TxtNumeClient.Text = "";
            TxtPrenumeClient.Text = "";
            TxtNrTelefonClient.Text = "";
            TxtDetaliiProdusClient.Text = "";
            TxtCNPClient.Text = "";

        }

        private void PnlAddCamera_VisibleChanged(object sender, EventArgs e)
        {
            LblAdaugareClientAvertisment.Text = "";
        }

        private void GeneratePDF(Client client)
        {
            // Create a new document
            Document document = new Document();
            string directoryPath = @"C:\Users\Bogdan\Desktop\MagazinBijuterii\MagazinBijuterii\Bills\";
            string filePath = directoryPath + $"Client_{client.Nume}" + $"_{client.Prenume}" + $"_{client.NrTelefon}" + $".pdf"; // You can customize the file name

            try
            {
                // Create a PdfWriter instance to write the document to a file
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                // Open the document for writing
                document.Open();

                // Add client details to the PDF
                Paragraph paragraph = new Paragraph($"Factura numarul {numar_factura} din data {client.DataActualizare}\n" +
                    $"MyJewels - \"Decades of Elegance: Crafting Fine Jewelry with Passion.\":\n\n" +
                    $"Client Details:\n" +
                    $"CNP: {client.CNP}\n" +
                    $"Nume: {client.Nume}\n" +
                    $"Prenume: {client.Prenume}\n" +
                    $"Numar Telefon: {client.NrTelefon}\n" +
                    $"Detalii Produs: {client.DetaliiProdus}\n" +
                    $"Garantie produs: 1 an\n");

                document.Add(paragraph);
                numar_factura++;

            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the document
                document.Close();
            }
        }

    }
}
