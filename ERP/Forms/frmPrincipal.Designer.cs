namespace ERP.Forms
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            fraPrincipal = new Panel();
            btnPedidos = new Button();
            btnLogOut = new Button();
            btnUsuarios = new Button();
            btnProdutos = new Button();
            btnFornecedores = new Button();
            btnClientes = new Button();
            fraPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // fraPrincipal
            // 
            fraPrincipal.Controls.Add(btnPedidos);
            fraPrincipal.Controls.Add(btnLogOut);
            fraPrincipal.Controls.Add(btnUsuarios);
            fraPrincipal.Controls.Add(btnProdutos);
            fraPrincipal.Controls.Add(btnFornecedores);
            fraPrincipal.Controls.Add(btnClientes);
            fraPrincipal.Location = new Point(12, 17);
            fraPrincipal.Name = "fraPrincipal";
            fraPrincipal.Size = new Size(424, 555);
            fraPrincipal.TabIndex = 0;
            // 
            // btnPedidos
            // 
            btnPedidos.Image = (Image)resources.GetObject("btnPedidos.Image");
            btnPedidos.Location = new Point(3, 83);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(99, 67);
            btnPedidos.TabIndex = 5;
            btnPedidos.Text = "Pedidos";
            btnPedidos.TextAlign = ContentAlignment.BottomCenter;
            btnPedidos.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.Location = new Point(318, 489);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(99, 63);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "LogOut";
            btnLogOut.TextAlign = ContentAlignment.BottomCenter;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.Location = new Point(318, 10);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(99, 67);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.TextAlign = ContentAlignment.BottomCenter;
            btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnProdutos
            // 
            btnProdutos.Image = (Image)resources.GetObject("btnProdutos.Image");
            btnProdutos.Location = new Point(213, 10);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(99, 67);
            btnProdutos.TabIndex = 2;
            btnProdutos.Text = "Produtos";
            btnProdutos.TextAlign = ContentAlignment.BottomCenter;
            btnProdutos.UseVisualStyleBackColor = true;
            // 
            // btnFornecedores
            // 
            btnFornecedores.Image = (Image)resources.GetObject("btnFornecedores.Image");
            btnFornecedores.Location = new Point(108, 10);
            btnFornecedores.Name = "btnFornecedores";
            btnFornecedores.Size = new Size(99, 67);
            btnFornecedores.TabIndex = 1;
            btnFornecedores.Text = "Fornecedores";
            btnFornecedores.TextAlign = ContentAlignment.BottomCenter;
            btnFornecedores.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.Location = new Point(3, 10);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(99, 67);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.BottomCenter;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 585);
            Controls.Add(fraPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            Text = "ERP";
            fraPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel fraPrincipal;
        private Button btnLogOut;
        private Button btnUsuarios;
        private Button btnProdutos;
        private Button btnFornecedores;
        private Button btnClientes;
        private Button btnPedidos;
    }
}