using SisVendas.DAO;
using SisVendas.DTO;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace SisVendas.Dialogs
{
    public partial class PDV_dialogdocontrole : Form
    {

        int id;
        private bool alter = false;
        public PDV_dialogdocontrole(int id)
        {
            this.id = id;
            List<Venda_Item> p = new dao_Venda_Item().getVendaItem($"WHERE venda_id = {this.id}");
            InitializeComponent();
            lbl_name.Text = p[0].Venda.Nome;
            populatudo();
        }
        private void populatudo()
        {
            List<Venda_Item> p = new dao_Venda_Item().getVendaItem($"WHERE venda_id = {this.id}");
            txt_valor.Text = p[0].Venda.Valor_total.ToString();
            populaitems();
            populaproduto();
        }
        private void populaproduto(string select = "")
        {
            try
            {
                if (grid_produto.Items.Count > 0) grid_produto.Items.Clear();
                List<Produto> p = new dao_Produto().ListProduts(select);
                foreach(var i in p)
                {
                    grid_produto.Items.Add(new ListViewItem(new string[] { i.Id.ToString(),i.Nome.Trim(),i.Preco.ToString()}));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populaitems(string select="")
        {
            try
            {
                if (grid_itemvenda.Items.Count > 0) grid_itemvenda.Items.Clear();
                List<Venda_Item> p = new dao_Venda_Item().getVendaItem($"WHERE venda_id = {this.id} {select}");

                foreach (var i in p)
                {
                    grid_itemvenda.Items.Add(new ListViewItem(new string[] { i.Id.ToString(), i.Produto.Nome, i.Produto.Preco.ToString(),i.Descricao,i.Quantidade.ToString()}));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
           }
        }

        private void txt_nome_prod_TextChanged(object sender, EventArgs e)
        {
            populaproduto($"WHERE produto.nome LIKE '%{txt_nome_prod.Text.Trim().Replace("'","")}%'");
        }

        private void grid_itemvenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grid_itemvenda.SelectedItems.Count > 0 )
            {
                try{
                    id_itemvenda.Text = Convert.ToInt32(grid_itemvenda.SelectedItems[0].SubItems[0].Text).ToString();
                    txt_quantidadeitemvenda.Value = Convert.ToInt32(grid_itemvenda.SelectedItems[0].SubItems[4].Text);
                    txt_descitemvenda.Text = grid_itemvenda.SelectedItems[0].SubItems[3].Text;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private bool invb(bool b)
        {
            if (b) return false; else return true;
        }
        private void btn_alter_Click(object sender, EventArgs e)
        {
            sla();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in grid_itemvenda.SelectedItems)
                {
                    new dao_Venda_Item().Delete(Convert.ToInt32(item.SubItems[0].Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                populatudo();
            }
        }
        private void sla()
        {
            alter = invb(alter);
            btn_guardar.Visible = invb(btn_guardar.Visible);
            txt_descitemvenda.Enabled = invb(txt_descitemvenda.Enabled);
            txt_quantidadeitemvenda.Enabled = invb(txt_quantidadeitemvenda.Enabled);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(id_itemvenda.Text);
                int qtd = Convert.ToInt32(txt_quantidadeitemvenda.Value);
                string desc = "sem descrição";
                if (id == 0)
                {
                    sla();
                    return;
                }
                if (!string.IsNullOrEmpty(txt_descitemvenda.Text)) {
                    desc = txt_descitemvenda.Text;
                }
                new dao_Venda_Item().altera(id,qtd,desc);
                txt_descitemvenda.Text = "";
                txt_quantidadeitemvenda.Value = 1;
                sla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                populatudo();
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(grid_produto.SelectedItems.Count > 0)
            {
                try
                {
                    string desc = "sem descrição";
                    if (!string.IsNullOrEmpty(txt_produtodesc.Text))
                    {
                        desc = txt_produtodesc.Text;
                    }

                    Venda_Item v = new Venda_Item() { Venda = new Venda() { Id = this.id }, Produto = new Produto() { Id = Convert.ToInt32(grid_produto.SelectedItems[0].SubItems[0].Text) }, Descricao = desc, Quantidade = Convert.ToInt32(txt_quantidadeproduto.Value) };
                    new dao_Venda_Item().addItem(v);
                    decimal vall = Convert.ToDecimal(txt_valor.Text);
                    decimal calc = vall + (Convert.ToDecimal(grid_produto.SelectedItems[0].SubItems[2].Text) * Convert.ToInt32(txt_quantidadeproduto.Value));
                    new dao_Venda().altervalor(calc,this.id);
                    txt_quantidadeproduto.Value = 1;
                    txt_produtodesc.Text = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    populatudo();
                }

            }
        }
    }
}
