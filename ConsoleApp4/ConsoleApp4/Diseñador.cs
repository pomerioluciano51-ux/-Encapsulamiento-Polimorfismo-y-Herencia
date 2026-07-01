using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Disenador : Empleado
{
    public string HerramientaFavorita { get; set; }

    public Disenador(int idEmpleado, string herramientaFavorita)
        : base(idEmpleado)
    {
        HerramientaFavorita = herramientaFavorita;
    }

    public override string Trabajar()
    {
        return $"Diseñador creando proyectos con {HerramientaFavorita}.";
    }
}