using MySql.Data.MySqlClient;
using DotNetEnv;

public class Connection
{
    private readonly string _ConnectionDbUrl;
    private MySqlConnection _Server;


    private protected Connection()
    {
        _ConnectionDbUrl = JsonConnection.ConnectionDbURL;
        _Server = new MySqlConnection(_ConnectionDbUrl);
    }

    public void ConectBd() => _Server.Open();

    public void DesconectBd() => _Server.Close();
}