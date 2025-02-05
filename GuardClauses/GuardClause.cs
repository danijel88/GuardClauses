using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using GuardClauses.Enums;

namespace GuardClauses
{
    public static class GuardClause
    {
        public static T IsZero<T>(T argumentValue, string argumentName) where T : struct, IComparable
        {
            if (argumentValue.CompareTo(default(T)) == 0)
                throw new ArgumentException($"{argumentName} is zero");
            return argumentValue;
        }

        public static T IsNegative<T>(T argumentValue, string argumentName) where T : struct, IComparable
        {
            if (argumentValue.CompareTo(default(T)) < 0)
                throw new ArgumentException($"{argumentName} is negative number");
            return argumentValue;
        }

        public static T IsZeroOrNegative<T>(T argumentValue, string argumentName) where T : struct, IComparable
        {
            if (argumentValue.CompareTo(default(T)) <= 0)
                throw new ArgumentException($"{argumentName} is zero or negative number");
            return argumentValue;
        }

        public static string IsLengthExceeded(string argumentValue, string argumentName, int maximumLength)
        {
            if (argumentValue.Length > maximumLength)
                throw new ArgumentException($"{argumentName} has exceeded maximum number of characters");
            return argumentValue;
        }

        public static string EnsureValidString(string argumentValue, string argumentName, List<StringValidationType> types)
        {
            foreach (var type in types)
            {
                var isInvalid = type switch
                {
                    StringValidationType.IsNullOrEmpty => string.IsNullOrEmpty(argumentValue),
                    StringValidationType.IsNullOrWhiteSpace => string.IsNullOrWhiteSpace(argumentValue),
                    _ => throw new ArgumentException(nameof(type), "Invalid string validation")
                };
                if (isInvalid) throw new ArgumentException($"String is {type}", nameof(argumentName));
            }
            return argumentValue;
        }

        public static string EnsureValidString(string argumentValue, string argumentName, StringValidationType type)
        {
            var isInvalid = type switch
            {
                StringValidationType.IsNullOrEmpty => string.IsNullOrEmpty(argumentValue),
                StringValidationType.IsNullOrWhiteSpace => string.IsNullOrWhiteSpace(argumentValue),
                _ => throw new ArgumentException(nameof(type), "Invalid string validation")
            };
            if (isInvalid) throw new ArgumentException($"String is {type}", nameof(argumentName));
            return argumentValue;
        }

        public static object ArgumentIsNotNull(object value, string argumentName)
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException($"{argumentName} is null object");
            return value;
        }

        public static DateTime DateTimeIsGreaterThan(DateTime argumentValue, string argumentName, DateTime comparableDateTime)
        {
            if (argumentValue > comparableDateTime)
                throw new ArgumentException($"{argumentName} {argumentValue} is greater than {comparableDateTime}");
            return argumentValue;
        }

        public static DateTime DateTimeIsLessThan(DateTime argumentValue, string argumentName, DateTime comparableDateTime)
        {
            if (argumentValue < comparableDateTime)
                throw new ArgumentException($"{argumentName} {argumentValue} is less than {comparableDateTime}");
            return argumentValue;
        }

        public static DateTime DateTimeIsOutOfRange(DateTime argumentValue, DateTime startDateTime, string argumentName, DateTime endDateTime)
        {
            if (argumentValue < startDateTime || argumentValue > endDateTime)
                throw new ArgumentException($"{argumentName} is out of range");
            return argumentValue;
        }

        public static string IsStringEmptyGuid(string argumentValue, string argumentName)
        {
            if (argumentValue == Guid.Empty.ToString())
                throw new ArgumentException($"{argumentName} cannot be a string with the value of an empty GUID.");
            return argumentValue;
        }

        public static Guid IsEmptyGuid(Guid argumentValue, string argumentName)
        {
            if (argumentValue == Guid.Empty)
                throw new ArgumentException($"{argumentName} cannot be an empty GUID.");
            return argumentValue;
        }

        public static string IsEmailValid(string email)
        {
            var regex = new Regex(DataPatternConst.VALID_EMAIL_ADDRESS_PATTERN, RegexOptions.IgnoreCase);
            if (!regex.IsMatch(email))
                throw new ArgumentException($"{email} is not valid");
            return email;
        }

        public static string UrlChecker(string url)
        {
            var regex = new Regex(DataPatternConst.VALID_URL_PATTERN);
            if (!regex.IsMatch(url))
                throw new ArgumentException($"{url} is not valid");
            return url;
        }

        public static string MaximumLength(string argumentValue, string argumentName, int maximumLength)
        {
            if (argumentValue.Length > maximumLength)
                throw new ArgumentException($"Argument {argumentName} exceeds maximum length {maximumLength}");
            return argumentValue;
        }
    }
}