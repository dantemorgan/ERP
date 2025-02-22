namespace ERP.Forms.Relatórios
{
    partial class FrmRelatorios
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
            btnRelatorioClientes = new Button();
            SuspendLayout();
            // 
            // btnRelatorioClientes
            // 
            btnRelatorioClientes.Location = new Point(24, 22);
            btnRelatorioClientes.Name = "btnRelatorioClientes";
            btnRelatorioClientes.Size = new Size(141, 41);
            btnRelatorioClientes.TabIndex = 0;
            btnRelatorioClientes.Text = "Relatório de clientes";
            btnRelatorioClientes.UseVisualStyleBackColor = true;
            btnRelatorioClientes.Click += btnRelatorioClientes_Click;
            // 
            // FrmRelatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 526);
            Controls.Add(btnRelatorioClientes);
            Name = "FrmRelatorios";
            Text = "Relatórios";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRelatorioClientes;
    }
}