using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using ZXing;
using ZXing.QrCode;
using ZXing.Common;
using System.Data.SqlClient;
using System.Configuration;

namespace KnjiznicaZavrsniGotal.Knjižnica
{
    public partial class PosudbaKnjige : Form
    {
        private VideoCapture capture;
        private bool captureInProgress = false;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;


        public PosudbaKnjige()
        {
            InitializeComponent();
            ConnectDB();
            btnPosudi.Visible = false;
            btnVrati.Visible = false;
            label3.Visible = false;
            btnPlati.Visible = false;
            txtZakasnina.Visible = false;
            
        }
        public void ConnectDB()
        {
            Helper.ConnectToDB().Open();
            using (SqlConnection cnn = Helper.ConnectToDB())
            {

                cnn.Open();
                using (SqlCommand kolegiji = new SqlCommand("SELECT JMBAG, Ime, Prezime FROM Osoba ORDER BY Ime ASC", cnn))
                {
                    SqlDataReader reader;
                    reader = kolegiji.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("JMBAG", typeof(string));
                    dt.Columns.Add("Ime", typeof(string));
                    dt.Columns.Add("Prezime", typeof(string));
                    dt.Columns.Add("ImePrezime", typeof(string), "Ime + ' ' + Prezime");
                    dt.Load(reader);
                    cmbKorisnik.ValueMember = "JMBAG";
                    cmbKorisnik.DisplayMember = "ImePrezime";
                    cmbKorisnik.DataSource = dt;
                }
            }
        }

        private void btnPosudi_Click(object sender, EventArgs e)
        {
            DateTime DatumVracanja = DateTime.Today.AddDays(+14);
            string datum = DatumVracanja.ToString("MM/dd/yyyy");
            DateTime DatumPosudbe = DateTime.Today;
            string datumP = DatumPosudbe.ToString("MM/dd/yyyy");
            if (!String.IsNullOrEmpty(textBox2.Text))
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    string query = "INSERT INTO Posudba(JMBAG, IDKnjige, Datumsudbe, DatumVracanja) VALUES ('" + cmbKorisnik.SelectedValue.ToString() + "','" + new Guid(textBox2.Text.ToString()) + "','" + datumP + "','" + datum + "')";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New row successfully added to Knjiga table.");

                }
            }
        }
        private void ProcessFrame(object sender, EventArgs arg)
        {

            Image<Bgr, byte> colImage = capture.QueryFrame().ToImage<Bgr, byte>();
            ibCamera.Image = colImage;

            //ovdje ide kod za citanje QR

            Bitmap BmpInput = colImage.ToBitmap();
            IBarcodeReader reader = new BarcodeReader();   // create a barcode reader instance           
            var barcodeBitmap = BmpInput;                  // load a bitmap              
            var result = reader.Decode(barcodeBitmap);     // detect and decode the barcode inside the bitmap            

            if (result != null)
            {

                textBox2.Text = result.Text;
                using (SqlConnection cnn = Helper.ConnectToDB())
                {
                    cnn.Open();
                    using (SqlCommand cmd2 = new SqlCommand("SELECT NazivKnjige FROM Knjiga where IDKnjige='" + new Guid(textBox2.Text) + "'", cnn))
                    {
                        string some = (string)cmd2.ExecuteScalar();
                        textBox3.Text = some;
                    }



                }

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (capture == null)
            {
                capture = new VideoCapture(0);
            }
            if (capture != null)
            {
                if (captureInProgress)
                {
                    Application.Idle -= ProcessFrame;
                }
                else
                {
                    Application.Idle += ProcessFrame;
                }
            }
        }

        private void btnProvjeri_Click(object sender, EventArgs e)
        {

            using (SqlConnection cnn = Helper.ConnectToDB())
            {
                cnn.Open();
                using (SqlCommand provjera = new SqlCommand("SELECT IDKnjige FROM Posudba Where JMBAG='" + cmbKorisnik.SelectedValue.ToString() + "'AND IDKnjige='" + textBox2.Text + "'", cnn))
                {


                    string aloha = Convert.ToString(provjera.ExecuteScalar());
                    aloha = aloha.ToUpper();

                    if (string.Equals(aloha, textBox2.Text))
                    {
                        MessageBox.Show("Imamo korisnika.");
                        btnVrati.Visible = true;     
                        

                    }



                    else
                    {
                        MessageBox.Show($"Nemamo korisnika {aloha}");
                        btnPosudi.Visible = true;
                    }

                }

            }

        }
        private TimeSpan RacunanjeZakasnine()
        {
            using (SqlConnection cnn = Helper.ConnectToDB())
            {
                cnn.Open();
                using (var datumV = new SqlCommand("SELECT DatumVracanja FROM Posudba where JMBAG='" + cmbKorisnik.SelectedValue.ToString() + "' ", cnn))
                {
                    string iDate = datumV.ExecuteScalar().ToString();
                    Console.WriteLine(iDate);
                    DateTime DatumVracanja = Convert.ToDateTime(iDate);
                    return DateTime.Now.Subtract(DatumVracanja);
                }
            }

        }

        private void NoviQRID(object sender, EventArgs e)
        {
            btnVrati.Visible = false;
            btnPosudi.Visible = false;
        }

        private void btnVrati_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = Helper.ConnectToDB())
            {

                cnn.Open();
                using (SqlCommand Brisanje = new SqlCommand("DELETE Posudba Where JMBAG ='" + cmbKorisnik.SelectedValue.ToString() 
                    + "' AND IDKnjige ='" + textBox2.Text + "' ", cnn))
                {
                   
                    txtZakasnina.Text = Convert.ToInt32(RacunanjeZakasnine().TotalDays).ToString();
                    if (Int32.Parse(txtZakasnina.Text) <= 0)
                    {
                        MessageBox.Show("Podaci obrisani. Nema zakasnine");
                        Brisanje.ExecuteNonQuery();
                    }
                    else
                    {
                        string x = RacunanjeZakasnine().Minutes.ToString();
                        MessageBox.Show($" Korisnik mora platiti zakasninu.");
                        btnPlati.Visible = true;
                        label3.Visible = true;
                        txtZakasnina.Visible = true;
                    
                    }
                }
            }
        }

        private void btnPlati_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = Helper.ConnectToDB())
            {

                cnn.Open();
                using (SqlCommand Brisanje = new SqlCommand("DELETE Posudba Where JMBAG ='" + cmbKorisnik.SelectedValue.ToString() + "' AND IDKnjige ='" + textBox2.Text + "' ", cnn))
                {
                    Brisanje.ExecuteNonQuery();
                    MessageBox.Show("Knjiga je vračena u knjižnicu.");
                    label3.Visible = false;
                    btnPlati.Visible = false;
                    txtZakasnina.Visible = false;
                }
            }
        }
    }
}

