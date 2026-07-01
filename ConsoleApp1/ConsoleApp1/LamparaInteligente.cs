
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LamparaInteligente : Dispositivo
{
    public string ColorLed { get; set; }

    public LamparaInteligente(string habitacion, string colorLed)
        : base(habitacion)
    {
        ColorLed = colorLed;
    }

    public override string EjecutarFuncion()
    {
        return $"Lámpara Inteligente encendida en {Habitacion} con color {ColorLed}.";
    }
}