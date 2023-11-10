using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EventoEntity
    {
        //CONSTRUCTOR
        public EventoEntity(int codigoEvento, DateTime fecha, string lugar, PagoEntity pago, List<ServicioContratadoEntity> serviciosContratados, List<InvitadoEntity> invitados)
        {
            this.codigoEvento = codigoEvento;
            this.fecha = fecha;
            this.lugar = lugar;
            this.pago = pago;
            this.serviciosContratados = serviciosContratados;
            this.invitados = invitados;
        }


        //ATRIBUTOS
        private int codigoEvento;
        private DateTime fecha;
        private string lugar;
        private PagoEntity pago;
        private List<ServicioContratadoEntity> serviciosContratados = new List<ServicioContratadoEntity>();
        private List<InvitadoEntity> invitados = new List<InvitadoEntity>();



        //PROPIEDADES PUBLICAS
        public int CodigoEvento { get => codigoEvento; }
        public DateTime Fecha { get => fecha; }
        public string Lugar { get => lugar; }
        public PagoEntity Pago { get => pago; }
        public List<ServicioContratadoEntity> ServiciosContratados { get => serviciosContratados; }
        public List<InvitadoEntity> Invitados { get => invitados; }




        //METODOS

        private ServicioContratadoEntity NuevoServicioContrado(ServicioPublicadoEntity nuevoServicio, int cantidad) //TRANSAFORMA UN SERVICIO PUBLICADO EN SERVICIO CONTRATADO PARA PASAR AL BUSINESS
        {
            return new ServicioContratadoEntity( nuevoServicio, cantidad, (nuevoServicio.PrcioXunidad * cantidad) );
        }

        public void ContratarServicio(ServicioPublicadoEntity nuevoServicio, int cantidad)
        {
            this.serviciosContratados.Add(NuevoServicioContrado(nuevoServicio, cantidad));
        }

        public void ActualizarListaInvitados(List<InvitadoEntity> invitados)
        {
            this.invitados = invitados;
        }
    }
}
