using AtividadeFinal_Dados.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class PessoaController : ControllerBase
{
    #region |Configurações|
    private readonly PessoaRepository _repository;

    public PessoaController(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("conexao");
        _repository = new PessoaRepository(connectionString);
    }
    #endregion

    #region |Buscas|
    //Read
    [HttpGet]
    public IEnumerable<PessoaModel> Todas()
    {
        return _repository.Todas();
    }

    [HttpGet("id/{ID}")]
    public IActionResult Codigo(int ID)
    {
        var pessoa = _repository.Codigo(ID);

        if (pessoa == null)
        {
            return NotFound();
        }

        return Ok(pessoa);
    }

    [HttpGet("user/{nome}")]
    public IActionResult Nome(string nome)
    {
        var pessoas = _repository.Nome(nome);

        if (pessoas == null || !pessoas.Any())
        {
            return NotFound();
        }

        return Ok(pessoas);
    }
    #endregion

    #region |Atualizações|

    //Create
    [HttpPost]
    public IActionResult Adiciona([FromBody] PessoaModel pessoa)
    {
        if (pessoa == null)
        {
            return BadRequest("Pessoa não pode ser nula.");
        }

        try
        {
            int numLinhas = _repository.Adiciona(pessoa);
            return Ok($"Número de linhas adicionadas: {numLinhas}");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao processar a solicitação: {ex.Message}");
        }
    }


    //Update
    [HttpPut("id/{ID}")]
    public IActionResult Atualiza(int ID, [FromBody] PessoaModel pessoa)
    {
        if (pessoa == null)
        {
            return BadRequest("Pessoa não pode ser nula.");
        }

        if (ID != pessoa.IDPessoa)
        {
            return BadRequest("ID no URL e ID no corpo da requisição não coincidem.");
        }

        try
        {
            int numLinhas = _repository.Atualiza(pessoa);

            if (numLinhas == 0)
            {
                return NotFound("Pessoa não encontrada.");
            }

            return Ok($"Número de linhas atualizadas: {numLinhas}");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao processar a solicitação: {ex.Message}");
        }
    }

    //Delete
    [HttpDelete("id/{ID}")]
    public IActionResult Remove(int ID)
    {
        try
        {
            int numLinhas = _repository.Remove(ID);

            if (numLinhas == 0)
            {
                return NotFound("Pessoa não encontrada.");
            }

            return Ok($"Número de linhas removidas: {numLinhas}");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao processar a solicitação: {ex.Message}");
        }
    }

    #endregion

}
