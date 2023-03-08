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
    public partial class UCModificaFunc : UserControl
    {
        Funcionario funcionario;
        Index index;
        public UCModificaFunc(Index _index)
        {
            this.index = _index;
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Consulta(txtCPF.Text.Trim().Replace(".", null).Replace("-", null));
        }

        private void Consulta(string _cpf)
        {
            funcionario = new Funcionario(_cpf, index.funcionario.IDHotel);
            txtNome.Text = funcionario.Nome;
            txtEmail.Text = funcionario.Email;
            txtCargo.Text = funcionario.Cargo;
            txtTelefone.Text = funcionario.Telefone;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {   
                funcionario.Nome = txtNome.Text.ToString();
                funcionario.Email = txtEmail.Text;
                funcionario.Cargo = txtCargo.Text;
                funcionario.Telefone = txtTelefone.Text;
                if (funcionario.ModificaFuncionario())
                {
                    MessageBox.Show("Dados alterados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private Boolean VerificaCampos()
        {
            if (txtCPF.Text != "" && txtNome.Text != "" && txtEmail.Text != "" && txtCargo.Text != "" && txtTelefone.Text != "" )
            {
                return true;
            }
            else
            {
                MessageBox.Show("Não deixe nenhum campo vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                DialogResult dr = MessageBox.Show("Tem certeza que deseja excluir o registro do Funcionário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    funcionario.DeletarFuncionario();
                    txtNome.Text = "";
                    txtEmail.Text = "";
                    txtCargo.Text = "";
                    txtTelefone.Text = "";
                }
            }
        }
    }
}
