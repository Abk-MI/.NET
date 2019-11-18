using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.IDAO
{
    interface IDAOclient
    {
        bool ajouterClients(Clients c);
        bool modifierClients(Clients c);
        bool supprimerClients(Clients c);
        List<Clients> recupererTousClients();
    }
    
}
