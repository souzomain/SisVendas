using MySql.Data.MySqlClient;
using SisVendas.DTO;
using System.Collections.Generic;

namespace SisVendas.DAO
{
    class dao_Produto : Conn
    {
        public void Alter(Produto p)
        {
            using (var i = Conexion())
            {
                i.Open();
                using (var c = new MySqlCommand())
                {
                    c.Connection = i;
                    c.CommandText = "UPDATE produto SET nome=@NOME, preco=@PRECO,descricao=@DESC,valor_bruto=@BRUTO WHERE id=@ID";
                    c.Parameters.AddWithValue("@NOME",p.Nome);
                    c.Parameters.AddWithValue("@BRUTO", p.Valor_bruto);
                    c.Parameters.AddWithValue("@PRECO",p.Preco);
                    c.Parameters.AddWithValue("@DESC", p.Descricao);
                    c.Parameters.AddWithValue("@ID",p.Id);
                    c.ExecuteNonQuery();
                }
            }
        }
        /*
         SELECT SUM(quantidade) AS quantidade,produto.nome as produto_nome,venda.data_finalizado as data_venda,SUM(produto.preco) as valor FROM venda_item JOIN produto ON produto_id = produto.id JOIN venda ON venda_item.venda_id = venda.id GROUP BY produto_id ORDER BY valor DESC 
         */
        public List<Produto> ListProduts(string s)
        {
            List<Produto> p = new List<Produto>();
            using (var i = Conexion())
            {
                i.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = i;
                    if (string.IsNullOrEmpty(s))
                        cmd.CommandText = "SELECT * FROM produto;";
                    else
                        cmd.CommandText = $"SELECT * FROM produto {s}";
                    using (MySqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            string descricao = "sem descrição";
                            if (!rd.IsDBNull(3))
                                descricao = rd.GetString("descricao");
                            p.Add(new Produto() {Descricao=descricao,Id=rd.GetInt32("id"),Nome = rd.GetString("nome"),Preco=rd.GetDecimal("preco"),Inativo=rd.GetInt32("inativo"),Valor_bruto=rd.GetDecimal("valor_bruto") });
                        }
                        return p;
                    }
                }
            }
        }
        public void Ativa(int id)
        {
            using (var i = Conexion())
            {
                i.Open();
                using (var c = new MySqlCommand())
                {
                    c.Connection = i;
                    c.CommandText = $"UPDATE produto SET inativo=0 WHERE id = {id}";
                    c.ExecuteNonQuery();
                }
            }
        }
        public bool Insert(Produto c)
        {
            using (var i = Conexion())
            {
                i.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = i;
                    cmd.CommandText = "INSERT INTO produto VALUES(NULL,@NOME,@PRECO,@DESCRICAO,0,@BRUTO)";
                    cmd.Parameters.AddWithValue("@BRUTO", c.Valor_bruto);
                    cmd.Parameters.AddWithValue("@NOME", c.Nome);
                    cmd.Parameters.AddWithValue("@PRECO", c.Preco);
                    cmd.Parameters.AddWithValue("@DESCRICAO", c.Descricao);
                    if (cmd.ExecuteNonQuery() == 1)
                        return true;
                    else return false;
                }
            }
        }
        public void Delete(int id)
        {
            using (var i = Conexion()){
                i.Open();
                using (var c = new MySqlCommand())
                {
                    c.Connection = i;
                    c.CommandText=$"UPDATE produto SET inativo=1 WHERE id = {id}";
                    c.ExecuteNonQuery();
                }
            }
        }
    }
}
