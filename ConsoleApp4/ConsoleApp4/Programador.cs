using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Programador : Empleado
{
    public string LenguajePrincipal { get; set; }

    public Programador(int idEmpleado, string lenguajePrincipal)
        : base(idEmpleado)
    {
        LenguajePrincipal = lenguajePrincipal;
    }

    public override string Trabajar()
    {
        return $"Programador desarrollando en {LenguajePrincipal}.";
    }
}