using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ServicioPublicadoEntity
    {
        //CONSTRUCTOR
        public ServicioPublicadoEntity(string codigoPublicacion,ProveedorEntity proveedor, ServicioEntity servicio, double precioXunidad, string descripcion)
        {
            this.codigoPublicacion = codigoPublicacion;
            this.proveedor = proveedor;
            this.servicio = servicio;
            this.precioXunidad = precioXunidad;
            this.descripcion = descripcion;
        }

        //ATRIBUTOS PRIVADOS
        private string codigoPublicacion;
        private ProveedorEntity proveedor;
        private ServicioEntity servicio;
        private double precioXunidad;
        private string descripcion;


        //PROPIEDADES PUBLICAS
        public string CodigoPublicacion { get => codigoPublicacion; }
        public ProveedorEntity Proveedor { get => proveedor; }
        public ServicioEntity Servicio { get => servicio; }
        public double PrcioXunidad { get => precioXunidad; }
        public string Descripcion { get => descripcion; }        
    }
}
