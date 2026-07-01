using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Plato
{
    private string nombrePlato;

    public string NombrePlato
    {
        get { return nombrePlato; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nombrePlato = value;
        }
    }

    public Plato(string nombrePlato)
    {
        NombrePlato = nombrePlato;
    }

    public virtual string Preparar()
    {
        return $"Preparando {NombrePlato}.";
    }
}