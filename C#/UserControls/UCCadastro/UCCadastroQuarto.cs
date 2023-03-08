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
    public partial class UCCadastroQuarto : UserControl
    {
        Index index;
        public UCCadastroQuarto(Index _index)
        {
            InitializeComponent();
            this.index = _index;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberGroupSeparator = ".";
            if (VerificaCampos())
            {   Quarto quarto = new Quarto(index.funcionario.IDHotel, Convert.ToInt32(txtCapacidade.Text), Convert.ToInt32(txtNumero.Text), Convert.ToDouble(txtPreco.Text, provider));
                quarto.CadastraObjeto(quarto);
                txtCapacidade.Text = "";
                txtPreco.Text = "";
                txtNumero.Text = "";
            }
        }

        private Boolean VerificaCampos()
        {
            if (txtCapacidade.Text != "" && txtPreco.Text != "" && txtNumero.Text != "")
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
