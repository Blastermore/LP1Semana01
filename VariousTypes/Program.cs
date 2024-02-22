using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = 1;
            int b = 0x2;
            uint c = 3U;

            char d = '\u0064';
            char e = '\u0045';
            char f = '\u2606';

            Console.WriteLine(a +"\n" + b + "\n" + c);
            Console.WriteLine(d +"\n" + e + "\n" + f);
        }
    }
}
