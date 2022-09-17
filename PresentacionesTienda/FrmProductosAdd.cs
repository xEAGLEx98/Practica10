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
    public partial class FrmProductosAdd : Form
    {
        Funciones f;
        public FrmProductosAdd()
        {
            InitializeComponent();
            f = new Funciones();
            if (FrmProductos.producto.IdProductos > 0)
            {
                txtNombre.Text = FrmProductos.producto.Nombre;
                txtDescripcion.Text = FrmProductos.producto.Descripcion;
                txtCosto.Text = FrmProductos.producto.Precio.ToString(); 
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            f.Guardar(new Productos(FrmProductos.producto.IdProductos,
                txtNombre.Text, txtDescripcion.Text, 
                double.Parse(txtCosto.Text)));
            Close();
        }
    }
}
