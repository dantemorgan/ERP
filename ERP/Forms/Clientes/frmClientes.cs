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

namespace ERP.Forms.Clientes
{
    public partial class frmClientes : Form
    {
        ConexaoBD conexaoBanco = new ConexaoBD("(local)", "ERP", "sa", "280612");

        public enum ColClientes
        {
            Codigo = 0,
            Nome,
            Telefone

        }

        public frmClientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            conexaoBanco.AbrirConexao();
            FormataGrid();
            CarregaClientes("");



        }

        private void CarregaClientes(string filtro)
        {

            List<Cliente> clientes = Cliente.ConsultaTodosClientes(conexaoBanco);

            foreach (Cliente cliente in clientes)
            {
                int rowIndex = grdClientes.Rows.Add();
                grdClientes.Rows[rowIndex].Cells[((int)ColClientes.Codigo)].Value = cliente.codigo;
                grdClientes.Rows[rowIndex].Cells[((int)ColClientes.Nome)].Value = cliente.nome;
                int columnIndex = (int)ColClientes.Telefone;
                grdClientes.Rows[rowIndex].Cells[columnIndex].Value = cliente.telefone.ToString();

            }
        }

        private void FormataGrid()
        {
            grdClientes.RowCount = 1;
            grdClientes.ColumnCount = 3;
            grdClientes.Columns[((int)ColClientes.Codigo)].Width = (int)(grdClientes.Width * 0.1);
            grdClientes.Columns[((int)ColClientes.Nome)].Width = (int)(grdClientes.Width * 0.4);
            grdClientes.Columns[((int)ColClientes.Telefone)].Width = (int)(grdClientes.Width * 0.3);
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            frmCadCliente frm = Application.OpenForms["frmCadCliente"] as frmCadCliente;

            if (frm == null)
            {
                // Se não houver uma instância aberta, cria uma nova
                frm = new frmCadCliente();
                frm.PopulaComboUFs();
                frm.Show();
            }
            else
            {
                // Se já houver uma instância aberta, apenas traz ela para foco
                frm.Focus();
            }
        }

        private void grdClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdClientes_DoubleClick(object sender, EventArgs e)
        {
            int rowIndex = grdClientes.SelectedCells[0].RowIndex;
            int codigo = (int)grdClientes.Rows[rowIndex].Cells[(int)ColClientes.Codigo].Value;

            Cliente clienteParaAbrir = Cliente.ConsultaClientePorCodigo(conexaoBanco, codigo);

            frmCadCliente frm = Application.OpenForms["frmCadCliente"] as frmCadCliente;

            if (frm == null)
            {
                // Se não houver uma instância aberta, cria uma nova
                frm = new frmCadCliente();
                
                frm.CarregarClienteDoGrid(clienteParaAbrir);
                

                frm.Show();
            }
            else
            {
                // Se já houver uma instância aberta, apenas traz ela para foco
                frm.Focus();
            }


        }
    }
}
