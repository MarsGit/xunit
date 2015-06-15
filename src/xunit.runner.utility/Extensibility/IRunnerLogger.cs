namespace Xunit
{
    /// <summary>
    /// Interface implemented by runners, passed to <see cref="IRunnerReporter"/>, so that the
    /// report can log lines of text to the output device.
    /// </summary>
    public interface IRunnerLogger
    {
        /// <summary>
        /// Gets a lock object that can be used to ensure that multiple calls to
        /// log messages will always be grouped together.
        /// </summary>
        object LockObject { get; }

        /// <summary>
        /// Logs a normal-priority message.
        /// </summary>
        /// <param name="message">The message to be logged</param>
        void LogMessage(string message);

        /// <summary>
        /// Logs a high-priority message.
        /// </summary>
        /// <param name="message">The message to be logged</param>
        void LogImportantMessage(string message);

        /// <summary>
        /// Logs a warning.
        /// </summary>
        /// <param name="message">The message to be logged</param>
        void LogWarning(string message);

        /// <summary>
        /// Logs an error.
        /// </summary>
        /// <param name="message">The message to be logged</param>
        void LogError(string message);
    }
}