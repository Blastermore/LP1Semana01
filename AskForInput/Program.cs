using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro:");
            string input_int = Console.ReadLine();
            int n = Convert.ToInt16(input_int);

            Console.WriteLine("Insira um número real:");
            string input_real = Console.ReadLine();
            float r = float.Parse(input_real);

            Console.WriteLine(r);
        }
    }
}
