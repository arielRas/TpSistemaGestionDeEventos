using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PagoEntity
    {
        //CONSTRUCTOR
        public PagoEntity(DateTime fechaPago, double monto)
        {
            this.fechaPago = fechaPago;
            this.monto = monto;
        }

        //ATRIBUTOS PRIVADOS
        private DateTime fechaPago;
        private double monto;


        //PROPIEDADES PUBLICAS
        public DateTime FechaPago { get => fechaPago; }
        public double Monto { get => monto; }
    }
}
