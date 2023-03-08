
namespace CosmosHotel.UserControls.UCConsulta
{
    partial class UCConsultaQuarto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCConsultaQuarto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPesquisar = new Guna.UI2.WinForms.Guna2Button();
            this.txtBusca = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ItensQuarto = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idQuarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroQuarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbNumeroQuarto = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbIdQuarto = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbCapacidade = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnAtualizar = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.ItensQuarto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BorderRadius = 20;
            this.btnPesquisar.CheckedState.Parent = this.btnPesquisar;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.CustomImages.Parent = this.btnPesquisar;
            this.btnPesquisar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPesquisar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPesquisar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPesquisar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPesquisar.DisabledState.Parent = this.btnPesquisar;
            this.btnPesquisar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.HoverState.Parent = this.btnPesquisar;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPesquisar.Location = new System.Drawing.Point(584, 137);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.ShadowDecoration.Parent = this.btnPesquisar;
            this.btnPesquisar.Size = new System.Drawing.Size(88, 45);
            this.btnPesquisar.TabIndex = 44;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.BorderRadius = 15;
            this.txtBusca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusca.DefaultText = "";
            this.txtBusca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusca.DisabledState.Parent = this.txtBusca;
            this.txtBusca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusca.FocusedState.Parent = this.txtBusca;
            this.txtBusca.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtBusca.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusca.HoverState.Parent = this.txtBusca;
            this.txtBusca.Location = new System.Drawing.Point(87, 137);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.PasswordChar = '\0';
            this.txtBusca.PlaceholderText = "Insira o código desejado";
            this.txtBusca.SelectedText = "";
            this.txtBusca.ShadowDecoration.Parent = this.txtBusca;
            this.txtBusca.Size = new System.Drawing.Size(259, 45);
            this.txtBusca.TabIndex = 41;
            this.txtBusca.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(72)))), ((int)(((byte)(119)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(87, 62);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(349, 48);
            this.guna2HtmlLabel1.TabIndex = 42;
            this.guna2HtmlLabel1.Text = "Consulta de Quarto";
            // 
            // ItensQuarto
            // 
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
            this.ItensQuarto.Location = new System.Drawing.Point(87, 206);
            this.ItensQuarto.Name = "ItensQuarto";
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
            this.ItensQuarto.Size = new System.Drawing.Size(585, 284);
            this.ItensQuarto.TabIndex = 56;
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
            this.ItensQuarto.ThemeStyle.ReadOnly = false;
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
            this.Preco.DataPropertyName = "Preco2";
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // NumeroQuarto
            // 
            this.NumeroQuarto.DataPropertyName = "Número";
            this.NumeroQuarto.HeaderText = "Número";
            this.NumeroQuarto.Name = "NumeroQuarto";
            this.NumeroQuarto.ReadOnly = true;
            // 
            // rbNumeroQuarto
            // 
            this.rbNumeroQuarto.AutoSize = true;
            this.rbNumeroQuarto.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbNumeroQuarto.CheckedState.BorderThickness = 0;
            this.rbNumeroQuarto.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbNumeroQuarto.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbNumeroQuarto.CheckedState.InnerOffset = -4;
            this.rbNumeroQuarto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNumeroQuarto.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rbNumeroQuarto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbNumeroQuarto.Location = new System.Drawing.Point(353, 159);
            this.rbNumeroQuarto.Name = "rbNumeroQuarto";
            this.rbNumeroQuarto.Size = new System.Drawing.Size(84, 23);
            this.rbNumeroQuarto.TabIndex = 67;
            this.rbNumeroQuarto.Text = "Número";
            this.rbNumeroQuarto.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbNumeroQuarto.UncheckedState.BorderThickness = 2;
            this.rbNumeroQuarto.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbNumeroQuarto.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbNumeroQuarto.Click += new System.EventHandler(this.rbNumeroQuarto_Click);
            // 
            // rbIdQuarto
            // 
            this.rbIdQuarto.AutoSize = true;
            this.rbIdQuarto.Checked = true;
            this.rbIdQuarto.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbIdQuarto.CheckedState.BorderThickness = 0;
            this.rbIdQuarto.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbIdQuarto.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbIdQuarto.CheckedState.InnerOffset = -4;
            this.rbIdQuarto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbIdQuarto.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rbIdQuarto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbIdQuarto.Location = new System.Drawing.Point(353, 137);
            this.rbIdQuarto.Name = "rbIdQuarto";
            this.rbIdQuarto.Size = new System.Drawing.Size(77, 23);
            this.rbIdQuarto.TabIndex = 66;
            this.rbIdQuarto.TabStop = true;
            this.rbIdQuarto.Text = "Código";
            this.rbIdQuarto.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbIdQuarto.UncheckedState.BorderThickness = 2;
            this.rbIdQuarto.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbIdQuarto.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbIdQuarto.Click += new System.EventHandler(this.rbIdQuarto_Click);
            // 
            // rbCapacidade
            // 
            this.rbCapacidade.AutoSize = true;
            this.rbCapacidade.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbCapacidade.CheckedState.BorderThickness = 0;
            this.rbCapacidade.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbCapacidade.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbCapacidade.CheckedState.InnerOffset = -4;
            this.rbCapacidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCapacidade.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rbCapacidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbCapacidade.Location = new System.Drawing.Point(436, 137);
            this.rbCapacidade.Name = "rbCapacidade";
            this.rbCapacidade.Size = new System.Drawing.Size(107, 23);
            this.rbCapacidade.TabIndex = 70;
            this.rbCapacidade.Text = "Capacidade";
            this.rbCapacidade.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbCapacidade.UncheckedState.BorderThickness = 2;
            this.rbCapacidade.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbCapacidade.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbCapacidade.Click += new System.EventHandler(this.rbCapacidade_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAtualizar.CheckedState.Parent = this.btnAtualizar;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAtualizar.HoverState.Parent = this.btnAtualizar;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAtualizar.ImageRotate = 0F;
            this.btnAtualizar.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAtualizar.Location = new System.Drawing.Point(661, 434);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAtualizar.PressedState.Parent = this.btnAtualizar;
            this.btnAtualizar.ShadowDecoration.Parent = this.btnAtualizar;
            this.btnAtualizar.Size = new System.Drawing.Size(65, 56);
            this.btnAtualizar.TabIndex = 71;
            this.btnAtualizar.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UCConsultaQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.rbCapacidade);
            this.Controls.Add(this.rbNumeroQuarto);
            this.Controls.Add(this.rbIdQuarto);
            this.Controls.Add(this.ItensQuarto);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnAtualizar);
            this.Name = "UCConsultaQuarto";
            this.Size = new System.Drawing.Size(748, 560);
            ((System.ComponentModel.ISupportInitialize)(this.ItensQuarto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnPesquisar;
        private Guna.UI2.WinForms.Guna2TextBox txtBusca;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView ItensQuarto;
        private Guna.UI2.WinForms.Guna2RadioButton rbNumeroQuarto;
        private Guna.UI2.WinForms.Guna2RadioButton rbIdQuarto;
        private Guna.UI2.WinForms.Guna2RadioButton rbCapacidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn idQuarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroQuarto;
        private Guna.UI2.WinForms.Guna2ImageButton btnAtualizar;
    }
}
