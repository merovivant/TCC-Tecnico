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
    public partial class UCCadastroProd : UserControl
    {
        Index index;

        public UCCadastroProd(Index _index)
        {
            InitializeComponent();
            this.index = _index;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberGroupSeparator = ".";
            
            if (txtDescProd.Text != "" && txtPrecoProd.Text != "" && txtQntdProd.Text != "")
            {
                Produto produto = new Produto(index.funcionario.IDHotel, txtDescProd.Text, Convert.ToDouble(txtPrecoProd.Text.Replace(",", "."), provider), int.Parse(txtQntdProd.Text));
                txtDescProd.Text = "";
                txtPrecoProd.Text = "";
                txtQntdProd.Text = "";
            }
            else
            {
                MessageBox.Show("Não deixe nenhum campo vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastroServ_Click(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberGroupSeparator = ".";

            if (txtDescServ.Text != "" && txtPrecoServ.Text != "")
            {
                Servico servico = new Servico(index.funcionario.IDHotel, Convert.ToDouble(txtPrecoServ.Text.Replace(",","."), provider), txtDescServ.Text);
                txtDescServ.Text = "";
                txtPrecoServ.Text = "";
            }
            else
            {
                MessageBox.Show("Não deixe nenhum campo vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
