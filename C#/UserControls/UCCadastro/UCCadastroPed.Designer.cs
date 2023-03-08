
namespace CosmosHotel.UserControls.UCCadastro
{
    partial class UCCadastroPed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCadastroPed));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbProduto = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblProduto = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnFinalizar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbServico = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblServico = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAdicionarProduto = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnAdicionarServico = new Guna.UI2.WinForms.Guna2ImageButton();
            this.dtCarrinho = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeProduto = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.panelAviso = new Guna.UI2.WinForms.Guna2Panel();
            this.lblErro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnComprar = new Guna.UI2.WinForms.Guna2Button();
            this.txtTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrecoPedido = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCPF = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFechar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtdeProduto)).BeginInit();
            this.panelAviso.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbProduto
            // 
            this.cbProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProduto.BackColor = System.Drawing.Color.Transparent;
            this.cbProduto.BorderRadius = 15;
            this.cbProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbProduto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduto.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbProduto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbProduto.FocusedState.Parent = this.cbProduto;
            this.cbProduto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbProduto.HoverState.Parent = this.cbProduto;
            this.cbProduto.ItemHeight = 30;
            this.cbProduto.ItemsAppearance.Parent = this.cbProduto;
            this.cbProduto.Location = new System.Drawing.Point(231, 139);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.ShadowDecoration.Parent = this.cbProduto;
            this.cbProduto.Size = new System.Drawing.Size(195, 36);
            this.cbProduto.TabIndex = 47;
            // 
            // lblProduto
            // 
            this.lblProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblProduto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblProduto.Location = new System.Drawing.Point(160, 145);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(65, 21);
            this.lblProduto.TabIndex = 46;
            this.lblProduto.Text = "Produto:";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BorderRadius = 15;
            this.btnFinalizar.CheckedState.Parent = this.btnFinalizar;
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.CustomImages.Parent = this.btnFinalizar;
            this.btnFinalizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFinalizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFinalizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinalizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFinalizar.DisabledState.Parent = this.btnFinalizar;
            this.btnFinalizar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
            this.btnFinalizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.HoverState.Parent = this.btnFinalizar;
            this.btnFinalizar.Location = new System.Drawing.Point(467, 495);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.ShadowDecoration.Parent = this.btnFinalizar;
            this.btnFinalizar.Size = new System.Drawing.Size(180, 45);
            this.btnFinalizar.TabIndex = 44;
            this.btnFinalizar.Text = "Finalizar Pedido";
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(72)))), ((int)(((byte)(119)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(78, 71);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(415, 48);
            this.guna2HtmlLabel1.TabIndex = 41;
            this.guna2HtmlLabel1.Text = "Informações do Pedido";
            // 
            // cbServico
            // 
            this.cbServico.BackColor = System.Drawing.Color.Transparent;
            this.cbServico.BorderRadius = 15;
            this.cbServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbServico.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServico.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbServico.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbServico.FocusedState.Parent = this.cbServico;
            this.cbServico.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbServico.HoverState.Parent = this.cbServico;
            this.cbServico.ItemHeight = 30;
            this.cbServico.ItemsAppearance.Parent = this.cbServico;
            this.cbServico.Location = new System.Drawing.Point(231, 194);
            this.cbServico.Name = "cbServico";
            this.cbServico.ShadowDecoration.Parent = this.cbServico;
            this.cbServico.Size = new System.Drawing.Size(262, 36);
            this.cbServico.TabIndex = 49;
            // 
            // lblServico
            // 
            this.lblServico.BackColor = System.Drawing.Color.Transparent;
            this.lblServico.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblServico.Location = new System.Drawing.Point(160, 200);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(60, 21);
            this.lblServico.TabIndex = 48;
            this.lblServico.Text = "Serviço:";
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarProduto.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAdicionarProduto.CheckedState.Parent = this.btnAdicionarProduto;
            this.btnAdicionarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarProduto.HoverState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnAdicionarProduto.HoverState.Parent = this.btnAdicionarProduto;
            this.btnAdicionarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarProduto.Image")));
            this.btnAdicionarProduto.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAdicionarProduto.ImageRotate = 0F;
            this.btnAdicionarProduto.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdicionarProduto.Location = new System.Drawing.Point(499, 145);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnAdicionarProduto.PressedState.Parent = this.btnAdicionarProduto;
            this.btnAdicionarProduto.ShadowDecoration.Parent = this.btnAdicionarProduto;
            this.btnAdicionarProduto.Size = new System.Drawing.Size(31, 23);
            this.btnAdicionarProduto.TabIndex = 50;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // btnAdicionarServico
            // 
            this.btnAdicionarServico.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarServico.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAdicionarServico.CheckedState.Parent = this.btnAdicionarServico;
            this.btnAdicionarServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarServico.HoverState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnAdicionarServico.HoverState.Parent = this.btnAdicionarServico;
            this.btnAdicionarServico.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarServico.Image")));
            this.btnAdicionarServico.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAdicionarServico.ImageRotate = 0F;
            this.btnAdicionarServico.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdicionarServico.Location = new System.Drawing.Point(499, 198);
            this.btnAdicionarServico.Name = "btnAdicionarServico";
            this.btnAdicionarServico.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnAdicionarServico.PressedState.Parent = this.btnAdicionarServico;
            this.btnAdicionarServico.ShadowDecoration.Parent = this.btnAdicionarServico;
            this.btnAdicionarServico.Size = new System.Drawing.Size(31, 23);
            this.btnAdicionarServico.TabIndex = 51;
            this.btnAdicionarServico.Click += new System.EventHandler(this.btnAdicionarServico_Click);
            // 
            // dtCarrinho
            // 
            this.dtCarrinho.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(208)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtCarrinho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dtCarrinho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCarrinho.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtCarrinho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtCarrinho.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtCarrinho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(72)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(72)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtCarrinho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dtCarrinho.ColumnHeadersHeight = 30;
            this.dtCarrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Descricao,
            this.Subtotal,
            this.Quantidade,
            this.idItem});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(208)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtCarrinho.DefaultCellStyle = dataGridViewCellStyle19;
            this.dtCarrinho.EnableHeadersVisualStyles = false;
            this.dtCarrinho.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtCarrinho.Location = new System.Drawing.Point(89, 254);
            this.dtCarrinho.Name = "dtCarrinho";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtCarrinho.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dtCarrinho.RowHeadersVisible = false;
            this.dtCarrinho.RowHeadersWidth = 50;
            this.dtCarrinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtCarrinho.Size = new System.Drawing.Size(558, 225);
            this.dtCarrinho.TabIndex = 58;
            this.dtCarrinho.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtCarrinho.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCarrinho.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dtCarrinho.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(208)))), ((int)(((byte)(223)))));
            this.dtCarrinho.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtCarrinho.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dtCarrinho.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtCarrinho.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(72)))), ((int)(((byte)(119)))));
            this.dtCarrinho.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtCarrinho.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtCarrinho.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtCarrinho.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtCarrinho.ThemeStyle.HeaderStyle.Height = 30;
            this.dtCarrinho.ThemeStyle.ReadOnly = false;
            this.dtCarrinho.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtCarrinho.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtCarrinho.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtCarrinho.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtCarrinho.ThemeStyle.RowsStyle.Height = 22;
            this.dtCarrinho.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(208)))), ((int)(((byte)(223)))));
            this.dtCarrinho.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtCarrinho.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCarrinho_CellValueChanged);
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // idItem
            // 
            this.idItem.HeaderText = "Código";
            this.idItem.Name = "idItem";
            // 
            // qtdeProduto
            // 
            this.qtdeProduto.BackColor = System.Drawing.Color.Transparent;
            this.qtdeProduto.BorderRadius = 15;
            this.qtdeProduto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qtdeProduto.DisabledState.Parent = this.qtdeProduto;
            this.qtdeProduto.FocusedState.Parent = this.qtdeProduto;
            this.qtdeProduto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.qtdeProduto.ForeColor = System.Drawing.Color.Black;
            this.qtdeProduto.Location = new System.Drawing.Point(432, 139);
            this.qtdeProduto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtdeProduto.Name = "qtdeProduto";
            this.qtdeProduto.ShadowDecoration.Parent = this.qtdeProduto;
            this.qtdeProduto.Size = new System.Drawing.Size(61, 36);
            this.qtdeProduto.TabIndex = 59;
            this.qtdeProduto.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.qtdeProduto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelAviso
            // 
            this.panelAviso.BackColor = System.Drawing.Color.White;
            this.panelAviso.Controls.Add(this.lblErro);
            this.panelAviso.Controls.Add(this.btnComprar);
            this.panelAviso.Controls.Add(this.txtTotal);
            this.panelAviso.Controls.Add(this.lblPrecoPedido);
            this.panelAviso.Controls.Add(this.txtCPF);
            this.panelAviso.Controls.Add(this.btnFechar);
            this.panelAviso.Controls.Add(this.guna2HtmlLabel3);
            this.panelAviso.Location = new System.Drawing.Point(197, 169);
            this.panelAviso.Name = "panelAviso";
            this.panelAviso.ShadowDecoration.Parent = this.panelAviso;
            this.panelAviso.Size = new System.Drawing.Size(315, 214);
            this.panelAviso.TabIndex = 60;
            this.panelAviso.Visible = false;
            // 
            // lblErro
            // 
            this.lblErro.BackColor = System.Drawing.Color.Transparent;
            this.lblErro.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblErro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblErro.Location = new System.Drawing.Point(35, 140);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(3, 2);
            this.lblErro.TabIndex = 50;
            this.lblErro.Text = null;
            // 
            // btnComprar
            // 
            this.btnComprar.BorderRadius = 15;
            this.btnComprar.CheckedState.Parent = this.btnComprar;
            this.btnComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprar.CustomImages.Parent = this.btnComprar;
            this.btnComprar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComprar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComprar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComprar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComprar.DisabledState.Parent = this.btnComprar;
            this.btnComprar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
            this.btnComprar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.HoverState.Parent = this.btnComprar;
            this.btnComprar.Location = new System.Drawing.Point(180, 162);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.ShadowDecoration.Parent = this.btnComprar;
            this.btnComprar.Size = new System.Drawing.Size(113, 39);
            this.btnComprar.TabIndex = 49;
            this.btnComprar.Text = "Efetuar compra";
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Transparent;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtTotal.Location = new System.Drawing.Point(83, 68);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(59, 21);
            this.txtTotal.TabIndex = 48;
            this.txtTotal.Text = "R$ 0,00";
            // 
            // lblPrecoPedido
            // 
            this.lblPrecoPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecoPedido.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblPrecoPedido.Location = new System.Drawing.Point(35, 68);
            this.lblPrecoPedido.Name = "lblPrecoPedido";
            this.lblPrecoPedido.Size = new System.Drawing.Size(45, 21);
            this.lblPrecoPedido.TabIndex = 47;
            this.lblPrecoPedido.Text = "Total:";
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
            this.txtCPF.Location = new System.Drawing.Point(16, 90);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.PasswordChar = '\0';
            this.txtCPF.PlaceholderText = "Insira o CPF ou aproxime o cartão";
            this.txtCPF.SelectedText = "";
            this.txtCPF.ShadowDecoration.Parent = this.txtCPF;
            this.txtCPF.Size = new System.Drawing.Size(259, 45);
            this.txtCPF.TabIndex = 31;
            this.txtCPF.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnFechar.CheckedState.Parent = this.btnFechar;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.HoverState.ImageSize = new System.Drawing.Size(21, 21);
            this.btnFechar.HoverState.Parent = this.btnFechar;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnFechar.ImageRotate = 0F;
            this.btnFechar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFechar.Location = new System.Drawing.Point(263, 7);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.PressedState.ImageSize = new System.Drawing.Size(21, 21);
            this.btnFechar.PressedState.Parent = this.btnFechar;
            this.btnFechar.ShadowDecoration.Parent = this.btnFechar;
            this.btnFechar.Size = new System.Drawing.Size(50, 38);
            this.btnFechar.TabIndex = 30;
            this.btnFechar.UseTransparentBackground = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(3, 2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(309, 47);
            this.guna2HtmlLabel3.TabIndex = 29;
            this.guna2HtmlLabel3.Text = "Confirmar Pedido";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCCadastroPed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.panelAviso);
            this.Controls.Add(this.qtdeProduto);
            this.Controls.Add(this.dtCarrinho);
            this.Controls.Add(this.btnAdicionarServico);
            this.Controls.Add(this.cbServico);
            this.Controls.Add(this.lblServico);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Name = "UCCadastroPed";
            this.Size = new System.Drawing.Size(748, 560);
            this.Load += new System.EventHandler(this.UCCadastroPed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtdeProduto)).EndInit();
            this.panelAviso.ResumeLayout(false);
            this.panelAviso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbProduto;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProduto;
        private Guna.UI2.WinForms.Guna2Button btnFinalizar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbServico;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblServico;
        private Guna.UI2.WinForms.Guna2ImageButton btnAdicionarProduto;
        private Guna.UI2.WinForms.Guna2ImageButton btnAdicionarServico;
        private Guna.UI2.WinForms.Guna2DataGridView dtCarrinho;
        private Guna.UI2.WinForms.Guna2NumericUpDown qtdeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItem;
        private Guna.UI2.WinForms.Guna2Panel panelAviso;
        private Guna.UI2.WinForms.Guna2ImageButton btnFechar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblErro;
        private Guna.UI2.WinForms.Guna2Button btnComprar;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrecoPedido;
        private Guna.UI2.WinForms.Guna2TextBox txtCPF;
    }
}
