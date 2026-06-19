using ConsoleApp2;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();

        vehiculos.Add(new AutoElectrico("Tesla", 500));
        vehiculos.Add(new Camioneta("Ford", "4X4"));

        foreach ( Vehiculo vehiculo in vehiculos)
        {
            string resultado = vehiculo.Arrancar();
            Console.WriteLine(resultado);
        }
    }
}