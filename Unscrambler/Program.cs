using System;
using System.Collections.Generic;

namespace Unscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuewordUnscrambler = true;
            do
            {

                Console.Write("Please enter an option -F for file and M for manual: ");
                string option = Console.ReadLine() ?? string.Empty;

                switch (option.ToUpper())
                {
                    case "F":
                        Console.Write("enter file name: ");
                        ExecuteScrambledWordsinFileScenario();
                        break;
                    case "M":
                        Console.Write("enter words to scramble: ");
                        ExcecuteScrambledWordsManualEntryScenario();
                        break;
                    default:
                        Console.WriteLine("Option was not recongnised");
                        break;
                }

                var continueUnscrambling = string.Empty;
                do
                {
                    Console.Write("Do you want to continue? (Y or N): ");
                    continueUnscrambling = (Console.ReadLine() ?? string.Empty);

                } while (!continueUnscrambling.Equals("Y", StringComparison.OrdinalIgnoreCase) && 
                !continueUnscrambling.Equals("N", StringComparison.OrdinalIgnoreCase));

            } while (continuewordUnscrambler);
        }

        private static void ExcecuteScrambledWordsManualEntryScenario()
        {
            throw new NotImplementedException();
        }

        private static void ExecuteScrambledWordsinFileScenario()
        {
            throw new NotImplementedException();
        }
    }
}
