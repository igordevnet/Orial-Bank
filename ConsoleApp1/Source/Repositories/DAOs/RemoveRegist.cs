using ConsoleApp1.Source.UserPaste;

namespace ConsoleApp1.Source.Repositories.DAOs
{
    internal class RemoveRegist : User
    {
        Connection connect = new Connection();

        public string RemoveReg()
        {
            string syntaxSql = "delete from usuario where id = " + Id + ";";

            try
            {
                MySqlCommand commandSql = new MySqlCommand(syntaxSql, connect.server);

                connect.ConectBd();
                commandSql.ExecuteNonQuery;
                connect.DesconectBd();

                return "Que pena, você infelizmenten não faz mais parte do time Orial :(";
            }
            catch
            {
                return "Estamos com problemas no momento, tente novamente mais " +
                    "tarde, ou entre em contato com nossa assitência (11) 95990-3324";
            }
        }
    }
}
