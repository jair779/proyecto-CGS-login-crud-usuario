using Proyecto_CGS.Context;
using Proyecto_CGS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CGS.Controladores
{
    internal class UsuarioController
    {
        ModelVentaDeComputadoras _context = new ModelVentaDeComputadoras();
        public bool Login(string usuario, string password)
        {
            var UsuarioLogin = _context.Usuario.Where(x => x.NombreUsuario == usuario 
                                                    && x.PasswordUsuario == password).SingleOrDefault();
            if (UsuarioLogin != null) 
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
        //CRUD
        public List<Usuario> GetAll()
        {
            return _context.Usuario.ToList();
        }
        public Usuario Get(string NombreUsuario)
        {
            return _context.Usuario.Find(NombreUsuario);
        }
        //BUSCAR
        public List<Usuario> Search(string parametro)
        {
            if(String.IsNullOrEmpty(parametro))
            {
                return GetAll();
            }
            else
            {
                return _context.Usuario.Where(x => x.NombreUsuario.Contains(parametro)|| 
                        x.NombreCompleto.Contains(parametro)).ToList();
            }
        }
        //CREAR, ELIMINAR, ACTUALIZAR
        public bool Create(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            return _context.SaveChanges() > 0; 
        }
        public bool Update(Usuario usuario)
        {
            _context.Usuario.Attach(usuario);
            _context.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
            return _context.SaveChanges() > 0;

        }
        public bool Delete(Usuario usuario)
        {
            _context.Usuario.Remove(usuario);
            return _context.SaveChanges() > 0;
        }
    }
}
