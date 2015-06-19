using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicnaKartaWindowsForms
{
    public class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string utf8;
        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "licnakarta";
            uid = "root";
            password = "";
            utf8 = "utf8";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "CHARSET=" + utf8;

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {

                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert(User user)
        {
            if (user != null)
            {
                string id_br_karta = user.Id_br_karta;
                string newIme = user.Ime;
                string newPrezime = user.Prezime;
                string newEMBG = user.EMBG;
                string newDrzavjanstvo = user.Drzavjanstvo;
                string newPol = user.Pol;
                string newDatum_na_raganje = user.Datum_na_raganje;
                string newDatum_na_izdavanje = user.Datum_na_izdavanje;
                string newDatum_na_vaznost = user.Datum_na_vaznost;
                string newMesto_na_raganje = user.Mesto_na_raganje;
                string newAdresa = user.Adresa;
                string newIzdavac = user.Izdavac;
                string newPatekaKonSlika = user.PatekaKonSlikata;
                string query = "INSERT INTO user (id_br_karta, ime, prezime ,embg, drzavjanstvo, pol , datum_na_raganje, datum_na_izdavanje, datum_na_vaznost, mesto_na_raganje, adresa, izdavac, image_path) VALUES('" + id_br_karta + "','" + newIme + "', '" + newPrezime + "', '" + newEMBG + "','" + newDrzavjanstvo + "','" + newPol + "','" + newDatum_na_raganje + "','" + newDatum_na_izdavanje + "','" + newDatum_na_vaznost + "','" + newMesto_na_raganje + "','" + newAdresa + "','" + newIzdavac + "','" + newPatekaKonSlika + "')";

                //open connection
                if (this.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("The user is null!!");
            }
        }

        //Update statement
        public void Update(User user, string id)
        {

            string id_br_karta = user.Id_br_karta;
            string newIme = user.Ime;
            string newPrezime = user.Prezime;
            string newEMBG = user.EMBG;
            string newDrzavjanstvo = user.Drzavjanstvo;
            string newPol = user.Pol;
            string newDatum_na_raganje = user.Datum_na_raganje;
            string newDatum_na_izdavanje = user.Datum_na_izdavanje;
            string newDatum_na_vaznost = user.Datum_na_vaznost;
            string newMesto_na_raganje = user.Mesto_na_raganje;
            string newAdresa = user.Adresa;
            string newIzdavac = user.Izdavac;
            string newPatekaKonSlika = user.PatekaKonSlikata;

            string query = "UPDATE user SET id_br_karta='" + id_br_karta + "', ime='" + newIme + "',prezime='" + newPrezime + "',embg='" + newEMBG + "',drzavjanstvo='" + newDrzavjanstvo + "',pol='" + newPol + "',datum_na_raganje='" + newDatum_na_raganje + "',datum_na_izdavanje='" + newDatum_na_izdavanje + "',datum_na_vaznost='" + newDatum_na_vaznost + "',mesto_na_raganje='" + newMesto_na_raganje + "',adresa='" + newAdresa + "',izdavac='" + newIzdavac + "', image_path='"+newPatekaKonSlika+"' WHERE id_br_karta='" + id + "'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete(string id)
        {
            string query = "DELETE FROM user WHERE id_br_karta='" + id + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public List<string>[] Select()
        {
            string query = "SELECT * FROM user";

            
            //Create a list to store the result
            List<string>[] list = new List<string>[13];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();
            list[8] = new List<string>();
            list[9] = new List<string>();
            list[10] = new List<string>();
            list[11] = new List<string>();
            list[12] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    list[0].Add(dataReader["ID_BR_KARTA"] + "");
                    list[1].Add(dataReader["IME"] + "");
                    list[2].Add(dataReader["PREZIME"] + "");
                    list[3].Add(dataReader["EMBG"] + "");
                    list[4].Add(dataReader["DRZAVJANSTVO"] + "");
                    list[5].Add(dataReader["POL"] + "");
                    list[6].Add(dataReader["DATUM_NA_RAGANJE"] + "");
                    list[7].Add(dataReader["DATUM_NA_IZDAVANJE"] + "");
                    list[8].Add(dataReader["DATUM_NA_VAZNOST"] + "");
                    list[9].Add(dataReader["MESTO_NA_RAGANJE"] + "");
                    list[10].Add(dataReader["ADRESA"] + "");
                    list[11].Add(dataReader["IZDAVAC"] + "");
                    list[12].Add(dataReader["IMAGE_PATH"] + "");


                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public int Count()
        {
            string query = "SELECT COUNT(ID_BR_KARTA) FROM user";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public int checkID_br_karta(string id)
        {
            string query = "SELECT count(id_br_karta) FROM user WHERE id_br_karta='" + id + "'";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }


        public int checkDataVaznost()
        {
            string query = "SELECT count(id_br_karta) FROM user WHERE str_to_date(datum_na_vaznost, '%d.%m.%Y') < now()";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public List<string>[] SelectEndDateUsers()
        {
            string query = "SELECT * FROM user WHERE str_to_date(datum_na_vaznost, '%d.%m.%Y') < now()";

            //Create a list to store the result
            List<string>[] list = new List<string>[13];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();
            list[8] = new List<string>();
            list[9] = new List<string>();
            list[10] = new List<string>();
            list[11] = new List<string>();
            list[12] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    list[0].Add(dataReader["ID_BR_KARTA"] + "");
                    list[1].Add(dataReader["IME"] + "");
                    list[2].Add(dataReader["PREZIME"] + "");
                    list[3].Add(dataReader["EMBG"] + "");
                    list[4].Add(dataReader["DRZAVJANSTVO"] + "");
                    list[5].Add(dataReader["POL"] + "");
                    list[6].Add(dataReader["DATUM_NA_RAGANJE"] + "");
                    list[7].Add(dataReader["DATUM_NA_IZDAVANJE"] + "");
                    list[8].Add(dataReader["DATUM_NA_VAZNOST"] + "");
                    list[9].Add(dataReader["MESTO_NA_RAGANJE"] + "");
                    list[10].Add(dataReader["ADRESA"] + "");
                    list[11].Add(dataReader["IZDAVAC"] + "");
                    list[12].Add(dataReader["IMAGE_PATH"] + "");

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

    }
}
