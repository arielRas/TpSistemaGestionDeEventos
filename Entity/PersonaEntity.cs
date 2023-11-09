using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PersonaEntity
    {
        //ATRIBUTOS
        private string nombre;
        private string apellido;
        private Int64 dni;
        private string email;

        //PROPIEDADES PUBLICAS
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public long Dni { get => dni; set => dni = value; }
        public string Email { get => email; set => email = value; }
    }
}
