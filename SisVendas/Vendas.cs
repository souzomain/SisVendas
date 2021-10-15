using SisVendas.DAO;
using SisVendas.Dialogs;
using SisVendas.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SisVendas
{
    public partial class Vendas : Form
    {
        private void ini(DateTime data, bool mesano = false)
        {
            List<Venda_Item> detalhe;
            List<Venda> concluidas;
            lbl_valorbruto.Text = "0,00";
            lbl_total_vendas.Text = "0";
            lbl_total_vendas_cartao.Text = "0";
            lbl_total_vendas_dinheiro.Text = "0";
            lbl_total_dinheiro.Text = "0,00";
            lbl_qtd_prods.Text = "0";
            lbl_total_d_dinheiro.Text = "0,00";
            lbl_total_d_cartao.Text = "0,00";
            lbl_valor_liquido.Text = "0,00";
            decimal valorbruto = 0;
            if (list_detalhe_venda.Items.Count > 0) list_detalhe_venda.Items.Clear();
            if (list_vendas_concluidas.Items.Count > 0) list_vendas_concluidas.Items.Clear();
            try
            {
                if (mesano)
                {
                    detalhe = new dao_Venda_Item().getVendaItem($"WHERE finalizado = 1 AND MONTH(data_finalizado) = {data.Month} AND YEAR(data_finalizado) = {data.Year}");
                }
                else
                {
                    detalhe = new dao_Venda_Item().getVendaItem($"WHERE finalizado = 1 AND MONTH(data_finalizado) = {data.Month} AND DAY(data_finalizado) = {data.Day} AND YEAR(data_finalizado) = {data.Year}");
                }
               
                if(detalhe.Count <= 0)
                {
                    if (!lbl_alert_detalhe.Visible)
                    {
                        lbl_alert_detalhe.Visible = true;
                    }

                }
                else
                {
                    if (lbl_alert_detalhe.Visible)
                    {
                        lbl_alert_detalhe.Visible = false;
                    }
                    int qtd = 0;

                    foreach (var i in detalhe)
                    {
                        qtd++;
                        valorbruto += i.Produto.Valor_bruto;
                    }
                    lbl_valorbruto.Text = valorbruto.ToString();
                    lbl_qtd_prods.Text = qtd.ToString();
                    string tipo = "valor";
                    foreach (Control ctl in group_order.Controls)
                    {
                        if (ctl.GetType().ToString() == "System.Windows.Forms.RadioButton")
                        {
                            if (((RadioButton)ctl).Checked == true)
                            {
                                tipo = ctl.Text;
                            }
                        }
                    }
                    List<VendaProduto> vp;
                    if (mesano)
                         vp = new dao_Venda_Item().GetVendaProduto($"WHERE venda.finalizado = 1 AND MONTH(venda.data_finalizado) = {data.Month} AND YEAR(venda.data_finalizado) = {data.Year}",tipo);
                    else
                         vp = new dao_Venda_Item().GetVendaProduto($"WHERE venda.finalizado = 1 AND MONTH(venda.data_finalizado) = {data.Month} AND DAY(venda.data_finalizado) = {data.Day} AND YEAR(venda.data_finalizado) = {data.Year}",tipo);
                    List<VendaProduto> vs = new dao_Venda_Item().GetVendaProduto($"WHERE venda.finalizado = 1"); ;
                    foreach (var c in vp)
                    {
                        list_detalhe_venda.Items.Add(new ListViewItem(new string[] {c.Produto_nome,c.Datavenda.ToString(),c.Quantidade.ToString(),c.Valor.ToString() }));
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                if (mesano)
                {
                    concluidas = new dao_Venda().getVendas($"WHERE finalizado = 1 AND MONTH(data_finalizado) = {data.Month} AND YEAR(data_finalizado) = {data.Year}");
                }
                else
                {
                    concluidas = new dao_Venda().getVendas($"WHERE finalizado = 1 AND MONTH(data_finalizado) = {data.Month} AND DAY(data_finalizado) = {data.Day} AND YEAR(data_finalizado) = {data.Year}");
                }
               
                if (concluidas.Count<=0){
                    if (!lbl_alert_venda.Visible)
                        lbl_alert_venda.Visible = true;
                }
                else
                {

                    if (lbl_alert_venda.Visible)
                        lbl_alert_venda.Visible = false;
                    int totalvendas = 0;
                    int totalvcartao = 0;
                    int totalvdinheiro = 0;
                    decimal totaldcartao = 0;
                    decimal total_d_dinheiro = 0;
                    decimal total = 0;
                    foreach (var i in concluidas)
                    {
                        total += i.Valor_total;
                        totalvendas++;
                        if (i.Metodo_pagamento.Equals("dinheiro"))
                        {
                            totalvdinheiro++;
                            total_d_dinheiro += i.Valor_total;
                        }
                        else
                        {
                            totalvcartao++;
                            totaldcartao += i.Valor_total;
                        }
                        list_vendas_concluidas.Items.Add(new ListViewItem(new string[] { i.Id.ToString(),i.Nome, i.Valor_total.ToString(), i.Data_inicio.ToString(), i.Data_finalizado.ToString() }));
                    }
                    lbl_valor_liquido.Text = (total - valorbruto).ToString(); 
                    updtxt(total.ToString(), totaldcartao.ToString(), total_d_dinheiro.ToString(), totalvendas.ToString(), totalvcartao.ToString(), totalvdinheiro.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Vendas()
        {
            InitializeComponent();
            ini(DateTime.Now);
            List<VendaProduto>vp = new dao_Venda_Item().GetVendaProduto($"WHERE venda.finalizado = 1");
            if (list_mais_vendidos.Items.Count > 0) list_mais_vendidos.Items.Clear();
            foreach(var i in vp)
            {
                list_mais_vendidos.Items.Add(new ListViewItem(new string[] { i.Produto_nome,i.Valor.ToString(),i.Quantidade.ToString()}));
            }
        }
        private void updtxt(string total,string totaldcartao,string totalddinheiro,string totalvendas,string totalvcartao,string totalvdinheiro)
        {
            lbl_total_dinheiro.Text = total;
            lbl_total_d_cartao.Text = totaldcartao;
            lbl_total_d_dinheiro.Text = totalddinheiro;
            lbl_total_vendas.Text = totalvendas;
            lbl_total_vendas_cartao.Text = totalvcartao;
            lbl_total_vendas_dinheiro.Text = totalvdinheiro;
        }
       

        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            ini(DateTime.Now);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime d = new DateTime(monthCalendar1.SelectionStart.Year, monthCalendar1.SelectionStart.Month, monthCalendar1.SelectionStart.Day);
            ini(d);
        }

        private void btn_escolher_Click(object sender, EventArgs e)
        {
            try
            {
                string[] data = mesanodata.Text.Split('/');
                DateTime t=new DateTime(Convert.ToInt32(data[1]),Convert.ToInt32(data[0]),1);
                ini(t,true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_vendaesc_Click(object sender, EventArgs e)
        {
            if (list_vendas_concluidas.SelectedItems.Count > 0)
            {
                try
                {

                    PDV_dialogdocontrole c = new PDV_dialogdocontrole(Convert.ToInt32(list_vendas_concluidas.SelectedItems[0].SubItems[0].Text));
                    c.Show();

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void qtd_CheckedChanged(object sender, EventArgs e)
        {
            ini(DateTime.Now,true);
        }

        private void val_CheckedChanged(object sender, EventArgs e)
        {
            ini(DateTime.Now,true);
        }
    }
}
