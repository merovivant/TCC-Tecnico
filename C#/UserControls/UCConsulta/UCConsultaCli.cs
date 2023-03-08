using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmosHotel.UserControls.UCConsulta
{
    public partial class UCConsultaCli : UserControl
    {
        Index index;
        Cliente cliente;

        public UCConsultaCli(Index _index)
        {
            InitializeComponent();
            this.index = _index;
        }
        private void Consulta(string key, string keyName)
        {   
            cliente = new Cliente(key, keyName);
            txtCPF.Text = Convert.ToUInt64(cliente.CPF).ToString(@"000\.000\.000\-00");
            txtNome.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
            txtEstado.Text = cliente.Estado;
            txtCidade.Text = cliente.Cidade;
            txtEndereco.Text = cliente.Endereco;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text != "" && txtCPF.Text.Length == 14)
            {
                Consulta(txtCPF.Text.Trim().Replace(".", null).Replace("-", null), "CPF");
            }
            else
            {
                MessageBox.Show("Insira um CPF válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void LeitorCartao_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (index.ucpri.Ativo == this)
            {
                Consulta(index.CartaoLido, "idCartao");
            }
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            txtCPF.Text = index.MascaraCPF(txtCPF.Text);
            txtCPF.SelectionStart = txtCPF.Text.Length + 1;
        }
    }
}
