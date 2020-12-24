using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {

            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);

            int minumero;

            int intentos = 0;

            Console.WriteLine("Introduce un n° entre 0 y 100");

            do
            {
                intentos++;

                try
                {
                    minumero = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {

                    Console.WriteLine("No introduciste un valor numerico valido. Se utilizara el 0 por defecto");
                    minumero = 0;
                }
                if (minumero > aleatorio) Console.WriteLine("El n° es mas bajo");

                if (minumero < aleatorio) Console.WriteLine("El n° es mas alto");

            } while (aleatorio != minumero);

                Console.WriteLine($"Correcto! Has Necesitado {intentos} intentos");

            Console.WriteLine("A partir de esta linea de código el programa continuara");
            
                

            
        }
    }
}
