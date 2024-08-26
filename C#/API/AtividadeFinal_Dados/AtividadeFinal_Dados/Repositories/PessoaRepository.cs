using AtividadeFinal_Dados.Models;
using System.Data;
using System.Data.SqlClient;

public class PessoaRepository
{
    private readonly string _connectionString;

    public PessoaRepository(string connectionString)
    {
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new Exception("ConnectionString sem valor válido");
        }
        _connectionString = connectionString;
    }

    public IEnumerable<PessoaModel> Todas()
    {
        var pessoas = new List<PessoaModel>();

        try
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            using SqlCommand command = new SqlCommand("SELECT ID, Nome, Telefone FROM Pessoa", connection);
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                pessoas.Add(new PessoaModel
                {
                    ID = reader.GetInt32(reader.GetOrdinal("ID")),
                    Nome = reader.GetString(reader.GetOrdinal("Nome")),
                    Telefone = reader.GetString(reader.GetOrdinal("Telefone"))
                });
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Erro de conexão: " + ex.Message);
        }

        return pessoas;
    }
}
