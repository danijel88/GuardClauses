using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using GuardClauses.Enums;

namespace GuardClauses
{
    public static class GuardClause
    {
        private const string VALID_EMAIL_ADDRESS_PATTERN =
            @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        private const string VALID_URL_PATTERN =
            @"([\w+]+\:\/\/)?([\w\d-]+\.)*[\w-]+[\.\:]\w+([\/\?\=\&\#.]?[\w-]+)*\/?";

        public static int IsZero(int argumentValue, string argumentName)
        {
            if (argumentValue == 0)
                throw new ArgumentException($"{argumentName} is zero");
            return argumentValue;
        }

        public static long IsZero(long argumentValue, string argumentName)
        {
            if (argumentValue == 0)
                throw new ArgumentException($"{argumentName} is zero");
            return argumentValue;
        }

        public static decimal IsZero(decimal argumentValue, string argumentName)
        {
            if (argumentValue == 0)
                throw new ArgumentException($"{argumentName} is zero");
            return argumentValue;
        }

        public static double IsZero(double argumentValue, string argumentName)
        {
            if (argumentValue == 0)
                throw new ArgumentException($"{argumentName} is zero.");
            return argumentValue;
        }

        public static float IsZero(float argumentValue, string argumentName)
        {
            if (argumentValue == 0)
                throw new ArgumentException($"{argumentName} is zero.");
            return argumentValue;
        }

        public static int IsNegative(int argumentValue, string argumentName)
        {
            if (argumentValue < 0)
                throw new ArgumentException($"{argumentName} is negative number");
            return argumentValue;
        }

        public static long IsNegative(long argumentValue, string argumentName)
        {
            if (argumentValue < 0)
                throw new ArgumentException($"{argumentName} is negative number");
            return argumentValue;
        }

        public static decimal IsNegative(decimal argumentValue, string argumentName)
        {
            if (argumentValue < 0)
                throw new ArgumentException($"{argumentName} is negative number");
            return argumentValue;
        }

        public static double IsNegative(double argumentValue, string argumentName)
        {
            if (argumentValue < 0)
                throw new ArgumentException($"{argumentName} is negative number");
            return argumentValue;
        }

        public static float IsNegative(float argumentValue, string argumentName)
        {
            if (argumentValue < 0)
                throw new ArgumentException($"{argumentName} is 0 or negative number");
            return argumentValue;
        }

        public static int IsZeroOrNegative(int argumentValue, string argumentName)
        {
            if (argumentValue < 0 || argumentValue == 0)
                throw new ArgumentException($"{argumentName} is 0 or negative number");
            return argumentValue;
        }

        public static long IsZeroOrNegative(long argumentValue, string argumentName)
        {
            if (argumentValue < 0 || argumentValue == 0)
                throw new ArgumentException($"{argumentName} is 0 or negative number");
            return argumentValue;
        }

        public static decimal IsZeroOrNegative(decimal argumentValue, string argumentName)
        {
            if (argumentValue < 0 || argumentValue == 0)
                throw new ArgumentException($"{argumentName} is 0 or negative number");
            return argumentValue;
        }

        public static double IsZeroOrNegative(double argumentValue, string argumentName)
        {
            if (argumentValue < 0 || argumentValue == 0)
                throw new ArgumentException($"{argumentName} is 0 or negative number");
            return argumentValue;
        }

        public static float IsZeroOrNegative(float argumentValue, string argumentName)
        {
            if (argumentValue < 0 || argumentValue == 0)
                throw new ArgumentException($"{argumentName} is 0 or negative number");
            return argumentValue;
        }

        public static string IsLengthExceeded(string argumentValue, string argumentName, int maximumLength)
        {
            if (argumentValue.Length > maximumLength)
                throw new ArgumentException($"{argumentName} has exceeded maximum number of characters");
            return argumentValue;
        }

        [Obsolete]
        public static string IsNullOrEmptyStringOrWhiteSpace(string argumentValue, string argumentName)
        {
            IsNullOrWhiteSpace(argumentValue, nameof(argumentName));
            IsNullOrEmptyString(argumentValue, nameof(argumentName));
            return argumentValue;
        }

        [Obsolete]
        public static string IsNullOrWhiteSpace(string argumentValue, string argumentName)
        {
            if (string.IsNullOrWhiteSpace(argumentValue))
                throw new ArgumentException($"{argumentName} is null or white space");
            return argumentValue;
        }

        [Obsolete]
        public static string IsNullOrEmptyString(string argumentValue, string argumentName)
        {
            if (string.IsNullOrEmpty(argumentValue))
                throw new ArgumentException($"{argumentName} is null or empty string");
            return argumentValue;
        }

        public static string EnsureValidString(string argumentValue, string argumentName,
            List<StringValidationType> types)
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

        public static DateTime DateTimeIsGraterThan(DateTime argumentValue, string argumentName, DateTime comparableDateTme)
        {
            if (argumentValue > comparableDateTme)
                throw new ArgumentException(
                    $"{nameof(argumentName)}{argumentValue} is greater than {comparableDateTme}");
            return argumentValue;
        }

        public static DateTime DateTimeIsLessThan(DateTime argumentValue, string argumentName, DateTime comparableDateTme)
        {
            if (argumentValue < comparableDateTme)
                throw new ArgumentException($"{nameof(argumentName)}{argumentValue} is less than {comparableDateTme}");
            return argumentValue;
        }

        public static DateTime DateTimeIsOutOfRange(DateTime argumentValue, DateTime startDateTime, string argumentName,
            DateTime endDateTime)
        {
            if (argumentValue < startDateTime || argumentValue > endDateTime)
                throw new ArgumentException($"{nameof(argumentName)} is out of range");
            return argumentValue;
        }

        public static string IsStringEmptyGuid(string argumentValue, string argumentName)
        {
            if (argumentValue == Guid.Empty.ToString())
                throw new ArgumentException($"{nameof(argumentName)} can not be string with value of empty guid.");
            return argumentValue;
        }

        public static Guid IsEmptyGuid(Guid argumentValue, string argumentName)
        {
            if (argumentValue == Guid.Empty)
                throw new ArgumentException($"{nameof(argumentName)} can not be string with value of empty guid.");
            return argumentValue;
        }

        public static string IsEmailValid(string email)
        {
            var regex = new Regex(VALID_EMAIL_ADDRESS_PATTERN, RegexOptions.IgnoreCase);
            if (!regex.IsMatch(email))
                throw new ArgumentException($"{email} is not valid");
            return email;
        }

        public static string UrlChecker(string url)
        {
            var regex = new Regex(VALID_URL_PATTERN);
            if (!regex.IsMatch(url))
                throw new ArgumentException($"{url} is not valid");
            return url;
        }

        public static string MaximumLength(string argumentValue, string argumentName, int maximumLength)
        {
            if (argumentValue.Length > maximumLength)
                throw new ArgumentException($"Argument {argumentName} exceed maximum length {maximumLength}");
            return argumentValue;
        }
    }
}