using System;

namespace GuardClauses
{
    public static class GuardClause
    {
        public static void IsZeroOrNegative(int argumentValue, string argumentName)
        {
            if (argumentValue < 0 || argumentValue == 0)
                throw new ArgumentException($"{argumentName} is 0 or negative number");
        }

        public static void IsZeroOrNegative(long argumentValue, string argumentName)
        {
            if (argumentValue < 0 || argumentValue == 0)
                throw new ArgumentException($"{argumentName} is 0 or negative number");
        }
        public static void IsZeroOrNegative(decimal argumentValue, string argumentName)
        {
            if (argumentValue < 0 || argumentValue == 0)
                throw new ArgumentException($"{argumentName} is 0 or negative number");
        }
        public static void IsZeroOrNegative(double argumentValue, string argumentName)
        {
            if (argumentValue < 0 || argumentValue == 0)
                throw new ArgumentException($"{argumentName} is 0 or negative number");
        }
        public static void IsZeroOrNegative(float argumentValue, string argumentName)
        {
            if (argumentValue < 0 || argumentValue == 0)
                throw new ArgumentException($"{argumentName} is 0 or negative number");
        }

        public static void IsLengthExceeded(string argumentValue, string argumentName, int maximumLength)
        {
            if (argumentValue.Length > maximumLength)
                throw new ArgumentException($"{argumentName} has exceeded maximum number of characters");
        }

        public static void IsNullOrEmptyStringOrWhiteSpace(string argumentValue, string argumentName)
        {
            IsNullOrWhiteSpace(argumentValue, nameof(argumentName));
            IsNullOrEmptyString(argumentValue, nameof(argumentName));
        }

        public static void IsNullOrWhiteSpace(string argumentValue, string argumentName)
        {
            if (string.IsNullOrWhiteSpace(argumentValue))
                throw new ArgumentException($"{argumentName} is null or white space");
        }

        public static void IsNullOrEmptyString(string argumentValue, string argumentName)
        {
            if(string.IsNullOrEmpty(argumentValue))
                throw new ArgumentException($"{argumentName} is null or empty string");
        }

        public static void ArgumentIsNotNull(object value, string argumentName)
        {
            
            if (ReferenceEquals(value,null))
                throw new ArgumentNullException($"{argumentName} is null object");
        }
    }
}