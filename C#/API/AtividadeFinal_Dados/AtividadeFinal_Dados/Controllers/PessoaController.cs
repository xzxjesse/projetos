using AtividadeFinal_Dados.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class PessoaController : ControllerBase
{
    private readonly PessoaRepository _repository;

    public PessoaController(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("conexao");
        _repository = new PessoaRepository(connectionString);
    }

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
}
