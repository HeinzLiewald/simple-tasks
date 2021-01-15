namespace Runner.Services.OutputWriter {
    public interface IOutputWriter {

        void Clear();
        void Write(string message);
        void WriteLine(string message);
    }
}
