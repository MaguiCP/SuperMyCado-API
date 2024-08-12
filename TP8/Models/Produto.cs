namespace SuperMyCadoApi.Models
{
    public class Produto
    {
        public long ProdutoId { get; set; }

        public string? CodigoProduto { get; set; }

        public string? NomeProduto { get; set; }

        public Gama? SiglaGamaProduto { get; set; }

        public Loja? NomeLojaProduto { get; set; }
    }
}
