namespace ERP.Forms.Produtos
{
    partial class Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            helpProvider1 = new HelpProvider();
            PanelProdutos = new Panel();
            grpProduto = new GroupBox();
            txtCodProduto = new TextBox();
            txtDescricao = new TextBox();
            txtDescricaoReduzida = new TextBox();
            txtValorVenda = new TextBox();
            txtMediaCompra = new TextBox();
            lblCodigo = new Label();
            lblDescricaoProduto = new Label();
            lblDescricaoReduzida = new Label();
            lblValorVenda = new Label();
            lblCustoMedio = new Label();
            PanelProdutos.SuspendLayout();
            grpProduto.SuspendLayout();
            SuspendLayout();
            // 
            // PanelProdutos
            // 
            PanelProdutos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelProdutos.BackgroundImage = (Image)resources.GetObject("PanelProdutos.BackgroundImage");
            PanelProdutos.BackgroundImageLayout = ImageLayout.Stretch;
            PanelProdutos.Controls.Add(grpProduto);
            PanelProdutos.Location = new Point(1, 1);
            PanelProdutos.Name = "PanelProdutos";
            PanelProdutos.Size = new Size(620, 425);
            PanelProdutos.TabIndex = 0;
            // 
            // grpProduto
            // 
            grpProduto.BackColor = Color.Transparent;
            grpProduto.Controls.Add(lblCustoMedio);
            grpProduto.Controls.Add(lblValorVenda);
            grpProduto.Controls.Add(lblDescricaoReduzida);
            grpProduto.Controls.Add(lblDescricaoProduto);
            grpProduto.Controls.Add(lblCodigo);
            grpProduto.Controls.Add(txtMediaCompra);
            grpProduto.Controls.Add(txtValorVenda);
            grpProduto.Controls.Add(txtDescricaoReduzida);
            grpProduto.Controls.Add(txtDescricao);
            grpProduto.Controls.Add(txtCodProduto);
            grpProduto.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            grpProduto.Location = new Point(11, 9);
            grpProduto.Name = "grpProduto";
            grpProduto.Size = new Size(591, 394);
            grpProduto.TabIndex = 0;
            grpProduto.TabStop = false;
            grpProduto.Text = "Produto: ";
            // 
            // txtCodProduto
            // 
            txtCodProduto.Location = new Point(11, 73);
            txtCodProduto.Name = "txtCodProduto";
            txtCodProduto.Size = new Size(95, 23);
            txtCodProduto.TabIndex = 0;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(11, 118);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(263, 23);
            txtDescricao.TabIndex = 1;
            txtDescricao.TextChanged += txtDescricao_TextChanged;
            // 
            // txtDescricaoReduzida
            // 
            txtDescricaoReduzida.Location = new Point(280, 118);
            txtDescricaoReduzida.Name = "txtDescricaoReduzida";
            txtDescricaoReduzida.Size = new Size(175, 23);
            txtDescricaoReduzida.TabIndex = 2;
            // 
            // txtValorVenda
            // 
            txtValorVenda.Location = new Point(11, 167);
            txtValorVenda.Name = "txtValorVenda";
            txtValorVenda.Size = new Size(175, 23);
            txtValorVenda.TabIndex = 3;
            // 
            // txtMediaCompra
            // 
            txtMediaCompra.Location = new Point(11, 215);
            txtMediaCompra.Name = "txtMediaCompra";
            txtMediaCompra.Size = new Size(175, 23);
            txtMediaCompra.TabIndex = 4;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(10, 54);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(50, 15);
            lblCodigo.TabIndex = 5;
            lblCodigo.Text = "Código:";
            // 
            // lblDescricaoProduto
            // 
            lblDescricaoProduto.AutoSize = true;
            lblDescricaoProduto.Location = new Point(11, 100);
            lblDescricaoProduto.Name = "lblDescricaoProduto";
            lblDescricaoProduto.Size = new Size(65, 15);
            lblDescricaoProduto.TabIndex = 6;
            lblDescricaoProduto.Text = "Descrição:";
            // 
            // lblDescricaoReduzida
            // 
            lblDescricaoReduzida.AutoSize = true;
            lblDescricaoReduzida.Location = new Point(280, 100);
            lblDescricaoReduzida.Name = "lblDescricaoReduzida";
            lblDescricaoReduzida.Size = new Size(117, 15);
            lblDescricaoReduzida.TabIndex = 7;
            lblDescricaoReduzida.Text = "Descrição reduzida:";
            // 
            // lblValorVenda
            // 
            lblValorVenda.AutoSize = true;
            lblValorVenda.Location = new Point(11, 149);
            lblValorVenda.Name = "lblValorVenda";
            lblValorVenda.Size = new Size(93, 15);
            lblValorVenda.TabIndex = 8;
            lblValorVenda.Text = "Valor de venda:";
            // 
            // lblCustoMedio
            // 
            lblCustoMedio.AutoSize = true;
            lblCustoMedio.Location = new Point(10, 197);
            lblCustoMedio.Name = "lblCustoMedio";
            lblCustoMedio.Size = new Size(79, 15);
            lblCustoMedio.TabIndex = 9;
            lblCustoMedio.Text = "Custo Médio:";
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 425);
            Controls.Add(PanelProdutos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Produtos";
            Text = "Produtos";
            PanelProdutos.ResumeLayout(false);
            grpProduto.ResumeLayout(false);
            grpProduto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private HelpProvider helpProvider1;
        private Panel PanelProdutos;
        private GroupBox grpProduto;
        private TextBox txtDescricao;
        private TextBox txtCodProduto;
        private TextBox txtValorVenda;
        private TextBox txtDescricaoReduzida;
        private Label lblCustoMedio;
        private Label lblValorVenda;
        private Label lblDescricaoReduzida;
        private Label lblDescricaoProduto;
        private Label lblCodigo;
        private TextBox txtMediaCompra;
    }
}