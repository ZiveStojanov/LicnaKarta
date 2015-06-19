using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LicnaKartaWindowsForms
{
    public partial class Dodadi_novo_Lice : Form
    {
        private char[] Alphabet = { 'A', 'B' ,'C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V',
                                  'W','X','Y','Z'};
        public string FileName { get; set; }

        public bool[] flags { get; set; }

        public User User1 { get; set; }
        public string imagePath { get; set; }

        public Dodadi_novo_Lice()
        {
            InitializeComponent();
            Popolni_ID();
            Popolni_Datumi();
            FileName = null;
            Popolni_MVR();
            flags = new bool[7];


        }

        public void Popolni_MVR()
        {
            cbIzdavac.Items.Add("МВР Скопје");
            cbIzdavac.Items.Add("МВР Битола");
            cbIzdavac.Items.Add("МВР Прилеп");
            cbIzdavac.Items.Add("МВР Охрид");
            cbIzdavac.Items.Add("МВР Тетово");
            cbIzdavac.Items.Add("МВР Куманово");
            cbIzdavac.Items.Add("МВР Велес");
            cbIzdavac.Items.Add("МВР Кавадарци");
            cbIzdavac.Items.Add("МВР Неготино");
            cbIzdavac.Items.Add("МВР Струмица");
            cbIzdavac.Items.Add("МВР Гевгелија");

        }

        public void Popolni_ID()
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            sb.Append(Alphabet[random.Next(27)]);

            for (int i = 0; i < 7; i++)
            {
                sb.Append(random.Next(10));
            }
            //proverka dali ima isto id vo bazata
            DBConnect konekcija = new DBConnect();
            if (konekcija.checkID_br_karta(sb.ToString()) != 0)
            {
                Popolni_ID();
            }
            else
            {
                tbID_licnaKarta.Text = sb.ToString();
            }
        }

        public void Popolni_Datumi()
        {
            DateTime dt = DateTime.Now;
            string sega = String.Format("{0:dd/MM/yyyy}", dt);
            tbDatum_na_izdavanje.Text = sega;

            int godina = dt.Year + 5;

            string smeneta = sega.Substring(0, 6) + godina.ToString();
            tbDatum_na_vaznost.Text = smeneta;

        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            if (checkFlags() && (rbFemale.Checked || rbMale.Checked))
            {
                if (rbFemale.Checked)
                {
                    string img = imagePath.Replace("\\", "\\\\");
                    User1 = new User(tbID_licnaKarta.Text, tbIme.Text, tbPrezime.Text, tbEMBG.Text, tbDrzavjanstvo.Text, rbFemale.Text, tbDatum_na_raganje.Text, tbDatum_na_izdavanje.Text, tbDatum_na_vaznost.Text, tbMesto_na_raganje.Text, tbAdresa.Text, cbIzdavac.SelectedItem.ToString(), img);
                }
                else if (rbMale.Checked) {
                    string img = imagePath.Replace("\\", "\\\\");
                    User1 = new User(tbID_licnaKarta.Text, tbIme.Text, tbPrezime.Text, tbEMBG.Text, tbDrzavjanstvo.Text, rbMale.Text, tbDatum_na_raganje.Text, tbDatum_na_izdavanje.Text, tbDatum_na_vaznost.Text, tbMesto_na_raganje.Text, tbAdresa.Text, cbIzdavac.SelectedItem.ToString(), img);
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Сите полиња се задолжителни!!!");
            }
        }

        

        private bool checkFlags()
        {
            for (int i = 0; i < 7; i++)
            {
                bool b = flags[i];

                if (!b)
                    return false;
            }
            return true;
        }

        private void btnDodadiSlika_Click(object sender, EventArgs e)
        {
            Bitmap bmpImg = null;
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                if (bmpImg != null)
                {
                    bmpImg.Dispose(); bmpImg = null;
                }
                try
                {
                    imagePath = null;
                    openFileDialog1.InitialDirectory = "C:\\";
                    bmpImg = new Bitmap(openFileDialog1.FileName);
                    imagePath = openFileDialog1.FileName;
                    string image = imagePath.Replace("\\", "\\\\");
                    
                    string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
                    string exeDir = Path.GetDirectoryName(exeFile);
                    string pathToProjectImage = exeDir.Replace("%20", " ");

                    
                    bmpImg.Save( @"images\\" + tbID_licnaKarta.Text + ".jpg");

                    string endPathToImages = pathToProjectImage + "\\images\\" + tbID_licnaKarta.Text + ".jpg";
                    //imagePath = endPathToImages;
                    imagePath = @"images\\" + tbID_licnaKarta.Text + ".jpg";
                    //MessageBox.Show(imagePath);
                    SuspendLayout();
                    pictureBox1.Image = bmpImg;
                    PerformLayout();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file \"" +
                    openFileDialog1.FileName + "\" from disk. Original error: " + ex.Message);
                }
            }

        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if (checkText(tbIme.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(tbIme, null);
                flags[0] = true;
            }
            else
            {
                errorProvider1.SetError(tbIme, "Името не е соодветно, обидете се повторно!");
                e.Cancel = true;
            }

        }



        private bool checkText(string text)
        {
            if (text.Trim().Length == 0)
                return false;
            foreach (char c in text)
            {
                if (Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void tbPrezime_Validating(object sender, CancelEventArgs e)
        {

            if (checkText(tbPrezime.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(tbPrezime, null);
                flags[1] = true;
            }
            else
            {
                errorProvider1.SetError(tbPrezime, "Презимето не е соодветно, обидете се повторно!");
                e.Cancel = true;
            }
        }

        private void tbEMBG_Validating(object sender, CancelEventArgs e)
        {
            if (tbEMBG.Text.Length != 13)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEMBG, "Матичниот број мора да содржи точно 13 цифри");
            }
            else if (!(tbEMBG.Text[4].Equals('9') || tbEMBG.Text[4].Equals('0')))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEMBG, "Внесете валиден матичен број");
            }
            else if (tbEMBG.Text[4].Equals('0') && (tbEMBG.Text.Substring(5, 2).CompareTo("15") > 0))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEMBG, "Внесете валиден матичен број");
            }

            else if (tbEMBG.Text[4].Equals('0') && (tbEMBG.Text.Substring(5, 2).CompareTo("15") == 0) && (tbEMBG.Text.Substring(2, 2).CompareTo("05") >= 0))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEMBG, "Внесете валиден матичен број");
            }

            else if (!checkMeseci())
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEMBG, "Внесете валиден матичен број");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbEMBG, null);
                flags[2] = true;
            }
        }

        private bool checkMeseci()
        {
            int den = 0;
            int.TryParse(tbEMBG.Text.Substring(0, 2), out den);
            if (pomosna() == 31 && (den > 31))
                return false;
            else if (pomosna() == 30 && den > 30)
                return false;
            else if (pomosna() == 28 && den > 28)
                return false;
            else if (pomosna() == 0)
                return false;
            return true;
        }

        private int pomosna()
        {
            string maticen = tbEMBG.Text;
            int broj = 0;
            int.TryParse(maticen.Substring(2, 2), out broj);
            if (broj == 1 || broj == 3 || broj == 5 || broj == 7 || broj == 8
                || broj == 10 || broj == 12)
                return 31;
            else if (broj == 2)
                return 28;
            else if (broj == 4 || broj == 6 || broj == 9 || broj == 11)
                return 30;
            return 0;
        }

        private void tbEMBG_Validated(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(tbEMBG.Text.Substring(0, 4));
            if (tbEMBG.Text[4].Equals('9'))
                sb.Append(1);
            else
                sb.Append(2);
            sb.Append(tbEMBG.Text.Substring(4, 3));
            tbDatum_na_raganje.Text = sb.ToString();
            flags[2] = true;
            

        }

        private void tbDrzavjanstvo_Validating(object sender, CancelEventArgs e)
        {
            if (checkText(tbDrzavjanstvo.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(tbDrzavjanstvo, null);
                flags[3] = true;
            }
            else
            {
                errorProvider1.SetError(tbDrzavjanstvo, "Државјанството не е точно, внесете го повторно!");
                e.Cancel = true;
            }
        }

        private void tbMesto_na_raganje_Validating(object sender, CancelEventArgs e)
        {
            if (checkText(tbMesto_na_raganje.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(tbMesto_na_raganje, null);
                flags[4] = true;
            }
            else
            {
                errorProvider1.SetError(tbMesto_na_raganje, "Местото на раѓање не е валидно, внесете го повторно!");
                e.Cancel = true;
            }
        }

        private void tbAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (tbAdresa.Text.Trim().Length != 0)
            {
                e.Cancel = false;
                errorProvider1.SetError(tbAdresa, null);
                flags[5] = true;
            }
            else
            {
                errorProvider1.SetError(tbAdresa, "Адресата не е валидна, внесете ја повторно!");
                e.Cancel = true;
            }
        }

        private void cbIzdavac_Validating(object sender, CancelEventArgs e)
        {
            if (cbIzdavac.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbIzdavac, "Изберете издавач");
                e.Cancel = true;
                flags[6] = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbIzdavac, null);
            }
        }

        private void cbIzdavac_SelectedIndexChanged(object sender, EventArgs e)
        {
            flags[6] = true;
        }

    }
}