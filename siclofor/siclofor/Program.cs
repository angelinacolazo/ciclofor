using System;

namespace siclofor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine(" imprimir los numeros de la x a la y ");
            Console.WriteLine("cual es el valor  x");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("cual es el valor de m? ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" de cuanto en cuanto quieres que valla? ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                for (int i = a; i >b; i-= c)
                {
                    Console.WriteLine("i=" + i);
                }

               
                  
            }
            else
                {
                for (int i = a; i < b; i += c)
                {
                    Console.WriteLine("i=" + i);
                }
            }
        }
    }
}
