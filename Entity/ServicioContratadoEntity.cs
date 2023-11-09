using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ServicioContratadoEntity
    {
        //CONSTRUCTOR
        public ServicioContratadoEntity(int codigoProveedor, ServicioEntity servicio, double precioXunidad, int cantidad, double subtotal, string descripcion)
        {
            this.codigoProveedor = codigoProveedor;
            this.servicio = servicio;
            this.precioXunidad = precioXunidad;
            this.cantidad = cantidad;
            this.descripcion = descripcion;
            this.subtotal = subtotal;
        }


        //ATRIBUTOS PRIVADOS
        private int codigoProveedor;
        private ServicioEntity servicio;
        private double precioXunidad;
        private int cantidad;
        private double subtotal;
        string descripcion;


        //PROPIEDADES PUBLICAS
        public int CodigoProveedor { get => codigoProveedor; }
        public ServicioEntity Servicio { get => servicio; }
        public double PrecioXunidad { get => precioXunidad; }
        public int Cantidad { get => cantidad; }
        public string Descripcion { get => descripcion; }
        public double Subtotal { get => subtotal; }


        //METODOS
    }
}
