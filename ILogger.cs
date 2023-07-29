namespace H_W_Mod2_5;


    internal interface ILogger
{
    void Log(LogType type, string message);

    void Error(string message);
    void Info(string message);
    void Warning(string message);
}