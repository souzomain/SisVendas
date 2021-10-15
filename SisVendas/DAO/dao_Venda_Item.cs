using MySql.Data.MySqlClient;
using SisVendas.DTO;
using System;
using System.Collections.Generic;

/* 
    venda
    produto
    quantidade
 */
namespace SisVendas.DAO
{
    class dao_Venda_Item : Conn
    {
        public List<VendaProduto> GetVendaProduto(string select = null,string order = "valor")
        {
            using (var i = Conexion())
            {
                i.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = i;
                    cmd.CommandText = $"SELECT SUM(quantidade) AS quantidade,produto.nome as produto_nome,venda.data_finalizado as data_venda,SUM(produto.preco) as valor FROM venda_item JOIN produto ON produto_id = produto.id JOIN venda ON venda_item.venda_id = venda.id {select} GROUP BY produto_id ORDER BY {order} DESC";
                    using (var rd = cmd.ExecuteReader())
                    {
                        List<VendaProduto> vp = new List<VendaProduto>();
                        while (rd.Read())
                        {
                            vp.Add(new VendaProduto() {Quantidade=rd.IsDBNull(0)? 0 : Convert.ToInt32(rd["quantidade"]), Valor= rd.IsDBNull(3) ? 0 : Convert.ToDecimal(rd["valor"]), Datavenda= rd.IsDBNull(2) ? DateTime.MinValue : Convert.ToDateTime(rd["data_venda"]),Produto_nome=rd.IsDBNull(1)?null:rd["produto_nome"].ToString() });
                        }
                        return vp;
                    }
                }
            }
        }
        public void altera(int id, int qtd, string desc)
        {
            using (var i = Conexion())
            {
                i.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = i;
                    cmd.CommandText = $"UPDATE venda_item SET quantidade = {qtd},descricao ='{desc.Trim().Replace("'","")}' WHERE id = {id}";
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Delete(int id)
        {
            using (var i = Conexion())
            {
                i.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = i;
                    cmd.CommandText = $"DELETE FROM venda_item WHERE id = {id}";
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public bool addItem(Venda_Item v)
        {
            using (var i = Conexion())
            {
                i.Open();
                using (var c = new MySqlCommand())
                {
                    c.Connection = i;
                    c.CommandText = "INSERT INTO venda_item VALUES (NULL,@VENDAID,@PRODUTOID,@QUANTIDADE,@DESCRICAO)";
                    c.Parameters.AddWithValue("@QUANTIDADE", v.Quantidade);
                    c.Parameters.AddWithValue("@DESCRICAO", v.Descricao);
                    c.Parameters.AddWithValue("@VENDAID",v.Venda.Id);
                    c.Parameters.AddWithValue("@PRODUTOID", v.Produto.Id);
                    if (c.ExecuteNonQuery() == 1)
                        return true;
                    else
                        return false;
                }
            }
        }
        public List<Venda_Item> getVendaItem(string s)
        {
            using (var i = Conexion())
            {
                i.Open();
                using (MySqlCommand c = new MySqlCommand())
                {
                    c.Connection = i;
                    if (string.IsNullOrEmpty(s))
                        c.CommandText = "SELECT venda_item.id as 'id',venda.id as 'venda_id', venda.nome as 'venda_nome', venda.finalizado as 'venda_finalizado',venda.data_inicio as 'venda_data_inicio',venda.data_finalizado as 'venda_data_finalizado', venda.valor_total as 'venda_valor_total', produto.id as 'produto_id',produto.nome as 'produto_nome',produto.preco as 'produto_preco',produto.descricao as 'produto_descricao',venda_item.descricao as 'item_desc',quantidade,produto.valor_bruto as produto_valor_bruto FROM venda_item JOIN venda ON venda_id = venda.id JOIN produto ON produto_id = produto.id;";
                    else
                        c.CommandText = $"SELECT venda_item.id as 'id',venda.id as 'venda_id', venda.nome as 'venda_nome', venda.finalizado as 'venda_finalizado',venda.data_inicio as 'venda_data_inicio',venda.data_finalizado as 'venda_data_finalizado', venda.valor_total as 'venda_valor_total', produto.id as 'produto_id',produto.nome as 'produto_nome',produto.preco as 'produto_preco',produto.descricao as 'produto_descricao',venda_item.descricao as 'item_desc',quantidade,produto.valor_bruto as produto_valor_bruto FROM venda_item JOIN venda ON venda_id = venda.id JOIN produto ON produto_id = produto.id {s}";
                    using (MySqlDataReader rd = c.ExecuteReader())
                    {
                        List<Venda_Item> ven = new List<Venda_Item>();
                        while (rd.Read())
                        {
                            Produto p = new Produto();
                            p.Id =Convert.ToInt32( rd["produto_id"]);
                            p.Nome = rd["produto_nome"].ToString();
                            p.Preco =Convert.ToDecimal( rd["produto_preco"]);
                            p.Descricao = rd["produto_descricao"].ToString();
                            p.Valor_bruto = Convert.ToDecimal(rd["produto_valor_bruto"]);

                            Venda v = new Venda();
                            v.Nome = rd["venda_nome"].ToString();
                            v.Id =Convert.ToInt32( rd["venda_id"]);
                            bool isfin;
                            if (Convert.ToInt32(rd["venda_finalizado"]) == 1)
                            {
                                isfin = true;
                            }
                            else
                                isfin = false;

                            v.Finalizado =isfin;
                            DateTime data_ini = Convert.ToDateTime(rd["venda_data_inicio"]);
                            DateTime data_fin = DateTime.MinValue;
                            if (!rd.IsDBNull(5))
                                data_fin = Convert.ToDateTime(rd["venda_data_finalizado"]);
                            v.Data_finalizado = data_fin;
                            v.Data_inicio = data_ini;
                            v.Valor_total = Convert.ToDecimal(rd["venda_valor_total"]);

                            ven.Add(new Venda_Item() { Id = Convert.ToInt32(rd["id"]),Produto=p,Venda=v,Descricao=rd["item_desc"].ToString(),Quantidade=Convert.ToInt32(rd["quantidade"])});
                        }
                        return ven;
                    }
                }
            }
        }
    }
}