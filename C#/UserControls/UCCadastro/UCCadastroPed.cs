using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmosHotel.UserControls.UCCadastro
{
    public partial class UCCadastroPed : UserControl
    {
        Index index;
        public UCCadastroPed(Index _index)
        {
            InitializeComponent();
            this.index = _index;
        }

        private void UCCadastroPed_Load(object sender, EventArgs e)
        {
            ProdutoDAL produto = new ProdutoDAL();
            cbProduto.ValueMember = "idProduto";
            cbProduto.DisplayMember = "Descricao";
            cbProduto.DataSource = produto.ListarGrid(index.funcionario.IDHotel);

            ServicoDAL servico = new ServicoDAL();
            cbServico.ValueMember = "idServico";
            cbServico.DisplayMember = "Descricao";
            cbServico.DataSource = servico.ListarGrid(index.funcionario.IDHotel);
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(cbProduto.SelectedValue.ToString());
            Boolean repetido = false;
            foreach (DataGridViewRow row in dtCarrinho.Rows)
            {
                if (produto.idProduto.Equals(dtCarrinho[4, row.Index].Value) && (dtCarrinho[0, row.Index].Value.ToString() == "Produto"))
                {
                    repetido = true;
                    dtCarrinho[3, row.Index].Value = int.Parse(dtCarrinho[3, row.Index].Value.ToString()) + qtdeProduto.Value;
                    dtCarrinho[2, row.Index].Value = (Convert.ToInt32(dtCarrinho[3, row.Index].Value) * produto.Preco).ToString("C");
                }
            }
            if (!repetido) {
                dtCarrinho.Rows.Add("Produto", produto.Descricao, (produto.Preco * Convert.ToInt32(qtdeProduto.Value)).ToString("C"), qtdeProduto.Value, produto.idProduto);
            }
        }

        private void dtCarrinho_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Produto produto = new Produto(dtCarrinho[4, e.RowIndex].Value.ToString());
                if (Convert.ToInt32(dtCarrinho[3, e.RowIndex].Value) == 0)
                {
                    dtCarrinho.Rows.Remove(dtCarrinho.Rows[e.RowIndex]);
                }
                else
                {
                    dtCarrinho[2, e.RowIndex].Value = (Convert.ToInt32(dtCarrinho[3, e.RowIndex].Value) * produto.Preco).ToString("C");
                }
            }
        }

        private void btnAdicionarServico_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico(cbServico.SelectedValue.ToString());
            Boolean repetido = false;
            foreach (DataGridViewRow row in dtCarrinho.Rows)
            {
                if (servico.idServico.Equals(dtCarrinho[4, row.Index].Value) && dtCarrinho[0, row.Index].Value.ToString() == "Serviço")
                {
                    repetido = true;
                }
            }
            if (!repetido)
            {
                dtCarrinho.Rows.Add("Serviço", servico.Descricao, servico.Preco.ToString("C"), 1, servico.idServico);
            }
        }
        double total = 0;
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtCarrinho.Rows)
            {
                if (dtCarrinho[2, row.Index].Value != null)
                {
                    total += Convert.ToDouble(dtCarrinho[2, row.Index].Value.ToString().Replace("R$ ", null));
                }
            }
            if (dtCarrinho.Rows.Count > 1)
            {
                txtTotal.Text = total.ToString("C");
                panelAviso.Visible = true;
                txtCPF.Text = "";
            }
            else
            {
                MessageBox.Show("Insira os dados do pedido corretamente","Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {   
            Cliente cliente = new Cliente(txtCPF.Text, "CPF");
            if(cliente.idCartao != null)
            {
                Cartao cartao = new Cartao(cliente.idCartao);
                if(cartao.Saldo >= total)
                {
                    cartao.Saldo -= total;
                    cartao.UpdateObjeto(cartao);
                    Pedido pedido = new Pedido(cliente.CPF, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), total, "Pago");
                    pedido.ConsultaObjeto(pedido);
                    foreach (DataGridViewRow row in dtCarrinho.Rows)
                    {
                        if (dtCarrinho[0, row.Index].Value == "Produto")
                        {
                            ProdutoPedido produto = new ProdutoPedido(pedido.idPedido, dtCarrinho[4, row.Index].Value.ToString(), dtCarrinho[3, row.Index].Value.ToString());
                        } else if(dtCarrinho[0, row.Index].Value == "Serviço") 
                        {
                            ServicoPedido servico = new ServicoPedido(pedido.idPedido, dtCarrinho[4, row.Index].Value.ToString());
                        }
                    }
                    MessageBox.Show($"{cliente.Nome.Substring(0, cliente.Nome.IndexOf(" "))}, sua compra no valor de {pedido.Total:C} foi aprovada! \n Novo Saldo: {cartao.Saldo:C}", "Compra efetuada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelAviso.Visible = false;
                    txtCPF.Text = null;
                    dtCarrinho.Rows.Clear();
                }else
                {
                    lblErro.Text = "O cliente não possui saldo suficiente!";
                }
            }
            else
            {
                lblErro.Text = "Insira um CPF válido!";
            }
        }

        public void LeitorCartao_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (index.ucpri.Ativo == this && panelAviso.Visible == true)
            {
                Cliente cliente = new Cliente(index.CartaoLido, "idCartao");
                txtCPF.Text = cliente.CPF;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            panelAviso.Visible = false;
        }
    }
}
