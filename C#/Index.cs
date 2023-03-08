using System;
using CosmosHotel;
using CosmosHotel.UserControls;
using CosmosHotel.UserControls.UCConsulta;
using CosmosHotel.UserControls.UCCadastro;
using CosmosHotel.UserControls.UCModifica;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmosHotel
{
    public partial class Index : Form
    {
        public UCPrincipal ucpri;
        public Funcionario funcionario;
        public UCCadastroCli ucCadastroCliente;
        UCCadastroEst ucCadastroEstada;
        UCCadastroPed ucCadastroPedido;
        UCCadastroQuarto ucCadastroQuarto;
        public UCCadastroProd ucCadastroProduto;
        UCCadastroEvento ucCadastroEvento;
        UCCadastroFunc ucCadastroFuncionario;
        public UCConsultaCli ucConsultaCliente;
        UCConsultaEst ucConsultaEstada;
        UCConsultaPed ucConsultaPedido;
        UCConsultaQuarto ucConsultaQuarto;
        public UCConsultaProd ucConsultaProduto;
        UCConsultaEvento ucConsultaEvento;
        UCConsultaFunc ucConsultaFuncionario;
        UCModificaCli ucModificaCliente;
        UCModificaEst ucModificaEstada;
        UCModificaPed ucModificaPedido;
        UCModificaQuarto ucModificaQuarto;
        public UCModificaProd ucModificaProduto;
        UCModificaEvento ucModificaEvento;
        UCModificaFunc ucModificaFuncionario;
        UCHome uchome = new UCHome();
        public string CartaoLido = null;

        public Index(Funcionario funcionario)
        {
            this.funcionario = funcionario;
            InitializeComponent();
            if(funcionario.Cargo == "Recepcionista")
            {
                btnFuncionario.Visible = false;
            }
            else if(funcionario.Cargo == "Gerente")
            {
                btnFuncionario.Visible = true;

            }
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.ucpri = new UserControls.UCPrincipal(this);

            ucCadastroCliente = new UCCadastroCli(this);
            ucConsultaCliente = new UCConsultaCli(this);
            ucModificaCliente = new UCModificaCli(this);

            ucCadastroEstada = new UCCadastroEst(this);
            ucConsultaEstada = new UCConsultaEst(this);
            ucModificaEstada = new UCModificaEst(this);

            ucCadastroProduto = new UCCadastroProd(this);
            ucConsultaProduto = new UCConsultaProd(this);
            ucModificaProduto = new UCModificaProd(this);

            ucCadastroFuncionario = new UCCadastroFunc(this);
            ucConsultaFuncionario = new UCConsultaFunc(this);
            ucModificaFuncionario = new UCModificaFunc(this);

            ucCadastroQuarto = new UCCadastroQuarto(this);
            ucConsultaQuarto = new UCConsultaQuarto(this);
            ucModificaQuarto = new UCModificaQuarto(this);

            ucCadastroPedido = new UCCadastroPed(this);
            ucConsultaPedido = new UCConsultaPed(this);
            ucModificaPedido = new UCModificaPed(this);

            ucCadastroEvento = new UCCadastroEvento(this);
            ucConsultaEvento = new UCConsultaEvento(this);
            ucModificaEvento = new UCModificaEvento(this);


            this.LeitorCartao.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.LeitorCartao_DataReceived);
            this.LeitorCartao.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(ucCadastroCliente.LeitorCartao_DataReceived);
            this.LeitorCartao.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(ucConsultaCliente.LeitorCartao_DataReceived);
            this.LeitorCartao.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(ucModificaCliente.LeitorCartao_DataReceived);
            this.LeitorCartao.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(ucCadastroEstada.LeitorCartao_DataReceived);
            this.LeitorCartao.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(ucConsultaEstada.LeitorCartao_DataReceived);
            this.LeitorCartao.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(ucModificaEstada.LeitorCartao_DataReceived);
            this.LeitorCartao.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(ucCadastroPedido.LeitorCartao_DataReceived);
            this.LeitorCartao.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(ucConsultaPedido.LeitorCartao_DataReceived);

            try
            {
                LeitorCartao.Open();
            }
            catch {
                MessageBox.Show("Nenhum leitor de cartão identificado!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (this.ClientRectangle.Width > 0 && this.ClientRectangle.Height > 0)
            {
                System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml("#205E9C");
                System.Drawing.Color color2 = System.Drawing.ColorTranslator.FromHtml("#194877");
                using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       color,
                                                                       color2,
                                                                       90F))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            }
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );


        // Estabelecer a posição e controle do formulário
        Point DragCursor;
        Point DragForm;
        bool Dragging;

        private void Index_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void Index_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void Index_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(ucpri);
            ucpri.MudaUserControl(ucCadastroCliente, ucConsultaCliente, ucModificaCliente);
            detalhe.Visible = true;
            detalhe2.Visible = true;
        }

        private void btnEstada_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(ucpri);
            ucpri.MudaUserControl(ucCadastroEstada, ucConsultaEstada, ucModificaEstada);
            detalhe.Visible = true;
            detalhe2.Visible = true;
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(ucpri);
            ucpri.MudaUserControl(ucCadastroPedido, ucConsultaPedido, ucModificaPedido);
            detalhe.Visible = true;
            detalhe2.Visible = true;
        }

        private void btnQuarto_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(ucpri);
            ucpri.MudaUserControl(ucCadastroQuarto, ucConsultaQuarto, ucModificaQuarto);
            detalhe.Visible = true;
            detalhe2.Visible = true;
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(ucpri);
            ucpri.MudaUserControl(ucCadastroProduto, ucConsultaProduto, ucModificaProduto);
            detalhe.Visible = true;
            detalhe2.Visible = true;
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(ucpri);
            ucpri.MudaUserControl(ucCadastroEvento, ucConsultaEvento, ucModificaEvento);
            detalhe.Visible = true;
            detalhe2.Visible = true;
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(ucpri);
            ucpri.MudaUserControl(ucCadastroFuncionario, ucConsultaFuncionario, ucModificaFuncionario);
            detalhe.Visible = true;
            detalhe2.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(uchome);
            detalhe.Visible = false;
            detalhe2.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {   
            DialogResult dr = MessageBox.Show("Tem certeza que deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes){
                if (LeitorCartao.IsOpen)
                {
                    LeitorCartao.Close();
                }
                Application.Exit();
            }

        }

        public void LeitorCartao_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            CartaoLido = LeitorCartao.ReadExisting().Trim();
        }

        Boolean p1 = true, p2 = true, p3 = true;
        public string MascaraCPF(string _text)
        {
            int cont = _text.Length;
            if (cont == 3 && p1)
            {
                _text += ".";
                p1 = false;
            }
            else if (cont == 7 && p2)
            {
                _text += ".";
                p2 = false;
            }
            else if (cont == 11 && p3)
            {
                _text += "-";
                p3 = false;
            }
            else if (cont == 10)
            {
                p3 = true;
            }
            else if (cont == 6)
            {
                p2 = true;
            }
            else if (cont == 2)
            {
                p1 = true;
            }
            return _text;
        }
    }
}
