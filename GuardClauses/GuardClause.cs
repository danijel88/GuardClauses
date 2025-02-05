using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using GuardClauses.Enums;
using GuardClauses.Interfaces;

namespace GuardClauses
{
    public static class GuardClause
    {
        private static readonly IGuardClause _guardClause = new DefaultGuardClause();

        /// <summary>
        /// Ensures the argument is not zero.
        /// </summary>
        /// <typeparam name="T">The type of the argument.</typeparam>
        /// <param name="argumentValue">The value to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <returns>The original value if it is not zero.</returns>
        public static T IsZero<T>(T argumentValue, string argumentName) where T : struct, IComparable
        {
            return _guardClause.IsZero(argumentValue, argumentName);
        }

        /// <summary>
        /// Ensures the argument is not negative.
        /// </summary>
        /// <typeparam name="T">The type of the argument.</typeparam>
        /// <param name="argumentValue">The value to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <returns>The original value if it is not negative.</returns>
        public static T IsNegative<T>(T argumentValue, string argumentName) where T : struct, IComparable
        {
            return _guardClause.IsNegative(argumentValue, argumentName);
        }

        /// <summary>
        /// Ensures the argument is neither zero nor negative.
        /// </summary>
        /// <typeparam name="T">The type of the argument.</typeparam>
        /// <param name="argumentValue">The value to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <returns>The original value if it is neither zero nor negative.</returns>
        public static T IsZeroOrNegative<T>(T argumentValue, string argumentName) where T : struct, IComparable
        {
            return _guardClause.IsZeroOrNegative(argumentValue, argumentName);
        }

        /// <summary>
        /// Ensures the length of the string argument does not exceed the specified maximum length.
        /// </summary>
        /// <param name="argumentValue">The string to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <param name="maximumLength">The maximum allowed length.</param>
        /// <returns>The original string if its length does not exceed the maximum length.</returns>
        public static string IsLengthExceeded(string argumentValue, string argumentName, int maximumLength)
        {
            return _guardClause.IsLengthExceeded(argumentValue, argumentName, maximumLength);
        }

        /// <summary>
        /// Ensures the string argument meets the specified validation types.
        /// </summary>
        /// <param name="argumentValue">The string to validate.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <param name="types">The list of validation types to apply.</param>
        /// <returns>The original string if it meets the specified validation types.</returns>
        public static string EnsureValidString(string argumentValue, string argumentName, List<StringValidationType> types)
        {
            return _guardClause.EnsureValidString(argumentValue, argumentName, types);
        }

        /// <summary>
        /// Ensures the string argument meets the specified validation type.
        /// </summary>
        /// <param name="argumentValue">The string to validate.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <param name="type">The validation type to apply.</param>
        /// <returns>The original string if it meets the specified validation type.</returns>
        public static string EnsureValidString(string argumentValue, string argumentName, StringValidationType type)
        {
            return _guardClause.EnsureValidString(argumentValue, argumentName, type);
        }

        /// <summary>
        /// Ensures the string argument is not null, empty, or whitespace.
        /// </summary>
        /// <param name="argumentValue">The string to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <returns>The original string if it is not null, empty, or whitespace.</returns>
        [Obsolete]
        public static string IsNullOrEmptyStringOrWhiteSpace(string argumentValue, string argumentName)
        {
            return _guardClause.IsNullOrEmptyStringOrWhiteSpace(argumentValue, argumentName);
        }

        /// <summary>
        /// Ensures the string argument is not null or whitespace.
        /// </summary>
        /// <param name="argumentValue">The string to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <returns>The original string if it is not null or whitespace.</returns>
        [Obsolete]
        public static string IsNullOrWhiteSpace(string argumentValue, string argumentName)
        {
            return _guardClause.IsNullOrWhiteSpace(argumentValue, argumentName);
        }

        /// <summary>
        /// Ensures the string argument is not null or empty.
        /// </summary>
        /// <param name="argumentValue">The string to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <returns>The original string if it is not null or empty.</returns>
        [Obsolete]
        public static string IsNullOrEmptyString(string argumentValue, string argumentName)
        {
            return _guardClause.IsNullOrEmptyString(argumentValue, argumentName);
        }

        /// <summary>
        /// Ensures the argument is not null.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <returns>The original value if it is not null.</returns>
        public static object ArgumentIsNotNull(object value, string argumentName)
        {
            return _guardClause.ArgumentIsNotNull(value, argumentName);
        }

        /// <summary>
        /// Ensures the DateTime argument is greater than the specified comparable DateTime.
        /// </summary>
        /// <param name="argumentValue">The DateTime value to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <param name="comparableDateTime">The DateTime to compare against.</param>
        /// <returns>The original DateTime if it is greater than the comparable DateTime.</returns>
        public static DateTime DateTimeIsGreaterThan(DateTime argumentValue, string argumentName, DateTime comparableDateTime)
        {
            return _guardClause.DateTimeIsGreaterThan(argumentValue, argumentName, comparableDateTime);
        }

        /// <summary>
        /// Ensures the DateTime argument is less than the specified comparable DateTime.
        /// </summary>
        /// <param name="argumentValue">The DateTime value to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <param name="comparableDateTime">The DateTime to compare against.</param>
        /// <returns>The original DateTime if it is less than the comparable DateTime.</returns>
        public static DateTime DateTimeIsLessThan(DateTime argumentValue, string argumentName, DateTime comparableDateTime)
        {
            return _guardClause.DateTimeIsLessThan(argumentValue, argumentName, comparableDateTime);
        }

        /// <summary>
        /// Ensures the DateTime argument is within the specified range.
        /// </summary>
        /// <param name="argumentValue">The DateTime value to check.</param>
        /// <param name="startDateTime">The start of the range.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <param name="endDateTime">The end of the range.</param>
        /// <returns>The original DateTime if it is within the specified range.</returns>
        public static DateTime DateTimeIsOutOfRange(DateTime argumentValue, DateTime startDateTime, string argumentName, DateTime endDateTime)
        {
            return _guardClause.DateTimeIsOutOfRange(argumentValue, startDateTime, argumentName, endDateTime);
        }

        /// <summary>
        /// Ensures the string argument is not an empty GUID.
        /// </summary>
        /// <param name="argumentValue">The string to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <returns>The original string if it is not an empty GUID.</returns>
        public static string IsStringEmptyGuid(string argumentValue, string argumentName)
        {
            return _guardClause.IsStringEmptyGuid(argumentValue, argumentName);
        }

        /// <summary>
        /// Ensures the GUID argument is not empty.
        /// </summary>
        /// <param name="argumentValue">The GUID to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <returns>The original GUID if it is not empty.</returns>
        public static Guid IsEmptyGuid(Guid argumentValue, string argumentName)
        {
            return _guardClause.IsEmptyGuid(argumentValue, argumentName);
        }

        /// <summary>
        /// Ensures the email argument is valid.
        /// </summary>
        /// <param name="email">The email to validate.</param>
        /// <returns>The original email if it is valid.</returns>
        public static string IsEmailValid(string email)
        {
            return _guardClause.IsEmailValid(email);
        }

        /// <summary>
        /// Ensures the URL argument is valid.
        /// </summary>
        /// <param name="url">The URL to validate.</param>
        /// <returns>The original URL if it is valid.</returns>
        public static string UrlChecker(string url)
        {
            return _guardClause.UrlChecker(url);
        }

        /// <summary>
        /// Ensures the length of the string argument does not exceed the specified maximum length.
        /// </summary>
        /// <param name="argumentValue">The string to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <param name="maximumLength">The maximum allowed length.</param>
        /// <returns>The original string if its length does not exceed the maximum length.</returns>
        public static string MaximumLength(string argumentValue, string argumentName, int maximumLength)
        {
            return _guardClause.MaximumLength(argumentValue, argumentName, maximumLength);
        }
    }
}