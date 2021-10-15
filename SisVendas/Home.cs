using SisVendas.DAO;
using SisVendas.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SisVendas
{
    public partial class Home : Form
    {
        List<Venda> fiado;
        List<Venda> delivery;
        List<Venda> local;
        public Home()
        {
            InitializeComponent();
            atualiza();
        }
        public void atualiza()
        {

            fiado = new dao_Venda().getVendas("JOIN tipo on venda.id_tipo=tipo.id WHERE tipo.id = 3 AND venda.finalizado = 0");
            delivery = new dao_Venda().getVendas("JOIN tipo on venda.id_tipo=tipo.id WHERE tipo.id = 2 AND venda.finalizado = 0");
            local = new dao_Venda().getVendas("JOIN tipo on venda.id_tipo=tipo.id WHERE tipo.id = 1 AND venda.finalizado = 0");
            
            list_delivery.Items.Clear();
            list_fiado.Items.Clear();
            list_local.Items.Clear();
            decimal fiadovalues = 0;
            if(fiado.Count == 0)
            {
                lbl_fiado.Visible = true;
            }
            else
            {
                if (lbl_fiado.Visible) lbl_fiado.Visible = false;
                foreach (var i in fiado)
                {
                    list_fiado.Items.Add(new ListViewItem(new string[] { i.Id.ToString(), i.Nome, i.Valor_total.ToString(), i.Data_inicio.ToString() }));
                    fiadovalues += i.Valor_total;
                }
            }
            lbl_v_fiado.Text = fiadovalues.ToString();
            decimal deliveryvalues = 0;
            if (delivery.Count == 0)
            {
                lbl_delivery.Visible = true;
            }
            else
            {
                if (lbl_delivery.Visible) lbl_delivery.Visible = false;
                foreach (var i in delivery)
                {
                    list_delivery.Items.Add(new ListViewItem(new string[] { i.Id.ToString(), i.Nome, i.Valor_total.ToString(), i.Data_inicio.ToString() }));
                    deliveryvalues += i.Valor_total;
                }
            }
            lbl_v_delivery.Text= deliveryvalues.ToString();
            
            decimal localvalues = 0;
            if(local.Count == 0)
            {
                lbl_local.Visible = true;
            }
            else {
                if (lbl_local.Visible) lbl_local.Visible = false;
                foreach (var i in local)
                {
                    list_local.Items.Add(new ListViewItem(new string[] { i.Id.ToString(), i.Nome, i.Valor_total.ToString(), i.Data_inicio.ToString() }));
                    localvalues += i.Valor_total;
                }
            }
            lbl_v_local.Text = localvalues.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            atualiza();
        }
    }
}
