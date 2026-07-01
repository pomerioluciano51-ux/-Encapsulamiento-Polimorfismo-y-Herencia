using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dispositivo
{
    private string habitacion;

    public string Habitacion
    {
        get { return habitacion; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                habitacion = value;
        }
    }

    public Dispositivo(string habitacion)
    {
        Habitacion = habitacion;
    }

    public virtual string EjecutarFuncion()
    {
        return $"Dispositivo en {Habitacion} funcionando.";
    }
}