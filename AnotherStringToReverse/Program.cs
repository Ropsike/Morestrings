using System;

namespace AnotherStringToReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloW = "Hello World!";
            for(int i = helloW.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(helloW[i]);
            }

         
        }
    }
}
