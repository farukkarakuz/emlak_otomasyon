using System.Diagnostics.Eventing.Reader;

namespace EmlakForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            if (login.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EvEkle evEkle = new EvEkle();
            evEkle.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EvSorgula evSorgula = new EvSorgula();
            evSorgula.ShowDialog();
        }
    }
}
