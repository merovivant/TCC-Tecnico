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
    public partial class UCModificaPed : UserControl
    {
        Index index;
        Pedido pedido;
        Cliente cliente;
        public UCModificaPed(Index _index)
        {
            InitializeComponent();
            index = _index;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pedido = new Pedido(Convert.ToInt32(txtIDPedido.Text));
            cliente = new Cliente(pedido.CPF, "CPF");
            txtCliente.Text = cliente.Nome;
            txtCPF.Text = Convert.ToUInt64(cliente.CPF).ToString(@"000\.000\.000\-00");
            txtDataPed.Text = pedido.DataPed;
            txtTotal.Text = pedido.Total.ToString("C");
            txtStatus.Text = pedido.Status;
            dtDetalhePedido.DataSource = pedido.ListarDetalhePedido(pedido.idPedido);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (pedido.Status != "Cancelado")
            {
                Pedido cancelar = new Pedido();
                cancelar.idPedido = pedido.idPedido;
                cancelar.Status = "Cancelado";
                pedido.UpdateObjeto(cancelar);
                Cartao cartao = new Cartao(cliente.idCartao);
                cartao.Saldo += pedido.Total;
                cartao.UpdateObjeto(cartao);
                MessageBox.Show($"A compra do cliente {cliente.Nome.Substring(0, cliente.Nome.IndexOf(" "))} no valor de {pedido.Total:C} foi cancelada! \n Novo Saldo: {cartao.Saldo:C}", "Compra cancelada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDPedido.Text = "";
                txtCliente.Text = "";
                txtCPF.Text = "";
                txtDataPed.Text = "";
                txtTotal.Text = "";
                txtStatus.Text = "";
                dtDetalhePedido.DataSource = null;
            } else
            {
                MessageBox.Show("O pedido já foi cancelado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
