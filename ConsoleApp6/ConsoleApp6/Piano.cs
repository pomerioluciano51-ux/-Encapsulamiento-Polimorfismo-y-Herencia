using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Piano : Instrumento
{
    public int NumeroTeclas { get; set; }

    public Piano(string modelo, int numeroTeclas)
        : base(modelo)
    {
        NumeroTeclas = numeroTeclas;
    }

    public override string TocarNota()
    {
        return $"Piano {Modelo} tocando una nota con {NumeroTeclas} teclas.";
    }
}