using H_W_Mod2_5;

namespace H_W_Mod2_5
{

    internal class Program
    {
        static void Main(string[] args)
        {
            IFileService fileService = new FileService();
            var log = new Logger(fileService);

            var action = new Actions(log);

            var start = new App(action, log);
            start.Run();
        }
    }
}