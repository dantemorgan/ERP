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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
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

            foreach (Usuario usuario in users)
            {
                cboUser.Items.Add(usuario);
            }

            cboUser.ValueMember = "codigo";
            cboUser.DisplayMember = "nome";
            cboUser.SelectedIndex = 0;
        }

        private bool VerificaSenhaUsuario(ConexaoBD conexao ,double codUsuario)
        {

            Usuario usuario = Usuario.ConsultaUsuarioPorCodigo(conexao, codUsuario);
            if (usuario != null) 
            { 
                if(usuario.senha == txtSenha.Text)
                {
                    MessageBox.Show("Senha correta!", "Aviso");
                }
                else
                {
                    MessageBox.Show("Senha incorreta!", "Aviso");
                }
            }
            return false;
        }
    }
}
