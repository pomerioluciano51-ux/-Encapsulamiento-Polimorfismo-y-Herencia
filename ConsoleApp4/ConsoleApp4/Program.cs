using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Empleado> empleados = new List<Empleado>();

        empleados.Add(new Programador(1, "C#"));
        empleados.Add(new Disenador(2, "Photoshop"));

        foreach (Empleado e in empleados)
        {
            Console.WriteLine(e.Trabajar());
        }

        Console.ReadKey();
    }
}
