using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace EmlakForm
{
    public partial class EvDüzenle : Form
    {
        private Dictionary<string, string> evDetaylari;
        string degistirilecekpath;
        int indeks;
        string deger;
        public EvDüzenle(Dictionary<string, string> detaylar, int deger)
        {
            InitializeComponent();
            evDetaylari = detaylar;

            if (deger == 1)
            {
                degistirilecekpath = "satilik.txt";
                radioButton10.Visible = false;
                radioButton11.Visible = false;
            }
            else if (deger == 2)
            {
                degistirilecekpath = "kiralik.txt";
                label12.Visible = true;
                label12.Text = evDetaylari.Keys.ElementAt(11) + " : " + evDetaylari[evDetaylari.Keys.ElementAt(11)];
                radioButton9.Visible = false;
                radioButton10.Visible = true;
                radioButton11.Visible = true;
            }

        }

        private void EvDüzenle_Load(object sender, EventArgs e)
        {
            label1.Text = evDetaylari.Keys.First() + " : " + evDetaylari[evDetaylari.Keys.First()];
            label2.Text = evDetaylari.Keys.ElementAt(1) + " : " + evDetaylari[evDetaylari.Keys.ElementAt(1)];
            label3.Text = evDetaylari.Keys.ElementAt(2) + " : " + evDetaylari[evDetaylari.Keys.ElementAt(2)];
            label4.Text = evDetaylari.Keys.ElementAt(3) + " : " + evDetaylari[evDetaylari.Keys.ElementAt(3)];
            label5.Text = evDetaylari.Keys.ElementAt(4) + " : " + evDetaylari[evDetaylari.Keys.ElementAt(4)] + " m2";
            label6.Text = evDetaylari.Keys.ElementAt(5) + " : " + evDetaylari[evDetaylari.Keys.ElementAt(5)];
            label7.Text = evDetaylari.Keys.ElementAt(6) + " : " + evDetaylari[evDetaylari.Keys.ElementAt(6)];
            label8.Text = evDetaylari.Keys.ElementAt(7) + " : " + evDetaylari[evDetaylari.Keys.ElementAt(7)];
            label9.Text = evDetaylari.Keys.ElementAt(8) + " : " + evDetaylari[evDetaylari.Keys.ElementAt(8)];
            label10.Text = evDetaylari.Keys.ElementAt(9) + " : " + evDetaylari[evDetaylari.Keys.ElementAt(9)];
            label11.Text = evDetaylari.Keys.ElementAt(10) + " : " + evDetaylari[evDetaylari.Keys.ElementAt(10)];

            radioButton1.Click += RadioButton_Click;
            radioButton2.Click += RadioButton_Click;
            radioButton3.Click += RadioButton_Click;
            radioButton4.Click += RadioButton_Click;
            radioButton5.Click += RadioButton_Click;
            radioButton6.Click += RadioButton_Click;
            radioButton7.Click += RadioButton_Click;
            radioButton8.Click += RadioButton_Click;
            radioButton9.Click += RadioButton_Click;
            radioButton10.Click += RadioButton_Click;
            radioButton11.Click += RadioButton_Click;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ev_sil();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible)
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    deger = textBox1.Text;
                }
                else
                {
                    MessageBox.Show("Hata var");
                }
            }
            else if (comboBox1.Visible)
            {
                deger = comboBox1.SelectedItem.ToString();
            }
            else if (dateTimePicker1.Visible)
            {
                deger = dateTimePicker1.Value.ToString("dd.MM.yy");
            }
            ev_duzenle(indeks,deger);
            MessageBox.Show("Ev Düzenlendi");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            System.Windows.Forms.RadioButton clickedradiobutton = sender as System.Windows.Forms.RadioButton;
            label13.Visible = true;
            if (clickedradiobutton != null)
            {
                if (clickedradiobutton == radioButton3 || clickedradiobutton == radioButton7 || clickedradiobutton == radioButton8 || clickedradiobutton == radioButton6)
                {
                    dateTimePicker1.Visible = false;
                    textBox1.Visible = false;
                    comboBox1.Visible = true;
                    comboBox1.SelectedIndex = -1;
                    if (clickedradiobutton == radioButton3)
                    {
                        indeks = 3;
                        string[] semtler = File.ReadAllLines("semt.txt");
                        foreach (string semt in semtler)
                        {
                            comboBox1.Items.Add(semt);
                        }

                    }
                    else if (clickedradiobutton == radioButton6)
                    {
                        indeks = 6;
                        comboBox1.Items.Add("Satılık");
                        comboBox1.Items.Add("Kiralık");

                    }
                    else if (clickedradiobutton == radioButton7)
                    {
                        indeks = 7;
                        foreach (var tur in Enum.GetValues(typeof(Ev.EvTuru)))
                        {
                            comboBox1.Items.Add(tur);
                        }

                    }
                    else if (clickedradiobutton == radioButton8)
                    {
                        indeks = 8;
                        comboBox1.Items.Add("Satılık");
                        comboBox1.Items.Add("Kiralık");
                    }
                    
                }
                else if (clickedradiobutton == radioButton5)
                {
                    indeks = 5;
                    comboBox1.Visible = false;
                    textBox1.Visible = false;
                    dateTimePicker1.Visible = true;
                    
                }
                else
                {
                    textBox1.Text = "";
                    comboBox1.Visible = false;
                    textBox1.Visible = true;
                    dateTimePicker1.Visible = false;
                    if (clickedradiobutton == radioButton1)
                    {
                        indeks = 1;
                    }
                    else if (clickedradiobutton == radioButton2)
                    {
                        indeks = 2;
                    }
                    else if (clickedradiobutton == radioButton4)
                    {
                        indeks = 4;
                    }
                    else if (clickedradiobutton == radioButton9)
                    {
                        // satiliksa indeks 9
                        indeks = 9;

                    }
                    else if (clickedradiobutton == radioButton10)
                    {
                        //kiralıksada indeks 9
                        indeks = 9;
                    }
                    else if (clickedradiobutton == radioButton11)
                    {
                        //kiralık indeks 10
                        indeks = 10;
                    }
                    
                }        
            }

        }

        private void ev_duzenle(int indeks, string deger)
        {
            string emlakno = evDetaylari[evDetaylari.Keys.First()];
            string[] evler = File.ReadAllLines(degistirilecekpath);
            List<string> yeniEvler = new List<string>();

            foreach (string ev in evler)
            {
                string[] evparca = ev.Split(",");
                if (evparca[0] == emlakno)
                {
                    evparca[indeks] = deger;
                    yeniEvler.Add(string.Join(",", evparca));
                }
                else
                {
                    yeniEvler.Add(ev);
                }
            }

            File.WriteAllLines(degistirilecekpath, yeniEvler);
        }

        private void ev_sil()
        {
            string emlakno = evDetaylari[evDetaylari.Keys.First()];
            string[] evler = File.ReadAllLines(degistirilecekpath);
            List<string> yeniEvler = new List<string>();
            foreach (var ev in evler)
            {

                string[] evparca = ev.Split(',');
                if (evparca[0] != emlakno)
                {
                    yeniEvler.Add(ev);
                }

            }
            File.WriteAllLines(degistirilecekpath, yeniEvler);
        }

        
    }
}
