using API_ProjetoFinal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class VendedorController : ControllerBase
{
    private readonly VendedorRepository _repository;

    public VendedorController(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("conexao");
        _repository = new VendedorRepository(connectionString);
    }

    [HttpGet]
    public IEnumerable<VendedorModel> Pesquisa()
    {
        return _repository.Pesquisa();
    }

    [HttpGet("{id}")]
    public IActionResult BuscaPorCodigo(int id)
    {
        var vendedor = _repository.BuscaPorCodigo(id);

        if (vendedor == null)
        {
            return NotFound("Vendedor não encontrado.");
        }

        return Ok(vendedor);
    }

    [HttpPost]
    public IActionResult Inserir([FromBody] VendedorModel vendedor)
    {
        if (vendedor == null)
        {
            return BadRequest("Vendedor não pode ser nulo.");
        }

        try
        {
            int numLinhas = _repository.Inserir(vendedor);
            return Ok($"Número de linhas adicionadas: {numLinhas}");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao processar a solicitação: {ex.Message}");
        }
    }

    [HttpPut("{id}")]
    public IActionResult EditarPorCodigo(int id, [FromBody] VendedorModel vendedor)
    {
        if (vendedor == null)
        {
            return BadRequest("Vendedor não pode ser nulo.");
        }

        if (id != vendedor.IdVendedor)
        {
            return BadRequest("ID no URL e ID no corpo da requisição não coincidem.");
        }

        try
        {
            int numLinhas = _repository.EditarPorCodigo(id, vendedor);

            if (numLinhas == 0)
            {
                return NotFound("Vendedor não encontrado.");
            }

            return Ok($"Número de linhas atualizadas: {numLinhas}");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao processar a solicitação: {ex.Message}");
        }
    }

    [HttpDelete("{id}")]
    public IActionResult ExcluirPorCodigo(int id)
    {
        try
        {
            int numLinhas = _repository.ExcluirPorCodigo(id);

            if (numLinhas == 0)
            {
                return NotFound("Vendedor não encontrado.");
            }

            return Ok($"Número de linhas removidas: {numLinhas}");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao processar a solicitação: {ex.Message}");
        }
    }
}
