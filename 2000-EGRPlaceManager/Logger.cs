using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace MRK {
    public enum LogType {
        Info,
        Warning,
        Error
    }

    public class Logger {
        static void Log(LogType type, string msg, string callerPath) {
            string prefix = "[";

            switch (type) {

                case LogType.Info:
                    prefix += "INFO";
                    break;

                case LogType.Error:
                    prefix += "ERROR";
                    break;

                case LogType.Warning:
                    prefix += "WARN";
                    break;
            }

            prefix += "]";

            string caller = Main.Instance.ConsoleShowCallerNames ? $"[{Path.GetFileNameWithoutExtension(callerPath)}] " 
                : string.Empty;

            Main.Instance.AppendToConsole($"[{Core.Instance.RelativeTime:hh\\:mm\\:ss\\.fff}] " +
                $"{prefix} " +
                $"{caller}" +
                $"{msg}" +
                $"{Environment.NewLine}");
        }

        public static void LogInfo(string msg, [CallerFilePath] string path = null) {
            Log(LogType.Info, msg, path);
        }

        public static void LogWarning(string msg, [CallerFilePath] string path = null) {
            Log(LogType.Warning, msg, path);
        }

        public static void LogError(string msg, [CallerFilePath] string path = null) {
            Log(LogType.Error, msg, path);
        }

        public static void Log(string msg, [CallerFilePath] string path = null) {
            Log(LogType.Info, msg, path);
        }
    }
}
