using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesTienda;
using ManejadoresTienda;
namespace PresentacionesTienda
{
    public partial class FrmProductos : Form
    {
        int fila = 0, columna = 0;
        public static Productos producto = new Productos(0, "", "", 0);
        Funciones f;
        public FrmProductos()
        {
            InitializeComponent();
            f = new Funciones();
        }
        void Actualizar()
        {
            f.Mostrar(dgvProductos, txtBuscar.Text);
        }
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            producto.IdProductos = int.Parse(dgvProductos.Rows[fila].Cells[0]
                .Value.ToString());
            producto.Nombre = dgvProductos.Rows[fila].Cells[1].Value.ToString();
            producto.Descripcion = dgvProductos.Rows[fila].Cells[2].Value.ToString();
            producto.Precio = double.Parse(dgvProductos.Rows[fila].Cells[3].Value.ToString());
            switch (columna)
            {
                case 4: {
                        FrmProductosAdd a = new FrmProductosAdd();
                        a.ShowDialog();
                        Actualizar();
                    }break;
                case 5: {
                        f.Borrar(producto);
                        Actualizar();
                    }break;
            }
        }

        private void dgvProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            producto.IdProductos = -1;
            FrmProductosAdd a = new FrmProductosAdd();
            a.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
