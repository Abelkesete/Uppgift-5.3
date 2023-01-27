using System;
namespace Uppgift_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv tre heltal: ");
            int[] tal = new int[3];
  

                tal[0] = int.Parse(Console.ReadLine());
                 tal[1] = int.Parse(Console.ReadLine());
                tal[2] = int.Parse(Console.ReadLine());
            {
                Console.WriteLine(" summan av dina heltal är " + (tal[0] + tal[1] + tal[2]));
            }
 
        }
    }
}
