using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 0x2;
            uint c = 3U;

            char d = '\u0064';
            char e = '\u0045';
            char f = '\u2606';

            double g = 7.17890;
            float h = 12.146f;
            float i = 2.3e8f;

            bool j = false;
            bool k = true;

            Console.WriteLine(a +"\n" + b + "\n" + c);
            Console.WriteLine(d +"\n" + e + "\n" + f);
            Console.WriteLine(g +"\n" + h + "\n" + i);
            Console.WriteLine(j +"\n" + k);
        }
    }
}
