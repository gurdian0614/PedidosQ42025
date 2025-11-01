using System.Security.Principal;

public abstract class Producto : IInformacionDetallada
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }

    public Producto() { }

    public Producto(int Id, string Nombre, decimal Precio)
    {
        this.Id = Id;
        this.Nombre = Nombre;
        this.Precio = Precio;
        Stock = 0;
    }

    /// <summary>
    /// Muestra la informacion del producto
    /// </summary>
    public abstract void MostrarInformacion();
    public abstract void MostrarInformacion(string Direccion);
    public abstract void MostrarInformacion(string Direccion, string Dni);

    /// <summary>
    /// Disminuye el inventario
    /// </summary>
    /// <param name="Cantidad">Cantidad a disminuir en el inventario</param>
    public void DisminuirStock(int Cantidad)
    {
        if (Stock >= Cantidad)
        {
            Stock -= Cantidad;
        }
        else
        {
            Console.WriteLine($"No hay suficiente stock de {Nombre}");
            Console.WriteLine();
        }
    }

    public string ObtenerInformacionDetallada()
    {
        return $"ID: {Id}\n" +
               $"Nombre: {Nombre}\n" +
               $"Precio {Precio:C}\n" +
               $"Cantidad disponible: {Stock}";
    }
}