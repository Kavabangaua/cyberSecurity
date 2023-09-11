using System;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        int numTrials = 5;
        int sequenceLength = 10;

        for (int trial = 1; trial <= numTrials; trial++)
        {
            Console.WriteLine($"Trial {trial}:");

            byte[] randomSequence1 = GenerateRandomSequence(sequenceLength);
            byte[] randomSequence2 = GenerateRandomSequence(sequenceLength);

            Console.WriteLine("Random Sequence 1: ");
            DisplayByteArray(randomSequence1);

            Console.WriteLine("Random Sequence 2: ");
            DisplayByteArray(randomSequence2);

            bool sequencesEqual = CompareByteArrays(randomSequence1, randomSequence2);

            if (sequencesEqual)
            {
                Console.WriteLine("Sequences are equal.");
            }
            else
            {
                Console.WriteLine("Sequences are not equal.");
            }

            Console.WriteLine();
        }
    }


    static byte[] GenerateRandomSequence(int length)
    {
        using (var rng = RandomNumberGenerator.Create())
        {
            byte[] randomBytes = new byte[length];
            rng.GetBytes(randomBytes);
            return randomBytes;
        }
    }


    static bool CompareByteArrays(byte[] arr1, byte[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            return false;
        }

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                return false;
            }
        }

        return true;
    }


    static void DisplayByteArray(byte[] arr)
    {
        foreach (byte b in arr)
        {
            Console.Write($"{b:X2} ");
        }
        Console.WriteLine();
    }
}
