using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularVPN
{
    class Operaciones
    {
        public void CalcularVPN()
        {
            double valorInicial, flujoNeto, tmar, sumatoria;
            int numeroAnios;

            Console.WriteLine("*****App para calcular el Valor Presente Neto*****");

            Console.WriteLine("Ingrese la proyección en años del proyecto");
            numeroAnios = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la inversión inicial");
            valorInicial = Convert.ToDouble(Console.ReadLine()) *-1 ;

            Console.WriteLine("Ingrese la Tasa Mínima Aceptable de Rendimiento(TMAR)");
            tmar = Convert.ToDouble(Console.ReadLine())/100;

            //aca se almacena la suma de los resultados de dividir el FNE/1+TMAR^n que al final se resta a la inversión inicial
            sumatoria = 0;
            for (int contador = 1; contador <= numeroAnios; contador++)
            {
                Console.WriteLine("Indique el Flujo Neto de Efectivo(FNE) para el año "+contador);
                flujoNeto = Convert.ToDouble(Console.ReadLine());
                double denominador = Math.Pow(1 + tmar, contador);
                sumatoria =sumatoria + flujoNeto /denominador ;
            }
            Console.WriteLine("El Valor Presente Neto(VPN) es: "+(valorInicial+sumatoria));
            Console.ReadKey();
        }
    }
}
