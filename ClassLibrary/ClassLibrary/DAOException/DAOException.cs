using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAOException
{
    class DAOException:Exception
    {
        int _errorNumber;
        String _Description;

        public DAOException(int nb,string message)
        {
            this._errorNumber = nb;
            this._Description = message;
        }
    }
}
