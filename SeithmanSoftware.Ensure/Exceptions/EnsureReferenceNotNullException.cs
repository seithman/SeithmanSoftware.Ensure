using System;

namespace SeithmanSoftware.Ensure.Exceptions
{
    /// <summary>
    /// An exception thrown by <see cref="Ensure.NotNullReference(object, string, string, string, int)"/>.<br />
    /// Encapsulates a <see cref="NullReferenceException"/>.
    /// </summary>
    internal class EnsureReferenceNotNullException : EnsureBaseException
    {
        /// <summary>
        /// Constructs an <see cref="EnsureReferenceNotNullException"/> instance.
        /// </summary>
        /// <param name="referenceName">The name of the reference that is null</param>
        /// <param name="callerName">The name of the caller that invoked <see cref="Ensure.NotNullReference(object, string, string, string, int)"/></param>
        /// <param name="callerSourceFile">The source file containing the caller that invoked <see cref="Ensure.NotNullReference(object, string, string, string, int)"/></param>
        /// <param name="callerSourceLine">The source line where the caller invoked <see cref="Ensure.NotNullReference(object, string, string, string, int)"/></param>
        public EnsureReferenceNotNullException(string referenceName, string callerName, string callerSourceFile, int callerSourceLine)
            : base (new NullReferenceException($"{referenceName} cannot be null"), callerName, callerSourceFile, callerSourceLine)
        {
        }
    }
}
