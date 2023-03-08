using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmosHotel.UserControls.UCModifica
{
    public partial class UCModificaCli : UserControl
    {
        Index index;
        public UCModificaCli(Index _index)
        {
            this.index = _index;
            InitializeComponent();
        }

        public void LeitorCartao_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (index.ucpri.Ativo == this)
            {
                Cliente cliente = new Cliente(index.CartaoLido, "idCartao");
                txtCPF.Text = Convert.ToUInt64(cliente.CPF).ToString(@"000\.000\.000\-00");
                txtNome.Text = cliente.Nome;
                txtEmail.Text = cliente.Email;
                txtEndereço.Text = cliente.Endereco;
                txtEstado.Text = cliente.Cidade;
                txtCidade.Text = cliente.Cidade;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                Cliente cliente = new Cliente();
                cliente.CPF = txtCPF.Text;
                cliente.Nome = txtNome.Text;
                cliente.Email = txtEmail.Text;
                cliente.Endereco = txtEndereço.Text;
                cliente.Estado = txtEstado.Text;
                cliente.Cidade = txtCidade.Text;
                if (cliente.ModificaCliente(txtCPF.Text.Replace(".", null).Replace("-", null).Trim()))
                {
                    MessageBox.Show("Dados alterados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (VerificaCampos()) {
                DialogResult dr = MessageBox.Show("Tem certeza que deseja excluir o registro do cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    Cliente cliente = new Cliente();
                    cliente.CPF = txtCPF.Text.Trim();
                    cliente.DeletarRegistro(txtCPF.Text.Trim().Replace(".", null).Replace("-", null));
                    txtCPF.Text  =  "";
                    txtNome.Text = "";
                    txtEmail.Text = "";
                    txtEstado.Text = "";
                    txtCidade.Text = "";
                    txtEndereço.Text = "";
                }
            }
        }

        private Boolean VerificaCampos()
        {
            if (txtCPF.Text.Trim() != "" && txtNome.Text.Trim() != "" && txtEmail.Text.Trim() != "" && txtEndereço.Text.Trim() != "" && txtEstado.Text.Trim() != "" && txtCidade.Text.Trim() != "")
            {
                if (txtCPF.Text.Trim().Length == 14)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Insira dados válidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Não deixe nenhum campo vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            txtCPF.Text = index.MascaraCPF(txtCPF.Text);
            txtCPF.SelectionStart = txtCPF.Text.Length + 1;
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = txtCPF.Text;
            if (e.KeyChar == (char)8)
            {
                string lastchar = text[text.Length - 1].ToString();
                if (lastchar == "." || lastchar == "-")
                {
                    txtCPF.Text = text.Substring(0, text.Length - 1);
                }
            }
            else if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (text.Length == 14)
            {
                if (!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text != "" && txtCPF.Text.Length == 14)
            {
                Consulta(txtCPF.Text.Trim().Replace(".", "").Replace("-", ""), "CPF");
            }
            else
            {
                MessageBox.Show("Insira um CPF válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Text = "";
                txtEmail.Text = "";
                txtEstado.Text = "";
                txtCidade.Text = "";
                txtEndereço.Text = "";
            }
        }

        private void Consulta(string _chave, string typeKEY)
        {
            Cliente cliente = new Cliente(_chave, typeKEY);
            txtNome.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
            txtEstado.Text = cliente.Estado;
            txtCidade.Text = cliente.Cidade;
            txtEndereço.Text = cliente.Endereco;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {

        }
    }
}
