using System;
using System.Linq;

namespace Log_Levels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LogLine.Message(" [ERROR]: Stack overflow "));
            Console.WriteLine(LogLine.LogLevel(" [ERROR]: Stack overflow "));
            Console.WriteLine(LogLine.Reformat(" [ERROR]: Stack overflow "));
            
        }
    }

    static class LogLine
    {
        public static string Message(string logLine)
        {
            int indexMessage = logLine.IndexOf(":") + 1;
            string message = logLine.Substring(indexMessage).Trim();
            return message;
        }
        public static string LogLevel(string logLine)
        {
            int index1 = logLine.IndexOf('[');
            int index2 = logLine.IndexOf(']');
            string level = logLine.Substring(index1 + 1, index2 - index1 - 1).ToLower();
            return level;
        }
        public static string Reformat(string logLine)
        {
            return $"{Message(logLine)} ({LogLevel(logLine)})";
        }
    }

}
