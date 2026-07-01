using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Dispositivo> dispositivos = new List<Dispositivo>();

        dispositivos.Add(new AspiradoraRobot("Living", 5));
        dispositivos.Add(new LamparaInteligente("Dormitorio", "Azul"));

        foreach (Dispositivo d in dispositivos)
        {
            Console.WriteLine(d.EjecutarFuncion());
        }

        Console.ReadKey();
    }
}