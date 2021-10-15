namespace SisVendas.DTO
{
    public class Produto
    {
        private int id;
        private string nome;
        private string descricao;
        private decimal preco;
        private int inativo;
        private decimal valor_bruto;
        public Produto()
        {

        }
        public Produto(int id,string nome, string descricao, decimal preco)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.preco = preco;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public decimal Preco { get => preco; set => preco = value; }
        public int Inativo { get => inativo; set => inativo = value; }
        public decimal Valor_bruto { get => valor_bruto; set => valor_bruto = value; }
    }
}
