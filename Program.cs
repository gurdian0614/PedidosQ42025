
// Creamos el objeto
List<Producto> catalogoList = new List<Producto>();
Electronico electronico = new Electronico();
electronico.Id = 3;
electronico.Nombre = "iPhone 17 Pro Max";
electronico.Precio = 52000;
electronico.Stock = 10;
electronico.GarantiaMeses = 12;
electronico.Voltaje = "110V";
catalogoList.Add(electronico);

Libro libro = new Libro();
libro.Id = 4;
libro.Nombre = "El Principito";
libro.Precio = 250;
libro.Stock = 1500;
libro.ISBN = "8536492365322";
libro.Autor = "Antoine de Saint-Exupéry";
libro.NumeroPaginas = 170;
catalogoList.Add(libro);

Pedido pedido = new Pedido(1);
bool continuarPedido = true;

while (continuarPedido)
{
    Console.WriteLine("-------------------- Catálogo de Productos --------------------");
    foreach (Producto producto in catalogoList)
    {
        producto.MostrarInformacion();
    }

    try
    {
        Console.WriteLine();
        Console.WriteLine("------------------------------------------------------------");
        Console.Write("Ingrese ID del producto o 0 para finalizar: ");
        int id = int.Parse(Console.ReadLine());

        if (id == 0)
        {
            continuarPedido = false;
            continue;
        }

        Console.Write("Ingrese la cantidad: ");
        int cantidad = int.Parse(Console.ReadLine());

        Producto productoSeleccionado = catalogoList.FirstOrDefault(producto => producto.Id == id);
        if (productoSeleccionado is null)
        {
            throw new ArgumentException($"El Id {id} no corresponde a ningún producto.");
        }
        pedido.AgregarItem(productoSeleccionado, cantidad);
    }
    catch (ArgumentException ex)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"ADVERTENCIA: {ex.Message}");
        Console.ResetColor();
    }
    catch (InvalidOperationException ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"ATENCION: {ex.Message}");
        Console.ResetColor();
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("ADVERTENCIA: Por favor ingrese solo números para el Id y la Cantidad.");
        Console.ResetColor();
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"ERROR INESPERADO: {ex.Message}");
        Console.ResetColor();
    }
    finally
    {
        Console.WriteLine();
        Console.WriteLine($"-------------------- ESTADO ACTUAL DEL PEDIDO --------------------");
        pedido.MostrarDetalles();
    }
}
