using System.Data.Common;
using ConsoleApp1.Source.UserPaste;
namespace ConsoleApp1.Source.Repositories.DAOs
{
    internal class InsertRegist : User
    {
        Connection connect = new Connection();

        public string InsertReg()
        {
            string syntaxSql = "insert into usuario (nome, ident, cel, email, dataNascimento, profissao, renda, " +
                "patrimonio, escolaridade, saldo, senha)" +
                "values ('" + Name + "',  '" + Identify + "', '" + Phone + "', '" + Email + "', '" + BirthDate + "', " +
                "'" + Profession + "', " + Salary + ", " + Assets + ", '" + Education + "', 0, " + Password + ")";

            try
            {
                MySqlCommand commandSql = new MySqlCommand(syntaxSql, connect.server);

                connect.ConectBd();
                commandSql.ExecuteNonQuery;
                connect.DesconectBd();

                return "Parabéns, você conseguiu realizar seu cadastro!";
            }
            catch
            {
                return "Estamos com problemas no momento, tente novamente mais " +
                    "tarde, ou entre em contato com nossa assitência (11) 95990-3324";
            }
        }
    }

}