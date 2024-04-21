namespace ERP.Forms.Clientes
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            grdClientes = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            btnNovoCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)grdClientes).BeginInit();
            SuspendLayout();
            // 
            // grdClientes
            // 
            grdClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdClientes.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, Telefone });
            grdClientes.Location = new Point(12, 12);
            grdClientes.Name = "grdClientes";
            grdClientes.RowTemplate.Height = 25;
            grdClientes.Size = new Size(526, 522);
            grdClientes.TabIndex = 0;
            grdClientes.CellContentClick += grdClientes_CellContentClick;
            grdClientes.DoubleClick += grdClientes_DoubleClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Cód.";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Telefone
            // 
            Telefone.HeaderText = "Telefone";
            Telefone.Name = "Telefone";
            Telefone.ReadOnly = true;
            // 
            // btnNovoCliente
            // 
            btnNovoCliente.Image = (Image)resources.GetObject("btnNovoCliente.Image");
            btnNovoCliente.Location = new Point(423, 540);
            btnNovoCliente.Name = "btnNovoCliente";
            btnNovoCliente.Size = new Size(115, 65);
            btnNovoCliente.TabIndex = 1;
            btnNovoCliente.Text = "Novo";
            btnNovoCliente.TextAlign = ContentAlignment.BottomCenter;
            btnNovoCliente.UseVisualStyleBackColor = true;
            btnNovoCliente.Click += btnNovoCliente_Click;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 617);
            Controls.Add(btnNovoCliente);
            Controls.Add(grdClientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmClientes";
            Text = "Clientes";
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)grdClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grdClientes;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Telefone;
        private Button btnNovoCliente;
    }
}