using System;

namespace SeithmanSoftware.Ensure.Exceptions
{
    /// <summary>
    /// An exception thrown by <see cref="Ensure.AgumentInRange{T}(T, T, T, string, string, string, int)"/><br />
    /// Encapsulates an <see cref="ArgumentOutOfRangeException"/>.
    /// </summary>
    class EnsureArgumentNotOutOfRangeException : EnsureBaseException
    {
        /// <summary>
        /// Constructs an <see cref="EnsureArgumentNotOutOfRangeException"/> instance.
        /// </summary>
        /// <param name="actualValue">The actual value of the argument</param>
        /// <param name="argName">The name of the argument</param>
        /// <param name="callerName">The name of the caller that invoked <see cref="Ensure.AgumentInRange{T}(T, T, T, string, string, string, int)"/></param>
        /// <param name="callerSourceFile">The source file that contains the caller that invoked <see cref="Ensure.AgumentInRange{T}(T, T, T, string, string, string, int)"/></param>
        /// <param name="callerSourceLine">The line where the caller invoked <see cref="Ensure.AgumentInRange{T}(T, T, T, string, string, string, int)"/></param>
        public EnsureArgumentNotOutOfRangeException(object actualValue, string argName, string callerName, string callerSourceFile, int callerSourceLine) :
            base(new ArgumentOutOfRangeException(argName, actualValue, null), callerName, callerSourceFile, callerSourceLine)
        {
        }
    }
}
