using System;
using System.Windows.Forms;

namespace KnjiznicaZavrsniGotal.Knjižnica
{
    public partial class PocetnaStranica : Form
    {
        public PocetnaStranica()
        {
            InitializeComponent();
            Form initialForm = new Knjiznica();
            DisplayForm(initialForm);
        }
        private void DisplayForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void BtnPosudba_Click(object sender, EventArgs e)
        {
            Knjige form = new Knjige();
            form.Show();

        }

        private void BtnUnos_Click(object sender, EventArgs e)
        {
            Knjiznica form = new Knjiznica();
            form.Show();
        }

        private void PocetnaStranica_Load(object sender, EventArgs e)
        {

        }
    }
}
