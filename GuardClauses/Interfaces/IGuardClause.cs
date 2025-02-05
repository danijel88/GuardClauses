using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using GuardClauses.Enums;

namespace GuardClauses
{
    public interface IGuardClause
    {
        T IsZero<T>(T argumentValue, string argumentName) where T : struct, IComparable;
        T IsNegative<T>(T argumentValue, string argumentName) where T : struct, IComparable;
        T IsZeroOrNegative<T>(T argumentValue, string argumentName) where T : struct, IComparable;
        string IsLengthExceeded(string argumentValue, string argumentName, int maximumLength);
        string EnsureValidString(string argumentValue, string argumentName, List<StringValidationType> types);
        string EnsureValidString(string argumentValue, string argumentName, StringValidationType type);
        object ArgumentIsNotNull(object value, string argumentName);
        DateTime DateTimeIsGreaterThan(DateTime argumentValue, string argumentName, DateTime comparableDateTime);
        DateTime DateTimeIsLessThan(DateTime argumentValue, string argumentName, DateTime comparableDateTime);
        DateTime DateTimeIsOutOfRange(DateTime argumentValue, DateTime startDateTime, string argumentName, DateTime endDateTime);
        string IsStringEmptyGuid(string argumentValue, string argumentName);
        Guid IsEmptyGuid(Guid argumentValue, string argumentName);
        string IsEmailValid(string email);
        string UrlChecker(string url);
        string MaximumLength(string argumentValue, string argumentName, int maximumLength);
        string IsNullOrEmptyStringOrWhiteSpace(string argumentValue, string argumentName);
        string IsNullOrWhiteSpace(string argumentValue, string argumentName);
        string IsNullOrEmptyString(string argumentValue, string argumentName);
    }
}
