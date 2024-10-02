using ConsoleApp1.Source.UserPaste;

namespace ConsoleApp1.Source.Repositories.DAOs
{
    internal class UpdateRegist : User
    {
        Connection connect = new Connection();

        public string UpdateReg(int Id)
        {
            string syntaxSql = "update usuario set nome = '" + Name + "', ident = '" + Identify + "', " +
                                "cel = '" + Phone + "', email = '" + Email + "', " +
                                "dataNascimento = '" + BirthDate + "', profissao = '" + Profission + "', " +
                                "renda = " + Salary + ", patrimonio = " + Assets + ", " +
                                "escolaridade = '" + Education + "', saldo = 0, " +
                                "senha = '" + Password + "' where id = " + Id;

            try
            {
                MySqlCommand commandSql = new MySqlCommand(syntaxSql, connect.server);

                connect.ConectBd();
                commandSql.ExecuteNonQuery;
                connect.DesconectBd();

                return "Parabéns, você conseguiu atualizar seu cadastro!";
            }
            catch
            {
                return "Estamos com problemas no momento, tente novamente mais " +
                    "tarde, ou entre em contato com nossa assitência (11) 95990-3324";
            }
        }
    }
}
