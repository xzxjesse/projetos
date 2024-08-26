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

            using SqlCommand command = new SqlCommand("SELECT * FROM Pessoa", connection);
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                pessoas.Add(new PessoaModel
{
                    IDPessoa = reader.GetInt32(reader.GetOrdinal("IDPessoa")),
                    Nome = reader.GetString(reader.GetOrdinal("Nome")),
                    DataNascimento = reader.GetDateTime(reader.GetOrdinal("DataNascimento")),
                    Email = reader.GetString(reader.GetOrdinal("Email"))
                });
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Erro de conexão: " + ex.Message);
        }

        return pessoas;
    }

    public PessoaModel Codigo(int ID)
    {
        PessoaModel pessoa = null;

        try
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            using SqlCommand command = new SqlCommand("SELECT * FROM Pessoa WHERE IDPessoa = @IDPessoa", connection);
            command.Parameters.AddWithValue("@IDPessoa", ID);

            using SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                pessoa = new PessoaModel
                {
                    IDPessoa = reader.GetInt32(reader.GetOrdinal("IDPessoa")),
                    Nome = reader.GetString(reader.GetOrdinal("Nome")),
                    DataNascimento = reader.GetDateTime(reader.GetOrdinal("DataNascimento")),
                    Email = reader.GetString(reader.GetOrdinal("Email"))
                };
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Erro de conexão: " + ex.Message);
        }

        return pessoa;
    }

    public IEnumerable<PessoaModel> Nome(string nome)
    {
        var pessoas = new List<PessoaModel>();

        try
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            using SqlCommand command = new SqlCommand("SELECT * FROM Pessoa WHERE UPPER(Nome) LIKE '%' + @Nome + '%'", connection);
            command.Parameters.AddWithValue("@Nome", nome.ToUpper()); //  maiuscula

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                pessoas.Add(new PessoaModel
                {
                    IDPessoa = reader.GetInt32(reader.GetOrdinal("IDPessoa")),
                    Nome = reader.GetString(reader.GetOrdinal("Nome")),
                    DataNascimento = reader.GetDateTime(reader.GetOrdinal("DataNascimento")),
                    Email = reader.GetString(reader.GetOrdinal("Email"))
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
