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
    public partial class UCConsultaFunc : UserControl
    {
        Index index;
        FuncionarioDAL func = new FuncionarioDAL();

        public UCConsultaFunc(Index _index)
        {
            InitializeComponent();
            this.index = _index;
            ItensFunc.DataSource = func.ListarGrid(index.funcionario.IDHotel);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ItensFunc.DataSource = func.Consulta(txtCPF.Text.Trim(), index);
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ItensFunc.DataSource = func.ListarGrid(index.funcionario.IDHotel);
        }
    }
}
