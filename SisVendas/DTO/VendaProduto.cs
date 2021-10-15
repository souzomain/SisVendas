using System;

namespace SisVendas.DTO
{
    public class VendaProduto
    {
        private string produto_nome;
        private int quantidade;
        private DateTime datavenda;
        private decimal valor;

        public string Produto_nome { get => produto_nome; set => produto_nome = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public DateTime Datavenda { get => datavenda; set => datavenda = value; }
        public decimal Valor { get => valor; set => valor = value; }
    }
}
