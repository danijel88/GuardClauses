using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using GuardClauses.Enums;

namespace GuardClauses
{
    public static class GuardClause
    {
        private static readonly IGuardClause _guardClause = new DefaultGuardClause();
        public static T IsZero<T>(T argumentValue, string argumentName) where T : struct, IComparable
        {
            return _guardClause.IsZero(argumentValue, argumentName);
        }

        public static T IsNegative<T>(T argumentValue, string argumentName) where T : struct, IComparable
        {
           return _guardClause.IsNegative(argumentValue, argumentName);
        }

        public static T IsZeroOrNegative<T>(T argumentValue, string argumentName) where T : struct, IComparable
        {
            return _guardClause.IsZeroOrNegative(argumentValue, argumentName);
        }

        public static string IsLengthExceeded(string argumentValue, string argumentName, int maximumLength)
        {
            return _guardClause.IsLengthExceeded(argumentValue, argumentName, maximumLength);
        }

        public static string EnsureValidString(string argumentValue, string argumentName, List<StringValidationType> types)
        {
            return _guardClause.EnsureValidString(argumentValue, argumentName, types);
    }

        public static string EnsureValidString(string argumentValue, string argumentName, StringValidationType type)
        {
            return _guardClause.EnsureValidString(argumentValue, argumentName, type);
        }

        [Obsolete]
        public static string IsNullOrEmptyStringOrWhiteSpace(string argumentValue, string argumentName)
        {
           return _guardClause.IsNullOrEmptyStringOrWhiteSpace(argumentValue, argumentName);
        }

        [Obsolete]
        public static string IsNullOrWhiteSpace(string argumentValue, string argumentName)
        {
           return _guardClause.IsNullOrWhiteSpace(argumentValue, argumentName);
        }

        [Obsolete]
        public static string IsNullOrEmptyString(string argumentValue, string argumentName)
        {
           return _guardClause.IsNullOrEmptyString(argumentValue, argumentName);
        }

        public static object ArgumentIsNotNull(object value, string argumentName)
        {
            return _guardClause.ArgumentIsNotNull(value, argumentName);
        }

        public static DateTime DateTimeIsGreaterThan(DateTime argumentValue, string argumentName, DateTime comparableDateTime)
        {
            return _guardClause.DateTimeIsGreaterThan(argumentValue, argumentName, comparableDateTime);
        }

        public static DateTime DateTimeIsLessThan(DateTime argumentValue, string argumentName, DateTime comparableDateTime)
        {
            return _guardClause.DateTimeIsLessThan(argumentValue, argumentName, comparableDateTime);
        }

        public static DateTime DateTimeIsOutOfRange(DateTime argumentValue, DateTime startDateTime, string argumentName, DateTime endDateTime)
        {
            return _guardClause.DateTimeIsOutOfRange(argumentValue, startDateTime, argumentName, endDateTime);
        }

        public static string IsStringEmptyGuid(string argumentValue, string argumentName)
        {
           return _guardClause.IsStringEmptyGuid(argumentValue, argumentName);
        }

        public static Guid IsEmptyGuid(Guid argumentValue, string argumentName)
        {
           return _guardClause.IsEmptyGuid(argumentValue, argumentName);
        }

        public static string IsEmailValid(string email)
        {
          return _guardClause.IsEmailValid(email);
        }

        public static string UrlChecker(string url)
        {
            return _guardClause.UrlChecker(url);
        }

        public static string MaximumLength(string argumentValue, string argumentName, int maximumLength)
        {
            return _guardClause.MaximumLength(argumentValue, argumentName, maximumLength);
        }
    }
}