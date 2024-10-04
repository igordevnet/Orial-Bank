using ConsoleApp1.Source.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Source.Models.Repositories
{
    public interface ClientRepositoryInterface
    {
        void AddClient(Client client);
        Client GetById(string id);
        void Update(Client client);
        void Delete(string id);
        IEnumerable<Client> GetAll();
    }
}



