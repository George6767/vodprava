using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLab2Sony
{
    enum GENDER { male, female, variant};
    enum COLOREYES { brovn, green, blue, gray, black};
    public class driver
    {
        string number;
        char clas1;
        string name;
        double hgt;
        string address;
        DateTime dob;
        DateTime iss;
        DateTime exp;
        bool donor;
        string uriImage;
        GENDER gender;
        COLOREYES eyes;

        public driver()
        {
        }

        public string Number { get => number; set => number = value; }
        public char Clas1 { get => clas1; set => clas1 = value; }
        public string Name { get => name; set => name = value; }
        public double Hgt { get => hgt; set => hgt = value; }
        public string Address { get => address; set => address = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public DateTime Iss { get => iss; set => iss = value; }
        public DateTime Exp { get => exp; set => exp = value; }
        public bool Donor { get => donor; set => donor = value; }
        public string UriImage { get => uriImage; set => uriImage = value; }
        internal GENDER Gender { get => gender; set => gender = value; }
        internal COLOREYES Eyes { get => eyes; set => eyes = value; }

        public override string? ToString()
        {
            return $"№ {Number} {Clas1} from {Iss} to {Exp}.{Name}, {Gender} Dob({Dob}). Dob({Dob}). {Address}. Heght {Hgt}. Eyes {Eyes}. {(Donor ? "Donor" : "Not donor")}";

            //return $"№ {Number} {Clas1} from {Iss} to {Exp}. {Name}, {Gender} Dob({Dob}). {Address}. " +
            //    $"Heght {Hgt}.  {(Donor ? "Donor" : "Not donor")}";
        }
    }
}
