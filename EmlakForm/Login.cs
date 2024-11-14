using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (girisyap(username, password))
            {

                MessageBox.Show("Giriş Başarılı");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");

            }


        }

        private bool girisyap(string username, string password)
        {
            string[] users = File.ReadAllLines("users.txt");

            foreach (string user in users)
            {
                string[] alluser = user.Split("_");

                foreach (string user2 in alluser)
                {
                    string[] partuser = user2.Split(",");
                    if (partuser[0] == username && partuser[1] == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    
    }
}
