using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
namespace AccesoDatosTienda
{
    public class AccesoProductos
    {
        Base b = new Base("localhost", "root", "", "tienda2");
        public void Borrar(dynamic entidad)
        {
            b.Comando(String.Format("CALL DeleteProductos({0})", entidad.IdProductos));
        }

        public void Guardar(dynamic entidad)
        {
            b.Comando(string.Format("CALL InsertProductos('{0}','{1}',{2},{3})",
               entidad.Nombre, entidad.Descripcion, entidad.Precio, entidad.IdProductos));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("CALL ShowProductos('%{0}%')", filtro), "productos");
        }
    }
}
