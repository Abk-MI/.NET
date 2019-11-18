using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
   public class Clients
    {
        int _code;
        string _nom;
        string _prenom;
        string _civilite;
        DateTime _dateNaissance;
        string _tel;
        string _adresse;
        string _email;
        string _facebook;
        byte _infoParSMS;
        byte _infoParEMAIL;


        public Clients(int code, string nom, string prenom, string civilite, DateTime dateNaissance, string tel,string adresse, string email,string facebook, byte infoParSMS,byte infoParEmail)
        {
            _code = code;
            _nom = nom;
            _prenom = prenom;
            _civilite = civilite;
            _dateNaissance = dateNaissance;
            _tel = tel;
            _adresse = adresse;
            _email = email;
            _facebook = facebook;
            _infoParSMS = infoParSMS;
            _infoParEMAIL = infoParEmail;
        }
        public Clients( string nom, string prenom, string civilite, DateTime dateNaissance, string tel, string adresse, string email, string facebook, byte infoParSMS, byte infoParEmail)
        {
            
            _nom = nom;
            _prenom = prenom;
            _civilite = civilite;
            _dateNaissance = dateNaissance;
            _tel = tel;
            _adresse = adresse;
            _email = email;
            _facebook = facebook;
            _infoParSMS = infoParSMS;
            _infoParEMAIL = infoParEmail;
        }


        public int Code { get => _code; set => _code = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        public string civilite { get => _civilite; set => _civilite = value; }
        public DateTime dateNaissance { get => _dateNaissance; set => _dateNaissance = value; }
        public string tel { get => _tel; set => _tel = value; }
        public string email { get => _email; set => _email = value; }
        public string facebook { get => _facebook; set => _facebook = value; }
        public byte infoParSMS { get => _infoParSMS; set => _infoParSMS = value; }
        public byte infoParEMAIL { get => _infoParEMAIL; set => _infoParEMAIL = value; }

    }
}
