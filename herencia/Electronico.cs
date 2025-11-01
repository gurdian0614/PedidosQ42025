
public class Electronico : Producto
{
    public int GarantiaMeses { get; set; }
    public string? Voltaje { get; set; }

    public Electronico() { }

    public Electronico(int Id, string Nombre, decimal Precio)
    {
        this.Id = Id;
        this.Nombre = Nombre;
        this.Precio = Precio;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("********** DATOS DEL PRODUCTO **********");
        Console.WriteLine(ObtenerInformacionDetallada());
        Console.WriteLine($"Garantía: {GarantiaMeses} meses");
        Console.WriteLine($"Voltaje: {Voltaje}");
        Console.WriteLine();
    }

    public override void MostrarInformacion(string Direccion, string Dni)
    {
        Console.WriteLine("********** DATOS DEL PRODUCTO **********");
        Console.WriteLine(ObtenerInformacionDetallada());
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine($"DNI: {Dni}");
        Console.WriteLine($"Garantía: {GarantiaMeses} meses");
        Console.WriteLine($"Voltaje: {Voltaje}");
        Console.WriteLine();
    }

    public override void MostrarInformacion(string Direccion)
    {
        Console.WriteLine("********** DATOS DEL PRODUCTO **********");
        Console.WriteLine(ObtenerInformacionDetallada());
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine($"Garantía: {GarantiaMeses} meses");
        Console.WriteLine($"Voltaje: {Voltaje}");
        Console.WriteLine();
    }
}