namespace SisVendas
{
    partial class Cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_obs = new System.Windows.Forms.RichTextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.grid_client = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_id = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tel_text = new System.Windows.Forms.TextBox();
            this.btn_listaexcluidos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.endereco_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(716, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(716, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "ENDEREÇO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(716, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "OBSERVAÇÕES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(716, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "TELEFONE";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(721, 102);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(331, 20);
            this.txt_nome.TabIndex = 9;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(721, 171);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(331, 20);
            this.txt_endereco.TabIndex = 10;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(721, 242);
            this.txt_telefone.Mask = "(99) 00000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(331, 20);
            this.txt_telefone.TabIndex = 11;
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(721, 317);
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(331, 141);
            this.txt_obs.TabIndex = 13;
            this.txt_obs.Text = "";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(815, 476);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(147, 41);
            this.btn_guardar.TabIndex = 14;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(118, 476);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(147, 41);
            this.btn_edit.TabIndex = 15;
            this.btn_edit.Text = "EDITAR";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(271, 476);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(147, 41);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "EXCLUIR";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // grid_client
            // 
            this.grid_client.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader5});
            this.grid_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_client.FullRowSelect = true;
            this.grid_client.HideSelection = false;
            this.grid_client.Location = new System.Drawing.Point(58, 74);
            this.grid_client.Name = "grid_client";
            this.grid_client.Size = new System.Drawing.Size(614, 384);
            this.grid_client.TabIndex = 17;
            this.grid_client.UseCompatibleStateImageBehavior = false;
            this.grid_client.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NOME";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ENDEREÇO";
            this.columnHeader3.Width = 123;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TELEFONE";
            this.columnHeader6.Width = 122;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "OBS";
            this.columnHeader5.Width = 193;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(716, 22);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(24, 25);
            this.lbl_id.TabIndex = 18;
            this.lbl_id.Text = "0";
            this.lbl_id.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "NOME";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(351, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "TELEFONE";
            // 
            // tel_text
            // 
            this.tel_text.Location = new System.Drawing.Point(355, 48);
            this.tel_text.Name = "tel_text";
            this.tel_text.Size = new System.Drawing.Size(146, 20);
            this.tel_text.TabIndex = 22;
            this.tel_text.TextChanged += new System.EventHandler(this.tel_text_TextChanged);
            // 
            // btn_listaexcluidos
            // 
            this.btn_listaexcluidos.Location = new System.Drawing.Point(424, 476);
            this.btn_listaexcluidos.Name = "btn_listaexcluidos";
            this.btn_listaexcluidos.Size = new System.Drawing.Size(147, 41);
            this.btn_listaexcluidos.TabIndex = 23;
            this.btn_listaexcluidos.Text = "Lista de Excluidos";
            this.btn_listaexcluidos.UseVisualStyleBackColor = true;
            this.btn_listaexcluidos.Click += new System.EventHandler(this.btn_listaexcluidos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(815, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 41);
            this.button1.TabIndex = 24;
            this.button1.Text = "ATUALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // endereco_text
            // 
            this.endereco_text.Location = new System.Drawing.Point(526, 48);
            this.endereco_text.Name = "endereco_text";
            this.endereco_text.Size = new System.Drawing.Size(146, 20);
            this.endereco_text.TabIndex = 26;
            this.endereco_text.TextChanged += new System.EventHandler(this.endereco_text_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(522, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "ENDEREÇO";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 530);
            this.Controls.Add(this.endereco_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_listaexcluidos);
            this.Controls.Add(this.tel_text);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.grid_client);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_obs);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.RichTextBox txt_obs;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ListView grid_client;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tel_text;
        private System.Windows.Forms.Button btn_listaexcluidos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox endereco_text;
        private System.Windows.Forms.Label label5;
    }
}