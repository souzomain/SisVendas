using System;

namespace SisVendas.DTO
{
    public class Estoque
    {
        private int id;
        private Produto_Estoque produto_estoque;
        private DateTime data_reposicao;
        public Estoque()
        {

        }
        public Estoque(Produto_Estoque produto_estoque, DateTime data_reposicao)
        {
            this.produto_estoque = produto_estoque;
            this.data_reposicao = data_reposicao;
        }

        public int Id { get => id; set => id = value; }
        public Produto_Estoque Produto_estoque { get => produto_estoque; set => produto_estoque = value; }
        public DateTime Data_reposicao { get => data_reposicao; set => data_reposicao = value; }
    }
}
