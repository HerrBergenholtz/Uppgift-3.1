using System;

namespace Uppgift_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder < 16)
            {
                Console.WriteLine("Tyvärr så är du för ung för att delta");
            }
            else if (ålder > 19)
            {
                Console.WriteLine("Tyvärr så är du för gammal för att delta i tävlingen");
            }
            else if (ålder > 16 && ålder < 19) {
                Console.WriteLine("Grattis! Du får delta.");
            }
        }
    }
}