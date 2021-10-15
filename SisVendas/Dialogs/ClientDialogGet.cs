using SisVendas.DAO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SisVendas.Dialogs
{
    public partial class ClientDialogGet : Form
    {
        public DTO.Cliente c;
        public ClientDialogGet()
        {
            InitializeComponent();
            gridat();
        }
        private void gridat(string select = "")
        {
            try
            {
                if (grid_client.Items.Count > 0) grid_client.Items.Clear();
                List<DTO.Cliente> d = new dao_Cliente().getClientes($"WHERE inativo = 0 {select}");
                foreach (var c in d)
                {
                    grid_client.Items.Add(new ListViewItem(new string[] { c.Id.ToString(), c.Nome_cliente, c.Endereco, c.Casa_number.ToString(), c.Observacoes, c.Telefone }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (grid_client.SelectedItems.Count > 0)
            {
                try
                {
                    List<DTO.Cliente> ac = new dao_Cliente().getClientes($"WHERE id = {Convert.ToInt32(grid_client.SelectedItems[0].SubItems[0].Text)}");
                    c = ac[0];
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Escolha um cliente!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            gridat($"AND cliente.nome_cliente LIKE '%{textBox1.Text.Trim().Replace("'","")}%'");
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            gridat($"AND cliente.telefone LIKE '%{maskedTextBox1.Text.Trim().Replace("(", string.Empty).Replace(")", string.Empty).Replace("-", string.Empty).Replace(" ", string.Empty)}%'");
        }
    }
}
