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

namespace CosmosHotel.UserControls.UCModifica
{
    public partial class UCModificaProd : UserControl
    {
        Index index;
        Produto produto;
        Servico servico;

        public UCModificaProd(Index _index)
        {
            this.index = _index;
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(rbProduto.Checked)
            {
                produto = new Produto(Convert.ToInt32(txtIDItem.Text.Trim()), index.funcionario.IDHotel);
                txtDesc.Text = produto.Descricao;
                txtPreco.Text = produto.Preco.ToString();
                txtQuantidade.Text = produto.Quantidade.ToString();
            }
            else if(rbServico.Checked)
            {
                servico = new Servico(Convert.ToInt32(txtIDItem.Text.Trim()), index.funcionario.IDHotel);
                txtDesc.Text = servico.Descricao;
                txtPreco.Text = servico.Preco.ToString();
                txtQuantidade.Text = "1";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberGroupSeparator = ".";

            if (VerificaCampos())
            {   
                if (rbProduto.Checked)
                {
                    produto.Imagem = null;
                    produto.Descricao = txtDesc.Text.Trim();
                    produto.Preco = Convert.ToDouble(txtPreco.Text.Replace(",",".").Trim(), provider);
                    produto.Quantidade = int.Parse(txtQuantidade.Text.Trim());
                    produto.UpdateObjeto(produto);
                }
                else if (rbServico.Checked)
                {
                    servico.Descricao = txtDesc.Text.Trim();
                    servico.Preco = Convert.ToDouble(txtPreco.Text.Replace(",", ".").Trim(), provider);
                    servico.UpdateObjeto(servico);
                }
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                DialogResult dr = MessageBox.Show("Tem certeza que deseja excluir o registro do produto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {

                    if (rbProduto.Checked)
                    {
                        produto.DeletarObjeto(produto);
                    }
                    else if (rbServico.Checked)
                    {
                        servico.DeletarObjeto(servico);
                    }
                }      
            }
        }

        private Boolean VerificaCampos()
        {
            if (txtDesc.Text != "" && txtQuantidade.Text != "" && txtPreco.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Não deixe nenhum campo vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void rbServico_CheckedChanged(object sender, EventArgs e)
        {
            if (rbServico.Checked)
            {
                txtQuantidade.Text = "";
                txtQuantidade.ReadOnly = true;
            }
            else
            {
                txtQuantidade.ReadOnly = false;
            }
        }
    }
}
