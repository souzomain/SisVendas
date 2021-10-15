using SisVendas.DAO;
using SisVendas.Dialogs;
using SisVendas.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SisVendas
{
    public partial class Produto_pesquisa : Form
    {
        bool edit = false;
        public Produto_pesquisa()
        {
            InitializeComponent();
            listagrid();
        }
        private void limpa()
        {
            txt_descricao.Text = "";
            txt_id.Text = "0";
            txt_nome.Text = "";
            txt_valor.Text = "";
            txt_valorbruto.Text = "";
        }
        private void listagrid(string select = "WHERE produto.inativo = 0")
        {
            List<Produto> p = new dao_Produto().ListProduts(select);
            grid_item.Items.Clear();
            foreach (var i in p)
            {
                grid_item.Items.Add(new ListViewItem(new string[] { i.Id.ToString(), i.Nome, i.Preco.ToString(),i.Valor_bruto.ToString(), i.Descricao.ToString() }));
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Produto p = new Produto() { Id = Convert.ToInt32(txt_id.Text), Nome = txt_nome.Text, Descricao = txt_descricao.Text, Preco = Convert.ToDecimal(txt_valor.Text), Valor_bruto = Convert.ToDecimal(txt_valorbruto.Text) };
            if (edit)
            {
                try
                {
                    
                    new dao_Produto().Alter(p);
                    edit = false;
                    limpa();
                    MessageBox.Show("Editado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("não foi possivel editar por: ", ex.Message);
                }
                finally
                {
                    listagrid();
                }
            }
            else
            {
                try
                {
                    new dao_Produto().Insert(p);
                    limpa();
                    MessageBox.Show("Adicionado com sucesso!");
                }catch(Exception ex)
                {
                    MessageBox.Show("não foi possivel adicionar por: " + ex.Message);
                }
                finally
                {
                    listagrid();
                }
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("tem certeza que quer excluir esse(s) items?","confirme",MessageBoxButtons.YesNo) == DialogResult.Yes) {
                try { 
                    foreach (ListViewItem v in grid_item.SelectedItems)
                    {
                        new dao_Produto().Delete(Convert.ToInt32(v.SubItems[0].Text));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    listagrid();
                }
            }
        }
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (this.edit)
            {
                limpa();
                this.edit = false;
            }
            else { 
                if (grid_item.SelectedItems.Count > 0)
                {
                    if (this.edit)
                    {
                        limpa();
                        this.edit = false;
                    }
                    else { 
                        txt_id.Text= grid_item.SelectedItems[0].SubItems[0].Text;
                        txt_nome.Text = grid_item.SelectedItems[0].SubItems[1].Text;
                        txt_valor.Text = grid_item.SelectedItems[0].SubItems[2].Text;
                        txt_valorbruto.Text = grid_item.SelectedItems[0].SubItems[3].Text;
                        txt_descricao.Text = grid_item.SelectedItems[0].SubItems[4].Text;
                        this.edit = true;
                    }
                }
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            using (PDVprodutoPesquisa p = new PDVprodutoPesquisa())
            {
                if(p.ShowDialog() == DialogResult.OK)
                {
                    listagrid($"WHERE id = {p.pid}");
                }
            }
            
        }

        private void btn_listaexcluidos_Click(object sender, EventArgs e)
        {
            ProdutosInativos p = new ProdutosInativos();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listagrid();
        }
    }
}
//Produto p = new Produto() { Id = Convert.ToInt32(grid_item.SelectedItems[0].SubItems[0].Text), Nome = grid_item.SelectedItems[0].SubItems[1].Text, Preco = Convert.ToDecimal(grid_item.SelectedItems[0].SubItems[2].Text), Descricao = grid_item.SelectedItems[0].SubItems[3].Text };