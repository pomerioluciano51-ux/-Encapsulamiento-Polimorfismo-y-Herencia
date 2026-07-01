
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Alerta> alertas = new List<Alerta>();

        alertas.Add(new IntrusionRed("A001", "192.168.1.100"));
        alertas.Add(new MalwareDetectado("A002", @"C:\Virus\troyano.exe"));

        foreach (Alerta alerta in alertas)
        {
            Console.WriteLine(alerta.DispararProtocolo());
        }

        Console.ReadKey();
    }
}
