
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ensalada : Plato
{
    public string TipoAderezo { get; set; }

    public Ensalada(string nombrePlato, string tipoAderezo)
        : base(nombrePlato)
    {
        TipoAderezo = tipoAderezo;
    }

    public override string Preparar()
    {
        return $"Preparando ensalada '{NombrePlato}' con aderezo {TipoAderezo}.";
    }
}
