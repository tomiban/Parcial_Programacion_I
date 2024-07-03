using System.Text;

namespace Ejercicio3;
class Program
{
    static void Main(string[] args)
    {

        //Ejercicio 3
        const string PATH_FILE = "reporte_estudiantes.txt";

        List<Estudiante> Clase = new List<Estudiante>()
        {
            new Estudiante("Tobi", 80, 60, 30),
            new Estudiante("Ricky", 70, 50, 60),
            new Estudiante("Galo", 20, 100, 100),
            new Estudiante("Tizi", 80, 80, 80),
        };

        Clase.ForEach(estudiante => Console.WriteLine($"Alumno: {estudiante.Nombre} - Promedio: {estudiante.CalcularPromedio()} - Condicion: {estudiante.HaAprobado()}"));

        Estudiante estudiante = new Estudiante("Tomi", 8, 8, 8);
        estudiante.CambiarNombre("Fausto");
        estudiante.CambiarCalificacionCiencia(5);
        estudiante.CambiarCalificacionMatematica(5);
        estudiante.CambiarCalificacionLiteratura(5);
        GenerarReporteEstudiantes(PATH_FILE, Clase);
    }


    //Ejercicio 4
    private static string GenerarLineaDeReporte(Estudiante estudiante)
    {
        return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\n", estudiante.Nombre, estudiante.CalificacionMatematicas, estudiante.CalificacionCiencia, estudiante.CalificacionLiteratura, estudiante.HaAprobado());
    }

    private static void EscribirEnArchivo(string path, StringBuilder contenido)
    {
        try
        {
            File.WriteAllText(path, contenido.ToString());
            Console.WriteLine("Reporte generado con exito");
        }
        catch (Exception e)
        {
            throw new Exception("Error en la escritura: ", e);
        }
    }

    static void GenerarReporteEstudiantes(string path, List<Estudiante> estudiantes)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Nombre\tMatematica\tCiencias\tLiteratura\tAprobado");
        foreach (var estudiante in estudiantes)
        {
            sb.Append(GenerarLineaDeReporte(estudiante));
        }

        EscribirEnArchivo(path, sb);
    }

}
