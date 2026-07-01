
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AspiradoraRobot : Dispositivo
{
    public int CapacidadTanque { get; set; }

    public AspiradoraRobot(string habitacion, int capacidadTanque)
        : base(habitacion)
    {
        CapacidadTanque = capacidadTanque;
    }

    public override string EjecutarFuncion()
    {
        return $"Aspiradora Robot limpiando en {Habitacion}. Capacidad: {CapacidadTanque} L.";
    }
}