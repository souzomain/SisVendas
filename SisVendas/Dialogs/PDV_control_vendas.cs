using SisVendas.DAO;
using SisVendas.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SisVendas.Dialogs
{
    public partial class PDV_control_vendas : Form
    {
        private bool inedit;
        public PDV_control_vendas()
        {
            InitializeComponent();
            try { 
                GridAt();
            }catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void Finalizar()
        {
            if(grid_vendas.SelectedItems.Count > 0) {
                using (FinalizarVendaDialog d = new FinalizarVendaDialog(Convert.ToInt32(grid_vendas.SelectedItems[0].SubItems[0].Text)))
                {
                    if(d.ShowDialog() == DialogResult.OK)
                    {
                        GridAt();
                    }
                }
            }
        }
        private void GridAt(string select="")
        {
            if(grid_vendas.Items.Count != 0)
            {
                grid_vendas.Items.Clear();
            }
            string tipo = null;
            foreach (Control ctl in group_tipo_venda.Controls)
            {
                if (ctl.GetType().ToString() == "System.Windows.Forms.RadioButton")
                {
                    if (((RadioButton)ctl).Checked == true)
                    {
                        tipo = ctl.Text;
                        break;
                    }
                }
            }
            int t = 1;
            switch (tipo)
            {
                case "local":
                    t = 1;
                    break;
                case "delivery":
                    t= 2;
                    break;
                case "fiado":
                    t = 3;
                    break;
            }

            List<Venda> v = new dao_Venda().getVendas($"WHERE venda.finalizado = 0 AND id_tipo = {t} {select}");

            foreach(var i in v)
            {
                grid_vendas.Items.Add(new ListViewItem(new string[] { i.Id.ToString(), i.Nome, i.Valor_total.ToString() }));
            }
        }
        private void ExcluiVenda()
        {   if(MessageBox.Show("Tem certeza que quer excluir?","Confirme",MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            if (grid_vendas.SelectedItems.Count <= 0) MessageBox.Show("Escolha um item para excluir");
            foreach (ListViewItem item in grid_vendas.SelectedItems)
            {
                List<Venda_Item> p = new dao_Venda_Item().getVendaItem($"WHERE venda_id={Convert.ToInt32(item.SubItems[0].Text)}");
                foreach(var v in p)
                {
                    new dao_Venda_Item().Delete(v.Id);
                }
                new dao_Venda().Delete(Convert.ToInt32(item.SubItems[0].Text));
            }
            GridAt();
        }
        private bool Edit()
        {
            if (!inedit)
            {
                if (grid_vendas.SelectedItems.Count <= 0) { MessageBox.Show("Escolha um item");return false; }
                lbl_id.Text = grid_vendas.SelectedItems[0].SubItems[0].Text;
                txt_valortotal.Enabled = true;
                txt_valortotal.Text= grid_vendas.SelectedItems[0].SubItems[2].Text;
                inedit = true;
                return true;
            }
            else { 
                int id = Convert.ToInt32(lbl_id.Text);
                if(id <= 0)
                {
                    MessageBox.Show("Id inválido...");
                }
                else
                {
                    Venda v = new Venda();
                    v.Id = id;
                    v.Valor_total = Convert.ToDecimal(txt_valortotal.Text);
                    if (v.Valor_total == 0) { MessageBox.Show("Indique o valor total de forma correta"); return false; }
                    new dao_Venda().altervalor(v.Valor_total,v.Id);
                    GridAt();
                    inedit = false;
                    txt_valortotal.Enabled = false;
                    txt_valortotal.Text = "";
                    return true;
                }
            }
            return false;
        }
        private void EditProds()
        {
            if(grid_vendas.SelectedItems.Count > 0)
            {
                int id = Convert.ToInt32(grid_vendas.SelectedItems[0].SubItems[0].Text);
                if (id == 0)
                {
                    MessageBox.Show("erro ao pegar id");
                    return;
                }
                else
                {
                    PDV_dialogdocontrole v = new PDV_dialogdocontrole(id);
                    v.Show();
                }
            }
        }

        private void btn_alterarvenda_Click(object sender, EventArgs e)
        {
            try
            {
                Edit();
            }catch(Exception ex)
            {
                MessageBox.Show("Não foi possivel editar por: " + ex.Message);    
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                GridAt();

            }catch(Exception ex)
            {
                MessageBox.Show("Erro inesperado " + ex.Message);
            }
        }

        private void btn_excluirvenda_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("dejesa continuar?","confirme",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    ExcluiVenda();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir " + ex.Message);
            }

        }

        private void btn_finalizarvenda_Click(object sender, EventArgs e)
        {
            try
            {
                Finalizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_alterarprodutosvenda_Click(object sender, EventArgs e)
        {
            EditProds();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            GridAt($"AND venda.nome LIKE '%{txt_name.Text.Trim().Replace("'","")}%'");
        }

        private void rd_local_CheckedChanged(object sender, EventArgs e)
        {
            GridAt();
        }

        private void rd_delivery_CheckedChanged(object sender, EventArgs e)
        {
            GridAt();
        }

        private void rd_fiado_CheckedChanged(object sender, EventArgs e)
        {
            GridAt();
        }
    }
}
