namespace API_ProjetoFinal.Models
{
    public class VendedorModel
    {
        public int IdVendedor { get; set; }
        public string Vendedor { get; set; } 
        public decimal Comissao { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }
        public string CPF { get; set; }
    }

}
