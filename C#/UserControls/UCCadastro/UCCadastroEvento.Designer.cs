
namespace CosmosHotel.UserControls.UCCadastro
{
    partial class UCCadastroEvento
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCadastro = new Guna.UI2.WinForms.Guna2Button();
            this.txtLocal = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrecoEvent = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescEvento = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbPublico = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtInicio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(72)))), ((int)(((byte)(119)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(91, 59);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(355, 48);
            this.guna2HtmlLabel1.TabIndex = 14;
            this.guna2HtmlLabel1.Text = "Cadastro de Evento";
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
            this.btnCadastro.Location = new System.Drawing.Point(502, 388);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.ShadowDecoration.Parent = this.btnCadastro;
            this.btnCadastro.Size = new System.Drawing.Size(180, 45);
            this.btnCadastro.TabIndex = 12;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // txtLocal
            // 
            this.txtLocal.BorderRadius = 15;
            this.txtLocal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocal.DefaultText = "";
            this.txtLocal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLocal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLocal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocal.DisabledState.Parent = this.txtLocal;
            this.txtLocal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocal.FocusedState.Parent = this.txtLocal;
            this.txtLocal.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtLocal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocal.HoverState.Parent = this.txtLocal;
            this.txtLocal.Location = new System.Drawing.Point(442, 184);
            this.txtLocal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.PasswordChar = '\0';
            this.txtLocal.PlaceholderText = "Insira a localização";
            this.txtLocal.SelectedText = "";
            this.txtLocal.ShadowDecoration.Parent = this.txtLocal;
            this.txtLocal.Size = new System.Drawing.Size(240, 45);
            this.txtLocal.TabIndex = 24;
            this.txtLocal.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtNome
            // 
            this.txtNome.BorderRadius = 15;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.DefaultText = "";
            this.txtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.DisabledState.Parent = this.txtNome;
            this.txtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.FocusedState.Parent = this.txtNome;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.HoverState.Parent = this.txtNome;
            this.txtNome.Location = new System.Drawing.Point(65, 184);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PlaceholderText = "Insira o nome";
            this.txtNome.SelectedText = "";
            this.txtNome.ShadowDecoration.Parent = this.txtNome;
            this.txtNome.Size = new System.Drawing.Size(363, 45);
            this.txtNome.TabIndex = 23;
            this.txtNome.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtPrecoEvent
            // 
            this.txtPrecoEvent.BorderRadius = 15;
            this.txtPrecoEvent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecoEvent.DefaultText = "";
            this.txtPrecoEvent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecoEvent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecoEvent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecoEvent.DisabledState.Parent = this.txtPrecoEvent;
            this.txtPrecoEvent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecoEvent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecoEvent.FocusedState.Parent = this.txtPrecoEvent;
            this.txtPrecoEvent.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPrecoEvent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecoEvent.HoverState.Parent = this.txtPrecoEvent;
            this.txtPrecoEvent.Location = new System.Drawing.Point(442, 237);
            this.txtPrecoEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecoEvent.Name = "txtPrecoEvent";
            this.txtPrecoEvent.PasswordChar = '\0';
            this.txtPrecoEvent.PlaceholderText = "Insira o preço";
            this.txtPrecoEvent.SelectedText = "";
            this.txtPrecoEvent.ShadowDecoration.Parent = this.txtPrecoEvent;
            this.txtPrecoEvent.Size = new System.Drawing.Size(240, 45);
            this.txtPrecoEvent.TabIndex = 26;
            this.txtPrecoEvent.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtDescEvento
            // 
            this.txtDescEvento.BorderRadius = 15;
            this.txtDescEvento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescEvento.DefaultText = "";
            this.txtDescEvento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescEvento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescEvento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescEvento.DisabledState.Parent = this.txtDescEvento;
            this.txtDescEvento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescEvento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescEvento.FocusedState.Parent = this.txtDescEvento;
            this.txtDescEvento.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtDescEvento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescEvento.HoverState.Parent = this.txtDescEvento;
            this.txtDescEvento.Location = new System.Drawing.Point(65, 237);
            this.txtDescEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescEvento.Name = "txtDescEvento";
            this.txtDescEvento.PasswordChar = '\0';
            this.txtDescEvento.PlaceholderText = "Insira uma descrição";
            this.txtDescEvento.SelectedText = "";
            this.txtDescEvento.ShadowDecoration.Parent = this.txtDescEvento;
            this.txtDescEvento.Size = new System.Drawing.Size(363, 45);
            this.txtDescEvento.TabIndex = 25;
            this.txtDescEvento.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // cbPublico
            // 
            this.cbPublico.BackColor = System.Drawing.Color.Transparent;
            this.cbPublico.BorderRadius = 15;
            this.cbPublico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPublico.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPublico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPublico.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPublico.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPublico.FocusedState.Parent = this.cbPublico;
            this.cbPublico.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPublico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPublico.HoverState.Parent = this.cbPublico;
            this.cbPublico.ItemHeight = 30;
            this.cbPublico.Items.AddRange(new object[] {
            "Livre",
            "Maior de 14",
            "Maior de 16",
            "Maior de 18"});
            this.cbPublico.ItemsAppearance.Parent = this.cbPublico;
            this.cbPublico.Location = new System.Drawing.Point(412, 328);
            this.cbPublico.Name = "cbPublico";
            this.cbPublico.ShadowDecoration.Parent = this.cbPublico;
            this.cbPublico.Size = new System.Drawing.Size(240, 36);
            this.cbPublico.TabIndex = 29;
            // 
            // dtInicio
            // 
            this.dtInicio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtInicio.BorderRadius = 15;
            this.dtInicio.BorderThickness = 1;
            this.dtInicio.Checked = true;
            this.dtInicio.CheckedState.Parent = this.dtInicio;
            this.dtInicio.FillColor = System.Drawing.Color.White;
            this.dtInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtInicio.HoverState.Parent = this.dtInicio;
            this.dtInicio.Location = new System.Drawing.Point(87, 328);
            this.dtInicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtInicio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.ShadowDecoration.Parent = this.dtInicio;
            this.dtInicio.Size = new System.Drawing.Size(281, 36);
            this.dtInicio.TabIndex = 30;
            this.dtInicio.Value = new System.DateTime(2021, 8, 24, 14, 22, 25, 736);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(110, 301);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(105, 21);
            this.guna2HtmlLabel2.TabIndex = 33;
            this.guna2HtmlLabel2.Text = "Data de início:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(430, 301);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(60, 21);
            this.guna2HtmlLabel3.TabIndex = 34;
            this.guna2HtmlLabel3.Text = "Público:";
            // 
            // UCCadastroServ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.cbPublico);
            this.Controls.Add(this.txtPrecoEvent);
            this.Controls.Add(this.txtDescEvento);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnCadastro);
            this.Name = "UCCadastroServ";
            this.Size = new System.Drawing.Size(748, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnCadastro;
        private Guna.UI2.WinForms.Guna2TextBox txtLocal;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecoEvent;
        private Guna.UI2.WinForms.Guna2TextBox txtDescEvento;
        private Guna.UI2.WinForms.Guna2ComboBox cbPublico;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtInicio;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}
