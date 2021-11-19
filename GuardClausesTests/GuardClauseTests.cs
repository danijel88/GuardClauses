using System;
using System.Collections.Generic;
using GuardClauses;
using Xunit;
using static System.Decimal;

namespace GuardClausesTests
{
    public class GuardClauseTests
    {
        [Theory]
        [MemberData(nameof(IntegerDataZeroOrNegative))]
        public void IsZeroOrNegative_WithNegativeIntegerOrZero_ThrowsArgumentException(int number)
        {
            Action action = () => GuardClause.IsZeroOrNegative(number, nameof(number));
            Assert.Throws<ArgumentException>(action);
        }
        [Theory]
        [MemberData(nameof(IntegerDataPositiveValues))]
        public void IsZeroOrNegative_WithIntegerPositiveValue(int number)
        {
            GuardClause.IsZeroOrNegative(number, nameof(number));
        }

        [Theory]
        [MemberData(nameof(LongDataZeroOrNegative))]
        public void IsZeroOrNegative_WithNegativeLongOrZero_ThrowsArgumentException(long number)
        {
            Action action = () => GuardClause.IsZeroOrNegative(number, nameof(number));
            Assert.Throws<ArgumentException>(action);
        }

        [Theory]
        [MemberData(nameof(LongDataPositiveValues))]
        public void IsZeroOrNegative_WithLongPositiveValues(long number)
        {
            GuardClause.IsZeroOrNegative(number, nameof(number));
        }

        [Theory]
        [MemberData(nameof(DecimalDataZeroOrNegative))]
        public void IsZeroOrNegative_WithNegativeDecimalOrZero_ThrowsArgumentException(decimal number)
        {
            Action action = () => GuardClause.IsZeroOrNegative(number, nameof(number));
            Assert.Throws<ArgumentException>(action);
        }
        [Theory]
        [MemberData(nameof(DecimalDataPositiveValues))]
        public void IsZeroOrNegative_WithDecimalPositiveValues(decimal number)
        {
            GuardClause.IsZeroOrNegative(number, nameof(number));
        }
        [Theory]
        [MemberData(nameof(FloatDataZeroOrNegative))]
        public void IsZeroOrNegative_WithNegativeFloatOrZero_ThrowsArgumentException(float number)
        {
            Action action = () => GuardClause.IsZeroOrNegative(number, nameof(number));
            Assert.Throws<ArgumentException>(action);
        }
        [Theory]
        [MemberData(nameof(FloatDataPositiveValues))]
        public void IsZeroOrNegative_WithFloatPositiveValues(float number)
        {
            GuardClause.IsZeroOrNegative(number, nameof(number));
        }
        [Theory]
        [MemberData(nameof(DoubleDataZeroOrNegative))]
        public void IsZeroOrNegative_WithNegativeDoubleOrZero_ThrowsArgumentException(double number)
        {
            Action action = () => GuardClause.IsZeroOrNegative(number, nameof(number));
            Assert.Throws<ArgumentException>(action);
        }
        [Theory]
        [MemberData(nameof(DoubleDataPositiveValues))]
        public void IsZeroOrNegative_WithDoublePositiveValues(double number)
        {
            GuardClause.IsZeroOrNegative(number, nameof(number));
        }

        [Theory]
        [InlineData(150)]
        public void IsLengthExceeded_WithExceededNumberOfChars_ThrowsArgumentException(int maximumLength)
        {
            var exceededNrOfChars = new string('x', maximumLength + 1);
            Action action = () => GuardClause.IsLengthExceeded(exceededNrOfChars, nameof(exceededNrOfChars), maximumLength);
            Assert.Throws<ArgumentException>(action);
        }

        [Theory]
        [InlineData(150)]
        public void IsLengthExceeded_WithEqualNumberOfChars(int maximumLength)
        {
            var exceededNrOfChars = new string('x', maximumLength);
            GuardClause.IsLengthExceeded(exceededNrOfChars, nameof(exceededNrOfChars), maximumLength);
        }
        [Theory]
        [MemberData(nameof(NullEmptyStrings))]
        public void IsNullOrEmptyStringOrWhiteSpace_WithNullEmptyAndWhiteSpace_ThrowsArgumentException(string value)
        {
            Action action = () => GuardClause.IsNullOrEmptyStringOrWhiteSpace(value, nameof(value));
            Assert.Throws<ArgumentException>(action);
        }

        [Theory]
        [MemberData(nameof(NullEmptyStrings))]
        public void IsNullOrEmptyString_WithNullEmptyAndWhiteSpace_ThrowsArgumentException(string value)
        {
            Action action = () => GuardClause.IsNullOrEmptyString(value, nameof(value));
            Assert.Throws<ArgumentException>(action);
        }

        [Theory]
        [MemberData(nameof(Strings))]
        public void IsNullOrEmptyStringOrWhiteSpace_WithNotNullOrEmptyString(string value)
        {
            GuardClause.IsNullOrEmptyStringOrWhiteSpace(value, nameof(value));
        }

        [Theory]
        [MemberData(nameof(Strings))]
        public void IsNullOrEmptyString_WithNotNullOrEmptyString(string value)
        {
            GuardClause.IsNullOrEmptyString(value, nameof(value));
        }

        [Theory]
        [MemberData(nameof(NullObject))]
        public static void ArgumentIsNotNull_WithNullObject_ThrowsArgumentNullException(object value)
        {
            Action action = () => GuardClause.ArgumentIsNotNull(value, nameof(value));
            Assert.Throws<ArgumentNullException>(action);
        }
        [Theory]
        [MemberData(nameof(Object))]
        public static void ArgumentIsNotNull(object value)
        {
            GuardClause.ArgumentIsNotNull(value, nameof(value));

        }

        [Fact]
        public static void IsZero_WithIntZeroValue_ThrowArgumentException()
        {
            int value = 0;
            Action action = () => GuardClause.IsZero(value, nameof(value));
            Assert.Throws<ArgumentException>(action);
        }
        [Fact]
        public static void IsZero_WithFloatZeroValue_ThrowArgumentException()
        {
            float value = 0;
            Action action = () => GuardClause.IsZero(value, nameof(value));
            Assert.Throws<ArgumentException>(action);
        }
        [Fact]
        public static void IsZero_WithDecimalZeroValue_ThrowArgumentException()
        {
            decimal value = 0;
            Action action = () => GuardClause.IsZero(value, nameof(value));
            Assert.Throws<ArgumentException>(action);
        }
        [Fact]
        public static void IsZero_WithDoubleZeroValue_ThrowArgumentException()
        {
            double value = 0;
            Action action = () => GuardClause.IsZero(value, nameof(value));
            Assert.Throws<ArgumentException>(action);
        }

        [Fact]
        public static void IsZero_WithLongZeroValue_ThrowArgumentException()
        {
            long value = 0;
            Action action = () => GuardClause.IsZero(value, nameof(value));
            Assert.Throws<ArgumentException>(action);
        }

        [Theory]
        [InlineData(int.MaxValue)]
        [InlineData(int.MinValue)]

        public static void IsZero_WithIntZeroValue(int value)
        {

            GuardClause.IsZero(value, nameof(value));

        }

        [Theory]
        [InlineData(float.MaxValue)]
        [InlineData(float.MinValue)]
        [InlineData(float.NegativeInfinity)]
        [InlineData(float.PositiveInfinity)]
        public static void IsZero_WithFloatZeroValue(float value)
        {
            GuardClause.IsZero(value, nameof(value));
        }

        [Fact]
        
        public static void IsZero_WithDecimalZeroValue()
        {
            var value = MinValue;
            GuardClause.IsZero(value, nameof(value));
            value = MaxValue;
            GuardClause.IsZero(value, nameof(value));
            value = MinusOne;
            GuardClause.IsZero(value, nameof(value));
            value = One;
            GuardClause.IsZero(value, nameof(value));
        }

        [Theory]
        [InlineData(double.MaxValue)]
        [InlineData(double.MinValue)]
        [InlineData(double.NegativeInfinity)]
        [InlineData(double.PositiveInfinity)]
        public static void IsZero_WithDoubleZeroValue(double value)
        {
            GuardClause.IsZero(value, nameof(value));
        }

        [Theory]
        [InlineData(long.MaxValue)]
        [InlineData(long.MinValue)]

        public static void IsZero_WithLongZeroValue(long value)
        {
            GuardClause.IsZero(value, nameof(value));
        }

        [Fact]
        public static void IsNegative_WithIntNegative_ThrowsArgumentException()
        {
            int value = int.MinValue;
            Action action = () => GuardClause.IsNegative(value, nameof(value));
            Assert.Throws<ArgumentException>(action);
        }
        [Fact]
        public static void IsNegative_WithIntNegative()
        {
            int value = int.MaxValue;
            GuardClause.IsNegative(value, nameof(value));
        }
        [Fact]
        public static void IsNegative_WithDecimalNegative_ThrowsArgumentException()
        {
            decimal value = decimal.MinValue;
            Action action = () => GuardClause.IsNegative(value, nameof(value));
            Assert.Throws<ArgumentException>(action);
        }
        [Fact]
        public static void IsNegative_WithDecimalNegative()
        {
            decimal value = decimal.MaxValue;
            GuardClause.IsNegative(value, nameof(value));
             value = decimal.Zero;
            GuardClause.IsNegative(value, nameof(value));
        }
        [Fact]
        public static void IsNegative_WithDoubleNegative_ThrowsArgumentException()
        {
            double value = double.MinValue;
            Action action = () => GuardClause.IsNegative(value, nameof(value));
            Assert.Throws<ArgumentException>(action);
        }
        [Fact]
        public static void IsNegative_WithDoubleNegative()
        {
            double value = double.PositiveInfinity;
            GuardClause.IsNegative(value, nameof(value));
             value = double.MaxValue;
            GuardClause.IsNegative(value, nameof(value));
        }
        [Fact]
        public static void IsNegative_WithLongNegative_ThrowsArgumentException()
        {
            long value = long.MinValue;
            Action action = () => GuardClause.IsNegative(value, nameof(value));
            Assert.Throws<ArgumentException>(action);
        }
        [Fact]
        public static void IsNegative_WithLongNegative()
        {
            long value = long.MaxValue;
            GuardClause.IsNegative(value, nameof(value));
            value = 0;
            GuardClause.IsNegative(value, nameof(value));
        }
        [Fact]
        public static void IsNegative_WithFloatNegative_ThrowsArgumentException()
        {
            float value = float.MinValue;
            Action action = () => GuardClause.IsNegative(value, nameof(value));
            Assert.Throws<ArgumentException>(action);
        }
        [Fact]
        public static void IsNegative_WithFloatNegative()
        {
            float value = float.MaxValue;
            GuardClause.IsNegative(value, nameof(value));
            value = float.PositiveInfinity;
            GuardClause.IsNegative(value, nameof(value));
        }

        [Theory]
        [InlineData("2021-01-25","2020-05-20")]
        public static void DateTimeIsGraterThan_WithGraterDate_ThrowsArgumentException(DateTime firstDate, DateTime secondDate)
        {
            Action action = () => GuardClause.DateTimeIsGraterThan(firstDate, nameof(firstDate),secondDate);
            Assert.Throws<ArgumentException>(action);
        }
        [Theory]
        [InlineData("2020-01-25","2020-05-20")]
        public static void DateTimeIsGraterThan(DateTime firstDate, DateTime secondDate)
        {
            GuardClause.DateTimeIsGraterThan(firstDate, nameof(firstDate),secondDate);
        }
        [Theory]
        [InlineData("2020-01-25","2020-05-20")]
        public static void DateTimeIsGraterThan_WithLessDate_ThrowsArgumentException(DateTime firstDate, DateTime secondDate)
        {
            Action action = () => GuardClause.DateTimeIsLessThan(firstDate, nameof(firstDate),secondDate);
            Assert.Throws<ArgumentException>(action);
        }
        [Theory]
        [InlineData("2021-01-25","2020-05-20")]
        public static void DateTimeIsLessThan(DateTime firstDate, DateTime secondDate)
        {
            GuardClause.DateTimeIsLessThan(firstDate, nameof(firstDate),secondDate);
        }
        [Theory]
        [InlineData("2021-01-25","2020-05-20","2020-08-25")]
        public static void DateTimeIsOutOfRange_ThrowsArgumentException(DateTime argumentValue, DateTime startDate,DateTime endDate)
        {
            Action action = () => GuardClause.DateTimeIsOutOfRange(argumentValue,startDate,nameof(argumentValue),endDate);
            Assert.Throws<ArgumentException>(action);
        }
        [Theory]
        [InlineData("2020-07-25","2020-05-20","2020-08-25")]
        public static void DateTimeIsOutOfRange(DateTime argumentValue, DateTime startDate,DateTime endDate)
        {
            GuardClause.DateTimeIsOutOfRange(argumentValue,startDate,nameof(argumentValue),endDate);
        }

        [Fact]
        public static void IsStringEmptyGuid_WithEmptyGuidString_ThrowsArgumentException()
        {
            var value = Guid.Empty.ToString();
            Action action = () => GuardClause.IsStringEmptyGuid(value, nameof(value));
            Assert.Throws<ArgumentException>(action);
        }

        [Fact]
        public static void IsStringEmptyGuid()
        {
            var value = Guid.NewGuid().ToString();
            GuardClause.IsStringEmptyGuid(value, nameof(value));
        }

        [Fact]
        public static void IsSEmptyGuid_WithEmptyGuid_ThrowsArgumentException()
        {
            var value = Guid.Empty;
            Action action = () => GuardClause.IsEmptyGuid(value, nameof(value));
            Assert.Throws<ArgumentException>(action);
        }

        [Fact]
        public static void IsEmptyGuid()
        {
            var value = Guid.NewGuid();
            GuardClause.IsEmptyGuid(value, nameof(value));
        }


        #region MemberDataHelper

        public class TestClass
        {
            public int Id { get; set; }
        }

        public static IEnumerable<object[]> NullObject()
        {
            TestClass a = null;
            return new List<object[]>
            {
                new object[] {a}
            };
        }
        public static IEnumerable<object[]> Object()
        {
            TestClass a = new TestClass();
            return new List<object[]>
            {
                new object[] {a}
            };
        }
        public static IEnumerable<object[]> NullEmptyStrings => new List<object[]>
        {
            new object[]{null},
            new object[]{""},
            new object[]{string.Empty},
        };
        public static IEnumerable<object[]> Strings => new List<object[]>
        {
            new object[]{new string('a',2)},
            new object[]{"ABCDE"},

        };

        public static IEnumerable<object[]> IntegerDataZeroOrNegative =>
            new List<object[]>
            {
                new object[] { -4,},
                new object[] { -2, },
                new object[] { int.MinValue, },
                new object[] { 0, },

            }; public static IEnumerable<object[]> IntegerDataPositiveValues =>
             new List<object[]>
             {
                new object[] { 4,},
                new object[] { 2, },
                new object[] { int.MaxValue, },

             };
        public static IEnumerable<object[]> DecimalDataZeroOrNegative =>
            new List<object[]>
            {
                new object[] { -4.2m,},
                new object[] { -2.5m, },
                new object[] { MinValue, },
                new object[] { MinusOne, },
                new object[] { Zero, },

            };
        public static IEnumerable<object[]> DecimalDataPositiveValues =>
            new List<object[]>
            {
                new object[] { 4.2m,},
                new object[] { 2.5m, },
                new object[] { MaxValue, },
                new object[] { One, },

            };
        public static IEnumerable<object[]> LongDataZeroOrNegative =>
            new List<object[]>
            {
                new object[] { long.Parse("-25"),},
                new object[] { long.MinValue },

            };
        public static IEnumerable<object[]> LongDataPositiveValues =>
            new List<object[]>
            {
                new object[] { long.Parse("8547"),},
                new object[] { long.MaxValue },

            };
        public static IEnumerable<object[]> FloatDataZeroOrNegative =>
            new List<object[]>
            {

                new object[] { float.MinValue },
                new object[] { float.NegativeInfinity },

            };
        public static IEnumerable<object[]> FloatDataPositiveValues =>
            new List<object[]>
            {

                new object[] { float.MaxValue },
                new object[] { float.PositiveInfinity },
                new object[] { float.Epsilon },

            };
        public static IEnumerable<object[]> DoubleDataZeroOrNegative =>
            new List<object[]>
            {

                new object[] { double.MinValue },
                new object[] { double.NegativeInfinity },

            };
        public static IEnumerable<object[]> DoubleDataPositiveValues =>
            new List<object[]>
            {

                new object[] { double.MaxValue },
                new object[] { double.PositiveInfinity },
                new object[] { double.Epsilon },

            };
        #endregion

    }
}
