using MySql.Data.MySqlClient;

public class Connection 
{
    public MySqlConnection server = new MySqlConnection(@"Server=localhost;Port=3308;Database=bancoOrial;User=root;Pwd=");

    public void ConectBd()
    {
        server.Open();
    }

    public void DesconectBd()
    {
        server.Close();
    }
}