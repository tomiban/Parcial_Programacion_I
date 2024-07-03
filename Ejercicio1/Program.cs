

namespace Ejercicio1;
class Program
{
    static void Main(string[] args)
    {
       
        List<int> numeros = new List<int>();

        while (true)
        {
            Console.WriteLine("Ingresa un numero - ENTER para finalizar:");
            string num = Console.ReadLine()!;
            if (string.IsNullOrEmpty(num))
            {
                break;
            }
            numeros.Add(int.Parse(num));
        }

        ImprimirIndicesPares(numeros);
        SumarNumerosImpares(numeros);
        var ListaActualizada = RemoverOcurrenciasLista(4,numeros);
        Console.WriteLine($"Lista actualizada: {string.Join("-", ListaActualizada)}");


        //DEFINICION DE FUNCIONES 
        static void ImprimirIndicesPares(List<int> numeros)
        {
            List<int> indicesPares = [];
            for (var i = 0; i < numeros.Count; i++)
            {
                if ((numeros[i] & 1) == 0)
                {
                    indicesPares.Add(i);
                }
            }

            if (indicesPares.Count == 0)
            {
                Console.WriteLine("No se ingreso ningun numero par");
            }
            else
            {
                Console.WriteLine($"Los numeros pares ingresados se encuentran en las posiciones: {string.Join("-", indicesPares)}");
            }
        }

        static void SumarNumerosImpares(List<int> numeros)
        {
            int sumaImpares = numeros.Where(numero => numero % 2 != 0).Sum();

            if (sumaImpares == 0)
                Console.WriteLine("No se ingreso ningun numero impar");
            else
                Console.WriteLine($"La suma de los numeros impares ingresados es: {sumaImpares}");
        }

        static List<int> RemoverOcurrenciasLista(int num, List<int> numeros)
        {
            if (numeros.Contains(num))
                numeros.RemoveAll(x => x == num);
            else
                Console.WriteLine("El numero no se encuentra en la lista");
            
            return numeros;
        }
    }
}
