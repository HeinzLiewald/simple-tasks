using System;

namespace Runner.Services.OutputWriter {
    public class ConsoleWriter : IOutputWriter {
        public void Clear() {
            Console.Clear();
        }

        public void Write(string message) {
            Console.Write(message);
        }

        public void WriteLine(string message) {
            Console.WriteLine(message);
        }
    }
}
