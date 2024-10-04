using ConsoleApp1.Source.Controllers.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Source.Models.Service
{
    public interface ClientServiceInterface
    {
        void AddClient(ClientPersonDTO clientDto);
        ClientPersonDTO GetClientById(string id);
    }
}
