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
    public partial class UCCadastroEvento : UserControl
    {
        Index index;
        public UCCadastroEvento(Index _index)
        {
            InitializeComponent();
            this.index = _index;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberGroupSeparator = ".";

            if (txtDescEvento.Text != "" && txtLocal.Text != "" && txtNome.Text != "" && txtPrecoEvent.Text != "" && cbPublico.Text != "")
            {
                Evento evento = new Evento(index.funcionario.IDHotel, txtNome.Text, dtInicio.Value,txtLocal.Text, cbPublico.Text, Convert.ToDouble(txtPrecoEvent.Text, provider), txtDescEvento.Text);
                MessageBox.Show($"Os dados são: {dtInicio.Value.ToString("yyyy-MM-dd HH:mm:ss")} e {cbPublico.Text}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show($"Não deixe nenhum campo vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
