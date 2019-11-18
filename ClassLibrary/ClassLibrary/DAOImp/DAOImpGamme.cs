using ClassLibrary.Connexion;
using ClassLibrary.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAOImp
{

    public class DAOImpGamme
    {

        MySqlConnection _maConnexion;
        MySqlCommand _maCommande;
        public  DAOImpGamme(string s)
        {
            _maConnexion = FactoryConnection.getConnection(s);
            _maCommande = new MySqlCommand();
            _maCommande.Connection = _maConnexion;
        }

        public bool ajouterAvoirGamme(int Code,String Gamme)
        {
            try
            {
                string req = "INSERT INTO `avoir_gammes` (`CodeClient`, `libelle_gamme`) VALUES (@Code,@Gamme)";

                _maCommande.CommandText = req;
                
                _maCommande.Parameters.Add(new MySqlParameter("@Code", MySqlDbType.Int16));
                _maCommande.Parameters.Add(new MySqlParameter("@Gamme", MySqlDbType.VarChar));
                
                _maCommande.Parameters["@Code"].Value = Code;
                _maCommande.Parameters["@Gamme"].Value = Gamme;
                
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

        public bool ajouterAutreGamme(int Code, String Gamme)
        {
            try
            {
                string req = "INSERT INTO `autre_gamme` (`libelle_autregamme`,`CodeClient`) VALUES (@Gamme,@Code)";

                _maCommande.CommandText = req;

                _maCommande.Parameters.Add(new MySqlParameter("@Code", MySqlDbType.Int16));
                _maCommande.Parameters.Add(new MySqlParameter("@Gamme", MySqlDbType.VarChar));

                _maCommande.Parameters["@Code"].Value = Code;
                _maCommande.Parameters["@Gamme"].Value = Gamme;

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
        

    }
}
