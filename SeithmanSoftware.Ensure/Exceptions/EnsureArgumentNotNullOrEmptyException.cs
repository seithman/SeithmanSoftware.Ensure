﻿using System;

namespace SeithmanSoftware.Ensure.Exceptions
{
    /// <summary>
    /// An exception generated by <see cref="Ensure.ArgumentNotNullOrEmpty(string, string, string, string, int)"/>.<br />
    /// 
    /// Encapsulates an <see cref="ArgumentException"/>.
    /// </summary>
    internal class EnsureArgumentNotNullOrEmptyException : EnsureBaseException
    {
        /// <summary>
        /// Constructs an <see cref="EnsureArgumentNotNullOrEmptyException"/> instance
        /// </summary>
        /// <param name="argName">The name of the argument that is null or empty.</param>
        /// <param name="callerName">The name of the caller that invoked <see cref="Ensure.ArgumentNotNullOrEmpty(string, string, string, string, int)"/></param>
        /// <param name="callerSourceFile">The source file containing the caller that invoked <see cref="Ensure.ArgumentNotNullOrEmpty(string, string, string, string, int)"/></param>
        /// <param name="callerSourceLine">The source line were caller invoked <see cref="Ensure.ArgumentNotNullOrEmpty(string, string, string, string, int)"/></param>
        public EnsureArgumentNotNullOrEmptyException(string argName, string callerName, string callerSourceFile, int callerSourceLine)
            : base (new ArgumentException("Cannot be null or empty", argName), callerName, callerSourceFile, callerSourceLine)
        {
        }
    }
}
