namespace EmlakForm
{
    partial class EvEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            maskedTextBox2 = new MaskedTextBox();
            label9 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            groupBox2 = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            comboBox2 = new ComboBox();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            radioButton3 = new RadioButton();
            label7 = new Label();
            radioButton4 = new RadioButton();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(472, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 195);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Satış Türü";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(124, 154);
            maskedTextBox2.Mask = "00000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(125, 27);
            maskedTextBox2.TabIndex = 12;
            maskedTextBox2.ValidatingType = typeof(int);
            maskedTextBox2.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 157);
            label9.Name = "label9";
            label9.Size = new Size(126, 20);
            label9.TabIndex = 3;
            label9.Text = "Bir seçim yap !!!!";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(44, 115);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(74, 24);
            radioButton2.TabIndex = 2;
            radioButton2.Text = "Kiralık";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(44, 74);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(72, 24);
            radioButton1.TabIndex = 1;
            radioButton1.Text = "Satılık";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 0;
            label1.Text = "Ev Satılık mı Kiralık mı?";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(maskedTextBox1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(34, 32);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(405, 400);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ev Hakkında Bilgiler";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(151, 170);
            maskedTextBox1.Mask = "00000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(215, 27);
            maskedTextBox1.TabIndex = 4;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(151, 343);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(215, 28);
            comboBox2.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(66, 346);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 10;
            label8.Text = "Ev Türü :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(151, 289);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 294);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 8;
            label6.Text = "Yapıldığı Tarih :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(151, 228);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(215, 28);
            comboBox1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 231);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 6;
            label5.Text = "Bulunduğu Semt :";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(151, 103);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(215, 27);
            numericUpDown2.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(151, 42);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(215, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 170);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 2;
            label4.Text = "Ev alanı (m2) :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 105);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 1;
            label3.Text = "Kat Numarası :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 44);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 0;
            label2.Text = "Oda Sayısı :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton3);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(radioButton4);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(472, 242);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(255, 190);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Evin Durumu";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(44, 84);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(129, 24);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "Evet, anlaşıldı.";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 40);
            label7.Name = "label7";
            label7.Size = new Size(143, 20);
            label7.TabIndex = 0;
            label7.Text = "Ev için anlaşıldı mı?";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(44, 132);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(157, 24);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Hayır, anlaşılmadı.";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(34, 464);
            button1.Name = "button1";
            button1.Size = new Size(693, 31);
            button1.TabIndex = 3;
            button1.Text = "Evi Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EvEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 526);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "EvEkle";
            Text = "EvEkle";
            Load += EvEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private GroupBox groupBox3;
        private RadioButton radioButton3;
        private Label label7;
        private RadioButton radioButton4;
        private Button button1;
        private ComboBox comboBox2;
        private Label label8;
        private Label label9;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
    }
}