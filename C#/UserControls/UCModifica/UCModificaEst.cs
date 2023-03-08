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
    public partial class UCModificaEst : UserControl
    {
        Index index;
        Estada estada = new Estada();
        List<Quarto> quartos = new List<Quarto>();
        double novoTotal;

        public UCModificaEst(Index _index)
        {
            InitializeComponent();
            index = _index;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            quartos = new List<Quarto>();
            estada = new Estada(int.Parse(txtIDEstada.Text));
            if (estada.Pagamento != null)
            {
                if (Convert.ToDateTime(estada.DataCheckout) > DateTime.Now)
                {
                    txtTotal.Text = estada.Preco.ToString("C");
                    txtPagamento.Text = estada.Pagamento;
                    novoTotal = estada.Preco;
                    if (estada.Pagamento == "Efetuado")
                    {
                        btnPagar.Visible = false;
                    }
                    else if (estada.Pagamento == "Pendente")
                    {
                        btnPagar.Visible = true;
                    }
                    DataTable dt = new DataTable();
                    EstadaQuarto estadaQuarto = new EstadaQuarto();
                    estadaQuarto.idEstada = estada.idEstada;
                    dt = estadaQuarto.ListarObjetos(estadaQuarto);
                    foreach (DataRow row in dt.Rows)
                    {
                        Quarto quarto = new Quarto(Convert.ToInt32(row["idQuarto"]));
                        quartos.Add(quarto);
                    }
                    dtInicio.Value = Convert.ToDateTime(estada.DataCheckin);
                    dtFim.Value = Convert.ToDateTime(estada.DataCheckout);
                }
                else
                {
                    MessageBox.Show("Não é possível alterar dados de uma estada já concluída, apenas de reservas futuras.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDEstada.Text = "";
                }
            }
        }

        private void dtInicio_ValueChanged(object sender, EventArgs e)
        {
            DateTime inicio = Convert.ToDateTime($"{dtInicio.Value:yyyy-MM-dd} 14:00:00");
            DateTime fim = Convert.ToDateTime($"{dtFim.Value:yyyy-MM-dd} 12:00:00");
            DateTime checkin = Convert.ToDateTime(estada.DataCheckin);
            DateTime checkout = Convert.ToDateTime(estada.DataCheckout);
            string _inicio, _fim;
            if (dtInicio.Value.ToString() != estada.DataCheckin)
            {
                if (dtFim.Value <= dtInicio.Value)
                {
                    dtFim.Value = dtInicio.Value.AddDays(1);
                }
                if (!(inicio > checkin && inicio < checkout))
                {
                    if (inicio < checkin)
                    {
                        _inicio = inicio.ToString("yyyy/MM/dd HH:mm:ss");
                        _fim = checkin.AddHours(-2).ToString("yyyy/MM/dd HH:mm:ss");
                    }
                    else
                    {
                        _inicio = inicio.ToString("yyyy/MM/dd HH:mm:ss");
                        _fim = fim.ToString("yyyy/MM/dd HH:mm:ss");
                    }
                    if (!VerificaDisponibilidade(_inicio, _fim))
                    {
                        MessageBox.Show("Os quartos reservados não têm disponibilidade na nova data de check-in inserida!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtInicio.Value = Convert.ToDateTime(estada.DataCheckin);
                    }
                    else { CalculaTotal(); }
                }
                else { CalculaTotal(); }
            }
        }

        private void dtFim_ValueChanged(object sender, EventArgs e)
        {
            if (dtFim.Value <= dtInicio.Value)
            {
                dtFim.Value = dtInicio.Value.AddDays(1);
            }
            DateTime inicio = Convert.ToDateTime($"{dtInicio.Value:yyyy-MM-dd} 14:00:00");
            DateTime fim = Convert.ToDateTime($"{dtFim.Value:yyyy-MM-dd} 12:00:00");
            DateTime checkin = Convert.ToDateTime(estada.DataCheckin);
            DateTime checkout = Convert.ToDateTime(estada.DataCheckout);
            string _inicio, _fim;
            if (dtFim.Value.ToString() != estada.DataCheckout)
            {
                if (!(fim > checkin && fim < checkout))
                {
                    if (fim > checkout)
                    {
                        _inicio = checkout.AddHours(+2).ToString("yyyy/MM/dd HH:mm:ss");
                        _fim = fim.ToString("yyyy/MM/dd HH:mm:ss");
                    }
                    else
                    {
                        _inicio = inicio.ToString("yyyy/MM/dd HH:mm:ss");
                        _fim = fim.ToString("yyyy/MM/dd HH:mm:ss");
                    }
                    if (!VerificaDisponibilidade(_inicio, _fim))
                    {
                        MessageBox.Show("Os quartos reservados não têm disponibilidade na nova data de check-out inserida!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtFim.Value = Convert.ToDateTime(estada.DataCheckout);
                    }
                    else { CalculaTotal(); }
                }
                else { CalculaTotal(); }
            }
        }

        private Boolean VerificaDisponibilidade(string inicio, string fim)
        {
            if (estada.Pagamento != null)
            {
                DataTable dt = new DataTable();
                dt = estada.ListarQuartosDisponiveis(inicio, fim, index.funcionario.IDHotel, null);
                int qtdeQuartos = quartos.Count;
                int qtdeQuartosDisponiveis = 0;
                foreach (DataRow row in dt.Rows)
                {
                    foreach (Quarto quarto in quartos)
                    {
                        int idQuarto = Convert.ToInt32(row["idQuarto"]);
                        if (quarto.idQuarto == idQuarto)
                        {
                            qtdeQuartosDisponiveis++;
                        }
                    }
                }
                if(qtdeQuartos == qtdeQuartosDisponiveis) {return true;} else {return false;}
            }
            return true;
        }

        public void CalculaTotal()
        {
            if (estada != null)
            {
                estada.DataCheckin = $"{dtInicio.Value:yyyy-MM-dd} 14:00:00";
                estada.DataCheckout = $"{dtFim.Value:yyyy-MM-dd} 12:00:00";
                double custoDiario = 0.0;
                int diarias = Convert.ToInt32((dtFim.Value - dtInicio.Value).TotalDays);
                if (quartos.Count > 0)
                {
                    foreach (Quarto quarto in quartos)
                    {
                        custoDiario += quarto.Preco;
                    }
                }
                novoTotal = custoDiario * diarias;
                txtTotal.Text = $"{novoTotal:C}";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (estada.CPF != null)
            {
                if (estada.Pagamento == "Efetuado")
                {
                    Cliente cliente = new Cliente(estada.CPF, "CPF");
                    Cartao cartao = new Cartao(cliente.idCartao);
                    cartao.Saldo += estada.Preco;
                    cartao.UpdateObjeto(cartao);
                }
                EstadaQuarto estadaQuarto = new EstadaQuarto();
                estadaQuarto.idEstada = estada.idEstada;
                estadaQuarto.DeletarObjeto(estadaQuarto);
                estada.DeletarObjeto(estada);
                txtIDEstada.Text = "";
                txtTotal.Text = "";
                txtPagamento.Text = "";
                btnPagar.Visible = true;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            panelAviso.Visible = true;  
        }

        private void PagarEstada(Cartao cartao)
        {
            if (cartao.Saldo >= estada.Preco)
            {
                estada.DataCheckin = Convert.ToDateTime(estada.DataCheckin).ToString("yyyy/MM/dd HH:mm:ss");
                estada.DataCheckout = Convert.ToDateTime(estada.DataCheckout).ToString("yyyy/MM/dd HH:mm:ss");
                cartao.Saldo -= estada.Preco;
                cartao.UpdateObjeto(cartao);
                estada.Pagamento = "Efetuado";
                estada.UpdateObjeto(estada);
                txtPagamento.Text = "Efetuado";
                btnPagar.Visible = false;
            }
            else
            {
                MessageBox.Show("Você não tem saldo suficiente para pagar a referida estada!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (estada.Pagamento != null)
            {
                Cliente cliente = new Cliente(estada.CPF, "CPF");
                Cartao cartao = new Cartao(cliente.idCartao);
                if (!novoTotal.Equals(estada.Preco))
                {
                    estada.DataCheckin = dtInicio.Value.ToString("yyyy/MM/dd HH:mm:ss");
                    estada.DataCheckout = dtFim.Value.ToString("yyyy/MM/dd HH:mm:ss");
                    if (estada.Pagamento == "Efetuado")
                    {
                        double saldo = novoTotal - estada.Preco;
                        cartao.Saldo -= saldo;
                        cartao.UpdateObjeto(cartao);
                    }
                    estada.Preco = novoTotal;
                    estada.UpdateObjeto(estada);
                }
                else
                {
                    MessageBox.Show("Você não fez nenhuma alteração na estada referida!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void LeitorCartao_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (index.ucpri.Ativo == this && panelAviso.Visible == true)
            {
                Cliente cliente = new Cliente(estada.CPF, "CPF");
                Cartao cartao = new Cartao(cliente.idCartao);
                if (index.CartaoLido == cartao.idCartao)
                {
                    PagarEstada(cartao);
                }
                else
                {
                    MessageBox.Show($"O cartão aproximado não está associado a estada do(a) cliente: {cliente.Nome}", "", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            panelAviso.Visible = false;
        }
    }
}
