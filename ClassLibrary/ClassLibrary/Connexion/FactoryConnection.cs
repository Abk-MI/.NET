using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClassLibrary.Connexion
{
    public class FactoryConnection
    {
        

        private static MySqlConnection _con;
        private MySqlCommand _cmd;
        private MySqlDataReader _reader;
        public FactoryConnection(string ChaineDeConnexion)
        {
            _con = new MySqlConnection(ChaineDeConnexion);
            _cmd = new MySqlCommand();
            _cmd.Connection = _con;
            _con.Open();
        }
        public static MySqlConnection getConnection(string s)
        {
            if (_con == null)
            {
                _con = new MySqlConnection(s);
            }
            return _con;
        }

        public MySqlConnection Con { get => _con; set => _con = value; }
        public MySqlCommand Cmd { get => _cmd; set => _cmd = value; }
        public MySqlDataReader Reader { get => _reader; set => _reader = value; }

        public void EcrireDansBD(string req)
        {
            Cmd.CommandText = req;
            Cmd.ExecuteNonQuery();
        }

        public MySqlDataReader LireDeBD(string req)
        {   
            Cmd.CommandText = req;
            return Cmd.ExecuteReader();
        }
        public void FermerConexion()
        {
            _con.Close();
        }
    }
}
