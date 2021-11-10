# GuardClauses
GuardClause is a check of integrity preconditions used to avoid errors during execution
# Usage
```c#
public void Execution(string name, int age)
{
  GuardClause.IsZeroOrNegative(age,nameof(age));
  GuardClause.IsNullOrEmptyStringOrWhiteSpace(name, nameof(name));
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
GuardClause.IsNullOrWhiteSpace(string argumentValue, string argumentName);
GuardClause.IsNullOrEmptyString(string argumentValue, string argumentName);
GuardClause.ArgumentIsNotNull(object value, string argumentName);
```
