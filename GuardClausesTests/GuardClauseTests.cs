using System;
using System.Collections.Generic;
using GuardClauses;
using Xunit;

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
        }        [Theory]
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
            var exceededNrOfChars = new string('x', maximumLength+1);
            Action action = () => GuardClause.IsLengthExceeded(exceededNrOfChars, nameof(exceededNrOfChars), maximumLength );
            Assert.Throws<ArgumentException>(action);
        }

        [Theory]
        [InlineData(150)]
        public void IsLengthExceeded_WithEqualNumberOfChars(int maximumLength)
        {
            var exceededNrOfChars = new string('x', maximumLength);
            GuardClause.IsLengthExceeded(exceededNrOfChars, nameof(exceededNrOfChars), maximumLength );
        }
        [Theory]
        [MemberData(nameof(NullEmptyStrings))]
        public void IsNullOrEmptyStringOrWhiteSpace_WithNullEmptyAndWhiteSpace_ThrowsArgumentException(string value)
        {
            Action action = () => GuardClause.IsNullOrEmptyStringOrWhiteSpace(value,nameof(value));
            Assert.Throws<ArgumentException>(action);
        }

        [Theory]
        [MemberData(nameof(NullEmptyStrings))]
        public void IsNullOrEmptyString_WithNullEmptyAndWhiteSpace_ThrowsArgumentException(string value)
        {
            Action action = () => GuardClause.IsNullOrEmptyString(value,nameof(value));
            Assert.Throws<ArgumentException>(action);
        }

        [Theory]
        [MemberData(nameof(Strings))]
        public void IsNullOrEmptyStringOrWhiteSpace_WithNotNullOrEmptyString(string value)
        {
            GuardClause.IsNullOrEmptyStringOrWhiteSpace(value,nameof(value));
        }

        [Theory]
        [MemberData(nameof(Strings))]
        public void IsNullOrEmptyString_WithNotNullOrEmptyString(string value)
        {
            GuardClause.IsNullOrEmptyString(value,nameof(value));
        }

        [Theory]
        [MemberData(nameof(NullObject))]
        public static void ArgumentIsNotNull_WithNullObject_ThrowsArgumentNullException(object value)
        {
            Action action = () => GuardClause.ArgumentIsNotNull(value,nameof(value));
            Assert.Throws<ArgumentNullException>(action);
        }
        [Theory]
        [MemberData(nameof(Object))]
        public static void ArgumentIsNotNull(object value)
        {
            GuardClause.ArgumentIsNotNull(value,nameof(value));

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

            };public static IEnumerable<object[]> IntegerDataPositiveValues =>
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
                new object[] { decimal.MinValue, },
                new object[] { decimal.MinusOne, },
                new object[] { decimal.Zero, },

            };
        public static IEnumerable<object[]> DecimalDataPositiveValues =>
            new List<object[]>
            {
                new object[] { 4.2m,},
                new object[] { 2.5m, },
                new object[] { decimal.MaxValue, },
                new object[] { decimal.One, },

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
