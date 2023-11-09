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

        public ServicioContratadoEntity NuevoServicioContrado(ServicioPublicadoEntity nuevoServicio, int cantidad) //TRANSAFORMA UN SERVICIO PUBLICADO EN SERVICIO CONTRATADO PARA PASAR AL BUSINESS
        {
            ServicioContratadoEntity servicioContratado = new ServicioContratadoEntity(
                nuevoServicio.Proveedor.IdProveedor,
                nuevoServicio.Servicio,
                nuevoServicio.PrcioXunidad,
                cantidad,
                (nuevoServicio.PrcioXunidad * cantidad),
                nuevoServicio.Descripcion
                );

            return servicioContratado;
        }

        public void ActualizarServiciosContratados(List<ServicioContratadoEntity> serviciosContrados)
        {
            this.serviciosContratados = serviciosContrados;
        }

        public void ActualizarListaInvitados(List<InvitadoEntity> invitados)
        {
            this.invitados = invitados;
        }
    }
}
