namespace API_ProjetoFinal.Models
{
    public class ProdutoModel
    {
        public int idProduto { get; set; }
        public string CodigoProduto { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }
        public decimal ValorVenda { get; set; }
        public float IPI { get; set; }
        public float Estoque { get; set; }
    }
}
