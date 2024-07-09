using System;

namespace Clase08_07_2024
{//Llave de inicio de la solución
    //encapsula la clase para evitar conflicto entre otro proyectos
    internal class Program
    {
        static void Main(string[] args)
        {//llave inicio 'main'
         //tipos de datos: ENTERO
            /*
             * para declarar una variable primero indico el tipo de dato
             * luego le asigno un nombre, luego utilizo el operador de asignación (=),
             * luego indico el valor
             * para imprimir ultilizo la clase Console y utilizo el metodo writeline
            */
            int numero = 4;
            Console.WriteLine(numero);
            Console.WriteLine("El numero es:" + numero);
            Console.WriteLine($"El numero es: {numero}");
            Console.ReadKey();

            //si se declara una variable de tipo byte, solo se alamcena entre 0 y 255
            byte numero2 = 255;
            Console.WriteLine(numero2);

            short numero3 = 1000;
            long numero4 = 15; 

        }//llave de cierre 'main'
    }
}//llave cierre de la solucíon
        