using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Empleado
{
    private int _idEmpleado;

    public int IdEmpleado
    {
        get { return _idEmpleado; }
        set
        {
            if (value > 0)
                _idEmpleado = value;
        }
    }

    public Empleado(int idEmpleado)
    {
        IdEmpleado = idEmpleado;
    }

    public virtual string Trabajar()
    {
        return $"Empleado {_idEmpleado} trabajando.";
    }
}
