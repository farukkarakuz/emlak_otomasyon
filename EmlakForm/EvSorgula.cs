using EmlakClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ev;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmlakForm
{
    
    public partial class EvSorgula : Form
    {
        int indeks;
        int degerint;
        string degerstr;
        string sorgupath;
        string sorgukayitpath;
        bool arsiv = false;
        CheckBox lastcheckbox;


        public EvSorgula()
        {
            InitializeComponent();
            button1.Visible = false;
        }

        private void EvSorgula_Load(object sender, EventArgs e)
        {

            radioButton3.Click += RadioButton_Click;
            radioButton4.Click += RadioButton_Click;
            radioButton5.Click += RadioButton_Click;
            radioButton6.Click += RadioButton_Click;
            radioButton7.Click += RadioButton_Click;
            radioButton8.Click += RadioButton_Click;
            radioButton9.Click += RadioButton_Click;
            radioButton10.Click += RadioButton_Click;
            radioButton11.Click += RadioButton_Click;
            checkBox1.Click += CheckBox_Click;
            checkBox2.Click += CheckBox_Click;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                radioButton7.Visible = true;
                radioButton8.Visible = true;
                radioButton11.Visible = true;
            }
            else
            {
                radioButton11.Visible = false;
            }
            sorgupath = "satilik.txt";
            sorgukayitpath = "satiliksorgu.txt";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                radioButton7.Visible = true;
                radioButton8.Visible = true;
                radioButton9.Visible = true;
                radioButton10.Visible = true;
            }
            else
            {
                radioButton9.Visible = false;
                radioButton10.Visible = false;
            }
            sorgupath = "kiralik.txt";
            sorgukayitpath = "kiraliksorgu.txt";
        }
        private void CheckBox_Click(object sender, EventArgs e)
        {
            CheckBox clickedCheckbox = sender as CheckBox;
            if(clickedCheckbox == checkBox1)
            {
                lastcheckbox = checkBox1;
            }
            else if (clickedCheckbox == checkBox2)
            {
                lastcheckbox = checkBox2;
            }

            
        }
        private void RadioButton_Click(object sender, EventArgs e)
        {
            RadioButton clickedRadioButton = sender as RadioButton;

            if (clickedRadioButton != null)
            {
                button1.Visible = true;
                checkBox3.Visible = true;
                comboBox1.Items.Clear();
                label1.Visible = true;
                label1.Text = clickedRadioButton.Text + " : ";
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                if (clickedRadioButton == radioButton3 || clickedRadioButton == radioButton4 || clickedRadioButton == radioButton5)
                {
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                    numericUpDown1.Visible = true;
                    maskedTextBox1.Visible = false;
                    comboBox1.Visible = false;
                    if (clickedRadioButton == radioButton3)
                    {
                        indeks = 1;
                    }
                    else if (clickedRadioButton == radioButton4)
                    {
                        indeks = 2;
                    }
                    else if (clickedRadioButton == radioButton5)
                    {
                        if (radioButton1.Checked)
                        {
                            indeks = 10;
                        }
                        else if (!radioButton2.Checked)
                        {
                            indeks = 11;
                        }
                    }
                    
                }
                else if (clickedRadioButton == radioButton6 || clickedRadioButton == radioButton11 || clickedRadioButton == radioButton10 || clickedRadioButton == radioButton9)
                {
                    numericUpDown1.Visible = false;
                    maskedTextBox1.Visible = true;
                    comboBox1.Visible = false;
                    if (clickedRadioButton == radioButton6)
                    {
                        indeks = 4;
                    }
                    else if(clickedRadioButton == radioButton9)
                    {
                        indeks = 10;
                        
                    }
                    else if(clickedRadioButton == radioButton10)
                    {
                        indeks = 9;
                        
                    }
                    else if (clickedRadioButton == radioButton11)
                    {
                        indeks = 9;
                        
                    }
                    
                }
                else if (clickedRadioButton == radioButton8 || clickedRadioButton == radioButton7)
                {
                    numericUpDown1.Visible = false;
                    maskedTextBox1.Visible = false;
                    comboBox1.Visible = true;
                    if (clickedRadioButton == radioButton8)
                    {
                        indeks = 3;
                        string[] semtler = File.ReadAllLines("semt.txt");
                        foreach (string semt in semtler)
                        {
                            comboBox1.Items.Add(semt);
                        }
                    }
                    else if (clickedRadioButton == radioButton7)
                    {
                        indeks =7;
                        foreach (var tur in Enum.GetValues(typeof(Ev.EvTuru)))
                        {
                            comboBox1.Items.Add(tur);
                        }
                        comboBox1.SelectedIndex = -1;
                    }
                    
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(sorgukayitpath, FileMode.Create))
                if (maskedTextBox1.Visible)
                {
                    if (radioButton9.Checked)
                    {
                        degerint = Convert.ToInt32(maskedTextBox1.Text);
                    }
                    else
                    {
                        degerstr = maskedTextBox1.Text;
                    }
                }
                else if (comboBox1.Visible)
                {
                    degerstr = comboBox1.SelectedItem.ToString();
                }
                else if (numericUpDown1.Visible)
                {
                    degerint = (int)numericUpDown1.Value;
                }

            if (radioButton3.Checked || radioButton4.Checked || radioButton5.Checked || radioButton9.Checked)
            {
                sorguyap_ve_txtyazdır(indeks, degerint);
            }
            else
            {
                sorguyap_ve_txtyazdır(indeks, degerstr);
            }

            SorguSonucunuGoster();


        }
       
        private void sorguyap_ve_txtyazdır(int indeks, int deger)
        {
            arsiv = checkBox3.Checked ? true : false;

            string[] evler = File.ReadAllLines(sorgupath);
            foreach (var ev in evler)
            {
                string[] evparca = ev.Split(",");

                if (lastcheckbox == checkBox1)
                {
                    if (Convert.ToInt16(evparca[indeks]) < deger && evparca[6] == arsiv.ToString())
                    {
                        using (StreamWriter sw = new StreamWriter(sorgukayitpath,true))
                        {
                            sw.WriteLine(ev);
                        }
                    }
                }
                else if (lastcheckbox == checkBox2)
                {
                    if (Convert.ToInt16(evparca[indeks]) > deger && evparca[6] == arsiv.ToString())
                    {
                        using (StreamWriter sw = new StreamWriter(sorgukayitpath, true))
                        {
                            sw.WriteLine(ev);
                        }
                    }
                }
                else
                {
                    if (Convert.ToInt16(evparca[indeks]) == deger && evparca[6] == arsiv.ToString())
                    {
                        using (StreamWriter sw = new StreamWriter(sorgukayitpath, true))
                        {
                            sw.WriteLine(ev);
                        }
                    }
                }
            }
        }

        private void sorguyap_ve_txtyazdır(int indeks, string deger)
        {
            arsiv = checkBox3.Checked ? true : false;

            string[] evler = File.ReadAllLines(sorgupath);
            foreach (var ev in evler)
            {
                string[] evparca = ev.Split(",");
                if ((evparca[indeks]) == deger && evparca[6] == arsiv.ToString())
                {
                    using (StreamWriter sw = new StreamWriter(sorgukayitpath,true))
                    {
                        sw.WriteLine(ev);
                    }
                }
            }
        }

        private void SorguSonucunuGoster()
        {
            // Dosyadaki tüm satırları oku
            string[] lines = File.ReadAllLines(sorgukayitpath);
            int lineCount = lines.Length;

            // FlowLayoutPanel'deki önceki ListBox'ları temizle
            flowLayoutPanel1.Controls.Clear();

            // FlowLayoutPanel ayarları
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.WrapContents = false;

            for (int i = 0; i < lineCount; i++)
            {
                // Yeni ListBox oluştur
                ListBox listBox = new ListBox();
                listBox.Width = 200;
                listBox.Height = 270;
                listBox.Margin = new Padding(30, 30, 0, 0);

                // Satırı , ile split et
                string[] evData = lines[i].Split(',');
                if (evData[0] == null)
                {
                    continue;
                }

                // Satırdaki verilere göre ListBox'a ekle
                listBox.Items.Add($"Emlak Numarası: {evData[0]}");
                listBox.Items.Add($"Oda Sayısı: {evData[1]}");
                listBox.Items.Add($"Kat Numarası: {evData[2]}");
                listBox.Items.Add($"Semt: {evData[3]}");
                listBox.Items.Add($"Alan: {evData[4]} m²");
                listBox.Items.Add($"Yapım Tarihi: {DateTime.ParseExact(evData[5], "dd.MM.yyyy", null):dd.MM.yyyy}");
                listBox.Items.Add($"Aktif: {(evData[6] == "False" ? "Satılmadı" : "Satıldı")}");
                listBox.Items.Add($"Tür: {evData[7]}");
                listBox.Items.Add($"Satış Türü: {evData[8]}");

                if (radioButton1.Checked)
                {
                    // Satılık ev verilerini ekle
                    listBox.Items.Add($"Fiyat: {evData[9]} TL");
                    listBox.Items.Add($"Yaş: {evData[10]}");
                    listBox.MouseDoubleClick += (sender, e) =>
                    {
                        var evDetaylari = new Dictionary<string, string>
            {
                            { "Emlak Numarası", evData[0] },
                            { "Oda Sayısı", evData[1] },
                            { "Kat Numarası", evData[2] },
                            { "Semt", evData[3] },
                            { "Alan", evData[4] },
                            { "Yapım Tarihi", evData[5] },
                            { "Aktif", (evData[6] == "False" ? "Satılmadı" : "Satıldı")},
                            { "Tür", evData[7] },
                            { "Satış Türü", evData[8] },
                            { "Fiyat", evData[9]},
                            { "Yaş",evData[10]}
                        };

                        // DetayEv formunu dictionary ile açın
                        EvDüzenle düzenleform = new EvDüzenle(evDetaylari,1);
                        düzenleform.ShowDialog();
                    };
                }
                else if (radioButton2.Checked)
                {
                    // Kiralık ev verilerini ekle
                    listBox.Items.Add($"Depozito: {evData[9]} TL");
                    listBox.Items.Add($"Kira: {evData[10]} TL");
                    listBox.Items.Add($"Yaş: {evData[11]}");
                    listBox.MouseDoubleClick += (sender, e) =>
                    {
                        var evDetaylari = new Dictionary<string, string>
                        {
                            { "Emlak Numarası", evData[0] },
                            { "Oda Sayısı", evData[1] },
                            { "Kat Numarası", evData[2] },
                            { "Semt", evData[3] },
                            { "Alan", evData[4] },
                            { "Yapım Tarihi", evData[5] },
                            { "Aktif", (evData[6] == "False" ? "Satılmadı" : "Satıldı") },
                            { "Tür", evData[7] },
                            { "Satış Türü", evData[8] },
                            { "Depozito",evData[9]},
                            { "Kira",evData[10]},
                            { "Yaş",evData[11]}
                        };

                        // DetayEv formunu dictionary ile açın
                        EvDüzenle düzenleform = new EvDüzenle(evDetaylari,2);
                        düzenleform.ShowDialog();
                    };
                }

                

                flowLayoutPanel1.Controls.Add(listBox);
            }
        }

    }
}
