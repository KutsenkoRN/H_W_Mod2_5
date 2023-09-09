
    namespace H_W_Mod2_5
{
   
    internal class Logger : ILogger
    {
        private readonly IFileService _fileService;

        public Logger(IFileService fileService)
        {
            _fileService = fileService;
        }

        public void Log(LogType type, string message)
        {
            string logData = $"{DateTime.Now}: {type}:  {message}";
            Console.WriteLine(logData);
            _fileService.Save(logData);
        }

        public void Error(string message)
        {
            Log(LogType.Error, message);
        }

        public void Info(string message)
        {
            Log(LogType.Info, message);
        }

        public void Warning(string message)
        {
            Log(LogType.Warning, message);
        }
    }
}