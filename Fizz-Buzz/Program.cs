using System;

namespace Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n1; // declaramos las variables que nos servira como contador.

            // Les asignamos el valor inicial a dichas variables
            n = 3;
            n1 = 5;

            // Implementamos un ciclo for, el cual nos generará los numeros del 1-100
            for (int i = 1; i <= 100; i++)
            {
                /* Implementamos una condicional en donde se evaluará si n y n1 son iguales al
                   al valor proporcionado por el ciclo for*/

                if (i == n && i == n1) // en caso de que sea verdadero, realizara lo siguiente:
                {
                    Console.WriteLine(i + " Fizz Buzz"); // Imprimir en consola el numero y la palabra Fizz Buzz

                    // Aqui incrementamos el valor de nuestros contadores
                    n += 3;
                    n1 += 5;

                }
                else if (i == n) /* en caso de que la condicional anterior sea falso, pues verificará si el
                                     valor suministrado es igual a n*/
                {
                    Console.WriteLine(i + " Fizz"); // si es verdadero imprimirá en consola el numero y la palabra Fizz
                    n += 3; // Aqui incrementamos el valor de nuestro contador
                }
                else if (i == n1) /* en caso de que la condicional anterior sea falso, pues verificará si el
                                     valor suministrado es igual a n1*/
                {
                    Console.WriteLine(i + " Buzz"); // si es verdadero imprimirá en consola el numero y la palabra Buzz
                    n1 += 5; //Aqui incrementamos el valor de nuestro contador
                }
                else // en caso de que todas las condicionales anteriores sean falsas, entonces solo va imprimir el numero
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey(); // esto permite que todo lo realizado se quede fijo en consola
        }

    }
}
