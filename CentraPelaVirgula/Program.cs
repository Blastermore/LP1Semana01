using System;

namespace CentraPelaVirgula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insere 4 números reais:");

            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            string n3 = Console.ReadLine();
            string n4 = Console.ReadLine();

            float n1_pro =float.Parse(n1);
            float n2_pro =float.Parse(n2);
            float n3_pro =float.Parse(n3);
            float n4_pro =float.Parse(n4);

            string n1_pro_string = $"{n1_pro,6:f2}";
            string n2_pro_string = $"{n2_pro,6:f2}";
            string n3_pro_string = $"{n3_pro,6:f2}";
            string n4_pro_string = $"{n4_pro,6:f2}";


            Console.WriteLine(n1_pro_string);
            Console.WriteLine(n2_pro_string);
            Console.WriteLine(n3_pro_string);
            Console.WriteLine(n4_pro_string);

        }
    }
}

