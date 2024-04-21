using ERP.Entities;
using ERP.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ERP.Forms.Clientes
{
    public partial class frmCadCliente : Form
    {

        ConexaoBD conexaoBanco = new ConexaoBD("(local)", "ERP", "sa", "280612");
        byte[] _imagemCliente;
        bool _abriuDoGrid;
        bool _alterandoCadastro;

        public frmCadCliente()
        {
            InitializeComponent();
            txtNro.KeyPress += txtNro_KeyPress;

        }

        public void CarregarClienteDoGrid(Cliente cliente)
        {
            PopulaComboUFs();
            txtNome.Text = cliente.nome;
            txtCidade.Text = cliente.cidade;
            txtBairro.Text = cliente.bairro;
            txtFone.Text = cliente.telefone;
            txtLogradouro.Text = cliente.logradouro;
            txtNro.Text = cliente.numero.ToString();
            txtCNPJCPF.Text = cliente.cpfCnpj;
            cboUF.SelectedValue = cliente.codigoUF;
            lblNumeroCodigo.Text = cliente.codigo.ToString(); ;

            DesativaBotoes();

            CarregarImagemCliente(cliente.codigo);

            _abriuDoGrid = true;


        }

        public void DesativaBotoes()
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;
            btnCarregarFoto.Enabled = false;
            btnGravar.Enabled = false;
            txtNome.Enabled = false;
            txtCidade.Enabled = false;
            txtBairro.Enabled = false;
            txtFone.Enabled = false;
            txtLogradouro.Enabled = false;
            txtNro.Enabled = false;
            txtCNPJCPF.Enabled = false;
            cboUF.Enabled = false;


        }

        public void AtivaBotoes()
        {
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;            
            btnCarregarFoto.Enabled = true;
            btnGravar.Enabled = true;
            txtNome.Enabled = true;
            txtCidade.Enabled = true;
            txtBairro.Enabled = true;
            txtFone.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNro.Enabled = true;
            txtCNPJCPF.Enabled = true;
            cboUF.Enabled = true;
            txtNome.Focus();

        }

        public void CarregarImagemCliente(int codCliente)
        {
            conexaoBanco.AbrirConexao();
            ClienteImagem clienteImagem = ClienteImagem.ConsultaImagemPorCodigo(conexaoBanco, codCliente);

            if (clienteImagem != null && clienteImagem.Imagem != null)
            {
                using (MemoryStream ms = new MemoryStream(clienteImagem.Imagem))
                {
                    Image imagem = Image.FromStream(ms);

                    // Exibe a imagem no controle PictureBox
                    picFotoCliente.SizeMode = PictureBoxSizeMode.Zoom;
                    picFotoCliente.Image = imagem;
                }
            }

        }


        private void btnCarregarFoto_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                openFileDialog.Title = "Selecione uma imagem";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    _imagemCliente = null;
                    picFotoCliente.SizeMode = PictureBoxSizeMode.Zoom;
                    picFotoCliente.Image = Image.FromFile(imagePath);

                    using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        _imagemCliente = new byte[fs.Length];
                        fs.Read(_imagemCliente, 0, (int)fs.Length);
                    }


                }

            }
        }

        private void picFotoCliente_Click(object sender, EventArgs e)
        {

        }

        private bool TestaCampos()
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o nome!", "Aviso!");
                txtNome.Focus();
                return false;
            }

            if (txtCidade.Text == "")
            {
                MessageBox.Show("Preencha a cidade!", "Aviso!");
                txtCidade.Focus();
                return false;
            }

            if (txtBairro.Text == "")
            {
                MessageBox.Show("Preencha o bairro", "Aviso!");
                txtBairro.Focus();
                return false;
            }

            if (txtLogradouro.Text == "")
            {
                MessageBox.Show("Preencha o logradouro!", "Aviso!");
                txtLogradouro.Focus();
                return false;
            }

            if (txtNro.Text == "")
            {
                MessageBox.Show("Preencha o número!", "Aviso");
                txtNro.Focus();
                return false;
            }

            if (txtCNPJCPF.Text == "")
            {
                MessageBox.Show("Preencha o CPF!", "Aviso!");
                //MessageBox.Show("Preencha o CNPJ!", "Aviso!");
                txtCNPJCPF.Focus();
                return false;
            }

            if (FuncoesGerais.ValidaCPFCNPJ(txtCNPJCPF.Text) == false)
            {
                MessageBox.Show("CPF inválido!");
                txtCNPJCPF.Focus();
                return false;
            }

            return true;
        }



        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (TestaCampos())
            {

                conexaoBanco.AbrirConexao();

                Cliente novoCliente = new Cliente();
                novoCliente.nome = txtNome.Text;
                novoCliente.codigoUF = (int)cboUF.SelectedValue;
                novoCliente.cidade = txtCidade.Text;
                novoCliente.bairro = txtBairro.Text;
                novoCliente.logradouro = txtLogradouro.Text;
                novoCliente.numero = (int)Convert.ToUInt32(txtNro.Text);
                novoCliente.cpfCnpj = txtCNPJCPF.Text;
                novoCliente.telefone = txtFone.Text;


                if (_alterandoCadastro)
                {
                    novoCliente.codigo = Convert.ToInt32(lblNumeroCodigo.Text);
                    Cliente.AlteraCliente(conexaoBanco, novoCliente);

                    if (_imagemCliente != null)
                    {

                        ClienteImagem clienteImagem = new ClienteImagem();
                        clienteImagem.Imagem = _imagemCliente;
                        clienteImagem.CodCliente = Convert.ToInt32(lblNumeroCodigo.Text);
                        ClienteImagem.AlteraImagemCliente(conexaoBanco, clienteImagem);
                    }
                }
                else
                {
                    Cliente.InserirCliente(conexaoBanco, novoCliente);
                    int codigoCliente = Cliente.BuscaUltimoCodigo(conexaoBanco);

                    if (_imagemCliente != null)
                    {

                        ClienteImagem clienteImagem = new ClienteImagem();
                        clienteImagem.Imagem = _imagemCliente;
                        clienteImagem.CodCliente = codigoCliente;
                        ClienteImagem.SalvarImagemCliente(conexaoBanco, clienteImagem);
                    }
                }


                MessageBox.Show("Cadastro gravado com sucesso!", "OK");

                this.Close();

            }

        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {



        }

        public void PopulaComboUFs()
        {
            conexaoBanco.AbrirConexao();
            List<UF> UFs = UF.ConsultaTodas(conexaoBanco);


            //cboUF.DataSource = UFs;
            cboUF.DataSource = UFs.OrderBy(u => u.descricao).ToList(); ;
            cboUF.ValueMember = "codigoUF";
            cboUF.DisplayMember = "UFAbreviacao";
            cboUF.SelectedIndex = 0;
        }

        private void txtNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada não é um número ou a tecla Backspace (para permitir apagar)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Define Handled como true para indicar que o evento foi tratado e a tecla não será processada
                e.Handled = true;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AtivaBotoes();
            _alterandoCadastro = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesativaBotoes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Tem certeza que deseja excluir esse cliente do sistema?","Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Cliente.ExcluirCliente(conexaoBanco, Convert.ToInt32(lblNumeroCodigo.Text));
                Close();
            }
        }
    }
}
