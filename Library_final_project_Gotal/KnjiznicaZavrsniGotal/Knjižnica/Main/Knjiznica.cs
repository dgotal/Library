using System.Windows.Forms;

namespace KnjiznicaZavrsniGotal.Knjižnica
{
    public partial class Knjiznica : Form
    {
        private Form formToShow = null;

        public Knjiznica()
        {
            InitializeComponent();
            formToShow = new UnosKnjige();
            DisplayForm(formToShow);
            panelUnos.Controls.Clear();
            panelUnos.Controls.Add(formToShow);
        }
        private void DisplayForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        private void MenuItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Početna stranica":
                    this.Close();
                    break;
                case "Unos Knjiga":
                    formToShow = new UnosKnjige();
                    DisplayForm(formToShow);
                    break;
                case "Unos Korisnika":
                    formToShow = new UnosKorisnika();
                    DisplayForm(formToShow);
                    break;
                case "Unos Žanra":
                    formToShow = new UnosZanra();
                    DisplayForm(formToShow);
                    break;
                case "Unos Autora":
                    formToShow = new UnosAutora();
                    DisplayForm(formToShow);
                    break;
                default:
                    break;
            }
            panelUnos.Controls.Clear();
            panelUnos.Controls.Add(formToShow);
        }
    }
}
