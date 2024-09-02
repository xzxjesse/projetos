using API_ProjetoFinal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class ProdutoController : ControllerBase
{
    private readonly ProdutoRepository _repository;

    public ProdutoController(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("conexao");
        _repository = new ProdutoRepository(connectionString);
    }

    [HttpGet]
    public IEnumerable<ProdutoModel> Pesquisa()
    {
        return _repository.Pesquisa();
    }

    [HttpGet("{id}")]
    public IActionResult BuscaPorCodigo(int id)
    {
        var produto = _repository.BuscaPorCodigo(id);

        if (produto == null)
        {
            return NotFound("Produto não encontrado.");
        }

        return Ok(produto);
    }

    [HttpPost]
    public IActionResult Inserir([FromBody] ProdutoModel produto)
    {
        if (produto == null)
        {
            return BadRequest("Produto não pode ser nulo.");
        }

        try
        {
            int numLinhas = _repository.Inserir(produto);
            return Ok($"Número de linhas adicionadas: {numLinhas}");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao processar a solicitação: {ex.Message}");
        }
    }

    [HttpPut("{id}")]
    public IActionResult EditarPorCodigo(int id, [FromBody] ProdutoModel produto)
    {
        if (produto == null)
        {
            return BadRequest("Produto não pode ser nulo.");
        }

        if (id != produto.idProduto)
        {
            return BadRequest("ID no URL e ID no corpo da requisição não coincidem.");
        }

        try
        {
            int numLinhas = _repository.EditarPorCodigo(id, produto);

            if (numLinhas == 0)
            {
                return NotFound("Produto não encontrado.");
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
                return NotFound("Produto não encontrado.");
            }

            return Ok($"Número de linhas removidas: {numLinhas}");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao processar a solicitação: {ex.Message}");
        }
    }
}
