using System;

namespace Clase15
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadora myLavadora = new Lavadora();
            Television myTelevision = new Television();
            int opcion;

            Console.WriteLine("---------------------------")
            Console.WriteLine("Elija el producto: ");
            Console.WriteLine("Televisor [1]");
            Console.WriteLine("Lavadora [2]");
            Console.WriteLine("---------------------------")
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    myTelevision.precioFinal();
                    break;
                case 2:
                    myLavadora.precioFinal();
                    break;
                default:
                    break;
            }
            


        }
    }
}
