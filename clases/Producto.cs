public abstract class Producto
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }

    /// <summary>
    /// Muestra la informacion del producto
    /// </summary>
    public abstract void MostrarInformacion();

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
}