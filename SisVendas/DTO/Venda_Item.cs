namespace SisVendas.DTO
{
    public class Venda_Item
    {
        

        private int id;
        private Venda venda;
        private Produto produto;
        private int quantidade;
        private string descricao;

        public int Id { get => id; set => id = value; }
        public Venda Venda { get => venda; set => venda = value; }
        public Produto Produto { get => produto; set => produto = value; }

        public int Quantidade { get => quantidade; set => quantidade = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}
