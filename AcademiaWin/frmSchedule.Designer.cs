namespace AcademiaWin
{
    partial class frmSchedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchedule));
            this.pnlAgenda = new System.Windows.Forms.Panel();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.lblComentario = new System.Windows.Forms.Label();
            this.lblProprietario = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtProprietario = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.grwContatos = new System.Windows.Forms.DataGridView();
            this.lblAbaAtual = new System.Windows.Forms.Label();
            this.bdsContacts = new System.Windows.Forms.BindingSource(this.components);
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.pnlAcao = new System.Windows.Forms.Panel();
            this.lblTextBox3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblTextBox2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblTextBox1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_contatos = new System.Windows.Forms.Button();
            this.btn_lembretes = new System.Windows.Forms.Button();
            this.btn_eventos = new System.Windows.Forms.Button();
            this.pnlAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grwContatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsContacts)).BeginInit();
            this.pnlBotoes.SuspendLayout();
            this.pnlAcao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAgenda
            // 
            this.pnlAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAgenda.Controls.Add(this.btnAgenda);
            this.pnlAgenda.Controls.Add(this.lblComentario);
            this.pnlAgenda.Controls.Add(this.lblProprietario);
            this.pnlAgenda.Controls.Add(this.lblTitulo);
            this.pnlAgenda.Controls.Add(this.txtComentario);
            this.pnlAgenda.Controls.Add(this.txtProprietario);
            this.pnlAgenda.Controls.Add(this.txtTitulo);
            this.pnlAgenda.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAgenda.Location = new System.Drawing.Point(114, 5);
            this.pnlAgenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAgenda.Name = "pnlAgenda";
            this.pnlAgenda.Size = new System.Drawing.Size(814, 103);
            this.pnlAgenda.TabIndex = 2;
            // 
            // btnAgenda
            // 
            this.btnAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgenda.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda.Image = ((System.Drawing.Image)(resources.GetObject("btnAgenda.Image")));
            this.btnAgenda.Location = new System.Drawing.Point(773, 24);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(34, 26);
            this.btnAgenda.TabIndex = 10;
            this.btnAgenda.Tag = "0";
            this.btnAgenda.UseVisualStyleBackColor = false;
            // 
            // lblComentario
            // 
            this.lblComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.Location = new System.Drawing.Point(501, 55);
            this.lblComentario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(310, 15);
            this.lblComentario.TabIndex = 7;
            this.lblComentario.Text = "Comentário";
            // 
            // lblProprietario
            // 
            this.lblProprietario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProprietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProprietario.Location = new System.Drawing.Point(12, 55);
            this.lblProprietario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProprietario.Name = "lblProprietario";
            this.lblProprietario.Size = new System.Drawing.Size(481, 15);
            this.lblProprietario.TabIndex = 6;
            this.lblProprietario.Text = "Proprietário";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 5);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(788, 15);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Título";
            // 
            // txtComentario
            // 
            this.txtComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComentario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.Location = new System.Drawing.Point(501, 75);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(310, 25);
            this.txtComentario.TabIndex = 4;
            // 
            // txtProprietario
            // 
            this.txtProprietario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProprietario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProprietario.Location = new System.Drawing.Point(12, 75);
            this.txtProprietario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProprietario.Name = "txtProprietario";
            this.txtProprietario.Size = new System.Drawing.Size(481, 25);
            this.txtProprietario.TabIndex = 3;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(12, 25);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(758, 25);
            this.txtTitulo.TabIndex = 2;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogo.BackgroundImage")));
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Location = new System.Drawing.Point(5, 5);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(107, 103);
            this.pnlLogo.TabIndex = 3;
            // 
            // grwContatos
            // 
            this.grwContatos.AllowUserToOrderColumns = true;
            this.grwContatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grwContatos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grwContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grwContatos.GridColor = System.Drawing.SystemColors.Menu;
            this.grwContatos.Location = new System.Drawing.Point(5, 165);
            this.grwContatos.Margin = new System.Windows.Forms.Padding(0);
            this.grwContatos.MultiSelect = false;
            this.grwContatos.Name = "grwContatos";
            this.grwContatos.ReadOnly = true;
            this.grwContatos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grwContatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grwContatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grwContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grwContatos.Size = new System.Drawing.Size(923, 361);
            this.grwContatos.TabIndex = 15;
            // 
            // lblAbaAtual
            // 
            this.lblAbaAtual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAbaAtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(113)))));
            this.lblAbaAtual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAbaAtual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbaAtual.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblAbaAtual.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblAbaAtual.Location = new System.Drawing.Point(2, 143);
            this.lblAbaAtual.Margin = new System.Windows.Forms.Padding(1);
            this.lblAbaAtual.Name = "lblAbaAtual";
            this.lblAbaAtual.Size = new System.Drawing.Size(923, 21);
            this.lblAbaAtual.TabIndex = 16;
            this.lblAbaAtual.Text = "Contatos";
            this.lblAbaAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBotoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(113)))));
            this.pnlBotoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Controls.Add(this.btnRemover);
            this.pnlBotoes.Controls.Add(this.btnAlterar);
            this.pnlBotoes.Controls.Add(this.btnInserir);
            this.pnlBotoes.Location = new System.Drawing.Point(4, 530);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(921, 36);
            this.pnlBotoes.TabIndex = 22;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(796, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 29);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(670, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 29);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(255, 3);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(120, 29);
            this.btnRemover.TabIndex = 24;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(129, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(120, 29);
            this.btnAlterar.TabIndex = 23;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.Control;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Location = new System.Drawing.Point(3, 3);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(120, 29);
            this.btnInserir.TabIndex = 22;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            // 
            // pnlAcao
            // 
            this.pnlAcao.Controls.Add(this.lblTextBox3);
            this.pnlAcao.Controls.Add(this.textBox3);
            this.pnlAcao.Controls.Add(this.lblTextBox2);
            this.pnlAcao.Controls.Add(this.textBox2);
            this.pnlAcao.Controls.Add(this.lblTextBox1);
            this.pnlAcao.Controls.Add(this.textBox1);
            this.pnlAcao.Location = new System.Drawing.Point(8, 469);
            this.pnlAcao.Name = "pnlAcao";
            this.pnlAcao.Size = new System.Drawing.Size(913, 55);
            this.pnlAcao.TabIndex = 23;
            // 
            // lblTextBox3
            // 
            this.lblTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextBox3.Location = new System.Drawing.Point(469, 5);
            this.lblTextBox3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextBox3.Name = "lblTextBox3";
            this.lblTextBox3.Size = new System.Drawing.Size(437, 15);
            this.lblTextBox3.TabIndex = 11;
            this.lblTextBox3.Text = "Endereço";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(469, 25);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(437, 25);
            this.textBox3.TabIndex = 10;
            // 
            // lblTextBox2
            // 
            this.lblTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextBox2.Location = new System.Drawing.Point(282, 5);
            this.lblTextBox2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextBox2.Name = "lblTextBox2";
            this.lblTextBox2.Size = new System.Drawing.Size(179, 15);
            this.lblTextBox2.TabIndex = 9;
            this.lblTextBox2.Text = "Fone";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(282, 25);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 25);
            this.textBox2.TabIndex = 8;
            // 
            // lblTextBox1
            // 
            this.lblTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextBox1.Location = new System.Drawing.Point(5, 5);
            this.lblTextBox1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextBox1.Name = "lblTextBox1";
            this.lblTextBox1.Size = new System.Drawing.Size(269, 15);
            this.lblTextBox1.TabIndex = 7;
            this.lblTextBox1.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(5, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 25);
            this.textBox1.TabIndex = 6;
            // 
            // btn_contatos
            // 
            this.btn_contatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contatos.Location = new System.Drawing.Point(16, 116);
            this.btn_contatos.Name = "btn_contatos";
            this.btn_contatos.Size = new System.Drawing.Size(75, 23);
            this.btn_contatos.TabIndex = 24;
            this.btn_contatos.Text = "Contatos";
            this.btn_contatos.UseVisualStyleBackColor = true;
            this.btn_contatos.Click += new System.EventHandler(this.btn_contatos_Click);
            // 
            // btn_lembretes
            // 
            this.btn_lembretes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lembretes.Location = new System.Drawing.Point(97, 116);
            this.btn_lembretes.Name = "btn_lembretes";
            this.btn_lembretes.Size = new System.Drawing.Size(75, 23);
            this.btn_lembretes.TabIndex = 25;
            this.btn_lembretes.Text = "Lembretes";
            this.btn_lembretes.UseVisualStyleBackColor = true;
            this.btn_lembretes.Click += new System.EventHandler(this.btn_lembretes_Click);
            // 
            // btn_eventos
            // 
            this.btn_eventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eventos.Location = new System.Drawing.Point(178, 116);
            this.btn_eventos.Name = "btn_eventos";
            this.btn_eventos.Size = new System.Drawing.Size(75, 23);
            this.btn_eventos.TabIndex = 26;
            this.btn_eventos.Text = "Eventos";
            this.btn_eventos.UseVisualStyleBackColor = true;
            this.btn_eventos.Click += new System.EventHandler(this.btn_eventos_Click);
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 581);
            this.Controls.Add(this.btn_eventos);
            this.Controls.Add(this.btn_lembretes);
            this.Controls.Add(this.btn_contatos);
            this.Controls.Add(this.pnlAcao);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.lblAbaAtual);
            this.Controls.Add(this.grwContatos);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlAgenda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academia PCD Avanade 2020";
            this.pnlAgenda.ResumeLayout(false);
            this.pnlAgenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grwContatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsContacts)).EndInit();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlAcao.ResumeLayout(false);
            this.pnlAcao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAgenda;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.TextBox txtProprietario;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.Label lblProprietario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.DataGridView grwContatos;
        private System.Windows.Forms.Label lblAbaAtual;
        private System.Windows.Forms.BindingSource bdsContacts;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Panel pnlAcao;
        private System.Windows.Forms.Label lblTextBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblTextBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_contatos;
        private System.Windows.Forms.Button btn_lembretes;
        private System.Windows.Forms.Button btn_eventos;
    }
}

