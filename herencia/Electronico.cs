
public class Electronico : Producto
{
    public int GarantiaMeses { get; set; }
    public string? Voltaje { get; set; }

    public override void MostrarInformacion()
    {
        Console.WriteLine("********** DATOS DEL PRODUCTO **********");
        Console.WriteLine(ObtenerInformacionDetallada());
        Console.WriteLine($"Garantía: {GarantiaMeses} meses");
        Console.WriteLine($"Voltaje: {Voltaje}");
        Console.WriteLine();
    }
}