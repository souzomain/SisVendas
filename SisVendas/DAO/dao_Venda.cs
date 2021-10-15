using MySql.Data.MySqlClient;
using SisVendas.DTO;
using System;
using System.Collections.Generic;

namespace SisVendas.DAO
{
    class dao_Venda:Conn
    {
        //adiciona venda e retorna o id
        public int addVenda(string nome,decimal valor, DTO.Cliente c,int tipoid, string metodo = "")
        {
            int id = 0;
            using (var i = Conexion())
            {
                i.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = i;
                    string sql = null;

                    /*verificar se o mesmo nome existe ja em uma venda nao finalizada*/
                    if (c == null)
                        sql = "INSERT INTO venda(nome,finalizado,valor_total,id_tipo,metodo_pagamento) VALUES (@NOME,0,@VALOR,@TIPO,@METODO);";
                    else { 
                        sql = "INSERT INTO venda(nome,finalizado,valor_total,id_cliente,id_tipo,metodo_pagamento) VALUES (@NOME,0,@VALOR,@IDCLI,@TIPO,@METODO);";
                        cmd.Parameters.AddWithValue("@IDCLI", c.Id);
                    }
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@NOME",nome);
                    cmd.Parameters.AddWithValue("@VALOR", valor);
                    cmd.Parameters.AddWithValue("@TIPO", tipoid);
                    cmd.Parameters.AddWithValue("@METODO", metodo);
                    cmd.ExecuteNonQuery();
                    
                    sql = "SELECT * FROM `venda` ORDER BY id DESC LIMIT 1;";
                    cmd.CommandText = sql;
                    using (MySqlDataReader rd = cmd.ExecuteReader())
                    {
                        rd.Read();
                        id = rd.GetInt32(0);
                    }
                }
            }
            return id;
        }
        public List<Venda> getVendas(string select)
        {
            using (var i = Conexion())
            {
                i.Open();
                using (MySqlCommand c = new MySqlCommand())
                {
                    c.Connection = i;
                    if (string.IsNullOrEmpty(select))
                        c.CommandText = "SELECT * FROM venda";
                    else
                        c.CommandText = $"SELECT * FROM venda {select}";
                    using (MySqlDataReader r = c.ExecuteReader())
                    {
                        List<Venda> v = new List<Venda>();
                        while (r.Read())
                        {
                            DateTime data_ini= Convert.ToDateTime(r["data_inicio"]);
                            DateTime data_fi = DateTime.MinValue;
                            if (!r.IsDBNull(5)) {
                                data_fi = Convert.ToDateTime(r["data_finalizado"]);
                            }

                            int a = Convert.ToInt32(r["finalizado"]);
                            bool isfin = false;
                            if (a == 1)
                            {
                                isfin = true;
                            } else
                                isfin = false;
                            Tipo t = new Tipo() { Id = Convert.ToInt32(r[1]) };
                            DTO.Cliente cli = new DTO.Cliente();
                            if (!r.IsDBNull(8))
                            {
                                cli.Id = Convert.ToInt32(r["id_cliente"]);
                            }
                            v.Add(new Venda() { Id=Convert.ToInt32(r[0]),Data_finalizado=data_fi, Finalizado =isfin,Nome=r["nome"].ToString(),Valor_total=Convert.ToDecimal(r["valor_total"]),Data_inicio=data_ini,Metodo_pagamento=r["metodo_pagamento"].ToString(),Tipo=t,Cliente=cli});
                        }
                        return v;
                    }
                }
            }
        }
        public bool FinalizarVenda(int id,string metodo="dinheiro")
        {
            using (var i = Conexion())
            {
                i.Open();
                using (MySqlCommand c = new MySqlCommand())
                {
                    //VALOR TOTAL E ID
                    c.Connection = i;
                    c.CommandText = $"UPDATE venda SET finalizado=1, data_finalizado=NOW(),metodo_pagamento = '{metodo.Trim().Replace("'","")}' WHERE id = @ID";
                    c.Parameters.AddWithValue("@ID", id);
                    if (c.ExecuteNonQuery() != 1)
                    {
                        return false;
                    }
                    else
                        return true;
                }
            }
        }
        public int Delete(int id)
        {
            using (var i = Conexion())
            {
                i.Open();
                using (var c = new MySqlCommand())
                {
                    c.Connection = i;
                    c.CommandText = $"DELETE FROM venda WHERE id = {id}";
                    return c.ExecuteNonQuery();
                }
            }
        }
        public void altervalor(decimal val,int id)
        {
            using (var i = Conexion())
            {
                i.Open();
                using (var c = new MySqlCommand())
                {
                    c.Connection = i;
                    c.CommandText = $"UPDATE venda SET valor_total =@PRECO WHERE id=@ID";
                    c.Parameters.AddWithValue("@PRECO", val);
                    c.Parameters.AddWithValue("@ID", id);
                    c.ExecuteNonQuery();
                }
            }
        }
    }
}