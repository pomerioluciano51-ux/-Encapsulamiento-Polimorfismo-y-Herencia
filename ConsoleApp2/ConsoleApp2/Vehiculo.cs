using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Vehiculo
    {
        private string marca;
        public string Marca
        {
            get { return marca; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    marca = value;
                }
            }
        }
        public Vehiculo(string marca)
        {
            Marca = marca;
        }
        public virtual string Arrancar()
        {
            return $"{Marca} arranca";
        }
    }
}
