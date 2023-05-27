using KnjiznicaZavrsniGotal.Knjižnica.Posudba;
using System.Windows.Forms;

namespace KnjiznicaZavrsniGotal.Knjižnica
{
    public partial class Knjige : Form
    {
        private Form formToShow = null;

        public Knjige()
        {
            InitializeComponent();
            formToShow = new PosudbaKnjige();
            DisplayForm(formToShow);
            panelKnjige.Controls.Clear();
            panelKnjige.Controls.Add(formToShow);
        }
        private void DisplayForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        private void MenuStripKnjige_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            switch (e.ClickedItem.Text)
            {
                case "Početna Stranica":
                    Close();
                    break;
                case "Posudba Knjiga":
                    formToShow = new PosudbaKnjige();
                    DisplayForm(formToShow);
                    break;
                case "Pretraživanje Knjiga":
                    formToShow = new PretrazivanjeKnjiga();
                    DisplayForm(formToShow);
                    break;
                default:
                    break;
            }
            panelKnjige.Controls.Clear();
            panelKnjige.Controls.Add(formToShow);
        }
    }
}
