
public class Libro : Producto
{
    public string? ISBN { get; set; }
    public string? Autor { get; set; }
    public int NumeroPaginas { get; set; }

    public override void MostrarInformacion()
    {
        Console.WriteLine("********** DATOS DEL PRODUCTO **********");
        Console.WriteLine(ObtenerInformacionDetallada());
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Numero de Páginas: {NumeroPaginas}");
        Console.WriteLine();
    }

    public override void MostrarInformacion(string Direccion)
    {
        Console.WriteLine("********** DATOS DEL PRODUCTO **********");
        Console.WriteLine(ObtenerInformacionDetallada());
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Numero de Páginas: {NumeroPaginas}");
        Console.WriteLine();
    }

    public override void MostrarInformacion(string Direccion, string Dni)
    {
        Console.WriteLine("********** DATOS DEL PRODUCTO **********");
        Console.WriteLine(ObtenerInformacionDetallada());
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine($"DNI: {Dni}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Numero de Páginas: {NumeroPaginas}");
        Console.WriteLine();
    }
}