using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnsApp_NumeroParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * @autor: Erick Escamilla Charco
             */
            /*
             Tarea 9. Elaborar un Programa que solicite al usuario la introducción de un numero 
             entero en el rango de -1000000 a 1000000 y después de haberlo introducido, 
             el mismo determine e indique mediante un mensaje en pantalla si el numero es par o impar.
            */
            char continuar = 'n';
            int numero;
            do {
                Console.WriteLine("################################################################################");
                Console.WriteLine("--Programa que determina si un ENTERO ingresado por el usuario es PAR o IMPAR--");
                Console.Write("Ingrese un número ENTERO (entre -1000000 y 1000000): ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El número {0} es {1}.", numero, esPar(numero) ? "PAR" : "Impar");
                Console.WriteLine("\n\t¿Desea determinar si otro número ENTERO es PAR o Impar? [y/n]: ");
                continuar = Console.ReadKey().KeyChar;
            } while(Char.ToLower(continuar) == 'y');
            
        }

        private static bool esPar(int numero){
            // operador lógico ternario,  condicion ? valorVerdadero : valorFalso
            return numero % 2 == 0 ? true : false;
        }
    }
}
