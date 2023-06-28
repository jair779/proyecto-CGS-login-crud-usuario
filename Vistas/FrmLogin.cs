using Proyecto_CGS.Context;
using Proyecto_CGS.Controladores;
using Proyecto_CGS.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_CGS
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //ModelVentaDeComputadoras db = new ModelVentaDeComputadoras();
            //var Usuario = db.Usuario.ToList();
            //var Cliente = db.Cliente.ToList();
            //var Equipo = db.Equipo.ToList();
            //var Devoliucion = db.Devolucion.ToList();
            //var HistorialVenta = db.HistorialVenta.ToList();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            UsuarioController usuarioController = new UsuarioController();
            bool isLogin = usuarioController.Login(usuario, password);
            if (isLogin == true)
            {
                FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal(usuario);
                frmMenuPrincipal.Show();
            }
            else 
            {
                MessageBox.Show("CUENTA O PASSWORD INCORRECTOS...",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
