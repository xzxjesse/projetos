using AtividadeFinal_Dados.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class TelefoneController : ControllerBase
{
    private readonly TelefoneRepository _repository;

    public TelefoneController(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("conexao");
        _repository = new TelefoneRepository(connectionString);
    }

    [HttpGet]
    public ActionResult<IEnumerable<TelefoneModel>> Todos()
    {
        var telefones = _repository.Todos();
        return Ok(telefones);
    }

    [HttpGet("pessoa/{codigo}")]
    public IActionResult Pessoa(int idPessoa)
    {
        var telefones = _repository.Pessoa(idPessoa);
        if (!telefones.Any())
        {
            return NotFound("Nenhum telefone encontrado para essa pessoa.");
        }

        return Ok(telefones);
    }

    [HttpGet("{codigo}")]
    public IActionResult Codigo(int ID)
    {
        var telefone = _repository.Codigo(ID);
        if (telefone == null)
        {
            return NotFound("Telefone não encontrado.");
        }

        return Ok(telefone);
    }

    [HttpGet("{numero}")]
    public IActionResult Numero(string numero)
    {
        var telefones = _repository.Numero(numero);
        if (!telefones.Any())
        {
            return NotFound("Nenhum telefone encontrado com esse número.");
        }

        return Ok(telefones);
    }

    [HttpPost]
    public IActionResult Adiciona([FromBody] TelefoneModel telefone)
    {
        if (telefone == null)
        {
            return BadRequest("Telefone não pode ser nulo.");
        }

        var resultado = _repository.Adiciona(telefone);
        return Ok($"Telefone adicionado com sucesso. Linhas afetadas: {resultado}");
    }

    [HttpPut("{codigo}")]
    public IActionResult Atualiza(int ID, [FromBody] TelefoneModel telefone)
    {
        if (telefone == null || ID != telefone.IDTelefone)
        {
            return BadRequest("Dados inválidos.");
        }

        var resultado = _repository.Atualiza(telefone);
        return Ok($"Telefone atualizado com sucesso. Linhas afetadas: {resultado}");
    }

    [HttpDelete("{codigo}")]
    public IActionResult Deleta(int ID)
    {
        var resultado = _repository.Deleta(ID);
        return Ok($"Telefone deletado com sucesso. Linhas afetadas: {resultado}");
    }

}
