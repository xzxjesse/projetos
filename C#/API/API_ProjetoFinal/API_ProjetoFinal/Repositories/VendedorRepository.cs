using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using API_ProjetoFinal.Models;

public class VendedorRepository
{
    private readonly string _connectionString;

    public VendedorRepository(string connectionString)
    {
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new Exception("ConnectionString sem valor válido");
        }
        _connectionString = connectionString;
    }

    public IEnumerable<VendedorModel> Pesquisa()
    {
        var vendedores = new List<VendedorModel>();

        try
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Vendedores", connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        vendedores.Add(new VendedorModel
                        {
                            IdVendedor = reader.GetInt32(reader.GetOrdinal("IdVendedor")),
                            Vendedor = reader.GetString(reader.GetOrdinal("Vendedor")), 
                            Comissao = Convert.ToDecimal(reader.GetDouble(reader.GetOrdinal("Comissao"))),
                            Endereco = reader.IsDBNull(reader.GetOrdinal("Endereco")) ? null : reader.GetString(reader.GetOrdinal("Endereco")),
                            Bairro = reader.IsDBNull(reader.GetOrdinal("Bairro")) ? null : reader.GetString(reader.GetOrdinal("Bairro")),
                            Cidade = reader.IsDBNull(reader.GetOrdinal("Cidade")) ? null : reader.GetString(reader.GetOrdinal("Cidade")),
                            CEP = reader.IsDBNull(reader.GetOrdinal("CEP")) ? null : reader.GetString(reader.GetOrdinal("CEP")),
                            UF = reader.IsDBNull(reader.GetOrdinal("UF")) ? null : reader.GetString(reader.GetOrdinal("UF")),
                            CPF = reader.IsDBNull(reader.GetOrdinal("CPF")) ? null : reader.GetString(reader.GetOrdinal("CPF"))
                        });
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("Erro ao acessar o banco de dados.", ex);
        }

        return vendedores;
    }

    public VendedorModel BuscaPorCodigo(int id)
    {
        VendedorModel vendedor = null;

        try
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            using SqlCommand command = new SqlCommand("SELECT * FROM Vendedores WHERE IdVendedor = @IdVendedor", connection);
            command.Parameters.AddWithValue("@IdVendedor", id);

            using SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                vendedor = new VendedorModel
                {
                    IdVendedor = reader.GetInt32(reader.GetOrdinal("IdVendedor")),
                    Vendedor = reader.IsDBNull(reader.GetOrdinal("Vendedor")) ? null : reader.GetString(reader.GetOrdinal("Vendedor")),
                    Comissao = reader.IsDBNull(reader.GetOrdinal("Comissao")) ? 0 : Convert.ToDecimal(reader.GetDouble(reader.GetOrdinal("Comissao"))),
                    Endereco = reader.IsDBNull(reader.GetOrdinal("Endereco")) ? null : reader.GetString(reader.GetOrdinal("Endereco")),
                    Bairro = reader.IsDBNull(reader.GetOrdinal("Bairro")) ? null : reader.GetString(reader.GetOrdinal("Bairro")),
                    Cidade = reader.IsDBNull(reader.GetOrdinal("Cidade")) ? null : reader.GetString(reader.GetOrdinal("Cidade")),
                    CEP = reader.IsDBNull(reader.GetOrdinal("CEP")) ? null : reader.GetString(reader.GetOrdinal("CEP")),
                    UF = reader.IsDBNull(reader.GetOrdinal("UF")) ? null : reader.GetString(reader.GetOrdinal("UF")),
                    CPF = reader.IsDBNull(reader.GetOrdinal("CPF")) ? null : reader.GetString(reader.GetOrdinal("CPF"))
                };
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("Erro ao acessar o banco de dados.", ex);
        }

        return vendedor;
    }


    public int Inserir(VendedorModel vendedor)
    {
        if (vendedor == null)
        {
            throw new ArgumentNullException(nameof(vendedor), "Vendedor não pode ser nulo.");
        }

        try
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Vendedores (Vendedor, Comissao, Endereco, Bairro, Cidade, CEP, UF, CPF) VALUES (@Vendedor, @Comissao, @Endereco, @Bairro, @Cidade, @CEP, @UF, @CPF)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Vendedor", vendedor.Vendedor ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Comissao", vendedor.Comissao);
                    command.Parameters.AddWithValue("@Endereco", vendedor.Endereco ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Bairro", vendedor.Bairro ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Cidade", vendedor.Cidade ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CEP", vendedor.CEP ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@UF", vendedor.UF ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CPF", vendedor.CPF ?? (object)DBNull.Value);

                    return command.ExecuteNonQuery();
                }
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("Erro ao acessar o banco de dados: " + ex.Message, ex);
        }
    }


    public int EditarPorCodigo(int id, VendedorModel vendedor)
    {
        if (vendedor == null)
        {
            throw new ArgumentNullException(nameof(vendedor), "Vendedor não pode ser nulo.");
        }

        try
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "UPDATE Vendedores SET Vendedor = @Vendedor, Comissao = @Comissao, Endereco = @Endereco, Bairro = @Bairro, Cidade = @Cidade, CEP = @CEP, UF = @UF, CPF = @CPF WHERE IdVendedor = @IdVendedor";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdVendedor", id);
                    command.Parameters.AddWithValue("@Vendedor", vendedor.Vendedor);
                    command.Parameters.AddWithValue("@Comissao", vendedor.Comissao);
                    command.Parameters.AddWithValue("@Endereco", vendedor.Endereco);
                    command.Parameters.AddWithValue("@Bairro", vendedor.Bairro);
                    command.Parameters.AddWithValue("@Cidade", vendedor.Cidade);
                    command.Parameters.AddWithValue("@CEP", vendedor.CEP);
                    command.Parameters.AddWithValue("@UF", vendedor.UF);
                    command.Parameters.AddWithValue("@CPF", vendedor.CPF);

                    return command.ExecuteNonQuery();
                }
            }
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
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Vendedores WHERE IdVendedor = @IdVendedor";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdVendedor", id);

                    return command.ExecuteNonQuery();
                }
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("Erro ao acessar o banco de dados.", ex);
        }
    }
}
