namespace SisVendas.Dialogs
{
    partial class PDV_control_vendas
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
            this.btn_alterarprodutosvenda = new System.Windows.Forms.Button();
            this.btn_finalizarvenda = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_vendas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_excluirvenda = new System.Windows.Forms.Button();
            this.btn_alterarvenda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txt_valortotal = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.group_tipo_venda = new System.Windows.Forms.GroupBox();
            this.rd_local = new System.Windows.Forms.RadioButton();
            this.rd_fiado = new System.Windows.Forms.RadioButton();
            this.rd_delivery = new System.Windows.Forms.RadioButton();
            this.group_tipo_venda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_alterarprodutosvenda
            // 
            this.btn_alterarprodutosvenda.Location = new System.Drawing.Point(228, 309);
            this.btn_alterarprodutosvenda.Name = "btn_alterarprodutosvenda";
            this.btn_alterarprodutosvenda.Size = new System.Drawing.Size(102, 42);
            this.btn_alterarprodutosvenda.TabIndex = 9;
            this.btn_alterarprodutosvenda.Text = "Alterar Produtos da venda";
            this.btn_alterarprodutosvenda.UseVisualStyleBackColor = true;
            this.btn_alterarprodutosvenda.Click += new System.EventHandler(this.btn_alterarprodutosvenda_Click);
            // 
            // btn_finalizarvenda
            // 
            this.btn_finalizarvenda.Location = new System.Drawing.Point(12, 309);
            this.btn_finalizarvenda.Name = "btn_finalizarvenda";
            this.btn_finalizarvenda.Size = new System.Drawing.Size(102, 42);
            this.btn_finalizarvenda.TabIndex = 8;
            this.btn_finalizarvenda.Text = "Finalizar";
            this.btn_finalizarvenda.UseVisualStyleBackColor = true;
            this.btn_finalizarvenda.Click += new System.EventHandler(this.btn_finalizarvenda_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(71, 36);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(225, 20);
            this.txt_name.TabIndex = 7;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo";
            // 
            // grid_vendas
            // 
            this.grid_vendas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.grid_vendas.FullRowSelect = true;
            this.grid_vendas.HideSelection = false;
            this.grid_vendas.Location = new System.Drawing.Point(12, 62);
            this.grid_vendas.Name = "grid_vendas";
            this.grid_vendas.Size = new System.Drawing.Size(687, 241);
            this.grid_vendas.TabIndex = 5;
            this.grid_vendas.UseCompatibleStateImageBehavior = false;
            this.grid_vendas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "COD";
            this.columnHeader2.Width = 214;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "VALOR";
            this.columnHeader3.Width = 186;
            // 
            // btn_excluirvenda
            // 
            this.btn_excluirvenda.Location = new System.Drawing.Point(120, 309);
            this.btn_excluirvenda.Name = "btn_excluirvenda";
            this.btn_excluirvenda.Size = new System.Drawing.Size(102, 42);
            this.btn_excluirvenda.TabIndex = 10;
            this.btn_excluirvenda.Text = "Excluir";
            this.btn_excluirvenda.UseVisualStyleBackColor = true;
            this.btn_excluirvenda.Click += new System.EventHandler(this.btn_excluirvenda_Click);
            // 
            // btn_alterarvenda
            // 
            this.btn_alterarvenda.Location = new System.Drawing.Point(765, 192);
            this.btn_alterarvenda.Name = "btn_alterarvenda";
            this.btn_alterarvenda.Size = new System.Drawing.Size(102, 42);
            this.btn_alterarvenda.TabIndex = 11;
            this.btn_alterarvenda.Text = "Alterar Venda";
            this.btn_alterarvenda.UseVisualStyleBackColor = true;
            this.btn_alterarvenda.Click += new System.EventHandler(this.btn_alterarvenda_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(707, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Valor Total";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(597, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 42);
            this.button5.TabIndex = 14;
            this.button5.Text = "Atualizar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_valortotal
            // 
            this.txt_valortotal.Enabled = false;
            this.txt_valortotal.Location = new System.Drawing.Point(711, 127);
            this.txt_valortotal.Name = "txt_valortotal";
            this.txt_valortotal.Size = new System.Drawing.Size(212, 20);
            this.txt_valortotal.TabIndex = 16;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(791, 29);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 20);
            this.lbl_id.TabIndex = 17;
            this.lbl_id.Text = "0";
            this.lbl_id.Visible = false;
            // 
            // group_tipo_venda
            // 
            this.group_tipo_venda.Controls.Add(this.rd_local);
            this.group_tipo_venda.Controls.Add(this.rd_fiado);
            this.group_tipo_venda.Controls.Add(this.rd_delivery);
            this.group_tipo_venda.Location = new System.Drawing.Point(348, 12);
            this.group_tipo_venda.Name = "group_tipo_venda";
            this.group_tipo_venda.Size = new System.Drawing.Size(243, 44);
            this.group_tipo_venda.TabIndex = 18;
            this.group_tipo_venda.TabStop = false;
            this.group_tipo_venda.Text = "Tipo de venda";
            // 
            // rd_local
            // 
            this.rd_local.AutoSize = true;
            this.rd_local.Checked = true;
            this.rd_local.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_local.Location = new System.Drawing.Point(9, 14);
            this.rd_local.Name = "rd_local";
            this.rd_local.Size = new System.Drawing.Size(59, 24);
            this.rd_local.TabIndex = 12;
            this.rd_local.TabStop = true;
            this.rd_local.Text = "local";
            this.rd_local.UseVisualStyleBackColor = true;
            this.rd_local.CheckedChanged += new System.EventHandler(this.rd_local_CheckedChanged);
            // 
            // rd_fiado
            // 
            this.rd_fiado.AutoSize = true;
            this.rd_fiado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_fiado.Location = new System.Drawing.Point(168, 14);
            this.rd_fiado.Name = "rd_fiado";
            this.rd_fiado.Size = new System.Drawing.Size(62, 24);
            this.rd_fiado.TabIndex = 14;
            this.rd_fiado.Text = "fiado";
            this.rd_fiado.UseVisualStyleBackColor = true;
            this.rd_fiado.CheckedChanged += new System.EventHandler(this.rd_fiado_CheckedChanged);
            // 
            // rd_delivery
            // 
            this.rd_delivery.AutoSize = true;
            this.rd_delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_delivery.Location = new System.Drawing.Point(80, 14);
            this.rd_delivery.Name = "rd_delivery";
            this.rd_delivery.Size = new System.Drawing.Size(79, 24);
            this.rd_delivery.TabIndex = 13;
            this.rd_delivery.Text = "delivery";
            this.rd_delivery.UseVisualStyleBackColor = true;
            this.rd_delivery.CheckedChanged += new System.EventHandler(this.rd_delivery_CheckedChanged);
            // 
            // PDV_control_vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 380);
            this.Controls.Add(this.group_tipo_venda);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_valortotal);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_alterarvenda);
            this.Controls.Add(this.btn_excluirvenda);
            this.Controls.Add(this.btn_alterarprodutosvenda);
            this.Controls.Add(this.btn_finalizarvenda);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_vendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PDV_control_vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Vendas";
            this.group_tipo_venda.ResumeLayout(false);
            this.group_tipo_venda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_alterarprodutosvenda;
        private System.Windows.Forms.Button btn_finalizarvenda;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView grid_vendas;
        private System.Windows.Forms.Button btn_excluirvenda;
        private System.Windows.Forms.Button btn_alterarvenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_valortotal;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.GroupBox group_tipo_venda;
        private System.Windows.Forms.RadioButton rd_local;
        private System.Windows.Forms.RadioButton rd_fiado;
        private System.Windows.Forms.RadioButton rd_delivery;
    }
}