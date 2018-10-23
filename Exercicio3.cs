using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {  
            
            bool par = true;
            {
                int[] impar;
                impar = new int [5];

                impar[1] = 1;
                impar[2] = 3;
                impar[3] = 5;
                impar[4] = 7;
                impar[5] = 9;

                int i = impar[5];

                if (i)
                {
                    Console.Write("False");
                } else
                {
                    Console.Write(par);
                }
            }

            int Verifica()
            {
                int[] num;
                num = new int[11];

                num[1] = 0;
                num[2] = 1;
                num[3] = 2;
                num[4] = 3;
                num[5] = 4;
                num[6] = 5;
                num[7] = 6;
                num[8] = 7;
                num[9] = 8;
                num[10] =9;
                num[11] =10;

                int n = num[11];
                return n;
            }
        }
    }
}
