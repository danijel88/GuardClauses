using System;
using System.Collections.Generic;
using GuardClauses.Enums;

namespace GuardClauses.Interfaces
{
    /// <summary>
    /// Interface defining various guard clause methods to validate arguments.
    /// </summary>
    public interface IGuardClause
    {
        /// <summary>
        /// Ensures the argument is not zero.
        /// </summary>
        /// <param name="argumentValue">The value to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <returns>The original value if it is not zero.</returns>
        T IsZero<T>(T argumentValue, string argumentName) where T : struct, IComparable;

        /// <summary>
        /// Ensures the argument is not negative.
        /// </summary>
        /// <param name="argumentValue">The value to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <returns>The original value if it is not negative.</returns>
        T IsNegative<T>(T argumentValue, string argumentName) where T : struct, IComparable;

        /// <summary>
        /// Ensures the argument is neither zero nor negative.
        /// </summary>
        /// <param name="argumentValue">The value to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <returns>The original value if it is neither zero nor negative.</returns>
        T IsZeroOrNegative<T>(T argumentValue, string argumentName) where T : struct, IComparable;

        /// <summary>
        /// Ensures the length of the string argument does not exceed the specified maximum length.
        /// </summary>
        /// <param name="argumentValue">The string to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <param name="maximumLength">The maximum allowed length.</param>
        /// <returns>The original string if its length does not exceed the maximum length.</returns>
        string IsLengthExceeded(string argumentValue, string argumentName, int maximumLength);

        /// <summary>
        /// Ensures the string argument meets the specified validation types.
        /// </summary>
        /// <param name="argumentValue">The string to validate.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <param name="types">The list of validation types to apply.</param>
        /// <returns>The original string if it meets the specified validation types.</returns>
        string EnsureValidString(string argumentValue, string argumentName, List<StringValidationType> types);

        /// <summary>
        /// Ensures the string argument meets the specified validation type.
        /// </summary>
        /// <param name="argumentValue">The string to validate.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <param name="type">The validation type to apply.</param>
        /// <returns>The original string if it meets the specified validation type.</returns>
        string EnsureValidString(string argumentValue, string argumentName, StringValidationType type);

        /// <summary>
        /// Ensures the argument is not null.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <returns>The original value if it is not null.</returns>
        object ArgumentIsNotNull(object value, string argumentName);

        /// <summary>
        /// Ensures the DateTime argument is greater than the specified comparable DateTime.
        /// </summary>
        /// <param name="argumentValue">The DateTime value to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <param name="comparableDateTime">The DateTime to compare against.</param>
        /// <returns>The original DateTime if it is greater than the comparable DateTime.</returns>
        DateTime DateTimeIsGreaterThan(DateTime argumentValue, string argumentName, DateTime comparableDateTime);

        /// <summary>
        /// Ensures the DateTime argument is less than the specified comparable DateTime.
        /// </summary>
        /// <param name="argumentValue">The DateTime value to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <param name="comparableDateTime">The DateTime to compare against.</param>
        /// <returns>The original DateTime if it is less than the comparable DateTime.</returns>
        DateTime DateTimeIsLessThan(DateTime argumentValue, string argumentName, DateTime comparableDateTime);

        /// <summary>
        /// Ensures the DateTime argument is within the specified range.
        /// </summary>
        /// <param name="argumentValue">The DateTime value to check.</param>
        /// <param name="startDateTime">The start of the range.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <param name="endDateTime">The end of the range.</param>
        /// <returns>The original DateTime if it is within the specified range.</returns>
        DateTime DateTimeIsOutOfRange(DateTime argumentValue, DateTime startDateTime, string argumentName, DateTime endDateTime);

        /// <summary>
        /// Ensures the string argument is not an empty GUID.
        /// </summary>
        /// <param name="argumentValue">The string to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <returns>The original string if it is not an empty GUID.</returns>
        string IsStringEmptyGuid(string argumentValue, string argumentName);

        /// <summary>
        /// Ensures the GUID argument is not empty.
        /// </summary>
        /// <param name="argumentValue">The GUID to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <returns>The original GUID if it is not empty.</returns>
        Guid IsEmptyGuid(Guid argumentValue, string argumentName);

        /// <summary>
        /// Ensures the email argument is valid.
        /// </summary>
        /// <param name="email">The email to validate.</param>
        /// <returns>The original email if it is valid.</returns>
        string IsEmailValid(string email);

        /// <summary>
        /// Ensures the URL argument is valid.
        /// </summary>
        /// <param name="url">The URL to validate.</param>
        /// <returns>The original URL if it is valid.</returns>
        string UrlChecker(string url);

        /// <summary>
        /// Ensures the length of the string argument does not exceed the specified maximum length.
        /// </summary>
        /// <param name="argumentValue">The string to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <param name="maximumLength">The maximum allowed length.</param>
        /// <returns>The original string if its length does not exceed the maximum length.</returns>
        string MaximumLength(string argumentValue, string argumentName, int maximumLength);

        /// <summary>
        /// Ensures the string argument is not null, empty, or whitespace.
        /// </summary>
        /// <param name="argumentValue">The string to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <returns>The original string if it is not null, empty, or whitespace.</returns>
        string IsNullOrEmptyStringOrWhiteSpace(string argumentValue, string argumentName);

        /// <summary>
        /// Ensures the string argument is not null or whitespace.
        /// </summary>
        /// <param name="argumentValue">The string to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <returns>The original string if it is not null or whitespace.</returns>
        string IsNullOrWhiteSpace(string argumentValue, string argumentName);

        /// <summary>
        /// Ensures the string argument is not null or empty.
        /// </summary>
        /// <param name="argumentValue">The string to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <returns>The original string if it is not null or empty.</returns>
        string IsNullOrEmptyString(string argumentValue, string argumentName);
    }
}
