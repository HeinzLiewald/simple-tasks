using System;

namespace Runner.Services.InputReader {
    public class ConsoleReader : IInputReader {
        public char ReadKey() {
            return Console.ReadKey().KeyChar;
        }

        public string ReadLine() {
            return Console.ReadLine();
        }
    }
}
