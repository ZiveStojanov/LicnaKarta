namespace LicnaKartaWindowsForms
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrikaciNovaSlika = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnZacuvaj = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbMestoNaRaganje = new System.Windows.Forms.TextBox();
            this.tbDatumNaVazenje = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbDatumNaIzdavanje = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbMaticen = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPol = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbDatumNaRaganje = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDrzavjanstvo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodadiNovoLice = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnIzvestaj = new System.Windows.Forms.Button();
            this.btnIzbrisiLice = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnPromenaLice = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbBrPominatRok = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tbVkupenBrLica = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnObnoviDatum = new System.Windows.Forms.Button();
            this.listLicniKarti = new LicnaKartaWindowsForms.MyListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Листа од лични карти:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObnoviDatum);
            this.groupBox1.Controls.Add(this.btnPrikaciNovaSlika);
            this.groupBox1.Controls.Add(this.btnOtkazi);
            this.groupBox1.Controls.Add(this.btnZacuvaj);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.tbAdresa);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.tbMestoNaRaganje);
            this.groupBox1.Controls.Add(this.tbDatumNaVazenje);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbDatumNaIzdavanje);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbMaticen);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbPol);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbDatumNaRaganje);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbDrzavjanstvo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbPrezime);
            this.groupBox1.Controls.Add(this.tbIme);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(196, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 270);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детален приказ за лицето";
            // 
            // btnPrikaciNovaSlika
            // 
            this.btnPrikaciNovaSlika.Location = new System.Drawing.Point(7, 204);
            this.btnPrikaciNovaSlika.Name = "btnPrikaciNovaSlika";
            this.btnPrikaciNovaSlika.Size = new System.Drawing.Size(134, 23);
            this.btnPrikaciNovaSlika.TabIndex = 25;
            this.btnPrikaciNovaSlika.Text = "Прикачи слика";
            this.btnPrikaciNovaSlika.UseVisualStyleBackColor = true;
            this.btnPrikaciNovaSlika.Visible = false;
            this.btnPrikaciNovaSlika.Click += new System.EventHandler(this.btnPrikaciNovaSlika_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(391, 230);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(100, 23);
            this.btnOtkazi.TabIndex = 24;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Visible = false;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnZacuvaj
            // 
            this.btnZacuvaj.Location = new System.Drawing.Point(149, 230);
            this.btnZacuvaj.Name = "btnZacuvaj";
            this.btnZacuvaj.Size = new System.Drawing.Size(109, 23);
            this.btnZacuvaj.TabIndex = 23;
            this.btnZacuvaj.Text = "Зачувај промени";
            this.btnZacuvaj.UseVisualStyleBackColor = true;
            this.btnZacuvaj.Visible = false;
            this.btnZacuvaj.Click += new System.EventHandler(this.btnZacuvaj_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(349, 204);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.ReadOnly = true;
            this.tbAdresa.Size = new System.Drawing.Size(134, 20);
            this.tbAdresa.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(346, 188);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Адреса / Address ";
            // 
            // tbMestoNaRaganje
            // 
            this.tbMestoNaRaganje.AutoCompleteCustomSource.AddRange(new string[] {
            "Берово",
            "Битола",
            "Богданци",
            "Валандово",
            "Вевчани",
            "Велес",
            "Виница",
            "Гевгелија",
            "Гостивар",
            "Градско",
            "Дебар",
            "Делчево",
            "Демир Капија",
            "Демир Хисар",
            "Дојран",
            "Кавадарци",
            "Кичево",
            "Кратово",
            "Кочани",
            "Крива Паланка",
            "Крушево",
            "Куманово",
            "Македонска Каменица",
            "Македонски Брод",
            "Неготино",
            "Охрид",
            "Пехчево",
            "Прилеп",
            "Пробиштип",
            "Радовиш",
            "Ресен",
            "Росоман",
            "Свети Николе",
            "Струга",
            "Струмица",
            "Тетово",
            "Штип"});
            this.tbMestoNaRaganje.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbMestoNaRaganje.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbMestoNaRaganje.Location = new System.Drawing.Point(349, 165);
            this.tbMestoNaRaganje.Name = "tbMestoNaRaganje";
            this.tbMestoNaRaganje.ReadOnly = true;
            this.tbMestoNaRaganje.Size = new System.Drawing.Size(134, 20);
            this.tbMestoNaRaganje.TabIndex = 19;
            // 
            // tbDatumNaVazenje
            // 
            this.tbDatumNaVazenje.Location = new System.Drawing.Point(349, 126);
            this.tbDatumNaVazenje.Name = "tbDatumNaVazenje";
            this.tbDatumNaVazenje.ReadOnly = true;
            this.tbDatumNaVazenje.Size = new System.Drawing.Size(134, 20);
            this.tbDatumNaVazenje.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(346, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Место на раѓање / Place of birth";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(346, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Важи до / Date of expiry";
            // 
            // tbDatumNaIzdavanje
            // 
            this.tbDatumNaIzdavanje.Location = new System.Drawing.Point(149, 204);
            this.tbDatumNaIzdavanje.Name = "tbDatumNaIzdavanje";
            this.tbDatumNaIzdavanje.ReadOnly = true;
            this.tbDatumNaIzdavanje.Size = new System.Drawing.Size(134, 20);
            this.tbDatumNaIzdavanje.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(149, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Датум на издавање / Date of issue";
            // 
            // tbMaticen
            // 
            this.tbMaticen.Location = new System.Drawing.Point(349, 87);
            this.tbMaticen.Name = "tbMaticen";
            this.tbMaticen.ReadOnly = true;
            this.tbMaticen.Size = new System.Drawing.Size(134, 20);
            this.tbMaticen.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(346, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Матичен број / Personal No.";
            // 
            // tbPol
            // 
            this.tbPol.Location = new System.Drawing.Point(349, 48);
            this.tbPol.Name = "tbPol";
            this.tbPol.ReadOnly = true;
            this.tbPol.Size = new System.Drawing.Size(62, 20);
            this.tbPol.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(346, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Пол / Sex";
            // 
            // tbDatumNaRaganje
            // 
            this.tbDatumNaRaganje.Location = new System.Drawing.Point(149, 165);
            this.tbDatumNaRaganje.Name = "tbDatumNaRaganje";
            this.tbDatumNaRaganje.ReadOnly = true;
            this.tbDatumNaRaganje.Size = new System.Drawing.Size(134, 20);
            this.tbDatumNaRaganje.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Датум на раѓање / Date of birth";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(6, 244);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(135, 20);
            this.tbID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID лична карта";
            // 
            // tbDrzavjanstvo
            // 
            this.tbDrzavjanstvo.AutoCompleteCustomSource.AddRange(new string[] {
            "Македонско",
            "Албанско",
            "Турско",
            "Грчко",
            "Хрватско",
            "Српско",
            "Бошњачко",
            "Австриско",
            "Германско",
            "Бугарско",
            "Француско",
            "Англиско"});
            this.tbDrzavjanstvo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbDrzavjanstvo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbDrzavjanstvo.Location = new System.Drawing.Point(149, 126);
            this.tbDrzavjanstvo.Name = "tbDrzavjanstvo";
            this.tbDrzavjanstvo.ReadOnly = true;
            this.tbDrzavjanstvo.Size = new System.Drawing.Size(134, 20);
            this.tbDrzavjanstvo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Државјанство / Nationalitiy";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(149, 87);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.ReadOnly = true;
            this.tbPrezime.Size = new System.Drawing.Size(134, 20);
            this.tbPrezime.TabIndex = 3;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(149, 48);
            this.tbIme.Name = "tbIme";
            this.tbIme.ReadOnly = true;
            this.tbIme.Size = new System.Drawing.Size(134, 20);
            this.tbIme.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Презиме / Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Име / Name:";
            // 
            // btnDodadiNovoLice
            // 
            this.btnDodadiNovoLice.Location = new System.Drawing.Point(15, 407);
            this.btnDodadiNovoLice.Name = "btnDodadiNovoLice";
            this.btnDodadiNovoLice.Size = new System.Drawing.Size(149, 39);
            this.btnDodadiNovoLice.TabIndex = 3;
            this.btnDodadiNovoLice.Text = "Додади ново лице";
            this.btnDodadiNovoLice.UseVisualStyleBackColor = true;
            this.btnDodadiNovoLice.Click += new System.EventHandler(this.btnDodadiNovoLice_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(72, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "РЕПУБЛИКА МАКЕДОНИЈА";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(107, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "ЛИЧНА КАРТА";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(437, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "REPUBLIC OF MACEDONIA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.Location = new System.Drawing.Point(464, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "IDENTITY CARD";
            // 
            // btnIzvestaj
            // 
            this.btnIzvestaj.Location = new System.Drawing.Point(18, 73);
            this.btnIzvestaj.Name = "btnIzvestaj";
            this.btnIzvestaj.Size = new System.Drawing.Size(162, 35);
            this.btnIzvestaj.TabIndex = 8;
            this.btnIzvestaj.Text = "Направи извештај";
            this.btnIzvestaj.UseVisualStyleBackColor = true;
            this.btnIzvestaj.Click += new System.EventHandler(this.btnIzvestaj_Click);
            // 
            // btnIzbrisiLice
            // 
            this.btnIzbrisiLice.Enabled = false;
            this.btnIzbrisiLice.Location = new System.Drawing.Point(149, 23);
            this.btnIzbrisiLice.Name = "btnIzbrisiLice";
            this.btnIzbrisiLice.Size = new System.Drawing.Size(117, 30);
            this.btnIzbrisiLice.TabIndex = 9;
            this.btnIzbrisiLice.Text = "Избриши лице";
            this.btnIzbrisiLice.UseVisualStyleBackColor = true;
            this.btnIzbrisiLice.Click += new System.EventHandler(this.btnIzbrisiLice_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Број на лична карта",
            "Име",
            "Презиме"});
            this.cbFilter.Location = new System.Drawing.Point(12, 335);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(152, 21);
            this.cbFilter.TabIndex = 10;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            this.cbFilter.Click += new System.EventHandler(this.cbFilter_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 314);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Прикажи според:";
            // 
            // btnPromenaLice
            // 
            this.btnPromenaLice.Enabled = false;
            this.btnPromenaLice.Location = new System.Drawing.Point(146, 72);
            this.btnPromenaLice.Name = "btnPromenaLice";
            this.btnPromenaLice.Size = new System.Drawing.Size(120, 33);
            this.btnPromenaLice.TabIndex = 12;
            this.btnPromenaLice.Text = "Промена на лице";
            this.btnPromenaLice.UseVisualStyleBackColor = true;
            this.btnPromenaLice.Click += new System.EventHandler(this.btnPromenaLice_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.tbBrPominatRok);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.btnIzvestaj);
            this.groupBox2.Location = new System.Drawing.Point(502, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 114);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Извештај";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 53);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(153, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "поминат рок на лични карти:";
            // 
            // tbBrPominatRok
            // 
            this.tbBrPominatRok.Location = new System.Drawing.Point(106, 17);
            this.tbBrPominatRok.Name = "tbBrPominatRok";
            this.tbBrPominatRok.ReadOnly = true;
            this.tbBrPominatRok.Size = new System.Drawing.Size(79, 20);
            this.tbBrPominatRok.TabIndex = 11;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "Број на лица:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(158, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Прикажи извештај на лица со";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.btnIzbrisiLice);
            this.groupBox3.Controls.Add(this.btnPromenaLice);
            this.groupBox3.Location = new System.Drawing.Point(196, 334);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 115);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ажурирање на лицето";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(26, 82);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 13);
            this.label22.TabIndex = 14;
            this.label22.Text = "Направи промена:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(26, 40);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "Избриши: ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 374);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(111, 13);
            this.label23.TabIndex = 15;
            this.label23.Text = "Вкупен број на лица:";
            // 
            // tbVkupenBrLica
            // 
            this.tbVkupenBrLica.Location = new System.Drawing.Point(126, 374);
            this.tbVkupenBrLica.Name = "tbVkupenBrLica";
            this.tbVkupenBrLica.ReadOnly = true;
            this.tbVkupenBrLica.Size = new System.Drawing.Size(64, 20);
            this.tbVkupenBrLica.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnObnoviDatum
            // 
            this.btnObnoviDatum.Location = new System.Drawing.Point(264, 230);
            this.btnObnoviDatum.Name = "btnObnoviDatum";
            this.btnObnoviDatum.Size = new System.Drawing.Size(116, 23);
            this.btnObnoviDatum.TabIndex = 26;
            this.btnObnoviDatum.Text = "Обнови датум";
            this.btnObnoviDatum.UseVisualStyleBackColor = true;
            this.btnObnoviDatum.Visible = false;
            this.btnObnoviDatum.Click += new System.EventHandler(this.btnObnoviDatum_Click);
            // 
            // listLicniKarti
            // 
            this.listLicniKarti.FormattingEnabled = true;
            this.listLicniKarti.Location = new System.Drawing.Point(12, 60);
            this.listLicniKarti.Name = "listLicniKarti";
            this.listLicniKarti.Size = new System.Drawing.Size(178, 251);
            this.listLicniKarti.TabIndex = 0;
            this.listLicniKarti.SelectedIndexChanged += new System.EventHandler(this.listLicniKarti_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 461);
            this.Controls.Add(this.tbVkupenBrLica);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDodadiNovoLice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listLicniKarti);
            this.Name = "Form1";
            this.Text = "Лична карта";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodadiNovoLice;
        private System.Windows.Forms.TextBox tbDatumNaRaganje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDrzavjanstvo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPol;
        private System.Windows.Forms.TextBox tbMaticen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbMestoNaRaganje;
        private System.Windows.Forms.TextBox tbDatumNaVazenje;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbDatumNaIzdavanje;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnIzvestaj;
        private System.Windows.Forms.Button btnIzbrisiLice;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnPromenaLice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbBrPominatRok;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbVkupenBrLica;
        private System.Windows.Forms.Button btnZacuvaj;
        private System.Windows.Forms.Button btnOtkazi;
        private MyListBox listLicniKarti;
        private System.Windows.Forms.Button btnPrikaciNovaSlika;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnObnoviDatum;
    }
}

