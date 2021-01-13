using System;

namespace SeithmanSoftware.Ensure.Exceptions
{
    /// <summary>
    /// A base exception thrown by <see cref="Ensure"/> tests.<br/>
    /// This class encapsulates another exception, tacking on information about
    /// the caller who invoked the <see cref="Ensure"/> test throwing the exception.
    /// </summary>
    public abstract class EnsureBaseException : Exception
    {
        /// <summary>
        /// Constructs a <see cref="EnsureBaseException"/> instance
        /// </summary>
        /// <param name="baseException">The base exception to encapsulate</param>
        /// <param name="callerName">The name of the caller of the <see cref="Ensure"/> test</param>
        /// <param name="callerSourceFile">The source file the caller of the <see cref="Ensure"/> test is located in</param>
        /// <param name="callerSourceLine">The source line at which the caller invoked the <see cref="Ensure"/> test</param>
        internal EnsureBaseException(Exception baseException, string callerName, string callerSourceFile, int callerSourceLine)
        {
            this.BaseException = baseException;
            this.CallerName = callerName;
            this.CallerSourceFile = callerSourceFile;
            this.CallerSourceLine = callerSourceLine;
        }

        /// <summary>
        /// The name of the caller that invoked the <see cref="Ensure"/> test
        /// </summary>
        virtual public string CallerName { get; internal set; }

        /// <summary>
        /// The source file containing the caller that invoked the <see cref="Ensure"/> test
        /// </summary>
        virtual public string CallerSourceFile { get; internal set; }

        /// <summary>
        /// The source line where the caller invoked the <see cref="Ensure"/> test.
        /// </summary>
        virtual public int CallerSourceLine { get; internal set; }

        /// <summary>
        /// The <see cref="Exception"/> that this <see cref="EnsureBaseException"/> encapsulates
        /// </summary>
        virtual public Exception BaseException { get; internal set; }
    }

}
