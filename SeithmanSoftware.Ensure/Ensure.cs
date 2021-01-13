using System;
using System.Runtime.CompilerServices;

namespace SeithmanSoftware.Ensure
{
    using Exceptions;

    /// <summary>
    /// Static class for performing various tests.
    /// </summary>
    public static class Ensure
    {
        /// <summary>
        /// Ensure that an argument is not null
        /// </summary>
        /// <param name="arg">The argument to test</param>
        /// <param name="argName">The name of the argument to test</param>
        /// <param name="callerName">The name of the caller for the test</param>
        /// <param name="callerSourceFile">The source file the caller for the test is in</param>
        /// <param name="callerSourceLine">The source line from which the caller called this test</param>
        /// <exception cref="EnsureBaseException">An encapsulated <see cref="ArgumentNullException"/></exception>
        public static void ArgumentNotNull(
            object arg,
            string argName,
            [CallerMemberName] string callerName = "",
            [CallerFilePath] string callerSourceFile = "",
            [CallerLineNumberAttribute] int callerSourceLine = 0)
        {
            if (arg != null)
            {
                throw new EnsureArgumentNotNullException(argName, callerName, callerSourceFile, callerSourceLine);
            }
        }

        /// <summary>
        /// Ensure that an argument is within a given range
        /// </summary>
        /// <param name="argument">The argument to test</param>
        /// <param name="lowerBound">The lower bound of the range</param>
        /// <param name="upperBound">The upper bound of the range</param>
        /// <param name="argName">The name of the argument to test</param>
        /// <param name="callerName">The name of the caller for the test</param>
        /// <param name="callerSourceFile">The source file the caller for the test is in</param>
        /// <param name="callerSourceLine">The source line from which the caller called this test</param>
        /// <exception cref="EnsureBaseException">An encapsulated <see cref="ArgumentOutOfRangeException"/></exception>
        public static void AgumentInRange<T>(
            T argument,
            T lowerBound,
            T upperBound,
            string argName = "",
            [CallerMemberName] string callerName = "",
            [CallerFilePath] string callerSourceFile = "",
            [CallerLineNumber] int callerSourceLine = 0)
            where T : IComparable<T>
        {
            if ((argument.CompareTo(lowerBound) < 0) ||
                (argument.CompareTo(upperBound) > 0))
            {
                throw new EnsureArgumentNotOutOfRangeException(argument, argName, callerName, callerSourceFile, callerSourceLine);
            }
        }

        /// <summary>
        /// Ensure that a string argument is neither null nor empty
        /// </summary>
        /// <param name="argument">The argument to test</param>
        /// <param name="argName">The name of the argument to test</param>
        /// <param name="callerName">The name of the caller for the test</param>
        /// <param name="callerSourceFile">The source file the caller for the test is in</param>
        /// <param name="callerSourceLine">The source line from which the caller called this test</param>
        /// <exception cref="EnsureBaseException">An encapsulated <see cref="ArgumentOutOfRangeException"/></exception>
        public static void ArgumentNotNullOrEmpty(
            string argument,
            string argumentName,
            [CallerMemberName] string callerName = "",
            [CallerFilePath] string callerSourceFile = "",
            [CallerLineNumber] int callerSourceLine = 0)
        {
            if (string.IsNullOrEmpty(argument))
            {
                throw new EnsureArgumentNotNullOrEmptyException(argumentName, callerName, callerSourceFile, callerSourceLine);
            }
        }

        /// <summary>
        /// Ensure that an object reference is not null
        /// </summary>
        /// <param name="reference">The object reference to test</param>
        /// <param name="referenceName">The name of the object reference to test</param>
        /// <param name="callerName">The name of the caller for the test</param>
        /// <param name="callerSourceFile">The source file the caller for the test is in</param>
        /// <param name="callerSourceLine">The source line from which the caller called this test</param>
        /// <exception cref="EnsureBaseException">An encapsulated <see cref="ArgumentOutOfRangeException"/></exception>
        public static void NotNullReference(
            object reference,
            string referenceName = null,
            [CallerMemberName] string callerName = "",
            [CallerFilePath] string callerSourceFile = "",
            [CallerLineNumber] int callerSourceLine = 0)
        {
            if (reference == null)
            {
                throw new EnsureReferenceNotNullException(referenceName, callerName, callerSourceFile, callerSourceLine);
            }
        }
    }
}
