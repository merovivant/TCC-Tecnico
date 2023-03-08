using CosmosHotel;
using System;
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
    public partial class Login : Form
    {
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (this.ClientRectangle.Width > 0 && this.ClientRectangle.Height > 0)
            {
                System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml("#205E9C");
                System.Drawing.Color color2 = System.Drawing.ColorTranslator.FromHtml("#102F4E");
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

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario(txtCPF.Text.Replace(".", null).Replace("-", null), txtSenha.Text);
            var (validacao, msg, hotel, cargo) = funcionario.ValidaLogin();
            if (validacao)
            {
                funcionario.IDHotel = hotel;
                funcionario.Cargo = cargo;
                this.Hide();
                Index form = new Index(funcionario);
                form.ShowDialog();
                
            }else
            {
                lblAviso.Text = msg;
                lblAviso.Visible = true;
            }

        }
        // Estabelecer a posição e controle do formulário

        Point DragCursor;
        Point DragForm;
        bool Dragging;

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = txtCPF.Text;
            if (e.KeyChar == (char)8) {
                string lastchar = text[text.Length - 1].ToString();
                if (lastchar == "." || lastchar == "-")
                {
                    txtCPF.Text = text.Substring(0, text.Length - 1);
                }
            } else if(!(char.IsDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            if(text.Length == 14)
            {
                if (!(char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }
        Boolean p1 = true, p2 = true, p3 = true;
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            string text = txtCPF.Text;
            int cont = text.Length;
            if (cont == 3 && p1)
            {
                txtCPF.Text += ".";
                p1 = false;
            }
            else if (cont == 7 && p2)
            {
                txtCPF.Text += ".";
                p2 = false;
            }
            else if (cont == 11 && p3)
            { 
                txtCPF.Text += "-";
                p3 = false;
            } else if (cont == 10)
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
            txtCPF.SelectionStart = txtCPF.Text.Length + 1;
        }
    }
}
