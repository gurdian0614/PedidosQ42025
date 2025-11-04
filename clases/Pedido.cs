
using System.Collections.ObjectModel;

public class Pedido : IInformacionDetallada
{
    public int Id { get; set; }
    public DateTime Fecha => DateTime.Now;
    public List<ItemPedido> Items { get; set; }
    public decimal Total => Items.Sum(item => item.Subtotal);

    public Pedido(int IdPedido)
    {
        Id = IdPedido;
        Items = new List<ItemPedido>();
        //Fecha = DateTime.Now;
    }

    public void AgregarItem(Producto Producto, int Cantidad)
    {
        if (Producto is null)
        {
            throw new ArgumentException("El producto no puede ser nulo.");
        }

        if (Producto.Stock < Cantidad)
        {
            throw new InvalidOperationException($"No hay suficiente stock de {Producto.Nombre}");
        }

        // Agregar elementos a la lista
        Items.Add(new ItemPedido(Producto, Cantidad));
        Producto.DisminuirStock(Cantidad);
        Console.WriteLine($"El Producto {Producto.Nombre} con cantidad {Cantidad}, se ha agregado al Pedido");
        Console.WriteLine();
    }
    
    public void MostrarDetalles()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine(ObtenerInformacionDetallada());

        foreach (var item in Items)
        {
            Console.WriteLine($"Producto: {item.Producto.Nombre}, Cantidad: {item.Cantidad}, Subtotal: {item.Subtotal:C}");
        }
        Console.WriteLine($"Total: {Total:C}");
        Console.WriteLine("------------------------------");
        Console.WriteLine();
    }

    public string ObtenerInformacionDetallada()
    {
        return $"Detalles del Pedido #{Id}\n" +
               $"Fecha: {Fecha:dd/MM/yyyy hh:mm:ss tt}";
    }
}