using SisVendas.DAO;
using SisVendas.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SisVendas.Dialogs
{
    public partial class ProdutosInativos : Form
    {
        public ProdutosInativos()
        {
            InitializeComponent();
            populagrid();
        }
        private void populagrid(string select = "")
        {
            try
            {
                if (listView1.Items.Count > 0)
                    listView1.Items.Clear();
                List<Produto> p = new dao_Produto().ListProduts($"WHERE inativo = 1 {select}");
                foreach (var i in p)
                {
                    listView1.Items.Add(new ListViewItem(new string[] { i.Id.ToString(),i.Nome,i.Preco.ToString(),i.Descricao}));
                }
            }
            catch (Exception)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            populagrid($"AND produto.nome LIKE '%{textBox1.Text.Trim().Replace("'","")}%'");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            populagrid($"AND produto.preco LIKE '%{textBox2.Text.Trim().Replace("'", "")}%'");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            populagrid($"AND produto.descricao LIKE '%{richTextBox1.Text.Trim().Replace("'", "")}%'");
        }

        private void btn_ativa_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem v in listView1.SelectedItems)
                {
                    new dao_Produto().Ativa(Convert.ToInt32(v.SubItems[0].Text));
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                populagrid();
            }
            
        }
    }
}
