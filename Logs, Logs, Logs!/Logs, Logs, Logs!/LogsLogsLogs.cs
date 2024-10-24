namespace LogsLogsLogs;

// TODO: define the 'LogLevel' enum
public enum LogLevel
{
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42,
    Unknown = 0
}


static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        if (logLine.StartsWith("[TRC]"))
            return LogLevel.Trace;

        else if (logLine.StartsWith("[DBG]"))
            return LogLevel.Debug;

        else if (logLine.StartsWith("[INF]"))
            return LogLevel.Info;

        else if (logLine.StartsWith("[WRN]"))
            return LogLevel.Warning;

        else if (logLine.StartsWith("[ERR]"))
            return LogLevel.Error;

        else if (logLine.StartsWith("[FTL]"))
            return LogLevel.Fatal;

        else 
            return LogLevel.Unknown;
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        return $"{logLevel.GetHashCode()}:{message}";
    }
}
