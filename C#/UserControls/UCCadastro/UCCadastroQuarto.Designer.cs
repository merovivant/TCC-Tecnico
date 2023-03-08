
namespace CosmosHotel.UserControls.UCCadastro
{
    partial class UCCadastroQuarto
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCadastroQuarto));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCadastro = new Guna.UI2.WinForms.Guna2Button();
            this.pnDados = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtNumero = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPreco = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCapacidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(72)))), ((int)(((byte)(119)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(78, 71);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(353, 48);
            this.guna2HtmlLabel1.TabIndex = 14;
            this.guna2HtmlLabel1.Text = "Cadastro de Quarto";
            // 
            // btnCadastro
            // 
            this.btnCadastro.BorderRadius = 15;
            this.btnCadastro.CheckedState.Parent = this.btnCadastro;
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastro.CustomImages.Parent = this.btnCadastro;
            this.btnCadastro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadastro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadastro.DisabledState.Parent = this.btnCadastro;
            this.btnCadastro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
            this.btnCadastro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.HoverState.Parent = this.btnCadastro;
            this.btnCadastro.Location = new System.Drawing.Point(525, 450);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.ShadowDecoration.Parent = this.btnCadastro;
            this.btnCadastro.Size = new System.Drawing.Size(180, 45);
            this.btnCadastro.TabIndex = 12;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // pnDados
            // 
            this.pnDados.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.pnDados.BorderRadius = 15;
            this.pnDados.BorderThickness = 1;
            this.pnDados.Controls.Add(this.guna2PictureBox1);
            this.pnDados.Controls.Add(this.txtNumero);
            this.pnDados.Controls.Add(this.txtPreco);
            this.pnDados.Controls.Add(this.txtCapacidade);
            this.pnDados.Location = new System.Drawing.Point(38, 148);
            this.pnDados.Name = "pnDados";
            this.pnDados.ShadowDecoration.Parent = this.pnDados;
            this.pnDados.Size = new System.Drawing.Size(667, 266);
            this.pnDados.TabIndex = 53;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(48, 33);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(300, 200);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 59;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // txtNumero
            // 
            this.txtNumero.BorderRadius = 15;
            this.txtNumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumero.DefaultText = "";
            this.txtNumero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumero.DisabledState.Parent = this.txtNumero;
            this.txtNumero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumero.FocusedState.Parent = this.txtNumero;
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtNumero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumero.HoverState.Parent = this.txtNumero;
            this.txtNumero.Location = new System.Drawing.Point(393, 108);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.PlaceholderText = "Insira o número";
            this.txtNumero.SelectedText = "";
            this.txtNumero.ShadowDecoration.Parent = this.txtNumero;
            this.txtNumero.Size = new System.Drawing.Size(198, 45);
            this.txtNumero.TabIndex = 58;
            this.txtNumero.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtPreco
            // 
            this.txtPreco.BorderRadius = 15;
            this.txtPreco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPreco.DefaultText = "";
            this.txtPreco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPreco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPreco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPreco.DisabledState.Parent = this.txtPreco;
            this.txtPreco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPreco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPreco.FocusedState.Parent = this.txtPreco;
            this.txtPreco.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPreco.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPreco.HoverState.Parent = this.txtPreco;
            this.txtPreco.Location = new System.Drawing.Point(393, 188);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.PasswordChar = '\0';
            this.txtPreco.PlaceholderText = "Insira o preço";
            this.txtPreco.SelectedText = "";
            this.txtPreco.ShadowDecoration.Parent = this.txtPreco;
            this.txtPreco.Size = new System.Drawing.Size(198, 45);
            this.txtPreco.TabIndex = 57;
            this.txtPreco.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtCapacidade
            // 
            this.txtCapacidade.BorderRadius = 15;
            this.txtCapacidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCapacidade.DefaultText = "";
            this.txtCapacidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCapacidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCapacidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCapacidade.DisabledState.Parent = this.txtCapacidade;
            this.txtCapacidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCapacidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCapacidade.FocusedState.Parent = this.txtCapacidade;
            this.txtCapacidade.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtCapacidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCapacidade.HoverState.Parent = this.txtCapacidade;
            this.txtCapacidade.Location = new System.Drawing.Point(393, 33);
            this.txtCapacidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.PasswordChar = '\0';
            this.txtCapacidade.PlaceholderText = "Insira a capacidade";
            this.txtCapacidade.SelectedText = "";
            this.txtCapacidade.ShadowDecoration.Parent = this.txtCapacidade;
            this.txtCapacidade.Size = new System.Drawing.Size(198, 45);
            this.txtCapacidade.TabIndex = 56;
            this.txtCapacidade.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // UCCadastroQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.pnDados);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnCadastro);
            this.Name = "UCCadastroQuarto";
            this.Size = new System.Drawing.Size(748, 560);
            this.pnDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnCadastro;
        private Guna.UI2.WinForms.Guna2Panel pnDados;
        private Guna.UI2.WinForms.Guna2TextBox txtNumero;
        private Guna.UI2.WinForms.Guna2TextBox txtPreco;
        private Guna.UI2.WinForms.Guna2TextBox txtCapacidade;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
