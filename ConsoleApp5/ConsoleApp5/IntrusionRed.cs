using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class IntrusionRed : Alerta
{
    public string IpOrigen { get; set; }

    public IntrusionRed(string codigo, string ipOrigen)
        : base(codigo)
    {
        IpOrigen = ipOrigen;
    }

    public override string DispararProtocolo()
    {
        return $"Intrusión detectada desde la IP {IpOrigen}. Protocolo de seguridad ejecutado.";
    }
}
