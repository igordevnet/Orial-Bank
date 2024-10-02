using ConsoleApp1.Source.Controllers.DTOs;
using ConsoleApp1.Source.Entities;
using ConsoleApp1.Source.Repositories.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Source.Repositories
{
    public class ClientRepository : ClientRepositoryInterface
    {
        private readonly DAOClient _DAOClient;

        public ClientRepository(DAOClient daoClient)
        {
            _DAOClient = daoClient;
        }

        public void AddClient(Client client)
        {
            var clientDAO = new DAOClient
            {
                Id = client.Id,
                Name = client.Name,
                Profession = client.Profession,
                Education = client.Education,
                Identity = client.Identity,
                BirthDate = client.BirthDate,
                Salary = client.Salary,
                Assets = client.Assets,
                Email = client.Email,
                Password = client.Password,
                Phone = client.Phone
            };

            _DAOClient.AddClientDb(clientDAO);
        }
        public Client GetById(string id)
        {
            var client = _DAOClient.GetByIdClientDb(id);

            if (client == null) return null;

            return new Client
            {
                Id = client.Id,
                Name = client.Name,
                Profession = client.Profession,
                Education = client.Education,
                Identity = client.Identity,
                BirthDate = client.BirthDate,
                Salary = client.Salary,
                Assets = client.Assets,
                Email = client.Email,
                Phone = client.Phone
            };

        }
        public void Update(Client client)
        {

        }
        public void Delete(string id)
        {

        }
        public IEnumerable<Client> GetAll()
        {

        }
    }

}
