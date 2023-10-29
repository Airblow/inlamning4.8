using System;
namespace inlamning4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en valfri mening.");
            string userInput = Console.ReadLine().ToLower();

            Console.WriteLine("Skriv in 2 valfria bokstäver, inget mellanslag mellan bokstäverna.");
            string letterInput = Console.ReadLine().ToLower();

            if (userInput.Contains(letterInput[0]) && userInput.Contains(letterInput[1]))
            {
                Console.WriteLine();
                Console.WriteLine("Båda bokstäverna finns i din originala mening.");
            }
            else if (userInput.Contains(letterInput[0]))
            {
                Console.WriteLine();
                Console.WriteLine($"Endast '{letterInput[0]}' utav de två bokstäver du skrev in finns i din originala mening");
            }
            else if (userInput.Contains(letterInput[1]))
            {
                Console.WriteLine();
                Console.WriteLine($"Endast '{letterInput[1]}' utav de två bokstäver du skrev in finns i din originala mening");
            }
            else
            {
                Console.WriteLine("Det verkar som att inga av dina bokstäver finns i din originala mening");
            }


        }

    }

}
