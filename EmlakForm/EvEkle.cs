using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmlakClasses;

namespace EmlakForm
{
    public partial class EvEkle : Form
    {
        public EvEkle()
        {
            InitializeComponent();
        }

        private void EvEkle_Load(object sender, EventArgs e)
        {
            semtleri_yukle();
            comboBox2.SelectedIndex = -1;
        }

        private void semtleri_yukle()
        {
            string[] semtler = File.ReadAllLines("semt.txt");
            foreach (string semt in semtler)
            {
                comboBox1.Items.Add(semt);
            }
            comboBox2.DataSource = Enum.GetValues(typeof(Ev.EvTuru));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label9.Text = "Satılık Fiyat : ";
                maskedTextBox2.Visible = true;
            }

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label9.Text = "Depozito Fiyat:";
                maskedTextBox2.Visible = true;
            }
        }


        private bool aktifmi()
        {
            if (radioButton3.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // NumericUpDown kontrolleri 0 ise 1 yap
            if (numericUpDown1.Value == 0)
                numericUpDown1.Value = 1;

            if (numericUpDown2.Value == 0)
                numericUpDown2.Value = 1;

            // MaskedTextBox kontrollerini kontrol et
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text) || maskedTextBox1.Text == "0")
            {
                MessageBox.Show("Lütfen Alan kısmını doldurunuz.");
                return;
            }

            if (string.IsNullOrWhiteSpace(maskedTextBox2.Text) || maskedTextBox2.Text == "0")
            {
                MessageBox.Show("Lütfen Fiyat veya Depozito alanını doldurunuz.");
                return;
            }

            // ComboBox seçimlerini kontrol et
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Semt alanından bir seçim yapın.");
                return;
            }

            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Ev Türü alanından bir seçim yapın.");
                return;
            }

            // RadioButton seçimlerini kontrol et
            if (!(radioButton1.Checked || radioButton2.Checked))
            {
                MessageBox.Show("Lütfen Satış Türü bölümünden bir seçim yapınız.");
                return;
            }

            if (!(radioButton3.Checked || radioButton4.Checked))
            {
                MessageBox.Show("Lütfen Evin Durumu bölümünden bir seçim yapınız.");
                return;
            }

            if (radioButton1.Checked)
            {
                SatilikEv satilikEv = new SatilikEv(
                    (int)numericUpDown1.Value,
                    (int)numericUpDown2.Value,
                    comboBox1.SelectedItem.ToString(),
                    maskedTextBox1.Text,
                    dateTimePicker1.Value,
                    aktifmi(),
                    (Ev.EvTuru)comboBox2.SelectedItem,
                    "Satılık",
                    maskedTextBox2.Text
                    );
                satilikEv.TxtFormatYazdir();
                MessageBox.Show("Ev Eklendi");
                
            }
            else if (radioButton2.Checked)
            {
                KiralikEv kiralikev = new KiralikEv(
                    (int)numericUpDown1.Value,
                    (int)numericUpDown2.Value,
                    comboBox1.SelectedItem.ToString(),
                    maskedTextBox1.Text,
                    dateTimePicker1.Value,
                    aktifmi(),
                    (Ev.EvTuru)comboBox2.SelectedItem,
                    "Kiralık",
                    maskedTextBox2.Text
                    );
                kiralikev.TxtFormatYazdir();
                MessageBox.Show("Ev Eklendi");
            }
            
        }

        
    }
}
