using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Camioneta : Vehiculo 
    {
        public string Traccion4x4 { get; set; }
        public Camioneta(string marca, string traccion4x4) : base(marca)
        {
            Traccion4x4 = traccion4x4;
        }

        public override string Arrancar()
        {
            return $"Camioneta {Marca} arranca con traccion {Traccion4x4}";
        }
    }

}
