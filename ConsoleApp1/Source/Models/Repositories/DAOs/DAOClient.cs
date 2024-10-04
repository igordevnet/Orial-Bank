using System.Data.Common;
using ConsoleApp1.Source.Entities;
namespace ConsoleApp1.Source.Models.Repositories.DAOs
{
    public class DAOClient
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public string Education { get; set; }
        public string Identity { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
        public decimal Assets { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Id { get; set; }

        Connection connect = new Connection();

        public void AddClientDb()
        {
        }
        public void UpdateClientDb()
        {
        }
        public void DeleteClientDb()
        {
        }
        public DAOClient GetByIdClientDb()
        {
        }

    }

}