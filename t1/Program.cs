using System;
using globalizer;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello");


            int i, j;

            Console.Write("Enter first number");
            i = int.Parse(Console.ReadLine());

            Console.Write("Enter second number");
            j = int.Parse(Console.ReadLine());

            Console.WriteLine(i+j);

            int k = 200;
            byte b = 100;
            k =b;
            Console.WriteLine(k);
            int q = 200;
            byte w = 100;
            w = (byte)q;
            Console.WriteLine(w);

            addition add = new addition();
            Console.WriteLine(add.AddTwoNum(i, j));
        }

    }
}
