
namespace CosmosHotel.UserControls.UCCadastro
{
    partial class UCCadastroEst
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCadastroEst));
            this.txtCPF = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCadastro = new Guna.UI2.WinForms.Guna2Button();
            this.dtInicio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtFim = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPreco = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbQuartos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPreco = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ItensQuarto = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idQuarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoInt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroQuarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtDiarias = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDiarias = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCustoDiaria = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCustoDiaria = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbPagamento = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ItensQuarto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCPF
            // 
            this.txtCPF.BorderRadius = 15;
            this.txtCPF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCPF.DefaultText = "";
            this.txtCPF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCPF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCPF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCPF.DisabledState.Parent = this.txtCPF;
            this.txtCPF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCPF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCPF.FocusedState.Parent = this.txtCPF;
            this.txtCPF.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtCPF.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCPF.HoverState.Parent = this.txtCPF;
            this.txtCPF.Location = new System.Drawing.Point(389, 202);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.PasswordChar = '\0';
            this.txtCPF.PlaceholderText = "Insira o CPF ou aproxime o cartão";
            this.txtCPF.SelectedText = "";
            this.txtCPF.ShadowDecoration.Parent = this.txtCPF;
            this.txtCPF.Size = new System.Drawing.Size(301, 38);
            this.txtCPF.TabIndex = 15;
            this.txtCPF.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(72)))), ((int)(((byte)(119)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(74, 34);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(355, 48);
            this.guna2HtmlLabel1.TabIndex = 14;
            this.guna2HtmlLabel1.Text = "Cadastro de Estada";
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
            this.btnCadastro.Location = new System.Drawing.Point(528, 457);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.ShadowDecoration.Parent = this.btnCadastro;
            this.btnCadastro.Size = new System.Drawing.Size(180, 45);
            this.btnCadastro.TabIndex = 12;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
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
            this.dtInicio.Location = new System.Drawing.Point(65, 129);
            this.dtInicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtInicio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.ShadowDecoration.Parent = this.dtInicio;
            this.dtInicio.Size = new System.Drawing.Size(301, 36);
            this.dtInicio.TabIndex = 25;
            this.dtInicio.Value = new System.DateTime(2021, 8, 24, 13, 39, 7, 79);
            this.dtInicio.ValueChanged += new System.EventHandler(this.dtInicio_ValueChanged);
            // 
            // dtFim
            // 
            this.dtFim.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtFim.BorderRadius = 15;
            this.dtFim.BorderThickness = 1;
            this.dtFim.Checked = true;
            this.dtFim.CheckedState.Parent = this.dtFim;
            this.dtFim.FillColor = System.Drawing.Color.White;
            this.dtFim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtFim.HoverState.Parent = this.dtFim;
            this.dtFim.Location = new System.Drawing.Point(389, 129);
            this.dtFim.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtFim.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtFim.Name = "dtFim";
            this.dtFim.ShadowDecoration.Parent = this.dtFim;
            this.dtFim.Size = new System.Drawing.Size(301, 36);
            this.dtFim.TabIndex = 26;
            this.dtFim.Value = new System.DateTime(2021, 8, 24, 13, 39, 7, 79);
            this.dtFim.ValueChanged += new System.EventHandler(this.dtFim_ValueChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(87, 102);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(105, 21);
            this.guna2HtmlLabel2.TabIndex = 27;
            this.guna2HtmlLabel2.Text = "Data de início:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(413, 102);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(91, 21);
            this.guna2HtmlLabel3.TabIndex = 28;
            this.guna2HtmlLabel3.Text = "Data de fim:";
            // 
            // lblPreco
            // 
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblPreco.Location = new System.Drawing.Point(214, 464);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(84, 21);
            this.lblPreco.TabIndex = 30;
            this.lblPreco.Text = "Preço total:";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(27, 18);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(60, 21);
            this.guna2HtmlLabel4.TabIndex = 33;
            this.guna2HtmlLabel4.Text = "Incluso:";
            // 
            // cbQuartos
            // 
            this.cbQuartos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbQuartos.BackColor = System.Drawing.Color.Transparent;
            this.cbQuartos.BorderRadius = 15;
            this.cbQuartos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbQuartos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbQuartos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuartos.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbQuartos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbQuartos.FocusedState.Parent = this.cbQuartos;
            this.cbQuartos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbQuartos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbQuartos.HoverState.Parent = this.cbQuartos;
            this.cbQuartos.ItemHeight = 30;
            this.cbQuartos.ItemsAppearance.Parent = this.cbQuartos;
            this.cbQuartos.Location = new System.Drawing.Point(65, 204);
            this.cbQuartos.Name = "cbQuartos";
            this.cbQuartos.ShadowDecoration.Parent = this.cbQuartos;
            this.cbQuartos.Size = new System.Drawing.Size(262, 36);
            this.cbQuartos.TabIndex = 60;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(87, 177);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(148, 21);
            this.guna2HtmlLabel5.TabIndex = 61;
            this.guna2HtmlLabel5.Text = "Quartos disponíveis:";
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.Transparent;
            this.txtPreco.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtPreco.Location = new System.Drawing.Point(302, 464);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(65, 21);
            this.txtPreco.TabIndex = 62;
            this.txtPreco.Text = "R$: 0,00";
            // 
            // ItensQuarto
            // 
            this.ItensQuarto.AllowUserToAddRows = false;
            this.ItensQuarto.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(208)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ItensQuarto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ItensQuarto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItensQuarto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ItensQuarto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItensQuarto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ItensQuarto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(72)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(72)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItensQuarto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ItensQuarto.ColumnHeadersHeight = 30;
            this.ItensQuarto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idQuarto,
            this.Capacidade,
            this.Preco,
            this.PrecoInt,
            this.NumeroQuarto});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(208)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItensQuarto.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItensQuarto.EnableHeadersVisualStyles = false;
            this.ItensQuarto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItensQuarto.Location = new System.Drawing.Point(125, 250);
            this.ItensQuarto.Name = "ItensQuarto";
            this.ItensQuarto.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItensQuarto.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ItensQuarto.RowHeadersVisible = false;
            this.ItensQuarto.RowHeadersWidth = 50;
            this.ItensQuarto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItensQuarto.Size = new System.Drawing.Size(493, 185);
            this.ItensQuarto.TabIndex = 63;
            this.ItensQuarto.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ItensQuarto.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItensQuarto.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ItensQuarto.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(208)))), ((int)(((byte)(223)))));
            this.ItensQuarto.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ItensQuarto.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.ItensQuarto.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItensQuarto.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(72)))), ((int)(((byte)(119)))));
            this.ItensQuarto.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ItensQuarto.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ItensQuarto.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ItensQuarto.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ItensQuarto.ThemeStyle.HeaderStyle.Height = 30;
            this.ItensQuarto.ThemeStyle.ReadOnly = true;
            this.ItensQuarto.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ItensQuarto.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ItensQuarto.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ItensQuarto.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ItensQuarto.ThemeStyle.RowsStyle.Height = 22;
            this.ItensQuarto.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(208)))), ((int)(((byte)(223)))));
            this.ItensQuarto.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idQuarto
            // 
            this.idQuarto.DataPropertyName = "idQuarto";
            this.idQuarto.HeaderText = "Código";
            this.idQuarto.Name = "idQuarto";
            this.idQuarto.ReadOnly = true;
            // 
            // Capacidade
            // 
            this.Capacidade.DataPropertyName = "Capacidade";
            this.Capacidade.HeaderText = "Capacidade";
            this.Capacidade.Name = "Capacidade";
            this.Capacidade.ReadOnly = true;
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // PrecoInt
            // 
            this.PrecoInt.DataPropertyName = "Preco";
            this.PrecoInt.HeaderText = "PrecoInt";
            this.PrecoInt.Name = "PrecoInt";
            this.PrecoInt.ReadOnly = true;
            this.PrecoInt.Visible = false;
            // 
            // NumeroQuarto
            // 
            this.NumeroQuarto.DataPropertyName = "Número";
            this.NumeroQuarto.HeaderText = "Número";
            this.NumeroQuarto.Name = "NumeroQuarto";
            this.NumeroQuarto.ReadOnly = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAdicionar.CheckedState.Parent = this.btnAdicionar;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAdicionar.HoverState.Parent = this.btnAdicionar;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAdicionar.ImageRotate = 0F;
            this.btnAdicionar.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAdicionar.Location = new System.Drawing.Point(326, 202);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAdicionar.PressedState.Parent = this.btnAdicionar;
            this.btnAdicionar.ShadowDecoration.Parent = this.btnAdicionar;
            this.btnAdicionar.Size = new System.Drawing.Size(39, 39);
            this.btnAdicionar.TabIndex = 64;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtDiarias
            // 
            this.txtDiarias.BackColor = System.Drawing.Color.Transparent;
            this.txtDiarias.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiarias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtDiarias.Location = new System.Drawing.Point(123, 441);
            this.txtDiarias.Name = "txtDiarias";
            this.txtDiarias.Size = new System.Drawing.Size(12, 21);
            this.txtDiarias.TabIndex = 66;
            this.txtDiarias.Text = "0";
            // 
            // lblDiarias
            // 
            this.lblDiarias.BackColor = System.Drawing.Color.Transparent;
            this.lblDiarias.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiarias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblDiarias.Location = new System.Drawing.Point(63, 441);
            this.lblDiarias.Name = "lblDiarias";
            this.lblDiarias.Size = new System.Drawing.Size(57, 21);
            this.lblDiarias.TabIndex = 65;
            this.lblDiarias.Text = "Diárias:";
            // 
            // txtCustoDiaria
            // 
            this.txtCustoDiaria.BackColor = System.Drawing.Color.Transparent;
            this.txtCustoDiaria.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoDiaria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtCustoDiaria.Location = new System.Drawing.Point(311, 441);
            this.txtCustoDiaria.Name = "txtCustoDiaria";
            this.txtCustoDiaria.Size = new System.Drawing.Size(65, 21);
            this.txtCustoDiaria.TabIndex = 68;
            this.txtCustoDiaria.Text = "R$: 0,00";
            // 
            // lblCustoDiaria
            // 
            this.lblCustoDiaria.BackColor = System.Drawing.Color.Transparent;
            this.lblCustoDiaria.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoDiaria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblCustoDiaria.Location = new System.Drawing.Point(214, 441);
            this.lblCustoDiaria.Name = "lblCustoDiaria";
            this.lblCustoDiaria.Size = new System.Drawing.Size(94, 21);
            this.lblCustoDiaria.TabIndex = 67;
            this.lblCustoDiaria.Text = "Custo diário:";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(413, 177);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(57, 21);
            this.guna2HtmlLabel6.TabIndex = 69;
            this.guna2HtmlLabel6.Text = "Cliente:";
            // 
            // cbPagamento
            // 
            this.cbPagamento.AutoSize = true;
            this.cbPagamento.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPagamento.CheckedState.BorderRadius = 0;
            this.cbPagamento.CheckedState.BorderThickness = 0;
            this.cbPagamento.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPagamento.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbPagamento.Location = new System.Drawing.Point(62, 464);
            this.cbPagamento.Name = "cbPagamento";
            this.cbPagamento.Size = new System.Drawing.Size(141, 23);
            this.cbPagamento.TabIndex = 71;
            this.cbPagamento.Text = "Pagar no chekin";
            this.cbPagamento.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbPagamento.UncheckedState.BorderRadius = 0;
            this.cbPagamento.UncheckedState.BorderThickness = 2;
            this.cbPagamento.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbPagamento.CheckedChanged += new System.EventHandler(this.cbPagamento_CheckedChanged);
            // 
            // UCCadastroEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.cbPagamento);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.txtCustoDiaria);
            this.Controls.Add(this.lblCustoDiaria);
            this.Controls.Add(this.txtDiarias);
            this.Controls.Add(this.lblDiarias);
            this.Controls.Add(this.ItensQuarto);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.cbQuartos);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "UCCadastroEst";
            this.Size = new System.Drawing.Size(748, 560);
            this.Load += new System.EventHandler(this.UCCadastroEst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItensQuarto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtCPF;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnCadastro;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtInicio;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtFim;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPreco;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox cbQuartos;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtPreco;
        private Guna.UI2.WinForms.Guna2DataGridView ItensQuarto;
        private Guna.UI2.WinForms.Guna2ImageButton btnAdicionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idQuarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoInt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroQuarto;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtDiarias;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDiarias;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtCustoDiaria;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCustoDiaria;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2CheckBox cbPagamento;
    }
}
