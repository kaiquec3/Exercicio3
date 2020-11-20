using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Quadrado();
            double k;

            do
            {
                Console.Write("Informe o valor da diagonal do quadrado: ");
                k = double.Parse(Console.ReadLine());

                if (k > 0) a1.SetDiagonal(k);
            }
            while (k <= 0);
            

            Console.WriteLine($"O valor da área do quadrado é igual a {a1.CalcularArea()}");
        }
    }
}
