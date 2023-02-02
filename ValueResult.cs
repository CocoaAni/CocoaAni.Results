using System.Diagnostics;

namespace CocoaAni.Results;

public class ValueResult<T> : IResult<T, Exception>
{
    public ValueResult()
    {
        Value = default;
        Error = default;
        StateCode = ResultStateCode.UnInit;
    }

    public ValueResult(T value)
    {
        if (value == null)
            throw new ArgumentNullException(nameof(value));
        Debug.Assert(typeof(T) != typeof(Exception));
        Value = value;
        Error = default;
        StateCode = ResultStateCode.Success;
    }

    public ValueResult(Exception error)
    {
        if (error is null)
            throw new ArgumentNullException(nameof(error));
        Debug.Assert(typeof(T) != typeof(Exception));
        StateCode = ResultStateCode.Error;
        Value = default;
        Error = error ?? throw new ArgumentNullException(nameof(error));
    }

    public T? Value { get; set; }
    public Exception? Error { get; set; }

    public void SetValue(T value)
    {
        if (value == null)
            throw new ArgumentNullException(nameof(value));
        StateCode = ResultStateCode.Success;
        Error = default;
        Value = value;
    }

    public void SetError(Exception error)
    {
        StateCode = ResultStateCode.Error;
        Value = default;
        Error = error ?? throw new ArgumentNullException(nameof(error));
    }

    public void SetValue(object value) => SetValue((T)value);

    public void SetError(object error) => SetError((Exception)error);

    public byte StateCode { get; private set; }
    public bool IsError => StateCode != ResultStateCode.Success;
    public bool IsSuccess => StateCode == ResultStateCode.Success;
}

public struct ValueResult<TV, TE> : IResult<TV, TE>
{
    public ValueResult()
    {
        Value = default;
        Error = default;
        StateCode = ResultStateCode.UnInit;
    }

    public ValueResult(TV value)
    {
        if (value == null)
            throw new ArgumentNullException(nameof(value));
        Debug.Assert(typeof(TV) != typeof(TE));
        Value = value;
        Error = default;
        StateCode = ResultStateCode.Success;
    }

    public ValueResult(TE error)
    {
        if (error == null)
            throw new ArgumentNullException(nameof(error));
        Debug.Assert(typeof(TV) != typeof(TE));
        Value = default;
        Error = error;
        StateCode = ResultStateCode.Error;
    }

    public TV? Value { get; set; }
    public TE? Error { get; set; }

    public void SetValue(TV value)
    {
        if (value == null)
            throw new ArgumentNullException(nameof(value));
        StateCode = ResultStateCode.Success;
        Error = default;
        Value = value;
    }

    public void SetError(TE error)
    {
        if (error == null)
            throw new ArgumentNullException(nameof(error));
        StateCode = ResultStateCode.Error;
        Value = default;
        Error = error;
    }

    public void SetValue(object value) => SetValue((TV)value);

    public void SetError(object error) => SetError((TE)error);

    public byte StateCode { get; private set; }
    public bool IsError => StateCode != ResultStateCode.Success;
    public bool IsSuccess => StateCode == ResultStateCode.Success;
}