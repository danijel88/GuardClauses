using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using GuardClauses.Enums;

namespace GuardClauses
{
    public class DefaultGuardClause : IGuardClause
    {
        public T IsZero<T>(T argumentValue, string argumentName) where T : struct, IComparable
        {
            if (argumentValue.CompareTo(default(T)) == 0)
                throw new ArgumentException($"{argumentName} is zero");
            return argumentValue;
        }

        public T IsNegative<T>(T argumentValue, string argumentName) where T : struct, IComparable
        {
            if (argumentValue.CompareTo(default(T)) < 0)
                throw new ArgumentException($"{argumentName} is negative number");
            return argumentValue;
        }

        public T IsZeroOrNegative<T>(T argumentValue, string argumentName) where T : struct, IComparable
        {
            if (argumentValue.CompareTo(default(T)) <= 0)
                throw new ArgumentException($"{argumentName} is zero or negative number");
            return argumentValue;
        }

        public string IsLengthExceeded(string argumentValue, string argumentName, int maximumLength)
        {
            if (argumentValue.Length > maximumLength)
                throw new ArgumentException($"{argumentName} has exceeded maximum number of characters");
            return argumentValue;
        }

        public string EnsureValidString(string argumentValue, string argumentName, List<StringValidationType> types)
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

        public string EnsureValidString(string argumentValue, string argumentName, StringValidationType type)
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
        [Obsolete]
        public  string IsNullOrEmptyStringOrWhiteSpace(string argumentValue, string argumentName)
        {
            IsNullOrWhiteSpace(argumentValue, nameof(argumentName));
            IsNullOrEmptyString(argumentValue, nameof(argumentName));
            return argumentValue;
        }

        [Obsolete]
        public  string IsNullOrWhiteSpace(string argumentValue, string argumentName)
        {
            if (string.IsNullOrWhiteSpace(argumentValue))
                throw new ArgumentException($"{argumentName} is null or white space");
            return argumentValue;
        }

        [Obsolete]
        public  string IsNullOrEmptyString(string argumentValue, string argumentName)
        {
            if (string.IsNullOrEmpty(argumentValue))
                throw new ArgumentException($"{argumentName} is null or empty string");
            return argumentValue;
        }

        public object ArgumentIsNotNull(object value, string argumentName)
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException($"{argumentName} is null object");
            return value;
        }

        public DateTime DateTimeIsGreaterThan(DateTime argumentValue, string argumentName, DateTime comparableDateTime)
        {
            if (argumentValue > comparableDateTime)
                throw new ArgumentException($"{argumentName} {argumentValue} is greater than {comparableDateTime}");
            return argumentValue;
        }

        public DateTime DateTimeIsLessThan(DateTime argumentValue, string argumentName, DateTime comparableDateTime)
        {
            if (argumentValue < comparableDateTime)
                throw new ArgumentException($"{argumentName} {argumentValue} is less than {comparableDateTime}");
            return argumentValue;
        }

        public DateTime DateTimeIsOutOfRange(DateTime argumentValue, DateTime startDateTime, string argumentName, DateTime endDateTime)
        {
            if (argumentValue < startDateTime || argumentValue > endDateTime)
                throw new ArgumentException($"{argumentName} is out of range");
            return argumentValue;
        }

        public string IsStringEmptyGuid(string argumentValue, string argumentName)
        {
            if (argumentValue == Guid.Empty.ToString())
                throw new ArgumentException($"{argumentName} cannot be a string with the value of an empty GUID.");
            return argumentValue;
        }

        public Guid IsEmptyGuid(Guid argumentValue, string argumentName)
        {
            if (argumentValue == Guid.Empty)
                throw new ArgumentException($"{argumentName} cannot be an empty GUID.");
            return argumentValue;
        }

        public string IsEmailValid(string email)
        {
            var regex = new Regex(DataPatternConst.VALID_EMAIL_ADDRESS_PATTERN, RegexOptions.IgnoreCase);
            if (!regex.IsMatch(email))
                throw new ArgumentException($"{email} is not valid");
            return email;
        }

        public string UrlChecker(string url)
        {
            var regex = new Regex(DataPatternConst.VALID_URL_PATTERN);
            if (!regex.IsMatch(url))
                throw new ArgumentException($"{url} is not valid");
            return url;
        }

        public string MaximumLength(string argumentValue, string argumentName, int maximumLength)
        {
            if (argumentValue.Length > maximumLength)
                throw new ArgumentException($"Argument {argumentName} exceeds maximum length {maximumLength}");
            return argumentValue;
        }
    }
}