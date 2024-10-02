using ConsoleApp1.Source.Controllers.DTOs;
using ConsoleApp1.Source.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Source.Service
{
    public class ClientService : ClientServiceInterface
    {
        private readonly ClientServiceInterface _clientRepository;

        public ClientService(ClientServiceInterface clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void AddClient(ClientPersonDTO clientDto)
        {
            var client = new Client
            {
                Id = clientDto.Id,
                Name = clientDto.Name,
                Profession = clientDto.Profession,
                Education = clientDto.Education,
                Identity = clientDto.Identity,
                BirthDate = clientDto.BirthDate,
                Salary = clientDto.Salary,
                Assets = clientDto.Assets,
                Email = clientDto.Email,
                Password = clientDto.Password,
                Phone = clientDto.Phone
            };

            _clientRepository.Add(client);
        }

        public ClientPersonDTO GetClientById(string id)
        {
            var client = _clientRepository.GetById(id);

            if (client == null) return null;

            return new ClientPersonDTO
            {
                Id = client.Id,
                Name = client.Name,
                Profession = client.Profession,
                Education = client.Education,
                Identity = client.Indentity,
                BirthDate = client.BirthDate,
                Salary = client.Salary,
                Assets = client.Assets,
                Email = client.Email,
                Phone = client.Phone
            };
        }
    }

}
