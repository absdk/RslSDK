using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using _logger = Microsoft.Practices.EnterpriseLibrary.Logging.Logger;


namespace SoftwareGrid.ExceptionLogging
{
	public static class Logger
    {
        #region Methods

        [DebuggerStepThrough()]
        public static void LogInfo(string message)
        {
            _logger.Write(CreateEntry(message, TraceEventType.Information));
        }

        [DebuggerStepThrough()]
        public static void LogWarning(string message)
        {
            _logger.Write(CreateEntry(message, TraceEventType.Warning));
        }

        [DebuggerStepThrough()]
        public static void LogError(string message)
        {
            _logger.Write(CreateEntry(message, TraceEventType.Error));
        }

        [DebuggerStepThrough()]
        private static LogEntry CreateEntry(string message, TraceEventType severity)
        {
            return new LogEntry(message, "General", 0, 100, severity, string.Empty, null);
        }

        [DebuggerStepThrough()]
        private static LogEntry CreateEntry(string message, CustomExceptionType exceptionType, TraceEventType severity)
        {
            return new LogEntry(message, "General", 0, 100, severity, string.Empty, null);
        }


		#endregion
	}
}