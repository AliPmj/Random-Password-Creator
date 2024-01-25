using System;
using System.Text;

// Created By Mr.PMJ

namespace RandomPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            const string symbols = "-*&^%$#@!";
            const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789" + symbols;

            Random random = new Random();
            bool continueGenerating = true;

            while (continueGenerating)
            {
                int passwordLength = random.Next(8, 17);
                StringBuilder passwordBuilder = new StringBuilder();
                for (int i = 0; i < passwordLength; i++)
                {
                    int index = random.Next(validChars.Length);
                    passwordBuilder.Append(validChars[index]);
                }

                string password = passwordBuilder.ToString();
                Console.WriteLine("Generated Password: " + password);

                Console.WriteLine("Generate another password? (Y/N)");
                string userInput = Console.ReadLine();
                continueGenerating = userInput.Equals("Y", StringComparison.OrdinalIgnoreCase);

            }
        }
    }
}