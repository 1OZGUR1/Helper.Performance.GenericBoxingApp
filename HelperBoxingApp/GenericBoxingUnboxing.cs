namespace HelperBoxingApp;

public static class GenericBoxingUnboxing
{
    // This line had only one type argument
    public static TBox? Box<TBox, TValue>(TValue value) => (TBox)Convert.ChangeType(value, typeof(TBox))!;
    public static TValue? Unbox<TValue>(object? boxedValue) => (TValue)Convert.ChangeType(boxedValue, typeof(TValue))!;
}