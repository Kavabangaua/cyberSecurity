using System;

class Program
{
    static void Main()
    {

        Random random1 = new Random(42); // Seed with value 42
        Random random2 = new Random(100); // Seed with value 100

        Console.WriteLine("Generating random numbers for random1:");
        GenerateAndDisplayRandomNumbers(random1);

        Console.WriteLine("\nGenerating random numbers for random2:");
        GenerateAndDisplayRandomNumbers(random2);


        CompareRandomSequences(random1, random2);

        Console.ReadLine();
    }

    static void GenerateAndDisplayRandomNumbers(Random random)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(random.Next());
        }
    }

    static void CompareRandomSequences(Random random1, Random random2)
    {
        Console.WriteLine("\nComparing random sequences for different initial values:");

        for (int i = 0; i < 5; i++)
        {
            int value1 = random1.Next();
            int value2 = random2.Next();

            Console.WriteLine($"Value from random1: {value1}, Value from random2: {value2}, Equal? {value1 == value2}");
        }
    }
}
