using AtividadeFinal_Dados.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

public class TelefoneRepository
{
    private readonly string _connectionString;

    public TelefoneRepository(string connectionString)
    {
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new ArgumentException("ConnectionString não pode ser nulo ou vazio", nameof(connectionString));
        }
        _connectionString = connectionString;
    }

    public IEnumerable<TelefoneModel> Todos()
    {
        var telefones = new List<TelefoneModel>();

        try
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            string query = "SELECT * FROM Telefone";
            telefones = connection.Query<TelefoneModel>(query).ToList();
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Erro ao acessar o banco de dados: " + ex.Message);
        }

        return telefones;
    }

    public IEnumerable<TelefoneModel> Pessoa(int idPessoa)
    {
        var telefones = new List<TelefoneModel>();

        try
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            string query = @"SELECT * FROM Telefone WHERE IDPessoa = @IDPessoa";
            telefones = connection.Query<TelefoneModel>(query, new { IDPessoa = idPessoa }).ToList();
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Erro ao acessar o banco de dados: " + ex.Message);
        }

        return telefones;
    }

    public TelefoneModel Codigo(int id)
    {
        TelefoneModel telefone = null;

        try
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            string query = @"SELECT * FROM Telefone WHERE IDTelefone = @IDTelefone";
            telefone = connection.QuerySingleOrDefault<TelefoneModel>(query, new { IDTelefone = id });
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Erro ao acessar o banco de dados: " + ex.Message);
        }

        return telefone;
    }

    public IEnumerable<TelefoneModel> Numero(string numero)
    {
        var telefones = new List<TelefoneModel>();

        try
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            string query = @"SELECT * FROM Telefone WHERE Telefone LIKE @Telefone";
            telefones = connection.Query<TelefoneModel>(query, new { Telefone = "%" + numero + "%" }).ToList();
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Erro ao acessar o banco de dados: " + ex.Message);
        }

        return telefones;
    }

    public int Adiciona(TelefoneModel telefone)
    {
        if (telefone == null)
        {
            throw new ArgumentNullException(nameof(telefone), "Telefone não pode ser nulo.");
        }

        try
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            string query = @"INSERT INTO Telefone (Telefone, TipoTelefone, IDPessoa) 
                             VALUES (@Telefone, @TipoTelefone, @IDPessoa)";
            return connection.Execute(query, telefone);
        }
        catch (SqlException ex)
        {
            throw new Exception("Erro ao acessar o banco de dados durante a inserção.", ex);
        }
    }

    public int Atualiza(TelefoneModel telefone)
    {
        if (telefone == null)
        {
            throw new ArgumentNullException(nameof(telefone), "Telefone não pode ser nulo.");
        }

        try
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            string query = @"UPDATE Telefone 
                             SET Telefone = @Telefone, TipoTelefone = @TipoTelefone 
                             WHERE IDTelefone = @IDTelefone";
            return connection.Execute(query, telefone);
        }
        catch (SqlException ex)
        {
            throw new Exception("Erro ao acessar o banco de dados durante a atualização.", ex);
        }
    }

    public int Deleta(int id)
    {
        try
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            string query = @"DELETE FROM Telefone WHERE IDTelefone = @IDTelefone";
            return connection.Execute(query, new { IDTelefone = id });
        }
        catch (SqlException ex)
        {
            throw new Exception("Erro ao acessar o banco de dados durante a exclusão.", ex);
        }
    }
}
