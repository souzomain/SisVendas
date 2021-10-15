using Microsoft.VisualBasic;
using SisVendas.DAO;
using SisVendas.Dialogs;
using SisVendas.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SisVendas
{
    public partial class PDV : Form
    {
        private bool incompra = false;
        private decimal valor_q_vai_pagar = decimal.Zero;
        private string metodo_pag = "dinheiro";
        int ident = 0;
        bool maispages = false;
        int ii = 0;
        List<Venda_Item> vitem = null;
        dao_Produto produtos;
        List<Produto> p;
        private DTO.Cliente cli;
        public PDV()
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            Initialize();
            produtos = new dao_Produto();
            p = produtos.ListProduts("");
            foreach (var s in p)
            {
                list_prods.Items.Add($"{s.Nome} | {s.Preco} | {s.Id}");
            }
        }

        private bool NovaCompra()
        {
            if (incompra) {
                MessageBox.Show("Não é possivel fazer uma nova compra quando ja se está em uma");
                return false;
            }
            else {
                Random rand = new Random();
                int num = rand.Next(55,1000);

                while (new dao_Venda().NumResult($"SELECT * FROM venda WHERE venda.nome='{num.ToString()}' AND venda.finalizado=0") != 0)
                {
                    num = rand.Next(55, 1000);
                }
                
                DialogResult r = MessageBox.Show("Tem certeza q deseja continuar?", "Confirme", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    lbl_client.Text = num.ToString();
                    incompra = true;
                    return true;
                }
                else
                    return false;
            }
        }
        //inicia os componentes
        private void Initialize()
        {
            if (container_sep.Visible == true)
                container_sep.Visible = false;
            string real = "0,00";
            lbl_precounit.Text = real;
            this.lbl_quantidade.Text = "1";
            this.lbl_subtotal.Text = real;
            this.lbl_total.Text = real;
            this.incompra = false;
            txt_item_descricao.Text = null;
            grid_items.Items.Clear();
            valor_q_vai_pagar = decimal.Zero;
            lbl_troco.Text = "0,00";
            ident = 0;
            ii = 0;
            maispages = false;
            vitem = null;
        }
        private void FlushF()
        {
            lbl_troco.Text = "0,00";
            valor_q_vai_pagar = decimal.Zero;
            string real = "0,00";
            lbl_precounit.Text = real;
            this.lbl_quantidade.Text = "1";
            this.lbl_subtotal.Text = real;
            this.lbl_total.Text = real;
            grid_items.Items.Clear();
        }
        //  finalizar a compra é diferente de finalizar a venda ...
        /*
          finalizar a compra vai adicionar nas contas pendentes
          finalizar a venda vai finalizar totalmente
         */
        private void Finalizar()
        {
            finalizarcompra();
        }
        private void finalizarcompra()
        {
            if (grid_items.Items.Count == 0) {
                MessageBox.Show("Adicione items no carrinho antes de finalizar a compra");
                return;
            }
            if (MessageBox.Show("Tem certeza que quer continuar?", "Confirme", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string tipo = null;
                foreach (Control ctl in group_tipo_venda.Controls)
                {
                    if (ctl.GetType().ToString() == "System.Windows.Forms.RadioButton") {
                        if (((RadioButton)ctl).Checked == true)
                        {
                            tipo = ctl.Text;
                        }
                    }
                }
                dao_Venda_Item v = new dao_Venda_Item();
                List<Tipo> tt = new dao_Tipo().getTipos($"WHERE nome='{tipo.Replace("'", "")}'");
                if (tipo == "delivery")
                {
                    if (!calculatroco())
                        return;
                    if (!altc())
                        return;
                    string s = Interaction.InputBox("1 - CARTÃO\n2 - DINHEIRO\n", "Metodo de pagamento", "1");
                    if (s.Equals("1"))
                    {
                        metodo_pag = "cartao";
                    }
                    else if (s.Equals("2"))
                    {
                        metodo_pag = "dinheiro";
                    }
                    else
                    {
                        MessageBox.Show("Adicione uma opção válida");
                        return;
                    }
                }
                this.ident = new dao_Venda().addVenda(lbl_client.Text, Convert.ToDecimal(lbl_total.Text), this.cli, tt[0].Id, metodo_pag);

                Venda venda = new Venda() { Id = ident };
                foreach (ListViewItem i in grid_items.Items)
                {
                    var n = new Venda_Item() { Produto = new Produto() { Id = Convert.ToInt32(i.SubItems[0].Text), Nome = i.SubItems[1].Text, Preco = Convert.ToDecimal(i.SubItems[2].Text) }, Venda = venda, Quantidade = Convert.ToInt32(i.SubItems[3].Text), Descricao = i.SubItems[4].Text };
                    v.addItem(n);
                }
                if (tipo == "delivery")
                {
                    if (MessageBox.Show("Deseja imprimir para o entregador?", "imprimir?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            vitem = new dao_Venda_Item().getVendaItem($"WHERE venda.id = {ident}");
                            entregador.Print();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
                else
                {
                    if (MessageBox.Show("Deseja imprimir para o cliente?", "imprimir?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            vitem = new dao_Venda_Item().getVendaItem($"WHERE venda.id = {ident}");
                            other.Print();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                Initialize();
            }
        }
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PDV_KeyDown(object sender, KeyEventArgs e)
        {


            if (!incompra) {
                if (e.KeyCode == Keys.F5 && !incompra)
                {
                    if (NovaCompra())
                        if (container_sep.Visible == false)
                            container_sep.Visible = true;
                }
                else if (e.KeyCode == Keys.F6)
                {
                    PDV_control_vendas v = new PDV_control_vendas();
                    v.Show();
                }
            }
            else
            {
                if (e.KeyCode == Keys.P & e.Control)
                {
                    using (PDVprodutoPesquisa p = new PDVprodutoPesquisa())
                    {
                        if (p.ShowDialog() == DialogResult.OK)
                        {
                            try {
                                addCarrinho(p.pid, p.qtd, p.desc);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
                else if (e.KeyCode == Keys.F & e.Control)
                {
                    DialogResult d = MessageBox.Show("Tem certeza q deseja refazer tudo?", "Confirme", MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                        FlushF();
                }
                else if (e.KeyCode == Keys.Q & e.Control)
                {
                    //adiciona quantidade
                    string inp = null;
                    int n = 0;
                    while (true)
                    {
                        inp = Microsoft.VisualBasic.Interaction.InputBox("Coloque uma quantidade", "Quantidade", "0");
                        if (Int32.TryParse(inp, out n)) {
                            if (n > 0)
                                break;
                        }
                        MessageBox.Show("Por favor, coloque um valor inteiro valido");
                    }

                    changeQuantidade(n, Convert.ToDecimal(lbl_precounit.Text));
                }
                else if (e.KeyCode == Keys.A & e.Control)
                {
                    try {
                        if (p.Count < list_prods.SelectedIndex || list_prods.SelectedIndex > -1)
                        {
                            addCarrinho(this.p[list_prods.SelectedIndex].Id, Convert.ToInt32(lbl_quantidade.Text), txt_item_descricao.Text);
                        }
                        else
                            MessageBox.Show("houve um erro... escolha um produto usando o mouse");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                } else if (e.KeyCode == Keys.F & e.Alt)
                {
                    Finalizar();
                } else if (e.KeyCode == Keys.F4)
                {
                    if (MessageBox.Show("Deseja excluir essa venda?", "confirme", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            Initialize();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                } else if (e.KeyCode == Keys.Delete)
                {
                    removeCarrinho();
                } else if (e.KeyCode == Keys.F6)
                {
                    PDV_control_vendas v = new PDV_control_vendas();
                    v.Show();
                } else if (e.KeyCode == Keys.C & e.Control)
                {
                    Cliente cc = new Cliente();
                    cc.Show();
                } else if (e.KeyCode == Keys.S & e.Control)
                {
                    calculatroco();
                }else if (e.KeyCode == Keys.C & e.Alt)
                {
                    altc();
                }
            }
        }
        private bool altc()
        {
            using (Dialogs.ClientDialogGet d = new ClientDialogGet())
            {
                if (d.ShowDialog() == DialogResult.OK)
                {
                    this.cli = d.c;
                    return true;
                }
                return false;
            }
        }
        private bool calculatroco()
        {
            string s = Interaction.InputBox("Valor recebido", "Calcular troco");
            try
            {
                decimal cc = Convert.ToDecimal(s);
                decimal ss = Convert.ToDecimal(lbl_total.Text) - cc;
                valor_q_vai_pagar = cc;
                lbl_troco.Text = ss.ToString();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public void changeQuantidade(int quantidade, decimal preco)
        {
            if (list_prods.SelectedIndex < 0)
                MessageBox.Show("escolha um item antes de adicionar uma quantidade");
            else if (quantidade <= 0 || quantidade >= 999)
                MessageBox.Show("não é possivel alterar a quantidade para esse valor");
            else {
                decimal val = preco * quantidade;
                lbl_quantidade.Text = quantidade.ToString();
                lbl_subtotal.Text = val.ToString();
            }
        }
        private void list_prods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_prods.SelectedIndex > -1)
            {
                try
                {
                    selectItem(p[list_prods.SelectedIndex].Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void selectItem(int id)
        {
            List<Produto> p = new dao_Produto().ListProduts($"WHERE id = {id}");
            lbl_precounit.Text = p[0].Preco.ToString();
            lbl_subtotal.Text = p[0].Preco.ToString();

        }
        //CARRINHO DE COMPRAS
        private void limpa()
        {
            string c = "0,00";
            lbl_precounit.Text = c;
            lbl_quantidade.Text = "1";
            lbl_subtotal.Text = c;
            list_prods.SelectedIndex = -1;
            txt_item_descricao.Text = null;
            this.metodo_pag = "dinheiro";
        }
        public void addCarrinho(int id, int quantidade, string desc = "")
        {
            try {

                if (!string.IsNullOrEmpty(desc))
                {
                    desc.Trim().Replace("'", "");
                } else
                    desc = "sem descrição";

                List<Produto> pqp = new dao_Produto().ListProduts($"WHERE id = {id}");
                Produto p = pqp[0];
                grid_items.Items.Add(new ListViewItem(new string[] { p.Id.ToString(), p.Nome, p.Preco.ToString(), quantidade.ToString(), desc }));
                decimal s = p.Preco * quantidade;
                lbl_total.Text = (Convert.ToDecimal(lbl_total.Text) + s).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                limpa();
            }
        }
        private void removeCarrinho()
        {
            foreach (ListViewItem i in grid_items.SelectedItems)
            {
                decimal _v_total = Convert.ToDecimal(lbl_total.Text) - (Convert.ToDecimal(i.SubItems[2].Text) * Convert.ToInt32(i.SubItems[3].Text));
                grid_items.Items.RemoveAt(i.Index);
                lbl_total.Text = _v_total.ToString();
            }
        }

        private void timer_data_Tick(object sender, EventArgs e)
        {
            lbl_horas.Text = DateTime.Now.ToString();
        }


        private void other_PrintPage(object sender, PrintPageEventArgs e)
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

                e.Graphics.DrawString($"CODIGO: {lbl_client.Text} | Data: {DateTime.Now}\n Total: {lbl_total.Text}", pequeno, cor, new Rectangle(0, y, largura, 50), ff);
                y += 80;
                e.Graphics.DrawString($"Aqui tudo é feito com amor. Lembre-se:  boca foi feita pra comer.\n\n@pasteldabranca", pequeno, cor, new Rectangle(0, y, largura, 100), alingc);
            }
        }

        private void entregador_PrintPage(object sender, PrintPageEventArgs e)
        {
            /*entregador*/
            int y = 350;
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
                e.Graphics.DrawString("-----------------------------------------------------------------------", pequeno, cor, new Point(0, 150));
                e.Graphics.DrawString("Cliente", grande, cor, new Rectangle(0, 160, largura, 30), alingc);
                e.Graphics.DrawString($"NOME: {cli.Nome_cliente}\nENDEREÇO: {cli.Endereco}\nTELEFONE: {cli.Telefone}\nPAGAMENTO: {metodo_pag}", pequeno, cor, new Rectangle(0, 200, largura, 60), fe);
                e.Graphics.DrawString("-----------------------------------------------------------------------", pequeno, cor, new Point(0, 270));
                e.Graphics.DrawString("Pedido", grande, cor, new Rectangle(0, 280, largura, 40), alingc);
                e.Graphics.DrawString("NOME         QTD         VALOR", medio, cor, new Rectangle(0, 310, largura, 40), alingc);
            }
            else
                y = 10;
            maispages = false;
            for (; ii < vitem.Count; ++ii)
            {
                e.Graphics.DrawString(vitem[ii].Produto.Nome, pequeno, cor, new Rectangle(0, y, largura / 2, 60), fe);
                e.Graphics.DrawString(vitem[ii].Quantidade.ToString(), pequeno, cor, new Rectangle(largura / 2, y, 35, 50), alingc);
                e.Graphics.DrawString(vitem[ii].Venda.Valor_total.ToString(), pequeno, cor, new Rectangle(200, y, 60, 50), ff);
                if (y + 180 >= altura) { e.HasMorePages = true; maispages = true; break; }
                y += 60;
            }

            if (!maispages)
            {
                e.Graphics.DrawLine(new Pen(cor), new Point(0, y), new Point(largura, y));
                y += 20;

                e.Graphics.DrawString($"CODIGO: {lbl_client.Text} | Data: {DateTime.Now}\nTotal: {lbl_total.Text} Troco: {lbl_troco.Text}", pequeno, cor, new Rectangle(0, y, largura, 50), ff);
                y += 80;
                e.Graphics.DrawString($"Aqui tudo é feito com amor. Lembre-se:  boca foi feita pra comer.\n\n@pasteldabranca", pequeno, cor, new Rectangle(0, y, largura, 100), alingc);
            }
        }
    }
}
