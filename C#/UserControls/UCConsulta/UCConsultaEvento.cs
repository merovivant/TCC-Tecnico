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
    public partial class UCConsultaEvento : UserControl
    {
        Index index;
        Evento evento;

        public UCConsultaEvento(Index _index)
        {
            InitializeComponent();
            index = _index;
            evento = new Evento(index.funcionario.IDHotel);
            EventoGrid.AutoGenerateColumns = false;
            Consulta();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            evento.Nome = "";
            Consulta();
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            Consulta();
        }

        private void Consulta()
        {
            evento.Nome = txtNome.Text.Trim();
            evento.idHotel = index.funcionario.IDHotel;
            DataTable dt = new DataTable();
            dt = evento.ListarObjetos(evento);
            dt.Columns.Add("Ingresso");
            dt.Columns.Add("Data");
            dt.Columns.Add("Hora");
            foreach (DataRow row in dt.Rows)
            {
                row["Ingresso"] = (row["Preco"] != null) ? $"{row["Preco"]:C}" : null;
                row["Data"] = (row["DataEvento"] != null) ? Convert.ToDateTime(row["DataEvento"]).ToString("dd/MM/yyyy") : null;
                row["Hora"] = (row["DataEvento"] != null) ? Convert.ToDateTime(row["DataEvento"]).ToString("HH:mm") : null;
            }
            EventoGrid.DataSource = dt;
        }
    }
}
