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
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        _repository = new PessoaRepository(connectionString);
    }
    #endregion

    #region |Get|
    [HttpGet]
    public IEnumerable<PessoaModel> Todas()
    {
        return _repository.Todas();
    }
    #endregion

}