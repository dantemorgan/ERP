using ERP.Forms.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public frmPrincipal(double CodUsuario)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = Application.OpenForms["frmLogin"] as frmLogin;
            if (frmLogin != null)
            {
                frmLogin.Show();
            }

            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes form = new frmClientes();
            form.Show();
        }
    }
}
