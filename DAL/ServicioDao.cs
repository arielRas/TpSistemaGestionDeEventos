using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ServicioDao
    {



        public List<ServicioPublicadoEntity> ListarServiciosPublicados()
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    var serviciosPublicados = context.SERVICIO_PUBLICADO.Select(S => new ServicioPublicadoEntity(
                        S.ID_PUBLICACION,
                        Convert.ToInt32(S.ID_PROVEEDOR),
                        this.GetServicio(Convert.ToInt32(S.ID_SERVICIO)),
                        Convert.ToDouble(S.PRECIO),
                        S.DESCRIPCION)
                    ).ToList();

                    return serviciosPublicados;
                }
            }
            catch { throw;  }            
        }


        public List<ServicioContratadoEntity> ListarServiciosContratados(int idEvento)
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    var serviciosContratadoDb =  context.EVENTO_SERVICIO.Where(S => S.ID_EVENTO == idEvento).Select(S => new ServicioContratadoEntity(
                        
                        
                        
                        )
                        

                        )
                }
            }
            catch { throw; }
        }


        private ServicioEntity GetServicio(int id)
        {
            try
            {
                using(ContextDb context = new ContextDb())
                {
                    SERVICIO servicio = context.SERVICIO.SingleOrDefault(S => S.ID_SERVICIO ==  id);

                    return new ServicioEntity(servicio.ID_SERVICIO, servicio.SERVICIO1);
                }
            }
            catch { throw; }
        }

        private ServicioContratadoEntity GetServicioContratado(Guid codPublicacion)
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    SERVICIO_PUBLICADO servicioPublicadoDb = context.SERVICIO_PUBLICADO.Where(S => S.ID_PUBLICACION == codPublicacion).SingleOrDefault();

                    ServicioContratadoEntity servicioPublicado = 

                    return new ServicioContratadoEntity()
                }
            }
            catch { throw; }
        }

    }
}
