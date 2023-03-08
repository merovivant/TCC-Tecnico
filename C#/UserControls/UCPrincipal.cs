using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CosmosHotel.UserControls.UCConsulta;
using CosmosHotel.UserControls.UCCadastro;
using CosmosHotel.UserControls.UCModifica;

namespace CosmosHotel.UserControls
{
    public partial class UCPrincipal : UserControl
    {
        Index index = null;
        System.Windows.Forms.Control Cadastra;
        System.Windows.Forms.Control Consulta;
        System.Windows.Forms.Control Modifica;
        public System.Windows.Forms.Control Ativo;

        public UCPrincipal(Index index)
        {
            InitializeComponent();
            this.index = index;
        }

        public void MudaUserControl(System.Windows.Forms.Control _cadastra, System.Windows.Forms.Control _consulta, System.Windows.Forms.Control _modifica)
        {
            this.Cadastra = _cadastra;
            this.Consulta = _consulta;
            this.Modifica = _modifica;
            mainpanel.Controls.Clear();
            Ativo = Cadastra;
            mainpanel.Controls.Add(Ativo);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Ativo = Cadastra;
            mainpanel.Controls.Add(Ativo);
        }


        private void btnConsulta_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Ativo = Consulta;
            mainpanel.Controls.Add(Ativo);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Ativo = Modifica;
            mainpanel.Controls.Add(Ativo);
        }

        private void UCPrincipal_Load(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Ativo = Cadastra;
            mainpanel.Controls.Add(Ativo);
        }

        private void mainpanel_ControlAdded(object sender, ControlEventArgs e)
        {
            if (index.ucpri.Ativo == index.ucCadastroCliente)
            {
                if (index.LeitorCartao.IsOpen)
                {
                    index.LeitorCartao.Close();
                }
            }
            else
            {
                try
                {
                    if (!index.LeitorCartao.IsOpen)
                    {
                        index.LeitorCartao.Open();
                    }
                }
                catch
                {

                }
            }
        }
    }
}
