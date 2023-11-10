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
        public ServicioPublicadoEntity(Guid codigoPublicacion, int codigoProveedor, ServicioEntity servicio, double precioXunidad, string descripcion)
        {
            this.codigoPublicacion = codigoPublicacion;
            this.codigoProveedor = codigoProveedor;            
            this.precioXunidad = precioXunidad;
            this.descripcion = descripcion;
        }

        //ATRIBUTOS PRIVADOS
        private Guid codigoPublicacion;
        private int codigoProveedor;
        private ServicioEntity servicio;
        private double precioXunidad;
        private string descripcion;


        //PROPIEDADES PUBLICAS
        public Guid CodigoPublicacion { get => codigoPublicacion; }
        public int CodigoProveedor { get => codigoProveedor;}
        public ServicioEntity Servicio { get => servicio; }
        public double PrcioXunidad { get => precioXunidad; }
        public string Descripcion { get => descripcion; }
        
    }
}
