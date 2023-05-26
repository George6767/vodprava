using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfLab2Sony
{
    public enum GENDER { male, female, variant};
    public enum COLOREYES { brovn, green, blue, gray, black};
    public class driver: INotifyPropertyChanged
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
        string? uriImage;
        GENDER gender;
        COLOREYES eyes;

        public driver()
        {
        }

        public string Number
        {
            get => number;
            set
            {
                number = value;
                OnPropertyChanged("Number");
            }   
        }
        public char Clas1
        { 
            get => clas1;
            set
            {
                clas1 = value;
                OnPropertyChanged("Clas1");
            }
        }
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public double Hgt 
        {
            get => hgt;
            set
            {
                hgt = value;
                OnPropertyChanged("Hgt");
            }
        }
        public string Address 
        { 
            get => address;
            set
            {
                address = value;
                OnPropertyChanged("Address");
            }


        }
        public DateTime Dob
        { get => dob;
            set
            {
                dob = value;
                OnPropertyChanged("Dob");
            } 
        }
        public DateTime Iss 
        { 
            get => iss;
            set
            {
                iss = value;
                OnPropertyChanged("Iss");
            }
        }
        public DateTime Exp 
        {
            get => exp;
            set
            {
                exp = value;
                OnPropertyChanged("Exp");
            }
        }
        public bool Donor 
        {
            get => donor;
            set
            {
                donor = value;
                OnPropertyChanged("Exp");
            }
        }
        public string UriImage 
        {
            get => uriImage;
            set
            {
                UriImage = value;
                OnPropertyChanged("UriImage");
            }
        }
        public GENDER Gender 
        {
            get => gender; 
            set
            {
                gender = value;
                OnPropertyChanged("Gender");
            } 
        }
        public COLOREYES Eyes 
        { 
            get => eyes;
            set
            {
                eyes = value;
                OnPropertyChanged("Eyes");
            }
        
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public override string? ToString()
        {
            return $"№ {Number} {Clas1} from {Iss} to {Exp}.{Name}, {Gender} Dob({Dob}). Dob({Dob}). " +
                $"{Address}. Heght {Hgt}. Eyes {Eyes}. {(Donor ? "Donor" : "Not donor")}\n {UriImage}";

            //return $"№ {Number} {Clas1} from {Iss} to {Exp}. {Name}, {Gender} Dob({Dob}). {Address}. " +
            //    $"Heght {Hgt}.  {(Donor ? "Donor" : "Not donor")}";
        }
    }
}
