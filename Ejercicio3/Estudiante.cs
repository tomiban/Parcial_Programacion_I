using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio3;
public class Estudiante
{
    public Estudiante(string nombre, int calificacionCiencia, int calificacionMat, int calificacionLit)
    {
        Nombre = nombre;
        CalificacionCiencia = calificacionCiencia;
        CalificacionMatematicas = calificacionMat;
        CalificacionLiteratura = calificacionLit;
    }
    public string Nombre { get; set; } = string.Empty;
    public int CalificacionCiencia { get; set; }
    public int CalificacionMatematicas { get; set; }
    public int CalificacionLiteratura { get; set; }


    public double CalcularPromedio()
    {
        // Suma las notas sin crear una lista
        int sumaNotas = CalificacionCiencia + CalificacionLiteratura + CalificacionMatematicas;
        return (double)sumaNotas / 3;
    }

    public bool HaAprobado()
    {
        var promedio = CalcularPromedio();
        return promedio >= 60;
    }

    public void CambiarNombre(string nombre)
    {
        this.Nombre = nombre;
    }

    public void CambiarCalificacionCiencia(int calificacionCiencia)
    {
        this.CalificacionCiencia = calificacionCiencia;
    }

    public void CambiarCalificacionMatematica(int calificacionMatematica)
    {
        this.CalificacionMatematicas = calificacionMatematica;
    }

    public void CambiarCalificacionLiteratura(int calificacionLiteratura)
    {
        this.CalificacionLiteratura = calificacionLiteratura;
    }
}
