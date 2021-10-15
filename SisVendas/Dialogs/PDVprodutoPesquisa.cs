using SisVendas.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SisVendas.Dialogs
{
    public partial class PDVprodutoPesquisa : Form
    {
        public int pid;
        public int qtd;
        public string desc = "";
        public PDVprodutoPesquisa()
        {
            InitializeComponent();
            view();
        }
        private void add()
        {
            if(grid_items.SelectedItems.Count == 0)
            {
                MessageBox.Show("Escolha um item!");
            }
            else
            {
                //Convert.ToInt32(grid_items.SelectedItems[0].SubItems[0].Text), grid_items.SelectedItems[0].SubItems[1].Text, grid_items.SelectedItems[0].SubItems[3].Text, Convert.ToDecimal(grid_items.SelectedItems[0].SubItems[2].Text
                this.pid = Convert.ToInt32(grid_items.SelectedItems[0].SubItems[0].Text);
                this.qtd = Convert.ToInt32(this.quantidade.Value);
                this.desc = this.txt_desc.Text.Trim().Replace("'","");
                this.DialogResult = DialogResult.OK;
            }
        }
        private void view(string select = "")
        {
            if(grid_items.Items.Count != 0)
            {
                grid_items.Items.Clear();
            }
            List<Produto> p = new DAO.dao_Produto().ListProduts($"WHERE produto.inativo = 0 {select}");
            foreach (var i in p)
            {
                grid_items.Items.Add(new ListViewItem(new string[] { i.Id.ToString(), i.Nome.ToString(), i.Preco.ToString(), i.Descricao.ToString() }));
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                add();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bntsair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
            this.Close();
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                view($"AND produto.nome LIKE '%{txt_nome.Text.Trim().Replace("'","")}%'");
            }
            catch (Exception)
            {
                view();
            }
        }

    }
}
