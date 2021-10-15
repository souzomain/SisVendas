namespace SisVendas
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.list_local = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_delivery = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_fiado = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_local = new System.Windows.Forms.Label();
            this.lbl_delivery = new System.Windows.Forms.Label();
            this.lbl_fiado = new System.Windows.Forms.Label();
            this.lbl_v_local = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_v_delivery = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_v_fiado = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(367, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 37);
            this.label8.TabIndex = 8;
            this.label8.Text = "Pedidos";
            // 
            // list_local
            // 
            this.list_local.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.list_local.FullRowSelect = true;
            this.list_local.HideSelection = false;
            this.list_local.Location = new System.Drawing.Point(12, 55);
            this.list_local.Name = "list_local";
            this.list_local.Size = new System.Drawing.Size(748, 163);
            this.list_local.TabIndex = 17;
            this.list_local.UseCompatibleStateImageBehavior = false;
            this.list_local.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NOME";
            this.columnHeader2.Width = 240;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "VALOR TOTAL";
            this.columnHeader3.Width = 192;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DATA DE INICIO";
            this.columnHeader4.Width = 252;
            // 
            // list_delivery
            // 
            this.list_delivery.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.list_delivery.FullRowSelect = true;
            this.list_delivery.HideSelection = false;
            this.list_delivery.Location = new System.Drawing.Point(12, 263);
            this.list_delivery.Name = "list_delivery";
            this.list_delivery.Size = new System.Drawing.Size(748, 163);
            this.list_delivery.TabIndex = 18;
            this.list_delivery.UseCompatibleStateImageBehavior = false;
            this.list_delivery.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "NOME";
            this.columnHeader6.Width = 240;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "VALOR TOTAL";
            this.columnHeader7.Width = 198;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "DATA DE INICIO";
            this.columnHeader8.Width = 247;
            // 
            // list_fiado
            // 
            this.list_fiado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.list_fiado.FullRowSelect = true;
            this.list_fiado.HideSelection = false;
            this.list_fiado.Location = new System.Drawing.Point(12, 470);
            this.list_fiado.Name = "list_fiado";
            this.list_fiado.Size = new System.Drawing.Size(748, 163);
            this.list_fiado.TabIndex = 19;
            this.list_fiado.UseCompatibleStateImageBehavior = false;
            this.list_fiado.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "NOME";
            this.columnHeader10.Width = 240;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "VALOR TOTAL";
            this.columnHeader11.Width = 202;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "DATA DE INICIO";
            this.columnHeader12.Width = 242;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fiado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Delivery";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Local";
            // 
            // lbl_local
            // 
            this.lbl_local.AutoSize = true;
            this.lbl_local.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_local.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_local.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_local.Location = new System.Drawing.Point(201, 122);
            this.lbl_local.Name = "lbl_local";
            this.lbl_local.Size = new System.Drawing.Size(388, 29);
            this.lbl_local.TabIndex = 23;
            this.lbl_local.Text = "Sem contas em pendencia no local";
            this.lbl_local.Visible = false;
            // 
            // lbl_delivery
            // 
            this.lbl_delivery.AutoSize = true;
            this.lbl_delivery.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_delivery.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_delivery.Location = new System.Drawing.Point(201, 330);
            this.lbl_delivery.Name = "lbl_delivery";
            this.lbl_delivery.Size = new System.Drawing.Size(421, 29);
            this.lbl_delivery.TabIndex = 24;
            this.lbl_delivery.Text = "Sem contas em pendencia no delivery";
            this.lbl_delivery.Visible = false;
            // 
            // lbl_fiado
            // 
            this.lbl_fiado.AutoSize = true;
            this.lbl_fiado.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_fiado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fiado.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_fiado.Location = new System.Drawing.Point(203, 554);
            this.lbl_fiado.Name = "lbl_fiado";
            this.lbl_fiado.Size = new System.Drawing.Size(397, 29);
            this.lbl_fiado.TabIndex = 25;
            this.lbl_fiado.Text = "Sem contas em pendencia em fiado";
            this.lbl_fiado.Visible = false;
            // 
            // lbl_v_local
            // 
            this.lbl_v_local.AutoSize = true;
            this.lbl_v_local.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_v_local.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl_v_local.Location = new System.Drawing.Point(342, 221);
            this.lbl_v_local.Name = "lbl_v_local";
            this.lbl_v_local.Size = new System.Drawing.Size(40, 20);
            this.lbl_v_local.TabIndex = 26;
            this.lbl_v_local.Text = "0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Location = new System.Drawing.Point(317, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "R$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label6.Location = new System.Drawing.Point(317, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "R$";
            // 
            // lbl_v_delivery
            // 
            this.lbl_v_delivery.AutoSize = true;
            this.lbl_v_delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_v_delivery.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl_v_delivery.Location = new System.Drawing.Point(342, 429);
            this.lbl_v_delivery.Name = "lbl_v_delivery";
            this.lbl_v_delivery.Size = new System.Drawing.Size(40, 20);
            this.lbl_v_delivery.TabIndex = 28;
            this.lbl_v_delivery.Text = "0,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label9.Location = new System.Drawing.Point(317, 636);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "R$";
            // 
            // lbl_v_fiado
            // 
            this.lbl_v_fiado.AutoSize = true;
            this.lbl_v_fiado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_v_fiado.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl_v_fiado.Location = new System.Drawing.Point(342, 636);
            this.lbl_v_fiado.Name = "lbl_v_fiado";
            this.lbl_v_fiado.Size = new System.Drawing.Size(40, 20);
            this.lbl_v_fiado.TabIndex = 30;
            this.lbl_v_fiado.Text = "0,00";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 670);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_v_fiado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_v_delivery);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_v_local);
            this.Controls.Add(this.lbl_fiado);
            this.Controls.Add(this.lbl_delivery);
            this.Controls.Add(this.lbl_local);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_fiado);
            this.Controls.Add(this.list_delivery);
            this.Controls.Add(this.list_local);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView list_local;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView list_delivery;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView list_fiado;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_local;
        private System.Windows.Forms.Label lbl_delivery;
        private System.Windows.Forms.Label lbl_fiado;
        private System.Windows.Forms.Label lbl_v_local;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_v_delivery;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_v_fiado;
        private System.Windows.Forms.Timer timer;
    }
}