using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace KnjiznicaZavrsniGotal.Knjižnica
{
    public partial class UnosZanra : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
        public Guid Id { get; set; }

        public UnosZanra()
        {
            InitializeComponent();
            lblUpozorenjeZanr.Visible = false;
        }

        private void BtnAddZanr_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                if (!String.IsNullOrEmpty(txtNazivZanra.Text))

                {
                    string query = "INSERT INTO Zanr(IDZanr, NazivZanra) VALUES ('" + Guid.NewGuid() + "','" + txtNazivZanra.Text.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uspješno je unesen novi žanr.");
                }
                else
                {
                    lblUpozorenjeZanr.Visible = true;
                }
            }


        }
    }
}
