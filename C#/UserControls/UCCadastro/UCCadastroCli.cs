using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace CosmosHotel.UserControls.UCCadastro
{
    public partial class UCCadastroCli : UserControl
    {
        Index index;
        public UCCadastroCli(Index _index)
        {
            InitializeComponent();
            this.index = _index;
        }


        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtCPF.Text, txtIDCartao.Text, txtNome.Text, txtEmail.Text, txtEstado.Text, txtCidade.Text, txtEndereco.Text);
            if (VerificaCampos())
            {
                switch (cliente.CadastraCliente())
                {
                    case "Erro1":
                        MessageBox.Show("O cartão já está associado a um cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "Erro2":
                        MessageBox.Show("O CPF já está associado a um cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "Cadastrado":
                        MessageBox.Show("Cadastrado com sucesso!", "Concluido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCPF.Text = "";
                        txtIDCartao.Text = "";
                        txtNome.Text = "";
                        txtEmail.Text = "";
                        txtEstado.Text = "";
                        txtCidade.Text = "";
                        txtEndereco.Text = "";
                        break;
                }
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            panelAviso.Visible = false;
            if (index.LeitorCartao.IsOpen)
            {
                index.LeitorCartao.Close();
            }
        }

        private void txtIDCartao_Click(object sender, EventArgs e)
        {
            panelAviso.Visible = true;
            if (!index.LeitorCartao.IsOpen)
            {
                try
                {
                    index.LeitorCartao.Open();
                }
                catch
                {
                    panelAviso.Visible = false;
                    MessageBox.Show("Nenhum leitor de cartão identificado!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void LeitorCartao_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (index.ucpri.Ativo == this)
            {
                txtIDCartao.Text = index.CartaoLido;
                panelAviso.Visible = false;
                if (index.LeitorCartao.IsOpen)
                {
                    index.LeitorCartao.Close();
                }
            }
        }

        private Boolean VerificaCampos()
        {
            if (txtCPF.Text != "" && txtNome.Text != "" && txtEmail.Text != "" && txtEndereco.Text != "" && txtEstado.Text != "" && txtCidade.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Não deixe nenhum campo vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
