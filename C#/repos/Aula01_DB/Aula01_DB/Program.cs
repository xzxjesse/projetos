using System.Data.SqlClient;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Noticias:");
        ExemploSqlClient();
    }

    private static void ExemploSqlClient()
    {
        string connectionString = "Server=JE_EVE\\MSSQLSERVER01;Database=DotNetCurso;Integrated Security=true;";

        string sql = "SELECT NoticiaID, NoticiaTitulo, NoticiaTexto, NoticiaData, CategoriaID FROM Noticia";

        using SqlConnection connection = new SqlConnection(connectionString);

        SqlCommand command = new SqlCommand(sql, connection);

        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine("{0} - {1} - {2}", reader[1], reader[2], reader[3]);
        }

        //connection.Dispose(); -> Exclui o objeto da memoria
        //Utilizando o "using" no objeto, ele faz o Dispose automaticamente, ao encerrar a execução do metodo

        Console.ReadLine();
    }
}