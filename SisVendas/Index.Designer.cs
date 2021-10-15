namespace SisVendas
{
    partial class Index
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_produto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_pdv = new System.Windows.Forms.Button();
            this.btn_estoque = new System.Windows.Forms.Button();
            this.btn_vendas = new System.Windows.Forms.Button();
            this.btn_carrinhodecompras = new System.Windows.Forms.PictureBox();
            this.panel_mostrar = new System.Windows.Forms.Panel();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_carrinhodecompras)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.DarkBlue;
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menu.Controls.Add(this.btn_produto);
            this.panel_menu.Controls.Add(this.button1);
            this.panel_menu.Controls.Add(this.btn_pdv);
            this.panel_menu.Controls.Add(this.btn_estoque);
            this.panel_menu.Controls.Add(this.btn_vendas);
            this.panel_menu.Controls.Add(this.btn_carrinhodecompras);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(200, 684);
            this.panel_menu.TabIndex = 5;
            // 
            // btn_produto
            // 
            this.btn_produto.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_produto.FlatAppearance.BorderSize = 0;
            this.btn_produto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_produto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_produto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_produto.Location = new System.Drawing.Point(0, 299);
            this.btn_produto.Name = "btn_produto";
            this.btn_produto.Size = new System.Drawing.Size(200, 33);
            this.btn_produto.TabIndex = 6;
            this.btn_produto.Text = "Produto";
            this.btn_produto.UseVisualStyleBackColor = false;
            this.btn_produto.Click += new System.EventHandler(this.btn_produto_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clientes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_pdv
            // 
            this.btn_pdv.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_pdv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pdv.FlatAppearance.BorderSize = 0;
            this.btn_pdv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_pdv.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_pdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pdv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_pdv.Location = new System.Drawing.Point(-1, 182);
            this.btn_pdv.Name = "btn_pdv";
            this.btn_pdv.Size = new System.Drawing.Size(200, 33);
            this.btn_pdv.TabIndex = 2;
            this.btn_pdv.Text = "PDV";
            this.btn_pdv.UseVisualStyleBackColor = false;
            this.btn_pdv.Click += new System.EventHandler(this.btn_pdv_Click);
            // 
            // btn_estoque
            // 
            this.btn_estoque.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_estoque.Enabled = false;
            this.btn_estoque.FlatAppearance.BorderSize = 0;
            this.btn_estoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_estoque.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estoque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_estoque.Location = new System.Drawing.Point(-1, 338);
            this.btn_estoque.Name = "btn_estoque";
            this.btn_estoque.Size = new System.Drawing.Size(200, 33);
            this.btn_estoque.TabIndex = 4;
            this.btn_estoque.Text = "Estoque";
            this.btn_estoque.UseVisualStyleBackColor = false;
            // 
            // btn_vendas
            // 
            this.btn_vendas.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_vendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vendas.FlatAppearance.BorderSize = 0;
            this.btn_vendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_vendas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_vendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vendas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_vendas.Location = new System.Drawing.Point(-1, 221);
            this.btn_vendas.Name = "btn_vendas";
            this.btn_vendas.Size = new System.Drawing.Size(200, 33);
            this.btn_vendas.TabIndex = 3;
            this.btn_vendas.Text = "Controle de Vendas";
            this.btn_vendas.UseVisualStyleBackColor = false;
            this.btn_vendas.Click += new System.EventHandler(this.btn_vendas_Click);
            // 
            // btn_carrinhodecompras
            // 
            this.btn_carrinhodecompras.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_carrinhodecompras.BackgroundImage = global::SisVendas.Properties.Resources.carrinhodecompras;
            this.btn_carrinhodecompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_carrinhodecompras.InitialImage = null;
            this.btn_carrinhodecompras.Location = new System.Drawing.Point(0, 0);
            this.btn_carrinhodecompras.Name = "btn_carrinhodecompras";
            this.btn_carrinhodecompras.Size = new System.Drawing.Size(200, 135);
            this.btn_carrinhodecompras.TabIndex = 1;
            this.btn_carrinhodecompras.TabStop = false;
            // 
            // panel_mostrar
            // 
            this.panel_mostrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mostrar.Location = new System.Drawing.Point(200, 0);
            this.panel_mostrar.Name = "panel_mostrar";
            this.panel_mostrar.Size = new System.Drawing.Size(839, 684);
            this.panel_mostrar.TabIndex = 18;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1039, 684);
            this.Controls.Add(this.panel_mostrar);
            this.Controls.Add(this.panel_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de vendas";
            this.panel_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_carrinhodecompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button btn_pdv;
        private System.Windows.Forms.Button btn_estoque;
        private System.Windows.Forms.Button btn_vendas;
        private System.Windows.Forms.PictureBox btn_carrinhodecompras;
        private System.Windows.Forms.Panel panel_mostrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_produto;
    }
}

