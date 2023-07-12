// See https://aka.ms/new-console-template for more information
using System;

namespace LengthHelperConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LengthHelperLibrary.LengthHelper lengthHelper = new LengthHelperLibrary.LengthHelper();

            string[] inputs = { "", "123", "123456789010", null };

            foreach (string input in inputs)
            {
                try
                {
                    int length = lengthHelper.FindLength(input);
                    Console.WriteLine($"Length of '{input}' is: {length}");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Input cannot be null.");
                }
            }

            Console.ReadLine();
        }
    }
}
