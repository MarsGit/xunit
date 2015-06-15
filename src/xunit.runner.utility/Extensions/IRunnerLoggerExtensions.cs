using Xunit;

/// <summary>
/// Extensions methods for <see cref="IRunnerLogger"/>.
/// </summary>
public static class IRunnerLoggerExtensions
{
    /// <summary>
    /// Logs a normal-priority formatted message.
    /// </summary>
    /// <param name="logger">The logger</param>
    /// <param name="messageFormat">The format of the message to be logged</param>
    /// <param name="args">The format arguments</param>
    public static void LogMessage(this IRunnerLogger logger, string messageFormat, params object[] args)
    {
        logger.LogMessage(string.Format(messageFormat, args));
    }

    /// <summary>
    /// Logs a high-priority formatted message.
    /// </summary>
    /// <param name="logger">The logger</param>
    /// <param name="messageFormat">The format of the message to be logged</param>
    /// <param name="args">The format arguments</param>
    public static void LogImportantMessage(this IRunnerLogger logger, string messageFormat, params object[] args)
    {
        logger.LogImportantMessage(string.Format(messageFormat, args));
    }

    /// <summary>
    /// Logs a warning.
    /// </summary>
    /// <param name="logger">The logger</param>
    /// <param name="messageFormat">The format of the message to be logged</param>
    /// <param name="args">The format arguments</param>
    public static void LogWarning(this IRunnerLogger logger, string messageFormat, params object[] args)
    {
        logger.LogWarning(string.Format(messageFormat, args));
    }

    /// <summary>
    /// Logs an error.
    /// </summary>
    /// <param name="logger">The logger</param>
    /// <param name="messageFormat">The format of the message to be logged</param>
    /// <param name="args">The format arguments</param>
    public static void LogError(this IRunnerLogger logger, string messageFormat, params object[] args)
    {
        logger.LogError(string.Format(messageFormat, args));
    }
}