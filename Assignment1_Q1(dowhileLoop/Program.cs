using System;

namespace Assignment1_Q1_dowhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
           int i = 0;
            do
            {
                int j = 1;
                int Sum = i*j;
                do
                {
                    Console.WriteLine(i + " X " + j  + "=" + Sum);
                        j++;
                        Sum = i * j;
                } while (j <= i);
                 i++;
            } while (i <= 10);
        }
    }
}
