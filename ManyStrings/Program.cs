using System;
using System.Security.Cryptography.X509Certificates;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            string message1 = "Heyo!";
            string message2 = "Wassup!";
            string message3 = "Howdy! \u02C3\u006F\u02C2";
            string message4 = "cool hat!";
            string message5 = message1 + " How you doin?";
            string message6 = "I have " + x + " apples!";
            string message7 = $"I do love having {x} apples!";

            Console.WriteLine(message1);
            Console.WriteLine(message2);
            Console.WriteLine(message3);
            Console.WriteLine(message4);
            Console.WriteLine(message5);
            Console.WriteLine(message6);
            Console.WriteLine(message7);

        }
    }
}
