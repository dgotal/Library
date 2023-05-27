using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KnjiznicaZavrsniGotal.Knjižnica
{
    public partial class UnosKorisnika : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

        public UnosKorisnika()
        {
            InitializeComponent();
        }

        private void BtnAddKorisnik_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "INSERT INTO Osoba(JMBAG, Ime, Prezime) VALUES ('" + txtJMBAG.Text.ToString() + "','" + txtImeKorisnika.Text.ToString() + "','" + txtPrezimeKorisnika.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New row successfully added to Osoba table.");
            }
        }
    }
}
