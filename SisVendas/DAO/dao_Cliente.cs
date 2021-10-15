using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace SisVendas.DAO
{
    class dao_Cliente : Conn
    {
        public List<DTO.Cliente> getClientes(string select = null)
        {
            using (var i = Conexion())
            {
                i.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = i;
                    cmd.CommandText = $"SELECT * FROM cliente {select}";
                    using (var rd = cmd.ExecuteReader())
                    {
                        List<DTO.Cliente> cli = new List<DTO.Cliente>();
                        while (rd.Read())
                        {
                            cli.Add(new DTO.Cliente() { Id = Convert.ToInt32(rd[0]), Nome_cliente = rd["nome_cliente"].ToString(), Endereco = rd.IsDBNull(2) ? "sem endereço" : rd["endereco"].ToString(), Casa_number = Convert.ToInt32(rd["casa_number"]), Observacoes = rd.IsDBNull(4) ? "sem observações" : rd[4].ToString(),Telefone= rd.IsDBNull(5) ? "sem telefone" : rd[5].ToString(),Inativo=Convert.ToInt32(rd["inativo"]) });
                        }
                        return cli;
                    }
                }
            }
        }
        public void Ativa(int id)
        {
            using (var i = Conexion())
            {
                i.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = i;
                    cmd.CommandText = $"UPDATE cliente SET inativo=0 WHERE id = {id}";
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void alterCliente(DTO.Cliente c)
        {
            using (var i = Conexion())
            {
                i.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = i;
                    cmd.CommandText = $"UPDATE cliente SET nome_cliente=@NOME,endereco=@ENDERECO,casa_number=0,observacoes=@OBS,telefone=@TELL WHERE id = {c.Id}";
                    cmd.Parameters.AddWithValue("@NOME",c.Nome_cliente);
                    cmd.Parameters.AddWithValue("@ENDERECO", c.Endereco);
                    cmd.Parameters.AddWithValue("@OBS", c.Observacoes);
                    cmd.Parameters.AddWithValue("@TELL", c.Telefone);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Insert(DTO.Cliente c)
        {
            using (var i = Conexion())
            {
                i.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = i;
                    cmd.CommandText = $"INSERT INTO cliente VALUES(NULL,@NOME,@ENDERECO,0,@OBS,@TELL,0)";
                    cmd.Parameters.AddWithValue("@NOME", c.Nome_cliente);
                    cmd.Parameters.AddWithValue("@ENDERECO", c.Endereco);
                    cmd.Parameters.AddWithValue("@OBS", c.Observacoes);
                    cmd.Parameters.AddWithValue("@TELL", c.Telefone);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void delete(int id)
        {
            using (var i = Conexion())
            {
                i.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = i;
                    cmd.CommandText = $"UPDATE cliente SET inativo=1 WHERE id = {id}";
                    cmd.ExecuteNonQuery();
                }
            }
        }
        /*using (var i = Conexion())
            {
                i.Open();
                using (var cmd = new MySqlCommand())
                {

                }
            }*/
    }
}
