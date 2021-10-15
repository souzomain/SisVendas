namespace SisVendas
{
    partial class Vendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.list_vendas_concluidas = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.list_detalhe_venda = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_alert_venda = new System.Windows.Forms.Label();
            this.lbl_alert_detalhe = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_total_vendas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_total_d_cartao = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_total_d_dinheiro = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_total_dinheiro = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_total_vendas_cartao = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbl_total_vendas_dinheiro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_qtd_prods = new System.Windows.Forms.Label();
            this.btn_reiniciar = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.list_mais_vendidos = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mesanodata = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_escolher = new System.Windows.Forms.Button();
            this.btn_vendaesc = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lbl_valor_liquido = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_valorbruto = new System.Windows.Forms.Label();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtd = new System.Windows.Forms.RadioButton();
            this.val = new System.Windows.Forms.RadioButton();
            this.group_order = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.group_order.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "VENDAS JÁ CONCLUÍDAS";
            // 
            // list_vendas_concluidas
            // 
            this.list_vendas_concluidas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.list_vendas_concluidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_vendas_concluidas.FullRowSelect = true;
            this.list_vendas_concluidas.HideSelection = false;
            this.list_vendas_concluidas.Location = new System.Drawing.Point(140, 53);
            this.list_vendas_concluidas.Name = "list_vendas_concluidas";
            this.list_vendas_concluidas.Size = new System.Drawing.Size(754, 257);
            this.list_vendas_concluidas.TabIndex = 4;
            this.list_vendas_concluidas.UseCompatibleStateImageBehavior = false;
            this.list_vendas_concluidas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "CODIGO";
            this.columnHeader6.Width = 176;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "VALOR";
            this.columnHeader7.Width = 133;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "DATA DE INÍCIO";
            this.columnHeader8.Width = 186;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "DATA DE FIM";
            this.columnHeader9.Width = 194;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(945, 152);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(976, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Modifique a Data";
            // 
            // list_detalhe_venda
            // 
            this.list_detalhe_venda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader11,
            this.columnHeader12});
            this.list_detalhe_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_detalhe_venda.HideSelection = false;
            this.list_detalhe_venda.Location = new System.Drawing.Point(138, 371);
            this.list_detalhe_venda.Name = "list_detalhe_venda";
            this.list_detalhe_venda.Size = new System.Drawing.Size(754, 257);
            this.list_detalhe_venda.TabIndex = 10;
            this.list_detalhe_venda.UseCompatibleStateImageBehavior = false;
            this.list_detalhe_venda.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome do Produto";
            this.columnHeader1.Width = 182;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dia da venda";
            this.columnHeader2.Width = 230;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(138, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Top Produtos";
            // 
            // lbl_alert_venda
            // 
            this.lbl_alert_venda.AutoSize = true;
            this.lbl_alert_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alert_venda.Location = new System.Drawing.Point(314, 166);
            this.lbl_alert_venda.Name = "lbl_alert_venda";
            this.lbl_alert_venda.Size = new System.Drawing.Size(365, 24);
            this.lbl_alert_venda.TabIndex = 15;
            this.lbl_alert_venda.Text = "VOCE NÃO TEM VENDAS CONCLUÍDAS";
            this.lbl_alert_venda.Visible = false;
            // 
            // lbl_alert_detalhe
            // 
            this.lbl_alert_detalhe.AutoSize = true;
            this.lbl_alert_detalhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alert_detalhe.Location = new System.Drawing.Point(314, 512);
            this.lbl_alert_detalhe.Name = "lbl_alert_detalhe";
            this.lbl_alert_detalhe.Size = new System.Drawing.Size(365, 24);
            this.lbl_alert_detalhe.TabIndex = 16;
            this.lbl_alert_detalhe.Text = "VOCE NÃO TEM VENDAS CONCLUIDAS";
            this.lbl_alert_detalhe.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_total_vendas);
            this.groupBox2.Location = new System.Drawing.Point(8, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 101);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Número total de vendas";
            // 
            // lbl_total_vendas
            // 
            this.lbl_total_vendas.AutoSize = true;
            this.lbl_total_vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_vendas.ForeColor = System.Drawing.Color.Black;
            this.lbl_total_vendas.Location = new System.Drawing.Point(28, 39);
            this.lbl_total_vendas.Name = "lbl_total_vendas";
            this.lbl_total_vendas.Size = new System.Drawing.Size(29, 31);
            this.lbl_total_vendas.TabIndex = 7;
            this.lbl_total_vendas.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_total_d_cartao);
            this.groupBox1.Location = new System.Drawing.Point(8, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 101);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valor de vendas no cartão";
            // 
            // lbl_total_d_cartao
            // 
            this.lbl_total_d_cartao.AutoSize = true;
            this.lbl_total_d_cartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_d_cartao.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_total_d_cartao.Location = new System.Drawing.Point(4, 36);
            this.lbl_total_d_cartao.Name = "lbl_total_d_cartao";
            this.lbl_total_d_cartao.Size = new System.Drawing.Size(67, 31);
            this.lbl_total_d_cartao.TabIndex = 7;
            this.lbl_total_d_cartao.Text = "0,00";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_total_d_dinheiro);
            this.groupBox3.Location = new System.Drawing.Point(8, 558);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 101);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Valor de vendas em dinheiro";
            // 
            // lbl_total_d_dinheiro
            // 
            this.lbl_total_d_dinheiro.AutoSize = true;
            this.lbl_total_d_dinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_d_dinheiro.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_total_d_dinheiro.Location = new System.Drawing.Point(4, 33);
            this.lbl_total_d_dinheiro.Name = "lbl_total_d_dinheiro";
            this.lbl_total_d_dinheiro.Size = new System.Drawing.Size(67, 31);
            this.lbl_total_d_dinheiro.TabIndex = 7;
            this.lbl_total_d_dinheiro.Text = "0,00";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_total_dinheiro);
            this.groupBox4.Location = new System.Drawing.Point(8, 344);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(124, 101);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Valor total das vendas";
            // 
            // lbl_total_dinheiro
            // 
            this.lbl_total_dinheiro.AutoSize = true;
            this.lbl_total_dinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_dinheiro.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_total_dinheiro.Location = new System.Drawing.Point(4, 38);
            this.lbl_total_dinheiro.Name = "lbl_total_dinheiro";
            this.lbl_total_dinheiro.Size = new System.Drawing.Size(67, 31);
            this.lbl_total_dinheiro.TabIndex = 7;
            this.lbl_total_dinheiro.Text = "0,00";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbl_total_vendas_cartao);
            this.groupBox5.Location = new System.Drawing.Point(8, 130);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(124, 101);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Numero total de vendas no cartão";
            // 
            // lbl_total_vendas_cartao
            // 
            this.lbl_total_vendas_cartao.AutoSize = true;
            this.lbl_total_vendas_cartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_vendas_cartao.ForeColor = System.Drawing.Color.Black;
            this.lbl_total_vendas_cartao.Location = new System.Drawing.Point(28, 46);
            this.lbl_total_vendas_cartao.Name = "lbl_total_vendas_cartao";
            this.lbl_total_vendas_cartao.Size = new System.Drawing.Size(29, 31);
            this.lbl_total_vendas_cartao.TabIndex = 7;
            this.lbl_total_vendas_cartao.Text = "0";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbl_total_vendas_dinheiro);
            this.groupBox6.Location = new System.Drawing.Point(8, 237);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(124, 101);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Numero total de vendas no dinheiro";
            // 
            // lbl_total_vendas_dinheiro
            // 
            this.lbl_total_vendas_dinheiro.AutoSize = true;
            this.lbl_total_vendas_dinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_vendas_dinheiro.ForeColor = System.Drawing.Color.Black;
            this.lbl_total_vendas_dinheiro.Location = new System.Drawing.Point(28, 42);
            this.lbl_total_vendas_dinheiro.Name = "lbl_total_vendas_dinheiro";
            this.lbl_total_vendas_dinheiro.Size = new System.Drawing.Size(29, 31);
            this.lbl_total_vendas_dinheiro.TabIndex = 7;
            this.lbl_total_vendas_dinheiro.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 653);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Quantidade de produtos:";
            // 
            // lbl_qtd_prods
            // 
            this.lbl_qtd_prods.AutoSize = true;
            this.lbl_qtd_prods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtd_prods.Location = new System.Drawing.Point(359, 653);
            this.lbl_qtd_prods.Name = "lbl_qtd_prods";
            this.lbl_qtd_prods.Size = new System.Drawing.Size(20, 24);
            this.lbl_qtd_prods.TabIndex = 26;
            this.lbl_qtd_prods.Text = "0";
            // 
            // btn_reiniciar
            // 
            this.btn_reiniciar.Location = new System.Drawing.Point(722, 10);
            this.btn_reiniciar.Name = "btn_reiniciar";
            this.btn_reiniciar.Size = new System.Drawing.Size(172, 37);
            this.btn_reiniciar.TabIndex = 27;
            this.btn_reiniciar.Text = "Reiniciar";
            this.btn_reiniciar.UseVisualStyleBackColor = true;
            this.btn_reiniciar.Click += new System.EventHandler(this.btn_reiniciar_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.list_mais_vendidos);
            this.groupBox7.Location = new System.Drawing.Point(898, 436);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(325, 192);
            this.groupBox7.TabIndex = 28;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Top Produtos de todos os tempos";
            // 
            // list_mais_vendidos
            // 
            this.list_mais_vendidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader10});
            this.list_mais_vendidos.HideSelection = false;
            this.list_mais_vendidos.Location = new System.Drawing.Point(6, 15);
            this.list_mais_vendidos.Name = "list_mais_vendidos";
            this.list_mais_vendidos.Size = new System.Drawing.Size(313, 171);
            this.list_mais_vendidos.TabIndex = 0;
            this.list_mais_vendidos.UseCompatibleStateImageBehavior = false;
            this.list_mais_vendidos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "NOME";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "VALOR";
            this.columnHeader4.Width = 102;
            // 
            // mesanodata
            // 
            this.mesanodata.Location = new System.Drawing.Point(1017, 350);
            this.mesanodata.Mask = "00/0000";
            this.mesanodata.Name = "mesanodata";
            this.mesanodata.Size = new System.Drawing.Size(65, 20);
            this.mesanodata.TabIndex = 29;
            this.mesanodata.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(976, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Escolha Mês/Ano";
            // 
            // btn_escolher
            // 
            this.btn_escolher.Location = new System.Drawing.Point(960, 376);
            this.btn_escolher.Name = "btn_escolher";
            this.btn_escolher.Size = new System.Drawing.Size(185, 37);
            this.btn_escolher.TabIndex = 31;
            this.btn_escolher.Text = "Escolher";
            this.btn_escolher.UseVisualStyleBackColor = true;
            this.btn_escolher.Click += new System.EventHandler(this.btn_escolher_Click);
            // 
            // btn_vendaesc
            // 
            this.btn_vendaesc.Location = new System.Drawing.Point(398, 316);
            this.btn_vendaesc.Name = "btn_vendaesc";
            this.btn_vendaesc.Size = new System.Drawing.Size(185, 37);
            this.btn_vendaesc.TabIndex = 32;
            this.btn_vendaesc.Text = "Ir para a venda escolhida";
            this.btn_vendaesc.UseVisualStyleBackColor = true;
            this.btn_vendaesc.Click += new System.EventHandler(this.btn_vendaesc_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lbl_valor_liquido);
            this.groupBox9.Location = new System.Drawing.Point(945, 10);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(214, 84);
            this.groupBox9.TabIndex = 34;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Margem de Lucro";
            // 
            // lbl_valor_liquido
            // 
            this.lbl_valor_liquido.AutoSize = true;
            this.lbl_valor_liquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_liquido.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_valor_liquido.Location = new System.Drawing.Point(18, 28);
            this.lbl_valor_liquido.Name = "lbl_valor_liquido";
            this.lbl_valor_liquido.Size = new System.Drawing.Size(67, 31);
            this.lbl_valor_liquido.TabIndex = 7;
            this.lbl_valor_liquido.Text = "0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 652);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "Valor bruto:";
            // 
            // lbl_valorbruto
            // 
            this.lbl_valorbruto.AutoSize = true;
            this.lbl_valorbruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorbruto.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_valorbruto.Location = new System.Drawing.Point(528, 645);
            this.lbl_valorbruto.Name = "lbl_valorbruto";
            this.lbl_valorbruto.Size = new System.Drawing.Size(67, 31);
            this.lbl_valorbruto.TabIndex = 37;
            this.lbl_valorbruto.Text = "0,00";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "QUANTIDADE";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Quantidade";
            this.columnHeader11.Width = 161;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Valor";
            this.columnHeader12.Width = 176;
            // 
            // qtd
            // 
            this.qtd.AutoSize = true;
            this.qtd.Checked = true;
            this.qtd.Location = new System.Drawing.Point(18, 20);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(78, 17);
            this.qtd.TabIndex = 38;
            this.qtd.TabStop = true;
            this.qtd.Text = "quantidade";
            this.qtd.UseVisualStyleBackColor = true;
            this.qtd.CheckedChanged += new System.EventHandler(this.qtd_CheckedChanged);
            // 
            // val
            // 
            this.val.AutoSize = true;
            this.val.Location = new System.Drawing.Point(109, 20);
            this.val.Name = "val";
            this.val.Size = new System.Drawing.Size(48, 17);
            this.val.TabIndex = 39;
            this.val.Text = "valor";
            this.val.UseVisualStyleBackColor = true;
            this.val.CheckedChanged += new System.EventHandler(this.val_CheckedChanged);
            // 
            // group_order
            // 
            this.group_order.Controls.Add(this.val);
            this.group_order.Controls.Add(this.qtd);
            this.group_order.Location = new System.Drawing.Point(692, 631);
            this.group_order.Name = "group_order";
            this.group_order.Size = new System.Drawing.Size(200, 45);
            this.group_order.TabIndex = 40;
            this.group_order.TabStop = false;
            this.group_order.Text = "Ordenar por:";
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1238, 688);
            this.Controls.Add(this.group_order);
            this.Controls.Add(this.lbl_valorbruto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.btn_vendaesc);
            this.Controls.Add(this.btn_escolher);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mesanodata);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.btn_reiniciar);
            this.Controls.Add(this.lbl_qtd_prods);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_alert_detalhe);
            this.Controls.Add(this.lbl_alert_venda);
            this.Controls.Add(this.list_detalhe_venda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.list_vendas_concluidas);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Vendas";
            this.Text = "VENDAS";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.group_order.ResumeLayout(false);
            this.group_order.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView list_vendas_concluidas;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView list_detalhe_venda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lbl_alert_venda;
        private System.Windows.Forms.Label lbl_alert_detalhe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_total_vendas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_total_d_cartao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_total_d_dinheiro;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_total_dinheiro;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbl_total_vendas_cartao;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbl_total_vendas_dinheiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_qtd_prods;
        private System.Windows.Forms.Button btn_reiniciar;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.MaskedTextBox mesanodata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView list_mais_vendidos;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_escolher;
        private System.Windows.Forms.Button btn_vendaesc;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lbl_valor_liquido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_valorbruto;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.RadioButton qtd;
        private System.Windows.Forms.RadioButton val;
        private System.Windows.Forms.GroupBox group_order;
    }
}