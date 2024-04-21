namespace ERP.Forms.Clientes
{
    partial class frmCadCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadCliente));
            grpDados = new GroupBox();
            lblNumeroCodigo = new Label();
            lblCodigoCliente = new Label();
            btnCarregarFoto = new Button();
            picFotoCliente = new PictureBox();
            lblUF = new Label();
            cboUF = new ComboBox();
            lblTelefone = new Label();
            lblCFPCnpj = new Label();
            lblNumero = new Label();
            lblLogradouro = new Label();
            lblBairro = new Label();
            lblCidade = new Label();
            lblNome = new Label();
            txtFone = new TextBox();
            txtCNPJCPF = new TextBox();
            txtNro = new TextBox();
            txtLogradouro = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtNome = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            grpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoCliente).BeginInit();
            SuspendLayout();
            // 
            // grpDados
            // 
            grpDados.Controls.Add(lblNumeroCodigo);
            grpDados.Controls.Add(lblCodigoCliente);
            grpDados.Controls.Add(btnCarregarFoto);
            grpDados.Controls.Add(picFotoCliente);
            grpDados.Controls.Add(lblUF);
            grpDados.Controls.Add(cboUF);
            grpDados.Controls.Add(lblTelefone);
            grpDados.Controls.Add(lblCFPCnpj);
            grpDados.Controls.Add(lblNumero);
            grpDados.Controls.Add(lblLogradouro);
            grpDados.Controls.Add(lblBairro);
            grpDados.Controls.Add(lblCidade);
            grpDados.Controls.Add(lblNome);
            grpDados.Controls.Add(txtFone);
            grpDados.Controls.Add(txtCNPJCPF);
            grpDados.Controls.Add(txtNro);
            grpDados.Controls.Add(txtLogradouro);
            grpDados.Controls.Add(txtBairro);
            grpDados.Controls.Add(txtCidade);
            grpDados.Controls.Add(txtNome);
            grpDados.Location = new Point(12, 2);
            grpDados.Name = "grpDados";
            grpDados.Size = new Size(321, 459);
            grpDados.TabIndex = 0;
            grpDados.TabStop = false;
            grpDados.Text = "Dados";
            // 
            // lblNumeroCodigo
            // 
            lblNumeroCodigo.AutoSize = true;
            lblNumeroCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumeroCodigo.Location = new Point(63, 19);
            lblNumeroCodigo.Name = "lblNumeroCodigo";
            lblNumeroCodigo.Size = new Size(66, 15);
            lblNumeroCodigo.TabIndex = 19;
            lblNumeroCodigo.Text = "NroCodigo";
            // 
            // lblCodigoCliente
            // 
            lblCodigoCliente.AutoSize = true;
            lblCodigoCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodigoCliente.Location = new Point(9, 19);
            lblCodigoCliente.Name = "lblCodigoCliente";
            lblCodigoCliente.Size = new Size(49, 15);
            lblCodigoCliente.TabIndex = 18;
            lblCodigoCliente.Text = "Código:";
            // 
            // btnCarregarFoto
            // 
            btnCarregarFoto.Location = new Point(114, 186);
            btnCarregarFoto.Name = "btnCarregarFoto";
            btnCarregarFoto.Size = new Size(88, 26);
            btnCarregarFoto.TabIndex = 17;
            btnCarregarFoto.Text = "Carregar foto";
            btnCarregarFoto.UseVisualStyleBackColor = true;
            btnCarregarFoto.Click += btnCarregarFoto_Click;
            // 
            // picFotoCliente
            // 
            picFotoCliente.Image = (Image)resources.GetObject("picFotoCliente.Image");
            picFotoCliente.Location = new Point(79, 37);
            picFotoCliente.Name = "picFotoCliente";
            picFotoCliente.Size = new Size(162, 143);
            picFotoCliente.SizeMode = PictureBoxSizeMode.StretchImage;
            picFotoCliente.TabIndex = 16;
            picFotoCliente.TabStop = false;
            picFotoCliente.Click += picFotoCliente_Click;
            // 
            // lblUF
            // 
            lblUF.AutoSize = true;
            lblUF.Location = new Point(264, 306);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(21, 15);
            lblUF.TabIndex = 15;
            lblUF.Text = "UF";
            // 
            // cboUF
            // 
            cboUF.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUF.FormattingEnabled = true;
            cboUF.Location = new Point(264, 327);
            cboUF.Name = "cboUF";
            cboUF.Size = new Size(48, 23);
            cboUF.TabIndex = 14;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(3, 397);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 13;
            lblTelefone.Text = "Telefone:";
            // 
            // lblCFPCnpj
            // 
            lblCFPCnpj.AutoSize = true;
            lblCFPCnpj.Location = new Point(3, 353);
            lblCFPCnpj.Name = "lblCFPCnpj";
            lblCFPCnpj.Size = new Size(31, 15);
            lblCFPCnpj.TabIndex = 12;
            lblCFPCnpj.Text = "CPF:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(187, 309);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 11;
            lblNumero.Text = "Número:";
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(6, 309);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(72, 15);
            lblLogradouro.TabIndex = 10;
            lblLogradouro.Text = "Logradouro:";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(212, 262);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(41, 15);
            lblBairro.TabIndex = 9;
            lblBairro.Text = "Bairro:";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(6, 262);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(47, 15);
            lblCidade.TabIndex = 8;
            lblCidade.Text = "Cidade:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(6, 214);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome:";
            // 
            // txtFone
            // 
            txtFone.Location = new Point(3, 415);
            txtFone.Name = "txtFone";
            txtFone.Size = new Size(158, 23);
            txtFone.TabIndex = 6;
            // 
            // txtCNPJCPF
            // 
            txtCNPJCPF.Location = new Point(3, 368);
            txtCNPJCPF.Name = "txtCNPJCPF";
            txtCNPJCPF.Size = new Size(158, 23);
            txtCNPJCPF.TabIndex = 5;
            // 
            // txtNro
            // 
            txtNro.Location = new Point(187, 327);
            txtNro.Name = "txtNro";
            txtNro.Size = new Size(66, 23);
            txtNro.TabIndex = 4;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(3, 327);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(178, 23);
            txtLogradouro.TabIndex = 3;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(167, 280);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(145, 23);
            txtBairro.TabIndex = 2;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(3, 280);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(158, 23);
            txtCidade.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(3, 236);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(309, 23);
            txtNome.TabIndex = 0;
            // 
            // btnGravar
            // 
            btnGravar.Image = (Image)resources.GetObject("btnGravar.Image");
            btnGravar.Location = new Point(262, 467);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(71, 42);
            btnGravar.TabIndex = 1;
            btnGravar.TextAlign = ContentAlignment.BottomCenter;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(18, 467);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(71, 42);
            btnCancelar.TabIndex = 2;
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Image = (Image)resources.GetObject("btnAlterar.Image");
            btnAlterar.Location = new Point(179, 467);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(71, 42);
            btnAlterar.TabIndex = 3;
            btnAlterar.TextAlign = ContentAlignment.BottomCenter;
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.Location = new Point(97, 466);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(71, 42);
            btnExcluir.TabIndex = 4;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // frmCadCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 521);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(grpDados);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadCliente";
            Text = "Detalhe Cliente";
            Load += frmCadCliente_Load;
            grpDados.ResumeLayout(false);
            grpDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDados;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtNome;
        private TextBox txtCNPJCPF;
        private TextBox txtNro;
        private TextBox txtLogradouro;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private Button btnAlterar;
        private Label lblUF;
        private ComboBox cboUF;
        private Label lblTelefone;
        private Label lblCFPCnpj;
        private Label lblNumero;
        private Label lblLogradouro;
        private Label lblBairro;
        private Label lblCidade;
        private Label lblNome;
        private PictureBox picFotoCliente;
        private Button btnCarregarFoto;
        private TextBox txtFone;
        private Label lblCodigoCliente;
        private Label lblNumeroCodigo;
        private Button btnExcluir;
    }
}