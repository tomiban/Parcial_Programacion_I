namespace Ejercicio2;
class Program
{
    static void Main(string[] args)
    {
        Fruta manzana = new Fruta("Manzana", 300, [20, 30, 25, 35, 20, 15, 40]);
        Fruta banana = new Fruta("Banana", 400, [15, 20, 25, 30, 15, 10, 25]);
        Fruta pera = new Fruta("Pera", 500, [10, 15, 20, 25, 10, 5, 20]);

        List<Fruta> frutas = [manzana, banana, pera];

        frutas.ForEach(fruta => Console.WriteLine($"El ingreso total generado en la semana por la venta de {fruta.Nombre} fue de ${fruta.CalcularIngresoTotalSemanal()}"));
        frutas.ForEach(fruta => Console.WriteLine($"El ingreso maximo generado en la semana por la venta de {fruta.Nombre} fue de ${fruta.CalcularIngresoMaximoSemanal()}"));
        frutas.ForEach(fruta => Console.WriteLine($"La venta minima de {fruta.Nombre} en la semana fue de ${fruta.CalcularIngresoMinimoSemanal()}"));
        frutas.ForEach(fruta => Console.WriteLine($"El promedio de ingresos de la venta de {fruta.Nombre} fue de ${fruta.CalcularPromedioIngresoSemanal()}"));
        Console.WriteLine($"El total de ingresos de la tiende fue de ${CalcularIngresoTotalTienda(frutas)}");


        // FUNCION ESTATICA PARA CALCULAR EL INGRESO TOTAL GENERADO ENTRE LAS VENTAS DE LAS 3 FRUTAS
        static int CalcularIngresoTotalTienda(List<Fruta> frutas) => frutas.Sum(fruta => fruta.CalcularIngresoTotalSemanal());

    }
}
