using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDao
    {
        public bool ValidarCredenciales(string email, string password)
        {
            try
            {
                using(ContextDb context = new ContextDb())
                {
                    if(context.USUARIO.Where(U => U.EMAIL == email && U.PASSWORD == password).Count() == 1) return true;
                        else return false;
                }
            }
            catch { throw; }
        }



        public void InstanciarUsuario(string email) //REVISAR NOMBRE
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    USUARIO usuario = context.USUARIO.SingleOrDefault(U => U.EMAIL == email);

                    UsuarioEntity.GetInstance(usuario.ID_USUARIO, usuario.NOMBRE, usuario.APELLIDO, usuario.DNI, usuario.EMAIL);
                }
            }
            catch { throw; }
        }
    }
}
