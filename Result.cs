using System.Diagnostics;

namespace CocoaAni.Results;

public class Result<T> : Result<T, Exception>
{
    public Result()
    {
    }

    public Result(T value) : base(value)
    {
    }

    public Result(Exception error) : base(error)
    {
    }
}

public class Result<TV, TE> : IResult<TV, TE>
{
    public Result()
    {
    }

    public Result(TV value)
    {
        if (value == null)
            throw new ArgumentNullException(nameof(value));
        Debug.Assert(typeof(TV) != typeof(TE));
        Value = value;
        Error = default;
        StateCode = ResultStateCode.Success;
    }

    public Result(TE error)
    {
        if (error == null)
            throw new ArgumentNullException(nameof(error));
        Debug.Assert(typeof(TV) != typeof(TE));
        Value = default;
        Error = error;
        StateCode = ResultStateCode.Error;
    }

    public byte StateCode { get; set; }
    public bool IsError => StateCode != ResultStateCode.Success;
    public bool IsSuccess => StateCode == ResultStateCode.Success;
    public TV? Value { get; protected set; }
    public TE? Error { get; protected set; }

    public virtual void SetValue(TV value)
    {
        if (value == null)
            throw new ArgumentNullException(nameof(value));
        StateCode = ResultStateCode.Success;
        Error = default;
        Value = value;
    }

    public virtual void SetError(TE error)
    {
        if (error == null)
            throw new ArgumentNullException(nameof(error));
        StateCode = ResultStateCode.Error;
        Value = default;
        Error = error;
    }

    public virtual void SetValue(object value) => SetValue((TV)value);

    public virtual void SetError(object error) => SetError((TE)error);
}