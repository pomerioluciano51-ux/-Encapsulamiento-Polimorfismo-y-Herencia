using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Guitarra : Instrumento
{
    public int NumeroCuerdas { get; set; }

    public Guitarra(string modelo, int numeroCuerdas)
        : base(modelo)
    {
        NumeroCuerdas = numeroCuerdas;
    }

    public override string TocarNota()
    {
        return $"Guitarra {Modelo} tocando una nota con {NumeroCuerdas} cuerdas.";
    }
}