using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_CGS.Vistas
{
    public partial class FrmMenuPrincipal : Form
    {
        string _usuario;
        public FrmMenuPrincipal(string usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = _usuario;
        }

        private void btnGestionarUsuario_Click(object sender, EventArgs e)
        {
            FrmGestionarUsuario frmGestionarUsuario = new FrmGestionarUsuario();
            frmGestionarUsuario.WindowState=FormWindowState.Maximized;
            frmGestionarUsuario.Show();
        }
    }
}
