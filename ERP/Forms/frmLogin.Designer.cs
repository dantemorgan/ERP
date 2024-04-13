namespace ERP.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pctLogo = new PictureBox();
            fraLogin = new GroupBox();
            cboUser = new ComboBox();
            btnSair = new Button();
            btnEntrar = new Button();
            lblSenha = new Label();
            lblUser = new Label();
            txtSenha = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pctLogo).BeginInit();
            fraLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pctLogo
            // 
            pctLogo.Image = (Image)resources.GetObject("pctLogo.Image");
            pctLogo.Location = new Point(20, 12);
            pctLogo.Name = "pctLogo";
            pctLogo.Size = new Size(245, 219);
            pctLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pctLogo.TabIndex = 7;
            pctLogo.TabStop = false;
            // 
            // fraLogin
            // 
            fraLogin.Controls.Add(cboUser);
            fraLogin.Controls.Add(btnSair);
            fraLogin.Controls.Add(btnEntrar);
            fraLogin.Controls.Add(lblSenha);
            fraLogin.Controls.Add(lblUser);
            fraLogin.Controls.Add(txtSenha);
            fraLogin.Location = new Point(20, 237);
            fraLogin.Name = "fraLogin";
            fraLogin.Size = new Size(245, 162);
            fraLogin.TabIndex = 8;
            fraLogin.TabStop = false;
            fraLogin.Text = "Login";
            // 
            // cboUser
            // 
            cboUser.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboUser.FormattingEnabled = true;
            cboUser.Location = new Point(25, 41);
            cboUser.Name = "cboUser";
            cboUser.Size = new Size(195, 23);
            cboUser.TabIndex = 12;
            cboUser.Text = "Usuário";
            // 
            // btnSair
            // 
            btnSair.Location = new Point(26, 119);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(87, 26);
            btnSair.TabIndex = 11;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(119, 118);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(92, 28);
            btnEntrar.TabIndex = 10;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(26, 70);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 9;
            lblSenha.Text = "Senha:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(26, 23);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(50, 15);
            lblUser.TabIndex = 8;
            lblUser.Text = "Usuário:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(26, 89);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(194, 23);
            txtSenha.TabIndex = 7;
            txtSenha.Text = "280612";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 407);
            Controls.Add(pctLogo);
            Controls.Add(fraLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pctLogo).EndInit();
            fraLogin.ResumeLayout(false);
            fraLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pctLogo;
        private GroupBox fraLogin;
        private ComboBox cboUser;
        private Button btnSair;
        private Button btnEntrar;
        private Label lblSenha;
        private Label lblUser;
        private TextBox txtSenha;
    }
}