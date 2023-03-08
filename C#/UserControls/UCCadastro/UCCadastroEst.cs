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
    public partial class UCCadastroEst : UserControl
    {
        Index index = null;
        List<Quarto> listaQuartos = new List<Quarto>();
        public UCCadastroEst(Index _index)
        {
            InitializeComponent();
            this.index = _index;
            ItensQuarto.AutoGenerateColumns = false;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtCPF.Text, "CPF");
            if(cliente.Nome != null)
            {
                if(listaQuartos.Count > 0)
                {
                    Estada estada = new Estada();
                    estada.Preco = Convert.ToDouble(txtPreco.Text.Replace("R$ ", null));
                    Cartao cartao = new Cartao(cliente.idCartao);
                    if(cartao.Saldo >= estada.Preco || cbPagamento.Checked)
                    {
                        string inicio = dtInicio.Value.ToString("yyyy-MM-dd");
                        string fim = dtFim.Value.ToString("yyyy-MM-dd");
                        inicio += " 14:00:00";
                        fim += " 12:00:00";
                        estada.CPF = cliente.CPF;
                        estada.DataCheckin = inicio;
                        estada.DataCheckout = fim;
                        estada.idHotel = index.funcionario.IDHotel;
                        if (!cbPagamento.Checked)
                        {
                            cartao.Saldo -= estada.Preco;
                            cartao.UpdateObjeto(cartao);
                            estada.Pagamento = "Efetuado";
                        }
                        estada.CadastraObjeto(estada);
                        estada.ConsultaObjeto(estada);
                        if  (estada.idEstada != null)
                        {
                            EstadaQuarto estadaQuarto = new EstadaQuarto();
                            foreach (Quarto quarto in listaQuartos)
                            {
                                estadaQuarto = new EstadaQuarto(estada.idEstada, quarto.idQuarto);
                            }
                            estadaQuarto.idQuarto = 0;
                            if (estadaQuarto.ListarObjetos(estadaQuarto).Rows.Count == listaQuartos.Count)
                            {
                                MessageBox.Show($"A reserva no valor de {estada.Preco.ToString("C")} foi efetuada no nome de {cliente.Nome}.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ItensQuarto.DataSource = null;
                                txtCustoDiaria.Text = "R$ 0,00";
                                txtPreco.Text = "R$ 0,00";
                                listaQuartos = new List<Quarto>();
                                txtCPF.Text = "";

                            }
                            else
                            {
                                MessageBox.Show("Ocorreu um erro no cadastro dos detalhes da sua reserva, tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                estada.DeletarObjeto(estada);
                            }
                        } else
                        {
                            MessageBox.Show("Ocorreu um erro no cadastro da sua reserva, tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Você não selecionou nenhum quarto!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void LeitorCartao_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (index.ucpri.Ativo == this)
            {
                Cliente cliente = new Cliente(index.CartaoLido, "idCartao");
                txtCPF.Text = cliente.CPF;
            }
        }

        private void dtInicio_ValueChanged(object sender, EventArgs e)
        {
            if (dtFim.Value <= dtInicio.Value)
            {
                dtFim.Value = dtInicio.Value.AddDays(1);
            } else
            {
                ConsultaQuartos(dtInicio.Value, dtFim.Value, null);
                ItensQuarto.DataSource = null;
                listaQuartos = new List<Quarto>();
                txtCustoDiaria.Text = "R$ 0,00";
                txtPreco.Text = "R$ 0,00";
            }
            if (cbPagamento.Checked && dtInicio.Value.Date == DateTime.Now.Date)
            {
                MessageBox.Show("A reserva atual tem como data de check-in o dia de hoje, portanto não é possivel pagar posteriormente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbPagamento.Checked = false;
            }
        }

        private void dtFim_ValueChanged(object sender, EventArgs e)
        {
            if (dtFim.Value <= dtInicio.Value)
            {
                dtFim.Value = dtInicio.Value.AddDays(1);
                MessageBox.Show("A data de check-out deve ser maior que a data de check-in!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ConsultaQuartos(dtInicio.Value, dtFim.Value, null);
                ItensQuarto.DataSource = null;
                listaQuartos = new List<Quarto>();
                txtCustoDiaria.Text = "R$ 0,00";
                txtPreco.Text = "R$ 0,00";
            }
        }

        private void ConsultaQuartos(DateTime _inicio, DateTime _fim, List<Quarto> quartos)
        {
            if (_inicio >= DateTime.Now)
            {
                Quarto quarto = new Quarto();
                string inicio = _inicio.ToString("yyyy-MM-dd");
                string fim = _fim.ToString("yyyy-MM-dd");
                inicio += " 14:00:00";
                fim += " 12:00:00";
                cbQuartos.ValueMember = "idQuarto";
                cbQuartos.DisplayMember = "Descricao";
                cbQuartos.DataSource = quarto.ListarQuartosDisponiveis(inicio, fim, index.funcionario.IDHotel, quartos);
                int diarias = Convert.ToInt32((dtFim.Value - dtInicio.Value).TotalDays);
                txtDiarias.Text = diarias.ToString();

            }
            else
            {
                MessageBox.Show("Insira uma data de check-in válida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Quarto quarto = new Quarto();
            quarto.idQuarto = Convert.ToInt32(cbQuartos.SelectedValue);
            quarto.ConsultaObjeto(quarto);
            listaQuartos.Add(quarto);
            ItensQuarto.DataSource = null;
            ItensQuarto.DataSource = listaQuartos;
            foreach (DataGridViewRow row in ItensQuarto.Rows)
            {
                ItensQuarto[2, row.Index].Value = (ItensQuarto[3, row.Index].Value != null) ? Convert.ToDouble(ItensQuarto[3, row.Index].Value).ToString("C") : null;
            }
            ConsultaQuartos(dtInicio.Value, dtFim.Value, listaQuartos);
            double custoDiaria = 0.0;
            int diarias = Convert.ToInt32((dtFim.Value - dtInicio.Value).TotalDays);
            foreach (Quarto qt in listaQuartos)
            {
                custoDiaria += qt.Preco;
            }
            txtDiarias.Text = diarias.ToString();
            txtCustoDiaria.Text = custoDiaria.ToString("C");
            txtPreco.Text = (custoDiaria * diarias).ToString("C");

        }

        private void UCCadastroEst_Load(object sender, EventArgs e)
        {
            dtInicio.Value = DateTime.Now.AddMinutes(10);
        }

        private void cbPagamento_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPagamento.Checked && dtInicio.Value.Date == DateTime.Now.Date)
            {
                MessageBox.Show("A reserva atual tem como data de check-in o dia de hoje, portanto não é possivel pagar posteriormente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbPagamento.Checked = false;
            }
        }
    }
}
