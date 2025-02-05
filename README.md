# GuardClauses
GuardClause is a check of integrity preconditions used to avoid errors during execution
# Get a star
If you like the library, please give a star.

# Usage
```c#
public void Execution(string name, int age)
{
  Name =  GuardClause.IsZeroOrNegative(age,nameof(age));
  Age  =  GuardClause.IsNullOrEmptyStringOrWhiteSpace(name, nameof(name));
}
```

# Available methods
```c#
GuardClause.IsZeroOrNegative(int argumentValue, string argumentName);
GuardClause.IsZeroOrNegative(decimal argumentValue, string argumentName);
GuardClause.IsZeroOrNegative(float argumentValue, string argumentName);
GuardClause.IsZeroOrNegative(long argumentValue, string argumentName);
GuardClause.IsZeroOrNegative(double argumentValue, string argumentName);
GuardClause.IsLengthExceeded(string argumentValue, string agrumentName, int maximumLength);
GuardClause.IsNullOrEmptyStringOrWhiteSpace(string argumentValue, string argumentName);
GuardClauseEnsureValidString(string argumentValue, string argumentName,List<StringValidationType> types);
GuardClauseEnsureValidString(string argumentValue, string argumentName,StringValidationType type);
GuardClause.IsNullOrEmptyString(string argumentValue, string argumentName);
GuardClause.ArgumentIsNotNull(object value, string argumentName);
GuardClause.IsZero(int argumentValue, string argumentName);
GuardClause.IsZero(long argumentValue, string argumentName);
GuardClause.IsZero(long argumentValue, string argumentName);
GuardClause.IsZero(decimal argumentValue, string argumentName);
GuardClause.IsZero(double argumentValue, string argumentName);
GuardClause.IsZero(float argumentValue, string argumentName);
GuardClause.IsNegative(int argumentValue, string argumentName);
GuardClause.IsNegative(long argumentValue, string argumentName);
GuardClause.IsNegative(long argumentValue, string argumentName);
GuardClause.IsNegative(decimal argumentValue, string argumentName);
GuardClause.IsNegative(double argumentValue, string argumentName);
GuardClause.IsNegative(float argumentValue, string argumentName);
GuardClause.DateTimeIsGraterThan(DateTime argumentValue, string argumentName ,DateTime comparableDateTme);
GuardClause.DateTimeIsLessThan(DateTime argumentValue, string argumentName ,DateTime comparableDateTme);
GuardClause.DateTimeIsOutOfRange(DateTime argumentValue,DateTime startDateTime, string argumentName ,DateTime endDateTime);
GuardClause.IsStringEmptyGuid(string argumentValue, string argumentName);
GuardClause.IsEmptyGuid(Guid argumentValue, string argumentName);
GuardClause.IsEmailValid(string email);
GuardClause.UrlChecker(string url);
GuardClause.MaximumLength(string argumentValue, string argumentName, int maximumLength);
```
# Nuget
https://www.nuget.org/packages/GuardClauses/
