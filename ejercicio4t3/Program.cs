using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4t3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número del 1 al 7:");
            int numero = Convert.ToInt32(Console.ReadLine());

            string nombreDia = ObtenerNombreDia(numero);

            if (nombreDia != "")
            {
                Console.WriteLine($"El día correspondiente al número {numero} es: {nombreDia}");
            }
            else
            {
                Console.WriteLine("Número inválido. Debe ser un número del 1 al 7.");
            }

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static string ObtenerNombreDia(int numero)
        {
            switch (numero)
            {
                case 1:
                    return "Lunes";
                case 2:
                    return "Martes";
                case 3:
                    return "Miércoles";
                case 4:
                    return "Jueves";
                case 5:
                    return "Viernes";
                case 6:
                    return "Sábado";
                case 7:
                    return "Domingo";
                default:
                    return "";
            }


        }
    }
}
