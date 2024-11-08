namespace SOLID_5
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[INFO] {message}");
        }
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.AppendAllText("log.txt", message + Environment.NewLine);
        }
    }

    public class Application
    {
        private readonly ILogger _logger;

        public Application(ILogger logger)
        {
            _logger = logger;
        }

        public void Run()
        {
            _logger.Log("Приложение запущено.");
        }
    }

    class Program
    {
        static void Main()
        {
            ILogger logger = new ConsoleLogger();
            var app = new Application(logger);
            app.Run();

            ILogger fileLogger = new FileLogger();
            var appWithFileLogger = new Application(fileLogger);
            appWithFileLogger.Run();
        }
    }

}
