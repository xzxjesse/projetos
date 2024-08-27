using AtividadeFinal_Dados.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

public class PessoaRepository
{
    #region |Configurações|
    private readonly string _connectionString;

    public PessoaRepository(string connectionString)
    {
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new Exception("ConnectionString sem valor válido");
        }
        _connectionString = connectionString;
    }
    #endregion

    #region |Buscas|
    //Read
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
    #endregion

    #region |Atualizações|
    //Create
    public int Adiciona(PessoaModel pessoa)
    {
        if (pessoa == null)
        {
            throw new ArgumentNullException(nameof(pessoa), "Pessoa não pode ser nula.");
        }

        try
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            string query = "INSERT INTO Pessoa (Nome, DataNascimento, Email) VALUES (@Nome, @DataNascimento, @Email)";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Nome", pessoa.Nome);
            command.Parameters.AddWithValue("@DataNascimento", pessoa.DataNascimento);
            command.Parameters.AddWithValue("@Email", pessoa.Email);

            return command.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            throw new Exception("Erro ao acessar o banco de dados.", ex);
        }
    }

    //Update
    public int Atualiza(PessoaModel pessoa)
    {
        if (pessoa == null)
        {
            throw new ArgumentNullException(nameof(pessoa), "Pessoa não pode ser nula.");
        }

        try
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            string query = "UPDATE Pessoa SET Nome = @Nome, DataNascimento = @DataNascimento, Email = @Email WHERE IDPessoa = @IDPessoa";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IDPessoa", pessoa.IDPessoa);
            command.Parameters.AddWithValue("@Nome", pessoa.Nome);
            command.Parameters.AddWithValue("@DataNascimento", pessoa.DataNascimento);
            command.Parameters.AddWithValue("@Email", pessoa.Email);

            return command.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            throw new Exception("Erro ao acessar o banco de dados.", ex);
        }
    }

    //Delete
    public int Remove(int id)
    {
        try
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            string query = "DELETE FROM Pessoa WHERE IDPessoa = @IDPessoa";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IDPessoa", id);

            return command.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            throw new Exception("Erro ao acessar o banco de dados.", ex);
        }
    }

    #endregion

}
