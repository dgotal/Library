using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KnjiznicaZavrsniGotal.Knjižnica.Posudba
{
    public partial class PretrazivanjeKnjiga : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

        public PretrazivanjeKnjiga()
        {
            InitializeComponent();
            //SetGrid();
        }

       /* #region Fields
        private readonly string AutorCoulmnKey = "Autor";
        private readonly string NumberOfBooksCoulmnKey = "Broj knjiga";
        private readonly string ZanrCoulmnKey = "Žanr";
        private readonly string GridEditColumnKey = "btnEdit";
        private readonly string GridDeleteColumnKey = "btnDelete";
        #endregion Fields
        #region Methods
        private void SetGrid()
        {
            dataGridBook.ColumnCount = 3;
            dataGridBook.AutoGenerateColumns = false;
            dataGridBook.Columns[0].Name = AutorCoulmnKey;
            dataGridBook.Columns[0].DataPropertyName = AutorCoulmnKey;
            dataGridBook.Columns[0].Visible = false;

            dataGridBook.Columns[1].Name = NumberOfBooksCoulmnKey;
            dataGridBook.Columns[1].DataPropertyName = "Broj knjiga";

            dataGridBook.Columns[2].Name = ZanrCoulmnKey;
            dataGridBook.Columns[2].DataPropertyName = "Zanr";
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            dataGridBook.Columns.Add(btnEdit);
            btnEdit.HeaderText = String.Empty;
            btnEdit.Text = "Izmijeni";
            btnEdit.Name = GridEditColumnKey;
            btnEdit.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            dataGridBook.Columns.Add(btnDelete);
            btnDelete.HeaderText = String.Empty;
            btnDelete.Text = "Obriši";
            btnDelete.Name = GridDeleteColumnKey;
            btnDelete.UseColumnTextForButtonValue = true;
        }*/

        //#endregion Methods
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            txtSearchBook.Text = String.Empty;
        }

        private void PretrazivanjeKnjiga_Load(object sender, EventArgs e)
        {
            dataGridBook.DataSource = GetKnjigeList();
        }
        private DataTable GetKnjigeList()
        {
            DataTable dtKnjige = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT NazivKnjige, Ime, Prezime, NazivZanra FROM Knjiga JOIN Autor ON Autor.IDAutor = Knjiga.IDAutor JOIN Zanr ON Zanr.IDZanr = Knjiga.IDZanr", connection))
                {
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    dtKnjige.Load(reader);
                }
            }
                return dtKnjige;
        }

        private void searchBooks_TextChanged(object sender, EventArgs e)
        {
            (dataGridBook.DataSource as DataTable).DefaultView.RowFilter = string.Format("NazivKnjige LIKE '{0}%' OR Ime LIKE '{0}%'", txtSearchBook.Text);
        }
    }
}
