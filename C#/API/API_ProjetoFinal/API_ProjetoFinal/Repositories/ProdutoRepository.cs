using API_ProjetoFinal.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

public class ProdutoRepository
{
    private readonly string _connectionString;

    public ProdutoRepository(string connectionString)
    {
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new Exception("ConnectionString sem valor válido");
        }
        _connectionString = connectionString;
    }

    public IEnumerable<ProdutoModel> Pesquisa()
    {
        var produtos = new List<ProdutoModel>();

        try
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            using SqlCommand command = new SqlCommand("SELECT * FROM Produtos", connection);
            using SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                produtos.Add(new ProdutoModel
                {
                    idProduto = reader.GetInt32(reader.GetOrdinal("idProduto")),
                    CodigoProduto = reader.GetString(reader.GetOrdinal("CodigoProduto")),
                    Descricao = reader.GetString(reader.GetOrdinal("Descricao")),
                    Unidade = reader.GetString(reader.GetOrdinal("Unidade")),
                    ValorVenda = reader.GetDecimal(reader.GetOrdinal("ValorVenda")),
                    IPI = (float)reader.GetDouble(reader.GetOrdinal("IPI")), // Converte de double para float
                    Estoque = (float)reader.GetDouble(reader.GetOrdinal("Estoque")) // Converte de double para float
                });

            }
        }
        catch (SqlException ex)
        {
            throw new Exception("Erro ao acessar o banco de dados.", ex);
        }

        return produtos;
    }

    public ProdutoModel BuscaPorCodigo(int id)
    {
        ProdutoModel produto = null;

        try
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            using SqlCommand command = new SqlCommand("SELECT * FROM Produtos WHERE idProduto = @idProduto", connection);
            command.Parameters.AddWithValue("@idProduto", id);

            using SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                produto = new ProdutoModel
                {
                    idProduto = reader.GetInt32(reader.GetOrdinal("idProduto")),
                    CodigoProduto = reader.GetString(reader.GetOrdinal("CodigoProduto")),
                    Descricao = reader.GetString(reader.GetOrdinal("Descricao")),
                    Unidade = reader.GetString(reader.GetOrdinal("Unidade")),
                    ValorVenda = reader.GetDecimal(reader.GetOrdinal("ValorVenda")),
                    IPI = (float)reader.GetDouble(reader.GetOrdinal("IPI")), // double para float
                    Estoque = (float)reader.GetDouble(reader.GetOrdinal("Estoque")) // double para float
                };
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("Erro ao acessar o banco de dados.", ex);
        }

        return produto;
    }

    public int Inserir(ProdutoModel produto)
    {
        if (produto == null)
        {
            throw new ArgumentNullException(nameof(produto), "Produto não pode ser nulo.");
        }

        try
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            string query = "INSERT INTO Produtos (CodigoProduto, Descricao, Unidade, ValorVenda, IPI, Estoque) VALUES (@CodigoProduto, @Descricao, @Unidade, @ValorVenda, @IPI, @Estoque)";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CodigoProduto", produto.CodigoProduto);
            command.Parameters.AddWithValue("@Descricao", produto.Descricao);
            command.Parameters.AddWithValue("@Unidade", produto.Unidade);
            command.Parameters.AddWithValue("@ValorVenda", produto.ValorVenda);
            command.Parameters.AddWithValue("@IPI", produto.IPI);
            command.Parameters.AddWithValue("@Estoque", produto.Estoque);

            return command.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            throw new Exception("Erro ao acessar o banco de dados.", ex);
        }
    }

    public int EditarPorCodigo(int id, ProdutoModel produto)
    {
        if (produto == null)
        {
            throw new ArgumentNullException(nameof(produto), "Produto não pode ser nulo.");
        }

        try
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            string query = "UPDATE Produtos SET CodigoProduto = @CodigoProduto, Descricao = @Descricao, Unidade = @Unidade, ValorVenda = @ValorVenda, IPI = @IPI, Estoque = @Estoque WHERE idProduto = @idProduto";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idProduto", id);
            command.Parameters.AddWithValue("@CodigoProduto", produto.CodigoProduto);
            command.Parameters.AddWithValue("@Descricao", produto.Descricao);
            command.Parameters.AddWithValue("@Unidade", produto.Unidade);
            command.Parameters.AddWithValue("@ValorVenda", produto.ValorVenda);
            command.Parameters.AddWithValue("@IPI", produto.IPI);
            command.Parameters.AddWithValue("@Estoque", produto.Estoque);

            return command.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            throw new Exception("Erro ao acessar o banco de dados.", ex);
        }
    }

    public int ExcluirPorCodigo(int id)
    {
        try
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            string query = "DELETE FROM Produtos WHERE idProduto = @idProduto";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idProduto", id);

            return command.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            throw new Exception("Erro ao acessar o banco de dados.", ex);
        }
    }
}