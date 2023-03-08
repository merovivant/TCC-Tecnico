using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmosHotel.UserControls.UCConsulta
{
    public partial class UCConsultaPed : UserControl
    {
        Index index;
        public UCConsultaPed(Index _index)
        {
            InitializeComponent();
            index = _index;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtCPF.Text.Replace("-", null).Replace(".", null), "CPF");
            Pesquisa(cliente);
        }

        private void dtPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idPedido = Convert.ToInt32(dtPedidos[0, e.RowIndex].Value);
                Pedido pedido = new Pedido();
                dtDetalhePedido.DataSource = pedido.ListarDetalhePedido(idPedido);
                dtPedidos.Visible = false;
                dtDetalhePedido.Visible = true;
                btnVoltar.Visible = true;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            dtPedidos.Visible = true;
            dtDetalhePedido.Visible = false;
            btnVoltar.Visible = false;
        }

        public void LeitorCartao_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (index.ucpri.Ativo == this)
            {
                Cliente cliente = new Cliente(index.CartaoLido, "idCartao");
                txtCPF.Text = Convert.ToUInt64(cliente.CPF).ToString(@"000\.000\.000\-00");
                Pesquisa(cliente);
            }
        }

        private void Pesquisa(Cliente cliente)
        {
            if (cliente.Nome != null)
            {
                Pedido pedido = new Pedido(cliente.CPF);
                DataTable dt = pedido.ListarObjetos(pedido);
                dtPedidos.AutoGenerateColumns = false;
                dt.Columns.Add("Total2");
                foreach (DataRow row in dt.Rows)
                {
                    row["Total2"] = (row["Total"] != null) ? Convert.ToDouble(row["Total"]).ToString("C") : null;
                }
                dtPedidos.DataSource = dt;
            }
        }
    }
}