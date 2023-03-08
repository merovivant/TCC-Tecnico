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
    public partial class UCConsultaEst : UserControl
    {
        Index index;

        public UCConsultaEst(Index _index)
        {
            InitializeComponent();
            this.index = _index;
            Estadas.AutoGenerateColumns = false;
            dgQuartos.AutoGenerateColumns = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtCPF.Text.Replace("-", null).Replace(".", null), "CPF");
            Listar(cliente);
        }
        public void LeitorCartao_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (index.ucpri.Ativo == this)
            {
                Cliente cliente = new Cliente(index.CartaoLido, "idCartao");
                txtCPF.Text = cliente.CPF;
                Listar(cliente);
            }
        }
        private void Listar(Cliente cliente)
        {
            if (cliente.Nome != null)
            {
                txtCPF.Text = Convert.ToUInt64(cliente.CPF).ToString(@"000\.000\.000\-00");
                Estada estada = new Estada(cliente.CPF);
                DataTable dt = estada.ListarObjetos(estada);
                dt.Columns.Add("Preco2");
                foreach (DataRow row in dt.Rows)
                {
                    row["Preco2"] = (row["Preco"] != null) ? Convert.ToDouble(row["Preco"]).ToString("C") : null;
                }
                Estadas.DataSource = dt;
            }
        }

        private void Estadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                List<Quarto> quartos = new List<Quarto>();
                EstadaQuarto estadaQuarto = new EstadaQuarto();
                estadaQuarto.idEstada = Convert.ToInt32(Estadas[0, e.RowIndex].Value);
                DataTable dt = new DataTable();
                dt = estadaQuarto.ListarObjetos(estadaQuarto);
                foreach(DataRow row in dt.Rows)
                {
                    Quarto quarto = new Quarto(Convert.ToInt32(row["idQuarto"]));
                    quartos.Add(quarto);
                }
                dgQuartos.DataSource = quartos;                
                Estadas.Visible = false;
                dgQuartos.Visible = true;
                btnVoltar.Visible = true;
                foreach(DataGridViewRow row in dgQuartos.Rows)
                {
                    if (dgQuartos[1, row.Index].Value != null) {
                        dgQuartos[0, row.Index].Value = estadaQuarto.idEstada;
                        dgQuartos[3, row.Index].Value = Convert.ToDouble(dgQuartos[4, row.Index].Value).ToString("C");
                    }
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Estadas.Visible = true;
            dgQuartos.Visible = false;
            btnVoltar.Visible = false;
        }
    }
}
