using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Instrumento
{
    private string _modelo;

    public string Modelo
    {
        get { return _modelo; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _modelo = value;
        }
    }

    public Instrumento(string modelo)
    {
        Modelo = modelo;
    }

    public virtual string TocarNota()
    {
        return $"Instrumento {Modelo} tocando una nota.";
    }
}
