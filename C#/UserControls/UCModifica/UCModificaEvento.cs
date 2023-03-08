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
    public partial class UCModificaEvento : UserControl
    {
        Index index;
        Evento evento;
        public UCModificaEvento(Index _index)
        {
            InitializeComponent();
            index = _index;
        }

        private void btnPesquisar2_Click(object sender, EventArgs e)
        {
            evento = new Evento();
            evento.idEvento = Convert.ToInt32(txtIdEvento.Text.Trim());
            evento.ConsultaObjeto(evento);
            txtNome.Text = evento.Nome;
            txtDesc.Text = evento.Descricao;
            txtLocalizacao.Text = evento.Localizacao;
            txtPrec.Text = evento.Preco.ToString();
            cbPublico.Text = evento.Publico;
            dtInicio.Text = evento.DataEvento;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberGroupSeparator = ".";
            evento.Descricao = txtDesc.Text.Trim();
            evento.Localizacao = txtLocalizacao.Text.Trim();
            evento.Preco = Convert.ToDouble(txtPrec.Text.Trim(), provider);
            evento.Publico = cbPublico.Text;
            evento.DataEvento = dtInicio.Value.ToString("yyyy-MM-dd HH:mm:ss");
            evento.Nome = txtNome.Text.Trim();
            evento.UpdateObjeto(evento);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                DialogResult dr = MessageBox.Show("Tem certeza que deseja excluir o registro do produto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    evento.DeletarObjeto(evento);
                    txtDesc.Text = "";
                    txtIdEvento.Text = "";
                    txtLocalizacao.Text = "";
                    txtPrec.Text = "";
                    cbPublico.Text = "Livre";
                    dtInicio.Text = "";
                    txtNome.Text = "";
                }
            }
        }

        private Boolean VerificaCampos()
        {
            if (txtDesc.Text != "" && txtLocalizacao.Text != "" && txtPrec.Text != "" && cbPublico.Text != "" && dtInicio.Text != "")
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
