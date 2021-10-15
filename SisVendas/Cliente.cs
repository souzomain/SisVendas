using SisVendas.DAO;
using SisVendas.Dialogs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SisVendas
{
    public partial class Cliente : Form
    {
        bool edit = false;
        public Cliente()
        {
            InitializeComponent();
            populagrid();
        }
        public void populagrid(string select = null)
        {
            try
            {
                if(grid_client.Items.Count > 0)
                {
                    grid_client.Items.Clear();
                }
                List <DTO.Cliente> clis = new dao_Cliente().getClientes($"WHERE cliente.inativo = 0 {select}");
                foreach(var c in clis)
                {
                    grid_client.Items.Add(new ListViewItem(new string[] { c.Id.ToString(),c.Nome_cliente,c.Endereco,c.Telefone,c.Observacoes })) ;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            populagrid($"AND cliente.nome_cliente LIKE '%{textBox1.Text.Trim().Replace("'","")}%'");
        }

        
        private void limpa()
        {
            lbl_id.Text = "0";
            txt_endereco.Text = "";
            txt_nome.Text = "";
            txt_obs.Text = "";
            txt_telefone.Text = "";
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.Cliente c = new DTO.Cliente() { Id = Convert.ToInt32(lbl_id.Text), Endereco = txt_endereco.Text, Casa_number = 0, Nome_cliente = txt_nome.Text.Trim(), Observacoes = txt_obs.Text, Telefone = txt_telefone.Text.Trim().Replace("(",string.Empty).Replace(")",string.Empty).Replace("-",string.Empty).Replace(" ",string.Empty) };
                if (edit)
                {
                    new dao_Cliente().alterCliente(c);
                    limpa();
                    MessageBox.Show("Editado!");
                    edit = false;
                }
                else
                {
                    new dao_Cliente().Insert(c);
                    limpa();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                populagrid();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (edit)
                {
                    edit = false;
                    limpa();
                }
                else
                {
                    if(grid_client.SelectedItems.Count > 0)
                    {
                        List<DTO.Cliente> c = new dao_Cliente().getClientes($"WHERE id = {Convert.ToInt32(grid_client.SelectedItems[0].SubItems[0].Text)}");
                        DTO.Cliente cc = c[0];
                        lbl_id.Text = cc.Id.ToString();
                        txt_endereco.Text = cc.Endereco;
                        txt_nome.Text = cc.Nome_cliente;
                        txt_obs.Text = cc.Observacoes;
                        txt_telefone.Text = cc.Telefone;
                        edit = true;
                    }
                    else
                    {
                        MessageBox.Show("escolha um cliente para editar...");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("tem certeza que quer excluir?","Excluir?",MessageBoxButtons.YesNo) == DialogResult.Yes) { 
                    foreach (ListViewItem item in grid_client.SelectedItems)
                    {
                        new dao_Cliente().delete(Convert.ToInt32(item.SubItems[0].Text));
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                populagrid();
            }   
        }

        private void tel_text_TextChanged(object sender, EventArgs e)
        {
            populagrid($"AND telefone LIKE '%{tel_text.Text.Replace("'",string.Empty).Trim()}%'");
        }

        private void btn_listaexcluidos_Click(object sender, EventArgs e)
        {
            ClienteInativo c = new ClienteInativo();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populagrid();
        }

        private void endereco_text_TextChanged(object sender, EventArgs e)
        {
            populagrid($"AND endereco LIKE '%{endereco_text.Text.Replace("'",string.Empty)}%'");
        }
    }
}
