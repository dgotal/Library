using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace KnjiznicaZavrsniGotal
{
    public partial class UnosKnjige : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

        private SqlConnection connection;

        public UnosKnjige()
        {
            InitializeComponent();
            ConnectDB();
            lblMessageNazivKnjige.Visible = false;
        }

        public void ConnectDB()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand zanrKnjige = new SqlCommand("SELECT NazivZanra,IDZanr FROM Zanr ORDER BY NazivZanra ASC", connection);
            SqlDataReader reader;
            reader = zanrKnjige.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("NazivZanra", typeof(string));
            dt.Load(reader);
            cmbZanr.ValueMember = "IDZanr";
            cmbZanr.DisplayMember = "NazivZanra";
            cmbZanr.DataSource = dt;

            //Combox Autor
            SqlCommand autor = new SqlCommand("SELECT Ime,IDAutor FROM Autor ORDER BY Ime ASC", connection);

            reader = autor.ExecuteReader();
            DataTable dtt = new DataTable();
            dtt.Columns.Add("Ime", typeof(string));
            dtt.Load(reader);
            cmbAutor.ValueMember = "IDAutor";
            cmbAutor.DisplayMember = "Ime";
            cmbAutor.DataSource = dtt;

            //connection.Close();
        }
        private void getExcel(object sender, EventArgs e)
        {
            string sql = null;
            string data = null;
            int i = 0;
            int j = 0;

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            connection = new SqlConnection(connectionString);
            connection.Open();
            sql = "SELECT * FROM Knjiga";
            SqlDataAdapter dscmd = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            dscmd.Fill(ds);

            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                for (j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                {
                    data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                    xlWorkSheet.Cells[i + 1, j + 1] = data;
                }
            }

            xlWorkBook.SaveAs("csharp.net-informations.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            MessageBox.Show("Excel file created , you can find the file c:\\Zapisi-informations.xls");

            //connection.Close();
        }
        private void BtnDodajKnjigu_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNazivKnjige.Text))
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    var s = cmbAutor.SelectedValue;
                    string query = "INSERT INTO Knjiga(IDKnjige, NazivKnjige, IDAutor, IDZanr, Kolicina) VALUES ('" + Guid.NewGuid() + "','" + txtNazivKnjige.Text.ToString() + "','" + new Guid(cmbAutor.SelectedValue.ToString()) + "','" + new Guid(cmbZanr.SelectedValue.ToString()) + "','" + numKnjiga.Value.ToString() + "' )";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New row successfully added to Knjiga table.");
                }
            }
            else
            {
                lblMessageNazivKnjige.Visible = true;
            }
        }

    }
}