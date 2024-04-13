using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ERP.Services;
using ERP.Entities;

namespace ERP.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }



        private void frmLogin_Load(object sender, EventArgs e)
        {

            PopulaComboUsuarios();

        }

        private void PopulaComboUsuarios()
        {
            ConexaoBD conexaoBanco = new ConexaoBD("(local)", "ERP", "sa", "280612");
            conexaoBanco.AbrirConexao();

            List<Usuario> users = Usuario.ConsultaUsuarios(conexaoBanco);

            cboUser.DataSource = users;

            cboUser.ValueMember = "codigo";
            cboUser.DisplayMember = "nome";
            cboUser.SelectedIndex = 0;

        }



        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Digite a senha!", "Aviso");
                txtSenha.Focus();

            }
            else
            {
                ConexaoBD conexaoBanco = new ConexaoBD("(local)", "ERP", "sa", "280612");
                conexaoBanco.AbrirConexao();
                if (Usuario.VerificaSenhaUsuario(conexaoBanco, (double)cboUser.SelectedValue, txtSenha.Text))

                {
                    this.Hide();
                    frmPrincipal Form = new frmPrincipal();
                    //Form.FormClosed += (s, args)  => this.Close();
                    Form.Show();



                }
            }


        }



        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
