using ClassLibrary.Connexion;
using ClassLibrary.Entities;
using ClassLibrary.IDAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAOImp
{
    public class DAOImpClients : IDAOclient
    {

        MySqlConnection _maConnexion;
        MySqlCommand _maCommande;

       public DAOImpClients(string s)
        {
            _maConnexion = FactoryConnection.getConnection(s);
            _maCommande = new MySqlCommand();
            _maCommande.Connection = _maConnexion;
        }
       
        public bool ajouterClients(Clients c)
        {
            try
            {
                string req = "INSERT INTO `Client` (`Nom`, `Prenom`, `Civilité`, `DateNaissance`, `Tel`, `Adress`, `Email`, `Facebook`,`InfoParSMS`, `InfoParEMAIL`) VALUES (@nom,@prenom,@Civilité,@DateNaissance,@Tel,@adress," +
                    "@Email,@Facebook,@InfoParSMS,@InfoParEMAIL)";

                _maCommande.CommandText = req;
                _maCommande.Parameters.Add(new MySqlParameter("@nom", MySqlDbType.VarChar));
                _maCommande.Parameters.Add(new MySqlParameter("@prenom", MySqlDbType.VarChar));
                _maCommande.Parameters.Add(new MySqlParameter("@Civilité", MySqlDbType.VarChar));
                _maCommande.Parameters.Add(new MySqlParameter("@DateNaissance", MySqlDbType.DateTime));
                _maCommande.Parameters.Add(new MySqlParameter("@Tel", MySqlDbType.VarChar));
                _maCommande.Parameters.Add(new MySqlParameter("@adress", MySqlDbType.VarChar));
                _maCommande.Parameters.Add(new MySqlParameter("@Email", MySqlDbType.VarChar));
                _maCommande.Parameters.Add(new MySqlParameter("@Facebook", MySqlDbType.VarChar));
                _maCommande.Parameters.Add(new MySqlParameter("@InfoParSMS", MySqlDbType.Byte));
                _maCommande.Parameters.Add(new MySqlParameter("@InfoParEMAIL", MySqlDbType.Byte));
                
                _maCommande.Parameters["@nom"].Value = c.Nom;
                _maCommande.Parameters["@prenom"].Value = c.Prenom;
                _maCommande.Parameters["@Civilité"].Value = c.civilite;
                _maCommande.Parameters["@DateNaissance"].Value = c.dateNaissance;
                _maCommande.Parameters["@Tel"].Value = c.tel;
                _maCommande.Parameters["@adress"].Value = c.Adresse;
                _maCommande.Parameters["@Email"].Value = c.email;
                _maCommande.Parameters["@Facebook"].Value = c.facebook;
                _maCommande.Parameters["@InfoParSMS"].Value = c.infoParSMS;
                _maCommande.Parameters["@InfoParEMAIL"].Value = c.infoParEMAIL;
                _maCommande.Connection = _maConnexion;

                _maCommande.ExecuteNonQuery();
                _maCommande.Parameters.Clear();
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public bool modifierClients(Clients c)
        {
            bool test = false;
            try
            {
                string req = "UPDATE `client` SET `Nom` = '" + c.Nom + "', `Prenom` = '" + c.Prenom + "', `Adresse` = '" + c.Adresse + "' WHERE `client`.`CodeClient` = " + c.Code + ";";
                _maCommande.CommandText = req;
                _maCommande.ExecuteNonQuery();
                test = true;
            }
            catch
            {
                throw new Exception();
            }
            return test;
        }

        public bool modifierClient(Clients c,int CodeClient)
        {
            try
            {
                string req = "UPDATE `client` set (`Nom`,`Prenom`,`DateNaissance`,`Tel`,`Adress`,`Email`,`Facebook`,`InfoParSMS`,`InfoParEMAIL`) VALUES  ('" + c.Nom + "', '" + c.Prenom + "', '" + c.civilite + "', '" + c.dateNaissance + "', '" + c.tel + "', '" + c.Adresse + "', '" + c.email + "', '" + c.facebook + "', " + c.infoParSMS + ", " + c.infoParEMAIL + " WHERE `client`.`CodeClient` ="+ CodeClient+";";
                
                _maCommande.Connection = _maConnexion;

                _maCommande.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
                
            
        }

        
        public List<Clients> recupererTousClients()
        {
            List<Clients> _listeClients;
            _listeClients = new List<Clients>();
            MySqlDataReader _reader;

            string req= "SELECT * FROM `client`";
            _maCommande.CommandText = req; 
            _reader = _maCommande.ExecuteReader();

            while (_reader.Read())
            {
                Clients _c = new Clients(_reader.GetInt16(0), _reader.GetString(1), _reader.GetString(2), _reader.GetString(3), _reader.GetDateTime(4), _reader.GetString(5), _reader.GetString(6), _reader.GetString(7), _reader.GetString(8), _reader.GetByte(9), _reader.GetByte(10));
                _listeClients.Add(_c);
            }
            _reader.Close();
            return _listeClients;
        }

        public bool supprimerClients(Clients c)
        {
            try
            {
                string req = "DELETE FROM `client` WHERE `client`.`CodeClient` = " + c.Code + ";";
                _maCommande.CommandText = req;
                _maCommande.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
