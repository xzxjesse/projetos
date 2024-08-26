using AtividadeFinal_Dados.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

public class PessoaRepository
{
    #region |Configurações|
    private readonly string _connectionString;

    public PessoaRepository(string connectionString)
    {
        _connectionString = connectionString;
    }
    #endregion

    #region |Buscas|

    /// <summary>
    /// Enumera todas as pessoas do banco
    /// </summary>
    /// <returns>id, nome e telefone</returns>
    public IEnumerable<PessoaModel> Todas()
    {
        var pessoas = new List<PessoaModel>();

        using (var connection = new MySqlConnection(_connectionString))
        {
            connection.Open();
            var command = new MySqlCommand("SELECT * FROM Pessoa", connection);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    pessoas.Add(new PessoaModel
                    {
                        ID = reader.GetInt32("ID"),
                        Nome = reader.GetString("Nome"),
                        Telefone = reader.GetString("Telefone")
                    });
                }
            }
        }

        return pessoas;
    }

    #endregion
}
