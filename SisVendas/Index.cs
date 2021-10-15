using System;
using System.Linq;
using System.Windows.Forms;

namespace SisVendas
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            var c = new DAO.Conn();

            if (!c.ConexionTest())
            {
                MessageBox.Show("Inicie o servidor mysql...");
            }
            else {
                AbrirForm<Home>();
            }
        }

        private void AbrirForm<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panel_mostrar.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel_mostrar.Controls.Add(formulario);
                panel_mostrar.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
                formulario.BringToFront();
        }
        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (panel_menu.Width == 200)
            {
                panel_menu.Width = 0;
            }
            else
                panel_menu.Width = 200;
        }


        private void btn_pdv_Click(object sender, EventArgs e)
        {
            PDV v = new PDV();
            try
            {
                v.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_vendas_Click(object sender, EventArgs e)
        {
            Form f = new Vendas();
            try {
                f.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_produto_Click(object sender, EventArgs e)
        {
            Form prod = new SisVendas.Produto_pesquisa();
            try
            {
                prod.Show();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form f = new Cliente();
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}