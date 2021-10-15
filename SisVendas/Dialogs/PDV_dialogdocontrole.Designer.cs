namespace SisVendas.Dialogs
{
    partial class PDV_dialogdocontrole
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
            this.grid_itemvenda = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_excluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.grid_produto = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_quantidadeitemvenda = new System.Windows.Forms.NumericUpDown();
            this.txt_descitemvenda = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_quantidadeproduto = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.id_itemvenda = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nome_prod = new System.Windows.Forms.TextBox();
            this.btn_alter = new System.Windows.Forms.Button();
            this.txt_produtodesc = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantidadeitemvenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantidadeproduto)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_itemvenda
            // 
            this.grid_itemvenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7});
            this.grid_itemvenda.FullRowSelect = true;
            this.grid_itemvenda.HideSelection = false;
            this.grid_itemvenda.Location = new System.Drawing.Point(10, 33);
            this.grid_itemvenda.Name = "grid_itemvenda";
            this.grid_itemvenda.Size = new System.Drawing.Size(489, 213);
            this.grid_itemvenda.TabIndex = 0;
            this.grid_itemvenda.UseCompatibleStateImageBehavior = false;
            this.grid_itemvenda.View = System.Windows.Forms.View.Details;
            this.grid_itemvenda.SelectedIndexChanged += new System.EventHandler(this.grid_itemvenda_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NOME";
            this.columnHeader1.Width = 156;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PREÇO";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DESCRIÇÃO";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "QUANTIDADE";
            this.columnHeader7.Width = 88;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(10, 252);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(119, 42);
            this.btn_excluir.TabIndex = 4;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Itens da Venda";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(652, 491);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(119, 42);
            this.btn_adicionar.TabIndex = 5;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // grid_produto
            // 
            this.grid_produto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.grid_produto.FullRowSelect = true;
            this.grid_produto.HideSelection = false;
            this.grid_produto.Location = new System.Drawing.Point(10, 326);
            this.grid_produto.Name = "grid_produto";
            this.grid_produto.Size = new System.Drawing.Size(489, 162);
            this.grid_produto.TabIndex = 6;
            this.grid_produto.UseCompatibleStateImageBehavior = false;
            this.grid_produto.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "NOME";
            this.columnHeader5.Width = 179;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "PREÇO";
            this.columnHeader6.Width = 244;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Produtos";
            // 
            // txt_quantidadeitemvenda
            // 
            this.txt_quantidadeitemvenda.Enabled = false;
            this.txt_quantidadeitemvenda.Location = new System.Drawing.Point(554, 104);
            this.txt_quantidadeitemvenda.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.txt_quantidadeitemvenda.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_quantidadeitemvenda.Name = "txt_quantidadeitemvenda";
            this.txt_quantidadeitemvenda.Size = new System.Drawing.Size(170, 20);
            this.txt_quantidadeitemvenda.TabIndex = 16;
            this.txt_quantidadeitemvenda.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_descitemvenda
            // 
            this.txt_descitemvenda.Enabled = false;
            this.txt_descitemvenda.Location = new System.Drawing.Point(554, 150);
            this.txt_descitemvenda.Name = "txt_descitemvenda";
            this.txt_descitemvenda.Size = new System.Drawing.Size(318, 96);
            this.txt_descitemvenda.TabIndex = 15;
            this.txt_descitemvenda.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(550, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Descrição";
            // 
            // txt_quantidadeproduto
            // 
            this.txt_quantidadeproduto.Location = new System.Drawing.Point(554, 349);
            this.txt_quantidadeproduto.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.txt_quantidadeproduto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_quantidadeproduto.Name = "txt_quantidadeproduto";
            this.txt_quantidadeproduto.Size = new System.Drawing.Size(170, 20);
            this.txt_quantidadeproduto.TabIndex = 18;
            this.txt_quantidadeproduto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(550, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Quantidade";
            // 
            // id_itemvenda
            // 
            this.id_itemvenda.AutoSize = true;
            this.id_itemvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_itemvenda.Location = new System.Drawing.Point(459, 9);
            this.id_itemvenda.Name = "id_itemvenda";
            this.id_itemvenda.Size = new System.Drawing.Size(18, 20);
            this.id_itemvenda.TabIndex = 19;
            this.id_itemvenda.Text = "0";
            this.id_itemvenda.Visible = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(652, 252);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(119, 42);
            this.btn_guardar.TabIndex = 20;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Visible = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nome";
            // 
            // txt_nome_prod
            // 
            this.txt_nome_prod.Location = new System.Drawing.Point(69, 494);
            this.txt_nome_prod.Name = "txt_nome_prod";
            this.txt_nome_prod.Size = new System.Drawing.Size(234, 20);
            this.txt_nome_prod.TabIndex = 22;
            this.txt_nome_prod.TextChanged += new System.EventHandler(this.txt_nome_prod_TextChanged);
            // 
            // btn_alter
            // 
            this.btn_alter.Location = new System.Drawing.Point(135, 252);
            this.btn_alter.Name = "btn_alter";
            this.btn_alter.Size = new System.Drawing.Size(119, 42);
            this.btn_alter.TabIndex = 23;
            this.btn_alter.Text = "Alterar";
            this.btn_alter.UseVisualStyleBackColor = true;
            this.btn_alter.Click += new System.EventHandler(this.btn_alter_Click);
            // 
            // txt_produtodesc
            // 
            this.txt_produtodesc.Location = new System.Drawing.Point(554, 392);
            this.txt_produtodesc.Name = "txt_produtodesc";
            this.txt_produtodesc.Size = new System.Drawing.Size(318, 96);
            this.txt_produtodesc.TabIndex = 25;
            this.txt_produtodesc.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(550, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Descrição";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(648, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 20);
            this.lbl_name.TabIndex = 26;
            this.lbl_name.Text = "text";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(550, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Valor da Venda";
            // 
            // txt_valor
            // 
            this.txt_valor.Enabled = false;
            this.txt_valor.Location = new System.Drawing.Point(554, 58);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(170, 20);
            this.txt_valor.TabIndex = 28;
            // 
            // PDV_dialogdocontrole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 550);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_produtodesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_alter);
            this.Controls.Add(this.txt_nome_prod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.id_itemvenda);
            this.Controls.Add(this.txt_quantidadeproduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_quantidadeitemvenda);
            this.Controls.Add(this.txt_descitemvenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grid_produto);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_itemvenda);
            this.Name = "PDV_dialogdocontrole";
            this.Text = "Contole dos items da venda";
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantidadeitemvenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantidadeproduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView grid_itemvenda;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.ListView grid_produto;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.NumericUpDown txt_quantidadeitemvenda;
        private System.Windows.Forms.RichTextBox txt_descitemvenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txt_quantidadeproduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label id_itemvenda;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nome_prod;
        private System.Windows.Forms.Button btn_alter;
        private System.Windows.Forms.RichTextBox txt_produtodesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_valor;
    }
}