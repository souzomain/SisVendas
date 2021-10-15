using System;

namespace SisVendas.DTO
{
    public class Venda
    {
        private int id;
        private string nome;
        private bool finalizado;
        private DateTime data_finalizado;
        private DateTime data_inicio;
        private string metodo_pagamento;
        private decimal valor_total;
        private Tipo tipo;
        private Cliente cliente;
        public Venda()
        {

        }
        public Venda(string nome, bool finalizado, DateTime data_finalizado)
        {
            this.nome = nome;
            this.finalizado = finalizado;
            this.data_finalizado = data_finalizado;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        
        public bool Finalizado { get => finalizado; set => finalizado = value; }
        public DateTime Data_finalizado { get => data_finalizado; set => data_finalizado = value; }
        public decimal Valor_total { get => valor_total; set => valor_total = value; }
        public DateTime Data_inicio { get => data_inicio; set => data_inicio = value; }
        public string Metodo_pagamento { get => metodo_pagamento; set => metodo_pagamento = value; }
        public  Tipo Tipo { get => tipo; set => tipo = value; }
        public DTO.Cliente Cliente { get => cliente; set => cliente = value; }
    }
}