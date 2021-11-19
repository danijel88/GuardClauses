﻿using System;

namespace GuardClauses
{
    public static class GuardClause
    {
        public static void IsZero(int argumentValue, string argumentName)
        {
            if (argumentValue == 0)
                throw new ArgumentException($"{argumentName} is zero");
        }

        public static void IsZero(long argumentValue, string argumentName)
        {
            if ( argumentValue == 0)
                throw new ArgumentException($"{argumentName} is zero");
        }
        public static void IsZero(decimal argumentValue, string argumentName)
        {
            if (argumentValue == 0)
                throw new ArgumentException($"{argumentName} is zero");
        }
        public static void IsZero(double argumentValue, string argumentName)
        {
            if ( argumentValue == 0)
                throw new ArgumentException($"{argumentName} is zero.");
        }
        public static void IsZero(float argumentValue, string argumentName)
        {
            if ( argumentValue == 0)
                throw new ArgumentException($"{argumentName} is zero.");
        }
        public static void IsNegative(int argumentValue, string argumentName)
        {
            if (argumentValue < 0 )
                throw new ArgumentException($"{argumentName} is negative number");
        }

        public static void IsNegative(long argumentValue, string argumentName)
        {
            if (argumentValue < 0 )
                throw new ArgumentException($"{argumentName} is negative number");
        }
        public static void IsNegative(decimal argumentValue, string argumentName)
        {
            if (argumentValue < 0)
                throw new ArgumentException($"{argumentName} is negative number");
        }
        public static void IsNegative(double argumentValue, string argumentName)
        {
            if (argumentValue < 0)
                throw new ArgumentException($"{argumentName} is negative number");
        }
        public static void IsNegative(float argumentValue, string argumentName)
        {
            if (argumentValue < 0)
                throw new ArgumentException($"{argumentName} is 0 or negative number");
        }
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

        public static void DateTimeIsGraterThan(DateTime argumentValue, string argumentName ,DateTime comparableDateTme)
        {
            if (argumentValue > comparableDateTme)
                throw new ArgumentException($"{nameof(argumentName)}{argumentValue} is greater than {comparableDateTme}");
        }

        public static void DateTimeIsLessThan(DateTime argumentValue, string argumentName ,DateTime comparableDateTme)
        {
            if (argumentValue < comparableDateTme)
                throw new ArgumentException($"{nameof(argumentName)}{argumentValue} is less than {comparableDateTme}");
        }
        public static void DateTimeIsOutOfRange(DateTime argumentValue,DateTime startDateTime, string argumentName ,DateTime endDateTime)
        {
            if (argumentValue < startDateTime || argumentValue > endDateTime)
                throw new ArgumentException($"{nameof(argumentName)} is out of range");
        }

        public static void IsStringEmptyGuid(string argumentValue, string argumentName)
        {
            if (argumentValue == Guid.Empty.ToString())
                throw new ArgumentException($"{nameof(argumentName)} can not be string with value of empty guid.");
        }
        public static void IsEmptyGuid(Guid argumentValue, string argumentName)
        {
            if (argumentValue == Guid.Empty)
                throw new ArgumentException($"{nameof(argumentName)} can not be string with value of empty guid.");
        }
    }
}