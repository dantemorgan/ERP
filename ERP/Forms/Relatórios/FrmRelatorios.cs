using ERP.ClassesRelatorios;
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

namespace ERP.Forms.Relatórios
{
    public partial class FrmRelatorios : Form
    {
        public FrmRelatorios()
        {
            InitializeComponent();
        }

        private void btnRelatorioClientes_Click(object sender, EventArgs e)
        {
            GeraRelatorioTodosClientes();
        }

        private void GeraRelatorioTodosClientes()
        {

            ConexaoBD conexaoBanco = new ConexaoBD("(local)", "ERP", "sa", "280612");
            conexaoBanco.AbrirConexao();
            ClasseRelatorioClientes.GerarRelatorioClientesCompletoHTML(Cliente.ConsultaTodosClientes(conexaoBanco), "D:\\ProjetosGit\\ERP\\ERP\\RelatorioTemp\\TempHTML.html", "\"D:\\\\ProjetosGit\\\\ERP\\\\ERP\\\\RelatorioTemp\\\\TempPDF.pdf\"");

        }


    }
}
