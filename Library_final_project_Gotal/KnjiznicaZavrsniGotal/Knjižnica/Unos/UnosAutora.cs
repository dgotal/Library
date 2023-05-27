using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KnjiznicaZavrsniGotal.Knjižnica
{
    public partial class UnosAutora : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

        public UnosAutora()
        {
            InitializeComponent();
            lblUpozorenjeAutor.Visible = false;
        }
        private void BtnAddAutor_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                if (!String.IsNullOrEmpty(txtUnosImenaAutora.Text) && !String.IsNullOrEmpty(txtUnosPrezimenaAutora.Text))
                {
                    string query = "INSERT INTO Autor(IDAutor, Ime, Prezime) VALUES ('" + Guid.NewGuid() + "','" 
                        + txtUnosImenaAutora.Text.ToString() + "','" + txtUnosPrezimenaAutora.Text.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New row successfully added to Autor table.");
                }
                else
                {
                    lblUpozorenjeAutor.Visible = true;
                }
            }

        }
    }
}
