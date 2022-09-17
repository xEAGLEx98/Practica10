namespace EntidadesTienda
{
    public class Productos
    {
        public Productos(int idProductos, string nombre,
            string descripcion, double precio)
        {
            IdProductos = idProductos;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }

        public int IdProductos { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
    }
}
