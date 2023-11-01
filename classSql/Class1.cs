using System.Data.SqlClient;

namespace classSql
{
    public class Class1
    {
        string connectionString = "Data Source=SeuServidor;Initial Catalog=SeuBancoDeDados;" +
            "User ID=SeuUsuario;Password=SuaSenha;";
         using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string sql = "SELECT Nome FROM Clientes WHERE Id = 1";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                string resultado = (string)command.ExecuteScalar();
                Console.WriteLine("Nome: " + resultado);
            }
        }
    }
}