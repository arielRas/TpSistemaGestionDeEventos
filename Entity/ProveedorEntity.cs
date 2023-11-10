using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProveedorEntity : PersonaEntity
    {
        //CONSTRUCTOR
        public ProveedorEntity(int idProveedor, string nombre, string apellido, Int64 dni, string email, List<ServicioPublicadoEntity> serviciosPublicados)
        {
            this.idProveedor = idProveedor;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Email = email;
            this.serviciosPublicados = serviciosPublicados;
        }
        public ProveedorEntity(int idProveedor, string nombre, string apellido, Int64 dni, string email)//SOBRECARGA
        {
            this.idProveedor = idProveedor;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Email = email;
        }

        //ATRIBUTOS PRIVADOS
        private int idProveedor;
        private List<ServicioPublicadoEntity> serviciosPublicados = new List<ServicioPublicadoEntity>();


        //PROPIEDADES PUBLICAS
        public int IdProveedor { get => idProveedor; }
        public List<ServicioPublicadoEntity> ServiciosPublicados { get => serviciosPublicados; }
    }
}
