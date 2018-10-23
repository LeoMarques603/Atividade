using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digitos = new int[] { 0, 1, 2, 3 };
            digitos[0] = 0 + 1 + 2 + 3 + 7;
            digitos[1] = 0 + 1 + 2 + 3 + 7;
            digitos[2] = 0 + 1 + 2 + 3 + 7;
            digitos[3] = 0 + 1 + 2 + 3 + 7;

            int aux = digitos[0];
            digitos[0] = digitos[0];
            aux = digitos[2];

            int aux1 = digitos[1];
            digitos[1] = digitos[1];
            aux1 = digitos[3];

            Console.Write(digitos);
        }
    }
}
