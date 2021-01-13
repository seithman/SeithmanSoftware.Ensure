﻿using System;

namespace SeithmanSoftware.Ensure.Exceptions
{
    /// <summary>
    /// An exception generated by <see cref="Ensure.ArgumentNotNull(object, string, string, string, int)"/>.<br />
    /// Encapsulates an <see cref="ArgumentNullException"/>.
    /// </summary>
    internal class EnsureArgumentNotNullException : EnsureBaseException
    {
        /// <summary>
        /// Constructs an <see cref="EnsureArgumentNotNullException"/> instance
        /// </summary>
        /// <param name="paramName">The name of the parameter that was null</param>
        /// <param name="callerName">The name of the caller that invoked <see cref="Ensure.ArgumentNotNull(object, string, string, string, int)"/></param>
        /// <param name="callerSourceFile">The source file containing the caller that invoked <see cref="Ensure.ArgumentNotNull(object, string, string, string, int)"/></param>
        /// <param name="callerSourceLine">The source line where the caller invoked <see cref="Ensure.ArgumentNotNull(object, string, string, string, int)"/></param>
        public EnsureArgumentNotNullException(string paramName, string callerName, string callerSourceFile, int callerSourceLine)
            : base(new ArgumentNullException(paramName), callerName, callerSourceFile, callerSourceLine)
        {
        }
    }
}
