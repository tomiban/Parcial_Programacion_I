using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Fruta
    {
        public Fruta(string nombre, int precioPorKg, IReadOnlyList<int> cantidadVendida)
        {
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            PrecioPorKg = precioPorKg;
            CantidadVendida = new List<int>(cantidadVendida);
        }
        public string Nombre { get; set; } = string.Empty;
        public int PrecioPorKg { get; set; }
        public List<int>? CantidadVendida { get; set; }

        public int CalcularIngresoTotalSemanal()
        {
            return CantidadVendida!.Sum(cantidad => cantidad * PrecioPorKg);
        }

        public int CalcularIngresoMinimoSemanal()
        {
            return CantidadVendida!.Count == 0 ? 0 : CantidadVendida!.Min() * PrecioPorKg;
        }

        public int CalcularIngresoMaximoSemanal()
        {
            return CantidadVendida?.Max() * PrecioPorKg ?? 0;
        }

        public double CalcularPromedioIngresoSemanal()
        {
            return CantidadVendida?.Sum(c => c * PrecioPorKg) / CantidadVendida?.Count ?? 0;
        }
    }
}