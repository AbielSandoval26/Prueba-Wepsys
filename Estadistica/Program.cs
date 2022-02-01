using System;
using System.Linq;

namespace Estadistica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaramos nuestro arreglo y le asignamos el valor que tendra
            int[] conjunto = new int[] { 10, 8, 3, 2, 10, 1, 5, 7, 9, 4, 10 };

            // Ordenamos nuestro arreglo de manera descendente
            Array.Sort(conjunto);

            // Declaramos las diferentes variables con el tipo de dato que recibirá
            int minimo, maximo, rango;
            double promedio, mediana;
            int numMax = conjunto[0];
            int maxVeces = 0;

            // designamos una variable que llevará la longitud de nuestro arreglo
            int n = conjunto.Length;

            /* Hacemos utilizacion de los metodos Min, Max y Average para obtener el 
               valor minimo, maximo y el promedio de nuestro arreglo */
            minimo = conjunto.Min();
            maximo = conjunto.Max();
            promedio = Math.Round(conjunto.Average()); // Utilizamos Math.Round para redondiar nuestro promedio

            /* Para obtener la mediana dividimos n / 2 dentro de la variable de nuestro arreglo 
               para obtener el valor central */
            mediana = conjunto[(n / 2)];

            // Para obtener el rango restamos el valor maximo de nuestro arreglo con el valor minimo
            rango = maximo - minimo;


            // Declararamos nuestra variable que hara la funcion de contador
            int i = 0;

            // Hacemos uso del ciclo while, el cual va a repetir el proceso mientras la condicion sea falsa
            // este ciclo recorrera el arreglo completo
            while (i < n)
            {
                // Declararamos nuestra variable que hara la funcion de contador
                int numVeces = 0;
                int j = 0;

                /* Hacemos uso de otro ciclo while, el cual tiene como funcion autoincrementar mis variables 
                   j y numVeces cuando los numero sean iguales en ambos ciclos */
                while (j < n)
                {
                    if (conjunto[j] == conjunto[i])
                        numVeces++;
                    j++;
                }

                /* Verificamos si el numero de veces es mayor al maximo de veces (este es igual a 0),
                   ya que este es su valor con el cual se declaró */
                if (numVeces > maxVeces)
                {
                    // Asignamos el valor del numero mas repetido en nuestro arreglo
                    numMax = conjunto[i];
                    // Asignamos el valor de cuantas veces se repitio nuestro numero.
                    maxVeces = numVeces;
                }

                i++; // autoincrementamos nuestra variable i para que asi nuestro ciclo while no sea un bucle infinito
            }

            // Mostramos en consola nuestros resultados
            Console.WriteLine("El valor minimo es " + minimo);
            Console.WriteLine("El valor maximo es " + maximo);
            Console.WriteLine("El promedio es " + promedio);
            Console.WriteLine("La moda es " + numMax);
            Console.WriteLine("La mediana es " + mediana);
            Console.WriteLine("El rango es " + rango);

            // esto permite que todo lo realizado se quede fijo en consola
            Console.ReadKey();
        }
    }
}
