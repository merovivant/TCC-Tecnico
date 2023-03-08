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
    public partial class UCModificaQuarto : UserControl
    {
        Index index;
        Quarto quarto;

        public UCModificaQuarto(Index _index)
        {
            InitializeComponent();
            index = _index;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Quarto limpaquarto = new Quarto();
            quarto = limpaquarto;
            quarto = new Quarto(Convert.ToInt32(txtIdQuarto.Text), index.funcionario.IDHotel);
            quarto.ConsultaObjeto(quarto);
            txtCapacidade.Text = quarto.Capacidade.ToString();
            txtNumero.Text = quarto.Número.ToString();
            txtPreco.Text = quarto.Preco.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberGroupSeparator = ".";

            if (VerificaCampos())
            {
                quarto.Preco = Convert.ToDouble(txtPreco.Text.Replace(",", ".").Trim(), provider);
                quarto.Capacidade = Convert.ToInt32(txtCapacidade.Text.Trim());
                quarto.Número = Convert.ToInt32(txtNumero.Text.Trim());
                quarto.UpdateObjeto(quarto);
            }
        }

        private Boolean VerificaCampos()
        {
            if (txtCapacidade.Text != "" && txtNumero.Text != "" && txtPreco.Text != "" && txtIdQuarto.Text != "")
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
                DialogResult dr = MessageBox.Show("Tem certeza que deseja excluir o registro do produto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    quarto.DeletarObjeto(quarto);
                    txtCapacidade.Text = "";
                    txtIdQuarto.Text = "";
                    txtNumero.Text = "";
                    txtPreco.Text = "";
                }
            }
        }
    }
}
