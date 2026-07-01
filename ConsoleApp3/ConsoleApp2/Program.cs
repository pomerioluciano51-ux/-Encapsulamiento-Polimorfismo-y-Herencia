using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Plato> platos = new List<Plato>();

        platos.Add(new Pizza("Muzzarella", "Fina"));
        platos.Add(new Ensalada("César", "Ranch"));

        foreach (Plato p in platos)
        {
            Console.WriteLine(p.Preparar());
        }

        Console.ReadKey();
    }
}