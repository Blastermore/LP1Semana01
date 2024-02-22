using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string message1 = "Heyo!";
            string message2 = "Wassup!";
            string message3 = "Howdy! \u02C3\u006F\u02C2";
            string message4 = "cool hat!";

            Console.WriteLine(message1);
            Console.WriteLine(message2);
            Console.WriteLine(message3);
            Console.WriteLine(message4);


        }
    }
}
