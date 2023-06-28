using Proyecto_CGS.Controladores;
using Proyecto_CGS.Models;
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
    public partial class FrmGestionarUsuario : Form
    {
        public FrmGestionarUsuario()
        {
            InitializeComponent();
        }

        UsuarioController _usuariocontrol = new UsuarioController();
        bool _Nuevo = true;
        private void FrmGestionarUsuario_Load(object sender, EventArgs e)
        {
            usuarioBindingSource.DataSource = _usuariocontrol.GetAll();
        }
        //boton cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            groupBox_Usuario.Enabled = false;
            usuarioBindingSource.CancelEdit();
        }
        //bton de guardar
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        public void Guardar()
        {
            var nusuario = (Usuario)usuarioBindingSource.Current;
            if (_Nuevo == true)
            {
                _usuariocontrol.Create(nusuario);
            }
            else
            {
                _usuariocontrol.Update(nusuario);
            }
            groupBox_Usuario.Enabled = false;
            usuarioBindingSource.DataSource = _usuariocontrol.GetAll();
        }
        //boton nuevo usuario
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            _Nuevo = true;
            groupBox_Usuario.Enabled = true;
            usuarioBindingSource.AddNew();
        }
        //boton eliminar
        private void button6_Click(object sender, EventArgs e)
        {
            var neli = (Usuario)usuarioBindingSource.Current;
            DialogResult dlr = MessageBox.Show(" QUIERES ELIMINAR ESTE USUARIO ?",
               "INFINITIX",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                _usuariocontrol.Delete(neli);
            }
            usuarioBindingSource.DataSource = _usuariocontrol.GetAll();
        }
        //boton de editar
        private void btn_editar_Click(object sender, EventArgs e)
        {
            _Nuevo = false;
            groupBox_Usuario.Enabled = true;
        }
        //boton de buscar
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string parametro = txt_buscar.Text;
            usuarioBindingSource.DataSource = _usuariocontrol.Search(parametro);
        }

    }
}
