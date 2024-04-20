namespace SinemaRezervasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxhangiSALONDA = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFİLMADI = new System.Windows.Forms.TextBox();
            this.comboBoxFİLMSAATİ = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxSEÇİLENSAAT = new System.Windows.Forms.ComboBox();
            this.comboBoxSEÇİLENFİLM = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxBİLETNO = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxSEÇİLENKOLTUKNO = new System.Windows.Forms.TextBox();
            this.textBoxTELNO = new System.Windows.Forms.TextBox();
            this.textBoxSOYADI = new System.Windows.Forms.TextBox();
            this.textBoxADI = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSALONADI = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxSALONKAPASİTESİ = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(65, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(753, 330);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.comboBoxhangiSALONDA);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxFİLMADI);
            this.tabPage1.Controls.Add(this.comboBoxFİLMSAATİ);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(745, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "FİLM";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // comboBoxhangiSALONDA
            // 
            this.comboBoxhangiSALONDA.FormattingEnabled = true;
            this.comboBoxhangiSALONDA.Location = new System.Drawing.Point(562, 135);
            this.comboBoxhangiSALONDA.Name = "comboBoxhangiSALONDA";
            this.comboBoxhangiSALONDA.Size = new System.Drawing.Size(177, 24);
            this.comboBoxhangiSALONDA.TabIndex = 8;
            this.comboBoxhangiSALONDA.SelectedIndexChanged += new System.EventHandler(this.comboBoxhangiSALONDA_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(597, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 25);
            this.label13.TabIndex = 5;
            this.label13.Text = "SALON";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(202, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "FİLM ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(361, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "FİLM SAATİ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxFİLMADI
            // 
            this.textBoxFİLMADI.Location = new System.Drawing.Point(183, 135);
            this.textBoxFİLMADI.Name = "textBoxFİLMADI";
            this.textBoxFİLMADI.Size = new System.Drawing.Size(146, 22);
            this.textBoxFİLMADI.TabIndex = 2;
            this.textBoxFİLMADI.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBoxFİLMSAATİ
            // 
            this.comboBoxFİLMSAATİ.FormattingEnabled = true;
            this.comboBoxFİLMSAATİ.Items.AddRange(new object[] {
            "00:00",
            "00:30",
            "01:00",
            "01:30",
            "02:00",
            "02:30",
            "03:00",
            "03:30",
            "04:00",
            "04:30",
            "05:00",
            "05:30",
            "06:00",
            "06:30",
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30"});
            this.comboBoxFİLMSAATİ.Location = new System.Drawing.Point(350, 135);
            this.comboBoxFİLMSAATİ.Name = "comboBoxFİLMSAATİ";
            this.comboBoxFİLMSAATİ.Size = new System.Drawing.Size(170, 24);
            this.comboBoxFİLMSAATİ.TabIndex = 1;
            this.comboBoxFİLMSAATİ.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(286, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage2.Controls.Add(this.comboBoxSEÇİLENSAAT);
            this.tabPage2.Controls.Add(this.comboBoxSEÇİLENFİLM);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.textBoxBİLETNO);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textBoxSEÇİLENKOLTUKNO);
            this.tabPage2.Controls.Add(this.textBoxTELNO);
            this.tabPage2.Controls.Add(this.textBoxSOYADI);
            this.tabPage2.Controls.Add(this.textBoxADI);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(745, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SEANS";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // comboBoxSEÇİLENSAAT
            // 
            this.comboBoxSEÇİLENSAAT.FormattingEnabled = true;
            this.comboBoxSEÇİLENSAAT.Location = new System.Drawing.Point(535, 184);
            this.comboBoxSEÇİLENSAAT.Name = "comboBoxSEÇİLENSAAT";
            this.comboBoxSEÇİLENSAAT.Size = new System.Drawing.Size(162, 24);
            this.comboBoxSEÇİLENSAAT.TabIndex = 17;
            this.comboBoxSEÇİLENSAAT.SelectedIndexChanged += new System.EventHandler(this.comboBoxSEÇİLENSAAT_SelectedIndexChanged);
            // 
            // comboBoxSEÇİLENFİLM
            // 
            this.comboBoxSEÇİLENFİLM.FormattingEnabled = true;
            this.comboBoxSEÇİLENFİLM.Location = new System.Drawing.Point(527, 70);
            this.comboBoxSEÇİLENFİLM.Name = "comboBoxSEÇİLENFİLM";
            this.comboBoxSEÇİLENFİLM.Size = new System.Drawing.Size(161, 24);
            this.comboBoxSEÇİLENFİLM.TabIndex = 16;
            this.comboBoxSEÇİLENFİLM.SelectedIndexChanged += new System.EventHandler(this.comboBoxSEÇİLENFİLM_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(531, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "SEÇİLEN SAAT";
            // 
            // textBoxBİLETNO
            // 
            this.textBoxBİLETNO.Location = new System.Drawing.Point(297, 184);
            this.textBoxBİLETNO.Name = "textBoxBİLETNO";
            this.textBoxBİLETNO.Size = new System.Drawing.Size(100, 22);
            this.textBoxBİLETNO.TabIndex = 13;
            this.textBoxBİLETNO.TextChanged += new System.EventHandler(this.textBoxBİLETNO_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(3, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "BİLET NO";
            // 
            // textBoxSEÇİLENKOLTUKNO
            // 
            this.textBoxSEÇİLENKOLTUKNO.Location = new System.Drawing.Point(297, 224);
            this.textBoxSEÇİLENKOLTUKNO.Name = "textBoxSEÇİLENKOLTUKNO";
            this.textBoxSEÇİLENKOLTUKNO.Size = new System.Drawing.Size(100, 22);
            this.textBoxSEÇİLENKOLTUKNO.TabIndex = 11;
            this.textBoxSEÇİLENKOLTUKNO.TextChanged += new System.EventHandler(this.textBoxSEÇİLENKOLTUKNO_TextChanged);
            // 
            // textBoxTELNO
            // 
            this.textBoxTELNO.Location = new System.Drawing.Point(297, 145);
            this.textBoxTELNO.Name = "textBoxTELNO";
            this.textBoxTELNO.Size = new System.Drawing.Size(100, 22);
            this.textBoxTELNO.TabIndex = 10;
            this.textBoxTELNO.TextChanged += new System.EventHandler(this.textBoxTELNO_TextChanged);
            // 
            // textBoxSOYADI
            // 
            this.textBoxSOYADI.Location = new System.Drawing.Point(297, 107);
            this.textBoxSOYADI.Name = "textBoxSOYADI";
            this.textBoxSOYADI.Size = new System.Drawing.Size(100, 22);
            this.textBoxSOYADI.TabIndex = 9;
            this.textBoxSOYADI.TextChanged += new System.EventHandler(this.textBoxSOYADI_TextChanged);
            // 
            // textBoxADI
            // 
            this.textBoxADI.Location = new System.Drawing.Point(297, 71);
            this.textBoxADI.Name = "textBoxADI";
            this.textBoxADI.Size = new System.Drawing.Size(100, 22);
            this.textBoxADI.TabIndex = 8;
            this.textBoxADI.TextChanged += new System.EventHandler(this.textBoxADI_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(3, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(267, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "SEÇİLEN KOLTUK NUMARASI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(3, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "TELNO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(3, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "SOYAD:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(3, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "AD:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(530, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "SEÇİLEN FİLM";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(346, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "EKLE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.textBoxSALONADI);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.comboBoxSALONKAPASİTESİ);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(745, 301);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SALON";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(518, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "SALON KAPASİTESİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(300, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "SALON ADI";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxSALONADI
            // 
            this.textBoxSALONADI.Location = new System.Drawing.Point(253, 153);
            this.textBoxSALONADI.Name = "textBoxSALONADI";
            this.textBoxSALONADI.Size = new System.Drawing.Size(215, 22);
            this.textBoxSALONADI.TabIndex = 2;
            this.textBoxSALONADI.TextChanged += new System.EventHandler(this.textBoxSALONADI_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "EKLE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBoxSALONKAPASİTESİ
            // 
            this.comboBoxSALONKAPASİTESİ.FormattingEnabled = true;
            this.comboBoxSALONKAPASİTESİ.Items.AddRange(new object[] {
            "100",
            "130",
            "140",
            "150",
            "180",
            "200",
            "300"});
            this.comboBoxSALONKAPASİTESİ.Location = new System.Drawing.Point(536, 153);
            this.comboBoxSALONKAPASİTESİ.Name = "comboBoxSALONKAPASİTESİ";
            this.comboBoxSALONKAPASİTESİ.Size = new System.Drawing.Size(172, 24);
            this.comboBoxSALONKAPASİTESİ.TabIndex = 0;
            this.comboBoxSALONKAPASİTESİ.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "SİNEMA TAKİP UYGULAMASI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(63, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 25);
            this.label14.TabIndex = 5;
            this.label14.Text = "SALON ID";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(39, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 25);
            this.label15.TabIndex = 9;
            this.label15.Text = "FİLM ID";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxFİLMSAATİ;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBoxSALONKAPASİTESİ;
        private System.Windows.Forms.TextBox textBoxFİLMADI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxSALONADI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSEÇİLENKOLTUKNO;
        private System.Windows.Forms.TextBox textBoxTELNO;
        private System.Windows.Forms.TextBox textBoxSOYADI;
        private System.Windows.Forms.TextBox textBoxADI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxBİLETNO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxSEÇİLENSAAT;
        private System.Windows.Forms.ComboBox comboBoxSEÇİLENFİLM;
        private System.Windows.Forms.ComboBox comboBoxhangiSALONDA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label15;
    }
}

