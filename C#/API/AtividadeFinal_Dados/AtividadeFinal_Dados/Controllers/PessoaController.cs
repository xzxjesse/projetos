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
}
