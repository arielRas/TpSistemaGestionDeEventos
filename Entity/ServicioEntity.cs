using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ServicioEntity
    {
        //CONSTRUCTOR
        public ServicioEntity(int codigoServico, string nombre)
        {
            this.codigoServicio = codigoServico;
            this.nombre = nombre;
        }

        //ATRIBUTOS PRIVADOS
        private int codigoServicio;
        private string nombre;


        //PROPIEDADES PUBLICAS
        public int CodigoServicio { get => codigoServicio; }
        public string Nombre { get => nombre; }
    }
}
