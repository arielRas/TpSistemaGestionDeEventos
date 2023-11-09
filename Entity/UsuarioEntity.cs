using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class UsuarioEntity : PersonaEntity
    {
        //CONSTRUCTOR
        private UsuarioEntity(int idUsuario, string nombre, string apellido, Int64 dni, string email)
        {
            this.idUsuario = idUsuario;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Email = email;
        }

        //ATRIBUTOS
        private int idUsuario;
        private static UsuarioEntity usuario = null;
        private List<EventoEntity> eventos = new List<EventoEntity>();


        //PROPIEDADES
        public int IdUsuario { get => idUsuario; }
        public List<EventoEntity> Eventos { get => eventos; }



        //METODOS
        public static UsuarioEntity GetInstance(int idUsuario, string nombre, string apellido, Int64 dni, string email /*AGREGAR LISTA DE EVENTOS CON ENTITY FRAMEWORK*/)
        {
            if (usuario == null)
            {
                usuario = new UsuarioEntity(idUsuario, nombre, apellido, dni, email);

                return usuario;
            }
            else
                return usuario;
        }

        public static UsuarioEntity GetInstance()//SOBRECARGA
        {
            if (usuario != null) return usuario;

            else return null;
        }

        public void ActualizarListaEventos(List<EventoEntity> eventos)
        {
            this.eventos = eventos;
        }
    }
}
