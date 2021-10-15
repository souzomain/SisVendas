using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace SisVendas.DAO
{
    class Conn
    {
        readonly string s;
        public Conn()
        {
            //bucetinha@mel123
            this.s = "Server=localhost;port=3306;User Id=root;database=sis_vendas_restaurante;password=";
        }
        protected MySqlConnection Conexion()
        {
            return new MySqlConnection(this.s);
        }
        public bool ConexionTest()
        {
            using (var c = new MySqlConnection(this.s)) {
                try { 
                    c.Open();
                }catch(Exception)
                {
                    return false;
                }
                if (c.State == ConnectionState.Open)
                    return true;
                else
                    return false;
            }
        }
        public int NumResult(string select)
        {
            using(var i= Conexion())
            {
                i.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = i;
                    cmd.CommandText = select;
                    using (MySqlDataReader rd = cmd.ExecuteReader())
                    {
                        int l = 0;
                        while (rd.Read())
                        {
                            l++;
                        }
                        return l;
                    }
                }
            }
        }
    }
}
