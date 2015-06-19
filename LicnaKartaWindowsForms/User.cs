using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicnaKartaWindowsForms
{
    public class User
    {
        public string Id_br_karta { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string EMBG { get; set; }
        public string Drzavjanstvo { get; set; }
        public string Pol { get; set; }
        public string Datum_na_raganje { get; set; }
        public string Datum_na_izdavanje { get; set; }
        public string Datum_na_vaznost { get; set; }
        public string Mesto_na_raganje { get; set; }
        public string Adresa { get; set; }
        public string Izdavac { get; set; }
        public string PatekaKonSlikata { get; set; }

        public User(string id_br_karta, string ime, string prezime, string embg, string drzavjanstvo, string pol, string datum_na_raganje, string datum_na_izdavanje, string datum_na_vaznost, string mesto_na_raganje, string adresa, string izdavac, string patekaKonSlikata)
        {
            Id_br_karta = id_br_karta;
            Ime = ime;
            Prezime = prezime;
            EMBG = embg;
            Drzavjanstvo = drzavjanstvo;
            Pol = pol;
            Datum_na_raganje = datum_na_raganje;
            Datum_na_izdavanje = datum_na_izdavanje;
            Datum_na_vaznost = datum_na_vaznost;
            Mesto_na_raganje = mesto_na_raganje;
            Adresa = adresa;
            Izdavac = izdavac;
            PatekaKonSlikata = patekaKonSlikata;
        }

        public User()
        {
            // TODO: Complete member initialization
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} {2}",Id_br_karta,Ime,Prezime);
        }

    }
}
