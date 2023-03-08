using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmosHotel.UserControls.UCCadastro
{
    public partial class UCCadastroFunc : UserControl
    {
        Index index;
        public UCCadastroFunc(Index _index)
        {
            InitializeComponent();
            this.index = _index;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario(txtCPF.Text, index.funcionario.IDHotel, txtNome.Text, txtTel.Text, cbCargo.Text, txtEmail.Text, txtSenha.Text);
            if (VerificaCampos())
            {
                funcionario.CadastraFuncionario();
                txtCPF.Text = "";
                txtNome.Text = "";
                txtTel.Text = "";
                cbCargo.Text = "";
                txtEmail.Text = "";
                txtSenha.Text = "";
            }
        }


        private Boolean VerificaCampos()
        {
            if (txtCPF.Text != "" && txtEmail.Text != "" && txtNome.Text != "" && txtSenha.Text != "" && txtTel.Text != "")
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
