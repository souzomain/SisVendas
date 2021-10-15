using Microsoft.VisualBasic;
using SisVendas.DAO;
using SisVendas.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SisVendas.Dialogs
{
    public partial class FinalizarVendaDialog : Form
    {
        int ident;
        Venda venda;
        List<Venda_Item> vitem;
        bool maispages = false;
        int ii = 0;
        public FinalizarVendaDialog(int id)
        {
            this.ident = id;
            List<Venda> v = new dao_Venda().getVendas($"WHERE venda.id = {id}");
            venda = v[0];
            InitializeComponent();
            lbl_client.Text = venda.Nome;
            lbl_total.Text = venda.Valor_total.ToString();
            ProductsOfVenda();
        }
        private void ProductsOfVenda(string select = "")
        {
            try
            {
                List<Venda_Item> v = new dao_Venda_Item().getVendaItem($"WHERE venda.id = {this.ident}");
                vitem = v;
                foreach (var i in v)
                {
                    grid_items.Items.Add(new ListViewItem(new string[] { i.Produto.Id.ToString(), i.Produto.Nome, i.Produto.Preco.ToString(), i.Quantidade.ToString(),i.Descricao }));
                }
                lbl_total.Text = v[0].Venda.Valor_total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void finaliza()
        {
            try
            {
                if(MessageBox.Show("Continuar?","confirme",MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
                if (venda.Tipo.Id == 2)
                {
                    if(MessageBox.Show("Tem certeza que quer finalizar?","confirme!",MessageBoxButtons.YesNo) == DialogResult.Yes) { 
                        new dao_Venda().FinalizarVenda(this.ident, venda.Metodo_pagamento);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    if (!cntrls())
                    {
                        return;
                    }
                    string s = Interaction.InputBox("1 - DINHEIRO\n2 - CARTÃO\n3 - CANCELAR\n", "Escolha a forma de pagamento", "3");
                    if (s.Equals("1"))
                    {
                        if(MessageBox.Show("Imprimir via cliente?","imprimir",MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            client.Print();
                        }
                        new dao_Venda().FinalizarVenda(this.ident,"dinheiro");
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (s.Equals("2"))
                    {
                        if (MessageBox.Show("Imprimir via cliente?", "imprimir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            client.Print();
                        }
                        new dao_Venda().FinalizarVenda(this.ident,"cartao");

                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void FinalizarVendaDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F & e.Alt)
            {
                finaliza();
            }
        }
        private bool cntrls()
        {
            string s = Interaction.InputBox("Valor recebido", "Calcular troco");
            try
            {
                decimal recebido = Convert.ToDecimal(lbl_total.Text);
                lbl_recebido.Text = recebido.ToString();
                decimal ss = recebido - Convert.ToDecimal(s);
                lbl_troco.Text = ss.ToString();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void client_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            /*cliente*/
            int y = 230;
            e.HasMorePages = false;
            const string arial = "arial";
            Brush cor = new SolidBrush(Color.Black);
            Font pequeno = new Font(arial, 10);
            Font menor = new Font(arial, 7);
            Font medio = new Font(arial, 14);
            Font grande = new Font(arial, 20);
            StringFormat alingc = new StringFormat();
            alingc.Alignment = StringAlignment.Center;
            int altura = e.PageBounds.Height;
            int largura = e.PageBounds.Width;
            StringFormat ff = new StringFormat();
            ff.Alignment = StringAlignment.Far;
            StringFormat fe = new StringFormat();
            fe.Alignment = StringAlignment.Near;
            /*Textos principais...*/
            if (!maispages)
            {
                e.Graphics.DrawString("Pastel Da Branca", grande, cor, new Rectangle(0, 10, largura, 40), alingc);
                e.Graphics.DrawString("Av. Bernardo Manuel, 8099.\nFortaleza - CE - 60.714-225\n17.260.815/0001-02\n(85) 99720-4465", medio, cor, new Rectangle(0, 50, largura, 100), alingc);
                e.Graphics.DrawString("-----------------------------------------------------------------------", pequeno, cor, new Point(0, 140));
                e.Graphics.DrawString("Pedido", grande, cor, new Rectangle(0, 160, largura, 40), alingc);
                e.Graphics.DrawString("NOME       QTD       VALOR", medio, cor, new Rectangle(0, 200, largura, 40), alingc);
            }
            else
                y = 10;
            maispages = false;
            for (; ii < vitem.Count; ++ii)
            {
                e.Graphics.DrawString($"{vitem[ii].Produto.Nome}", pequeno, cor, new Rectangle(0, y, largura / 2, 60), fe);
                e.Graphics.DrawString($"{vitem[ii].Quantidade}", pequeno, cor, new Rectangle(largura / 2, y, 35, 50), alingc);
                e.Graphics.DrawString($"{vitem[ii].Produto.Preco}", pequeno, cor, new Rectangle(200, y, 60, 50), ff);
                if (y + 180 >= altura) { e.HasMorePages = true; maispages = true; break; }
                y += 60;
            }

            if (!maispages)
            {
                e.Graphics.DrawLine(new Pen(cor), new Point(0, y), new Point(largura, y));
                y += 20; 
                e.Graphics.DrawString($"CODIGO: {venda.Nome} | Data: {DateTime.Now}\n Total: {lbl_total.Text}", pequeno, cor, new Rectangle(0, y, largura, 50), ff);
                y += 80;
                e.Graphics.DrawString($"Aqui tudo é feito com amor. Lembre-se:  boca foi feita pra comer.\n\n@pasteldabranca", pequeno, cor, new Rectangle(0, y, largura, 100), alingc);
            }
        }
    }
}
