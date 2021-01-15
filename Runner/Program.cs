using System;
using System.Diagnostics;

using Runner.Services.InputReader;
using Runner.Services.OutputWriter;

using SequenceAnalysis.Services.TextOperationsService;

using SumOfMultiple.Services.NumberOperationsService;

namespace Runner {
    public class Program {
        #region Services
        private static readonly IInputReader inputReader = new ConsoleReader();
        private static readonly IOutputWriter outputWriter = new ConsoleWriter();

        private static readonly INumberOperationsService numberOperations = new NumberOperationsService();
        private static readonly ITextOperationsService textOperations = new TextOperationsService();
        #endregion

        public static void Main(string[] args) {
            try {
                bool keepRunning;

                do {
                    keepRunning = ShowMenu();
                }
                while(keepRunning);
            } catch(Exception ex) {
                Debug.WriteLine(ex.ToString()); // TODO: Handle exception (log, report, ...)
            }
        }

        private static bool ShowMenu() {
            outputWriter.Clear();

            outputWriter.WriteLine("Options:");
            outputWriter.WriteLine("1 - Sum of multiple");
            outputWriter.WriteLine("2 - Sequence analysis");
            outputWriter.WriteLine("3 - Exit");

            switch(AskForInput("\nChoose an option: ")) {
                case "1":
                    SumOfMultiple();
                    AskForKeyToContinue();
                    return true;
                case "2":
                    SequenceAnalysis();
                    AskForKeyToContinue();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static void SumOfMultiple() {
            var input = AskForInput("Write a number: ");

            if(uint.TryParse(input, out var number)) {
                var result = numberOperations.CalculateSumOfMultiple(number);
                ShowResult(result.ToString());
            } else {
                ShowResult($"The input must be a valid number (Found '{input}')");
            }
        }

        private static void SequenceAnalysis() {
            var text = AskForInput("Write some text: ");

            var result = textOperations.GetUppercaseSequenceAnalysis(text);

            ShowResult(result);
        }

        private static string AskForInput(string message) {
            outputWriter.Write(message);
            return inputReader.ReadLine();
        }

        private static void AskForKeyToContinue() {
            outputWriter.Write("\nPress any key to continue...");
            inputReader.ReadKey();
        }

        private static void ShowResult(string result) {
            outputWriter.WriteLine($"The result is: {result}");
        }
    }
}
