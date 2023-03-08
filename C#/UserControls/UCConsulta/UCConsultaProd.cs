using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmosHotel.UserControls.UCConsulta
{
    public partial class UCConsultaProd : UserControl
    {
        Index index;
        ProdutoDAL prod = new ProdutoDAL();
        ServicoDAL serv = new ServicoDAL();

        public UCConsultaProd(Index _index)
        {
            InitializeComponent();
            this.index = _index;
            ItensGrid.DataSource = prod.ListarGrid(index.funcionario.IDHotel);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rbProduto.Checked)
            {
                ItensGrid.DataSource = prod.Consulta(txtDescricao.Text.Trim(), index.funcionario.IDHotel);
            }
            else if(rbServico.Checked)
            {
                ItensGrid.DataSource = serv.Consulta(txtDescricao.Text.Trim(), index.funcionario.IDHotel);
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = "";
            if (rbProduto.Checked)
            {
                ItensGrid.DataSource = prod.ListarGrid(index.funcionario.IDHotel);
            }
            else if (rbServico.Checked)
            {
                ItensGrid.DataSource = serv.ListarGrid(index.funcionario.IDHotel);
            }
        }

        private void rbProduto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProduto.Checked)
            {
                ItensGrid.DataSource = prod.Consulta(txtDescricao.Text.Trim(), index.funcionario.IDHotel);
            }
            else if(rbServico.Checked)
            {
                ItensGrid.DataSource = serv.Consulta(txtDescricao.Text.Trim(), index.funcionario.IDHotel);
            }
        }
    }
}
