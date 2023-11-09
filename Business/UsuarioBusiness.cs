using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business
{
    public class UsuarioBusiness
    {
        private UsuarioDao usuarioDao = new UsuarioDao();

        private bool ValidarCredenciales(string email, string password)
        {
            if (email == string.Empty) throw new Exception("El campo usuario no puede estar vacio");

            if (!Regex.IsMatch(email, ".+@.+")) throw new Exception("El formato de email no es correcto");

            if (password == string.Empty) throw new Exception("El campo contraseña no puede estar vacio");

            return usuarioDao.ValidarCredenciales(email, password);
        }

        public void InstanciarUsuario(string email, string password)
        {
            if (!ValidarCredenciales(email, password)) throw new Exception("Usuario o contraseña invalida, por favor revise sus datos");

            usuarioDao.InstanciarUsuario(email);
        }
    }
}
