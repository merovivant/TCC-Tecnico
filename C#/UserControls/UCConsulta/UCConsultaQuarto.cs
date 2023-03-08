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
    public partial class UCConsultaQuarto : UserControl
    {
        Index index;
        Quarto quarto;
        string chavepesquisa;

        public UCConsultaQuarto(Index _index)
        {
            InitializeComponent();
            this.index = _index;
            quarto = new Quarto();
            DataTable dt = new DataTable();
            ItensQuarto.AutoGenerateColumns = false;
            quarto.idHotel = index.funcionario.IDHotel;
            dt = quarto.ListarObjetos(quarto);
            dt.Columns.Add("Preco2");
            foreach (DataRow row in dt.Rows)
            {
                row["Preco2"] = (row["Preco"] != null) ? Convert.ToDouble(row["Preco"]).ToString("C") : null;
            }
            ItensQuarto.DataSource = dt;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Quarto qt = new Quarto();
            if (txtBusca.Text != "")
            {
                DataTable dt = new DataTable();
                if (rbCapacidade.Checked)
                {
                    chavepesquisa = "Capacidade";
                    qt.Capacidade = Convert.ToInt32(txtBusca.Text.Trim());
                    qt.idHotel = index.funcionario.IDHotel;
                    dt = qt.ListarObjetos(qt);

                }
                else if (rbNumeroQuarto.Checked)
                {
                    chavepesquisa = "Número";
                    qt.idHotel = index.funcionario.IDHotel;
                    dt = qt.ListarObjetos(qt);
                }
                else if (rbIdQuarto.Checked)
                {
                    chavepesquisa = "idQuarto";
                    qt.idQuarto = Convert.ToInt32(txtBusca.Text.Trim());
                    qt.idHotel = index.funcionario.IDHotel;
                    dt = qt.ListarObjetos(qt);
                }
                dt.Columns.Add("Preco2");
                foreach (DataRow row in dt.Rows)
                {
                    row["Preco2"] = (row["Preco"] != null) ? Convert.ToDouble(row["Preco"]).ToString("C") : null;
                }
                ItensQuarto.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Insira um dado válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Quarto limpaquarto = new Quarto();
            quarto = limpaquarto;
            quarto.idHotel = index.funcionario.IDHotel;
            DataTable dt = new DataTable();
            dt = quarto.ListarObjetos(quarto);
            dt.Columns.Add("Preco2");
            foreach (DataRow row in dt.Rows)
            {
                row["Preco2"] = (row["Preco"] != null) ? Convert.ToDouble(row["Preco"]).ToString("C") : null;
            }
            ItensQuarto.DataSource = dt;
        }

        private void rbIdQuarto_Click(object sender, EventArgs e)
        {
            txtBusca.PlaceholderText = "Insira o ID desejado";
        }

        private void rbCapacidade_Click(object sender, EventArgs e)
        {
            txtBusca.PlaceholderText = "Insira a capacidade desejada";
        }

        private void rbNumeroQuarto_Click(object sender, EventArgs e)
        {
            txtBusca.PlaceholderText = "Insira o n° do quarto desejado";
        }
    }
}
