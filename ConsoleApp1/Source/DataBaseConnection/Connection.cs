using MySql.Data.MySqlClient;
using DotNetEnv;

namespace ConsoleApp1.Source.DataBaseConnection
{
    public class Connection
    {
        private string _ConnectionDbUrl;
        private MySqlConnection _Server;

        public Connection()
        {
            DotEnv.Load();
            _ConnectionDbUrl = Environment.GetEnvironmentVariable("ConnectionDbURL");
            _Server = new MySqlConnection(_ConnectionDbUrl);
        }

        public void ConectBd() => _Server.Open();

        public void DesconectBd() => _Server.Close();
    }
}