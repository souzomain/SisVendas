namespace SisVendas.DTO
{
    public class Produto_Estoque
    {
        private int id;
        private string nome_prod;
        private int quantidade;
        private decimal valor_unid;

        public Produto_Estoque()
        {

        }
        public Produto_Estoque(string nome_prod, int quantidade, decimal valor_unid)
        {
            this.nome_prod = nome_prod;
            this.quantidade = quantidade;
            this.valor_unid = valor_unid;
        }

        public int Id { get => id; set => id = value; }
        public string Nome_prod { get => nome_prod; set => nome_prod = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public decimal Valor_unid { get => valor_unid; set => valor_unid = value; }
    }
}
