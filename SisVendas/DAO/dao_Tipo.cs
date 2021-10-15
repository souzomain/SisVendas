using MySql.Data.MySqlClient;
using SisVendas.DTO;
using System;
using System.Collections.Generic;

namespace SisVendas.DAO
{
    class dao_Tipo : Conn
    {
        public List<Tipo> getTipos(string s)
        {
            using (var i = Conexion())
            {
                i.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = i;
                    cmd.CommandText = $"SELECT * FROM tipo {s}";
                    using (var r = cmd.ExecuteReader())
                    {
                        List<Tipo> t = new List<Tipo>();
                        while (r.Read())
                        {
                            t.Add(new Tipo()
                            {
                                Id = Convert.ToInt32(r["id"]),
                                Nome = r["nome"].ToString()
                            });
                        }
                        return t;
                    }
                }
            }
        }
    }
}
