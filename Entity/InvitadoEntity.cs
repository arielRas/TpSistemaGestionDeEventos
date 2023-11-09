using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class InvitadoEntity : PersonaEntity
    {
        //CONSTRUCTOR
        public InvitadoEntity(int codigoEvento, string nombre, string apellido, Int64 dni, string email)
        {
            this.CodigoEvento = codigoEvento;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Email = email;
        }

        //PROPIEDADES PUBLICAS
        public int CodigoEvento { get; }
    }
}
