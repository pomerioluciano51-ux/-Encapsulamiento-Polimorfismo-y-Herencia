using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Alerta
{
    private string _codigo;

    public string Codigo
    {
        get { return _codigo; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _codigo = value;
        }
    }

    public Alerta(string codigo)
    {
        Codigo = codigo;
    }

    public virtual string DispararProtocolo()
    {
        return $"Alerta {_codigo} activada.";
    }
}
