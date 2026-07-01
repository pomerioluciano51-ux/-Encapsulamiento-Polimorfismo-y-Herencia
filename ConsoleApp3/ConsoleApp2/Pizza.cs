
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pizza : Plato
{
    public string TipoMasa { get; set; }

    public Pizza(string nombrePlato, string tipoMasa)
        : base(nombrePlato)
    {
        TipoMasa = tipoMasa;
    }

    public override string Preparar()
    {
        return $"Preparando pizza '{NombrePlato}' con masa {TipoMasa}.";
    }
}
