using StructuralPatterns.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Repositories
{
    class ClientSystem
    {
        List<Client> clients = new List<Client>();

        public List<Client> GetAllClients()
        {
            return clients;
        }

        public void AddClient(Client c)
        {
            clients.Add(c);
        }

        public void RemoveClient(Client c)
        {
            clients.Remove(c);
        }
    }
}
