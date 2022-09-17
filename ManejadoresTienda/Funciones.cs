using System;
using AccesoDatosTienda;
using Crud;
using System.Windows.Forms;
using System.Drawing;

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
                ap.Borrar(Entidad);
        }

        public void Guardar(dynamic Entidad)
        {
            ap.Guardar(Entidad);
            g.Mensaje("Registro guardado exitosamente", "!Información",
                MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.ColumnHeadersHeight = 40;
            tabla.DataSource = ap.Mostrar(filtro).Tables["productos"];
            tabla.Columns.Insert(4, g.Boton("Editar", Color.GreenYellow));
            tabla.Columns.Insert(5, g.Boton("Eliminar", Color.IndianRed));
            tabla.Columns[0].Visible = false;
        }
    }
}
