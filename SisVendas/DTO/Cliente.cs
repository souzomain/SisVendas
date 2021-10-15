namespace SisVendas.DTO
{
    public class Cliente
    {
        private int id;
        private string nome_cliente;
        private string endereco;
        private int casa_number;
        private string observacoes;
        private string telefone;
        private int inativo;
        public int Id { get => id; set => id = value; }
        public string Nome_cliente { get => nome_cliente; set => nome_cliente = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public int Casa_number { get => casa_number; set => casa_number = value; }
        public string Observacoes { get => observacoes; set => observacoes = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public int Inativo { get => inativo; set => inativo = value; }
    }
}
