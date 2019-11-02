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

                var continueDecision = string.Empty;
                do
                {
                    Console.Write("Do you want to continue? (Y or N): ");
                    continueDecision = (Console.ReadLine() ?? string.Empty);

                } while (
                !continueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase) && 
                !continueDecision.Equals("N", StringComparison.OrdinalIgnoreCase));

                continuewordUnscrambler = continueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase);

            } while (continuewordUnscrambler);
        }

        private static void ExcecuteScrambledWordsManualEntryScenario()
        {
            var ManualInput = Console.ReadLine() ?? string.Empty;
            string[] ScrambledWords = ManualInput.Split(',');
            DislayMatchedUnscrambledWords(ScrambledWords);
        }

        private static void ExecuteScrambledWordsinFileScenario()
        {
            var FileName = Console.ReadLine() ?? string.Empty;
            string[] ScrambledWords = _fileReader.Read(FileName);
            DislayMatchedUnscrambledWords(ScrambledWords);
        }

        private static void DislayMatchedUnscrambledWords(string[] scrambledWords)
        {
            string wordList = _fileReader.Read(wordListFileName);

            List<MatchedWord> matchedWords = _WordMatcher.Match(scrambledWords, wordList);

            if (matchedWords.Any())
            {
                foreach (var matchedWord in matchedWords)
                {
                    Console.WriteLine($"Match found for {matchedWord }");
                }
            }
            else
            {
                Console.WriteLine("No Matches have been matched");
            }
        }
    }
}
