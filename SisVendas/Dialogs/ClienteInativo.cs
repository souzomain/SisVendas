using SisVendas.DAO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SisVendas.Dialogs
{
    public partial class ClienteInativo : Form
    {
        public ClienteInativo()
        {
            InitializeComponent();
            atualizagrid();
        }
        private void atualizagrid(string select = "")
        {
            try
            {
                if (listView1.Items.Count > 0) listView1.Items.Clear();
                List<DTO.Cliente> c = new dao_Cliente().getClientes($"WHERE cliente.inativo = 1 {select}");
                foreach (var i in c)
                {
                    listView1.Items.Add(new ListViewItem(new string[] { i.Id.ToString(),i.Nome_cliente,i.Endereco,i.Telefone}));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            atualizagrid($"AND cliente.nome_cliente LIKE '%{textBox1.Text.Trim().Replace("'","")}%'");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            atualizagrid($"AND cliente.endereco LIKE '%{textBox2.Text.Trim().Replace("'", "")}%'");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            atualizagrid($"AND cliente.telefone LIKE '%{textBox3.Text.Trim().Replace("'", "")}%'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem i in listView1.SelectedItems)
                {
                    new dao_Cliente().Ativa(Convert.ToInt32(i.SubItems[0].Text));
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                atualizagrid();
            }
        }
    }
}
