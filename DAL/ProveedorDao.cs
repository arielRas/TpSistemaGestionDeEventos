using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProveedorDao
    {
        internal static ProveedorEntity GetProveedor(int idProveedor)
        {
            try
            {
                using(ContextDb context =  new ContextDb())
                {
                    USUARIO proveedor = context.USUARIO.SingleOrDefault(U => U.ID_USUARIO == idProveedor);

                    return new ProveedorEntity(proveedor.ID_USUARIO, proveedor.NOMBRE, proveedor.APELLIDO, proveedor.DNI, proveedor.EMAIL);
                }
            }
            catch { throw; }
        }
    }
}
