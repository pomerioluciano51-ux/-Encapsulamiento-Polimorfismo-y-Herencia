using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class AutoElectrico : Vehiculo
    {
        public int Autonomia { get; set; }

        public AutoElectrico(string marca, int autonomia) : base(marca)
            {
            Autonomia = autonomia;
        }
        public override string Arrancar()
        {
            return $"Auto electrico {Marca} arranca silenciosamente. Autonomia: {Autonomia} km"; 
        }
    }
}
