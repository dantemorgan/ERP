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
            txtSenha = new TextBox();
            lblUser = new Label();
            lblSenha = new Label();
            btnEntrar = new Button();
            btnSair = new Button();
            cboUser = new ComboBox();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(12, 141);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(285, 23);
            txtSenha.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(12, 65);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(50, 15);
            lblUser.TabIndex = 2;
            lblUser.Text = "Usuário:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(12, 123);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha:";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(204, 182);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(92, 28);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Login";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(111, 183);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(87, 26);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // cboUser
            // 
            cboUser.FormattingEnabled = true;
            cboUser.Location = new Point(12, 91);
            cboUser.Name = "cboUser";
            cboUser.Size = new Size(285, 23);
            cboUser.TabIndex = 6;
            cboUser.Text = "Usuário";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 222);
            Controls.Add(cboUser);
            Controls.Add(btnSair);
            Controls.Add(btnEntrar);
            Controls.Add(lblSenha);
            Controls.Add(lblUser);
            Controls.Add(txtSenha);
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSenha;
        private Label lblUser;
        private Label lblSenha;
        private Button btnEntrar;
        private Button btnSair;
        private ComboBox cboUser;
    }
}