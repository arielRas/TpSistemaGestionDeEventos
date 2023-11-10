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
        public ServicioContratadoEntity(ServicioPublicadoEntity servicio , int cantidad, double subtotal)
        {
            this.servicio = servicio;
            this.cantidad = cantidad;
            this.subtotal = subtotal;
        }


        //ATRIBUTOS PRIVADOS
        private ServicioPublicadoEntity servicio;
        private int cantidad;
        private double subtotal;
        


        //PROPIEDADES PUBLICAS     
        
        public ServicioPublicadoEntity Servicio { get => servicio;}
        public double Subtotal { get => subtotal;}
        public int Cantidad { get => cantidad;}


        //METODOS
    }
}
