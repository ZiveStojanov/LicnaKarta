using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Reflection;

namespace LicnaKartaWindowsForms
{
    public partial class Form1 : Form
    {
        private List<string>[] listUsers;
        private List<string>[] listEndDateUsers;
        public string imagePath { get; set; }
        public bool isClickedPrikaciiSlika = false;
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            LoadUsers();
            CountUsers();
            CountEndDateUsers();
        }

        private void btnDodadiNovoLice_Click(object sender, EventArgs e)
        {

            Dodadi_novo_Lice novoLice = new Dodadi_novo_Lice();

            if (novoLice.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DBConnect konekcija = new DBConnect();

                konekcija.Insert(novoLice.User1);
                
                listLicniKarti.Items.Clear();
               // DBConnect konekcija = new DBConnect();
                listUsers = konekcija.Select();
                listLicniKarti.BeginUpdate();
                for (int i = 0; i < listUsers[0].Count; i++)
                {

                    User user = new User();
                    user.Id_br_karta = listUsers[0][i];
                    user.Ime = listUsers[1][i];
                    user.Prezime = listUsers[2][i];
                    user.EMBG = listUsers[3][i];
                    user.Drzavjanstvo = listUsers[4][i];
                    user.Pol = listUsers[5][i];
                    user.Datum_na_raganje = listUsers[6][i];
                    user.Datum_na_izdavanje = listUsers[7][i];
                    user.Datum_na_vaznost = listUsers[8][i];
                    user.Mesto_na_raganje = listUsers[9][i];
                    user.Adresa = listUsers[10][i];
                    user.Izdavac = listUsers[11][i];
                    user.PatekaKonSlikata = listUsers[12][i];

                    listLicniKarti.Items.Add(user);
                }
                listLicniKarti.EndUpdate();
                CountUsers();
            }
        }

        public void LoadUsers()
        {
            listLicniKarti.Items.Clear();
             DBConnect konekcija = new DBConnect();
            listUsers = konekcija.Select();
            for (int i = 0; i < listUsers[0].Count; i++)
            {

                User user = new User();
                user.Id_br_karta = listUsers[0][i];
                user.Ime = listUsers[1][i];
                user.Prezime = listUsers[2][i];
                user.EMBG = listUsers[3][i];
                user.Drzavjanstvo = listUsers[4][i];
                user.Pol = listUsers[5][i];
                user.Datum_na_raganje = listUsers[6][i];
                user.Datum_na_izdavanje = listUsers[7][i];
                user.Datum_na_vaznost = listUsers[8][i];
                user.Mesto_na_raganje = listUsers[9][i];
                user.Adresa = listUsers[10][i];
                user.Izdavac = listUsers[11][i];
                user.PatekaKonSlikata = listUsers[12][i];

                listLicniKarti.Items.Add(user);

            }
        }

        public void CountUsers()
        {
            DBConnect konekcija = new DBConnect();

            tbVkupenBrLica.Text = string.Format("{0}",konekcija.Count());
            
        }

        public void CountEndDateUsers()
        {
            DBConnect konekcija = new DBConnect();
            tbBrPominatRok.Text = string.Format("{0}", konekcija.checkDataVaznost());
        }

        private void listLicniKarti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listLicniKarti.SelectedIndex >= 0)
            {
                User user = listLicniKarti.SelectedItem as User;
                tbAdresa.Text = user.Adresa;
                tbDatumNaIzdavanje.Text = user.Datum_na_izdavanje;
                tbDatumNaRaganje.Text = user.Datum_na_raganje;
                tbDatumNaVazenje.Text = user.Datum_na_vaznost;
                tbDrzavjanstvo.Text = user.Drzavjanstvo;
                tbID.Text = user.Id_br_karta;
                tbIme.Text = user.Ime;
                tbMaticen.Text = user.EMBG;
                tbMestoNaRaganje.Text = user.Mesto_na_raganje;
                tbPol.Text = user.Pol;
                tbPrezime.Text = user.Prezime;
                pictureBox2.ImageLocation = user.PatekaKonSlikata;
                btnPromenaLice.Enabled = true;
                btnIzbrisiLice.Enabled = true;
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            funkcija();
        }

        public void funkcija()
        {
            

            if (cbFilter.SelectedIndex != -1)
            {
                List<User> lista = new List<User>();

                foreach (Object o in listLicniKarti.Items)
                {
                    lista.Add(o as User);
                }
                if (cbFilter.SelectedIndex == 0) // licna karta
                {
                    lista = lista.OrderBy(x => x.Id_br_karta).ToList();
                    listLicniKarti.Items.Clear();
                    for (int i = 0; i < lista.Count; i++)
                    {
                        listLicniKarti.Items.Add(lista[i]);
                    }
                }
                if (cbFilter.SelectedIndex == 1) // ime
                {
                    lista = lista.OrderBy(x => x.Ime).ToList();
                    listLicniKarti.Items.Clear();
                    for (int i = 0; i < lista.Count; i++)
                    {
                        listLicniKarti.Items.Add(lista[i]);
                    }
                }
                if (cbFilter.SelectedIndex == 2) // prezime
                {
                    lista = lista.OrderBy(x => x.Prezime).ToList();
                    listLicniKarti.Items.Clear();
                    for (int i = 0; i < lista.Count; i++)
                    {
                        listLicniKarti.Items.Add(lista[i]);
                    }
                }

            }
            else
            {
                ClearText();
                btnIzbrisiLice.Enabled = false;
                btnPromenaLice.Enabled = false;
            }
            
            
        }

        private void btnIzbrisiLice_Click(object sender, EventArgs e)
        {
            User user = listLicniKarti.SelectedItem as User;
            DialogResult res = MessageBox.Show(String.Format("Дали сте сигурни дека сакате да го избришете лицето {0}",user) ,"Бришење на личност?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);


            if (listLicniKarti.SelectedItem != null && res == System.Windows.Forms.DialogResult.Yes)
            {

                DBConnect konekcija = new DBConnect();
                
                
                string id = user.Id_br_karta;
                listLicniKarti.Items.Remove(listLicniKarti.SelectedItem);
                //MessageBox.Show("Лицето со бој на лична карта " + id + " Име: " + user.Ime + " Презиме: " + user.Prezime + " е успешно избришано!!");
                listLicniKarti.Refresh();
                konekcija.Delete(id);

                CountUsers();
                CountEndDateUsers();
                ClearText();
                btnIzbrisiLice.Enabled = false;
                btnPromenaLice.Enabled = false;
            }
            
        }

        private void ClearText()
        {
            tbAdresa.Clear();
            tbDatumNaIzdavanje.Clear();
            tbDatumNaRaganje.Clear();
            tbDatumNaVazenje.Clear();
            tbDrzavjanstvo.Clear();
            tbID.Clear();
            tbIme.Clear();
            tbMaticen.Clear();
            tbMestoNaRaganje.Clear();
            tbPol.Clear();
            tbPrezime.Clear();
            pictureBox2.ImageLocation = null;
            
        }

        private void btnPromenaLice_Click(object sender, EventArgs e)
        {
            if (listLicniKarti.SelectedIndex != -1)
            {
                changeEnabled();
            }
        }

        private void changeEnabled()
        {
            User user = listLicniKarti.SelectedItem as User;
            if(user.Pol.Equals("Ж"))
                tbPrezime.ReadOnly = false;
            tbAdresa.ReadOnly = false;
            tbDrzavjanstvo.ReadOnly = false;
            btnZacuvaj.Visible = true;
            btnOtkazi.Visible = true;
            btnPrikaciNovaSlika.Visible = true;
            btnDodadiNovoLice.Enabled = false;
            listLicniKarti.Enabled = false;
            btnIzbrisiLice.Enabled = false;
            btnIzvestaj.Enabled = false;
            btnPromenaLice.Enabled = false;
            cbFilter.Enabled = false;
            btnObnoviDatum.Visible = true;
        }

        private void smeniDatumi()
        {
            int segasnaGodina = 0;
            int godina = 0;
            int.TryParse(tbDatumNaRaganje.Text.Substring(6, 4), out godina);
            int.TryParse(DateTime.Now.ToString().Substring(5, 4), out segasnaGodina);
            if (segasnaGodina - godina <= 27)
            {
                DateTime dt = DateTime.Now;
                string sega = String.Format("{0:MM/dd/yyyy}", dt);
                tbDatumNaIzdavanje.Text = sega;

                godina = dt.Year + 5;

                string smeneta = sega.Substring(0, 6) + godina.ToString();
                tbDatumNaVazenje.Text = smeneta;

            }
            else
            {
                DateTime dt = DateTime.Now;
                string sega = String.Format("{0:MM/dd/yyyy}", dt);
                tbDatumNaIzdavanje.Text = sega;

                godina = dt.Year + 10;

                string smeneta = sega.Substring(0, 6) + godina.ToString();
                tbDatumNaVazenje.Text = smeneta;
            }
        }

        private void btnIzvestaj_Click(object sender, EventArgs e)
        {

            if (tbBrPominatRok.Text.Equals("0"))
                MessageBox.Show("Во моментов нема лица со поминат датум на важење на личната карта!");
            else
            {
                Document document = new Document();
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


                StringBuilder sb = new StringBuilder();

                sb.Append("МВР ИЗВЕШТАЈ НА РЕПУБЛИКА МАКЕДОНИЈА \n Лични карти со поминат рок на траење.");
                sb.AppendLine();
                sb.Append(String.Format("{0,-18}{1,-15}{2,-15}{3,-15}", "Лична карта бр.", "Име", "Презиме", "Рок на важење "));
                sb.AppendLine();
                sb.AppendLine();

                DBConnect konekcija = new DBConnect();
                listEndDateUsers = konekcija.SelectEndDateUsers();
                for (int i = 0; i < listEndDateUsers[0].Count; i++)
                {

                    User user = new User();
                    user.Id_br_karta = listEndDateUsers[0][i];
                    user.Ime = listEndDateUsers[1][i];
                    user.Prezime = listEndDateUsers[2][i];
                    user.EMBG = listEndDateUsers[3][i];
                    user.Drzavjanstvo = listEndDateUsers[4][i];
                    user.Pol = listEndDateUsers[5][i];
                    user.Datum_na_raganje = listEndDateUsers[6][i];
                    user.Datum_na_izdavanje = listEndDateUsers[7][i];
                    user.Datum_na_vaznost = listEndDateUsers[8][i];
                    user.Mesto_na_raganje = listEndDateUsers[9][i];
                    user.Adresa = listEndDateUsers[10][i];
                    user.Izdavac = listEndDateUsers[11][i];
                    user.PatekaKonSlikata = listEndDateUsers[12][i];
                    sb.Append(String.Format("{0,-20}{1,-15}{2,-15}{3,-15}", user.Id_br_karta, user.Ime, user.Prezime, user.Datum_na_vaznost));
                    sb.AppendLine();
                }
                sb.AppendLine();
                sb.AppendLine();


                string FONT = "c:/windows/fonts/arialbd.ttf";
                var bf = BaseFont.CreateFont(FONT, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);


                DialogResult rez = MessageBox.Show(sb.ToString(), "Дали сакате овој извештај да го симните??", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rez == System.Windows.Forms.DialogResult.Yes)
                {
                    PdfWriter.GetInstance(document, new FileStream(path + "/Izvestaj.pdf", FileMode.Create));
                    document.Open();
                    Paragraph p = new Paragraph(sb.ToString(), new iTextSharp.text.Font(bf));
                    document.Add(p);
                    document.Close();
                    MessageBox.Show("Извештајот вие автоматски симнат и тој се наоѓа на десктоп!!");
                }
            }

        }


        private void btnZacuvaj_Click(object sender, EventArgs e)
        {
            User user = listLicniKarti.SelectedItem as User;
            user.Adresa = tbAdresa.Text;
            user.Datum_na_izdavanje = tbDatumNaIzdavanje.Text;
            user.Datum_na_vaznost = tbDatumNaVazenje.Text;
            user.Prezime = tbPrezime.Text;
            user.Drzavjanstvo = tbDrzavjanstvo.Text;
            string img = null;
            if (isClickedPrikaciiSlika) {
                if (imagePath == null)
                {
                    string path = user.PatekaKonSlikata;
                    img = path.Replace("\\", "\\\\"); ;

                }
                else
                {
                    img = imagePath.Replace("\\", "\\\\");
                }
                user.PatekaKonSlikata = img;
            }

            DBConnect konekcija = new DBConnect();
            konekcija.Update(user, user.Id_br_karta);

            MessageBox.Show("Промените се успешно направени!");
            if (user.Pol.Equals("Ж"))
                tbPrezime.ReadOnly = true;
            tbAdresa.ReadOnly = true;
            tbDrzavjanstvo.ReadOnly = true;
            btnZacuvaj.Visible = false;
            btnDodadiNovoLice.Enabled = true;
            listLicniKarti.Enabled = true;
            btnIzbrisiLice.Enabled = true;
            btnIzvestaj.Enabled = true;
            btnPromenaLice.Enabled = true;
            cbFilter.Enabled = true;
            btnOtkazi.Visible = false;
            btnPrikaciNovaSlika.Visible = false;
            btnObnoviDatum.Visible = false;
            LoadUsers();
            CountEndDateUsers();
        }

        private void cbFilter_Click(object sender, EventArgs e)
        {
            
            
            if (listLicniKarti.SelectedIndex == -1)
            {
                ClearText();
                btnIzbrisiLice.Enabled = false;
                btnPromenaLice.Enabled = false;
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            tbPrezime.ReadOnly = true;
            tbAdresa.ReadOnly = true;
            tbDrzavjanstvo.ReadOnly = true;
            btnZacuvaj.Visible = false;
            btnPrikaciNovaSlika.Visible = false;
            btnOtkazi.Visible = false;
            btnDodadiNovoLice.Enabled = true;
            listLicniKarti.Enabled = true;
            btnIzbrisiLice.Enabled = true;
            btnIzvestaj.Enabled = true;
            btnPromenaLice.Enabled = true;
            cbFilter.Enabled = true;
            isClickedPrikaciiSlika = false;
            btnObnoviDatum.Visible = false;
            User user = listLicniKarti.SelectedItem as User;
            tbAdresa.Text = user.Adresa;
            tbDrzavjanstvo.Text = user.Drzavjanstvo;
            tbPrezime.Text = user.Prezime;
            tbDatumNaIzdavanje.Text = user.Datum_na_izdavanje;
            tbDatumNaVazenje.Text = user.Datum_na_vaznost;
        }

        public void DodadiSlika()
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
                    
                   // bmpImg.Save(pathToProjectImage + "\\images\\" + tbID.Text + ".jpg");
                    bmpImg.Save(@"images\\" + tbID.Text + ".jpg");

                    string endPathToImages = pathToProjectImage + "\\images\\"+ tbID.Text + ".jpg";
                   // imagePath = endPathToImages;
                    imagePath = @"images\\" + tbID.Text + ".jpg";
                    SuspendLayout();
                    pictureBox2.Image = bmpImg;
                    PerformLayout();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file \"" +
                    openFileDialog1.FileName + "\" from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btnPrikaciNovaSlika_Click(object sender, EventArgs e)
        {
            DodadiSlika();
            isClickedPrikaciiSlika = true;
        }

        private void btnObnoviDatum_Click(object sender, EventArgs e)
        {
            smeniDatumi();
        }

       
    }
}
