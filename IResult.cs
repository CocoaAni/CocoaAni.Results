namespace CocoaAni.Results;

public interface IResult
{
    public byte StateCode { get; }
    public Type ValueType { get; }
    public Type ErrorType { get; }

    public object? GetValue();

    public object? GetError();

    public void SetValue(object value);

    public void SetError(object error);

    public bool IsError { get; }
    public bool IsSuccess { get; }

    public static bool IsNumberOrBoolOrChar(Type dataType)
    {
        return (dataType == typeof(int)
                || dataType == typeof(double)
                || dataType == typeof(long)
                || dataType == typeof(float)
                || dataType == typeof(short)
                || dataType == typeof(ushort)
                || dataType == typeof(uint)
                || dataType == typeof(ulong)
                || dataType == typeof(sbyte)
                || dataType == typeof(bool)
                || dataType == typeof(char)
            );
    }
}

public interface IResult<TV, TE> : IResult
{
    Type IResult.ValueType => typeof(TV);
    Type IResult.ErrorType => typeof(TE);
    public TV? Value { get; }
    public TE? Error { get; }

    object? IResult.GetValue() => Value;

    object? IResult.GetError() => Error;

    public void SetValue(TV value);

    public void SetError(TE error);
}