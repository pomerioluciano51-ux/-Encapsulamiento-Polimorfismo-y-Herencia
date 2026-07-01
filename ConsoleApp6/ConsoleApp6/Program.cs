using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Instrumento> instrumentos = new List<Instrumento>();

        instrumentos.Add(new Guitarra("Fender", 6));
        instrumentos.Add(new Piano("Yamaha", 88));

        foreach (Instrumento instrumento in instrumentos)
        {
            Console.WriteLine(instrumento.TocarNota());
        }

        Console.ReadKey();
    }
}

