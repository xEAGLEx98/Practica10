using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesTienda;
using AccesoDatosTienda;
using Crud;
using System.Windows.Forms;

namespace ManejadoresTienda
{
    public class Funciones
    {
        AccesoProductos ap = new AccesoProductos();
        Grafica g = new Grafica();

        public void Borrar(dynamic Entidad)
        {
            DialogResult dr = MessageBox.Show(
               String.Format("¿Estás seguro de borrar este registro?",
               Entidad.Nombre), "!Atención", MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
                ac.Borrar(Entidad);
        }

        public void Guardar(dynamic Entidad)
        {
            ac.Guardar(Entidad);
            g.Mensaje("Registro guardado exitosamente", "!Información",
                MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.ColumnHeadersHeight = 40;
            tabla.DataSource = ac.Mostrar(filtro).Tables["categorias"];
            tabla.Columns.Insert(2, g.Boton("Editar", Color.GreenYellow));
            tabla.Columns.Insert(3, g.Boton("Eliminar", Color.IndianRed));
            tabla.Columns[0].Visible = false;
        }
    }
}
