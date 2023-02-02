namespace CocoaAni.Results;

public class ResultTask<T> : ResultTask<T, Exception>
{
    public ResultTask(Func<object?, ResultTask<T, Exception>> function, object? state) : base(function, state)
    {
    }

    public ResultTask(Func<object?, ResultTask<T, Exception>> function, object? state, CancellationToken cancellationToken) : base(function, state, cancellationToken)
    {
    }

    public ResultTask(Func<object?, ResultTask<T, Exception>> function, object? state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) : base(function, state, cancellationToken, creationOptions)
    {
    }

    public ResultTask(Func<object?, ResultTask<T, Exception>> function, object? state, TaskCreationOptions creationOptions) : base(function, state, creationOptions)
    {
    }

    public ResultTask(Func<ResultTask<T, Exception>> function) : base(function)
    {
    }

    public ResultTask(Func<ResultTask<T, Exception>> function, CancellationToken cancellationToken) : base(function, cancellationToken)
    {
    }

    public ResultTask(Func<ResultTask<T, Exception>> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions) : base(function, cancellationToken, creationOptions)
    {
    }

    public ResultTask(Func<ResultTask<T, Exception>> function, TaskCreationOptions creationOptions) : base(function, creationOptions)
    {
    }
}

public class ResultTask<TV, TE> : Task<ResultTask<TV, TE>>
{
    public ResultTask(Func<object?, ResultTask<TV, TE>> function, object? state) : base(function, state)
    {
    }

    public ResultTask(Func<object?, ResultTask<TV, TE>> function, object? state, CancellationToken cancellationToken) : base(function, state, cancellationToken)
    {
    }

    public ResultTask(Func<object?, ResultTask<TV, TE>> function, object? state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) : base(function, state, cancellationToken, creationOptions)
    {
    }

    public ResultTask(Func<object?, ResultTask<TV, TE>> function, object? state, TaskCreationOptions creationOptions) : base(function, state, creationOptions)
    {
    }

    public ResultTask(Func<ResultTask<TV, TE>> function) : base(function)
    {
    }

    public ResultTask(Func<ResultTask<TV, TE>> function, CancellationToken cancellationToken) : base(function, cancellationToken)
    {
    }

    public ResultTask(Func<ResultTask<TV, TE>> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions) : base(function, cancellationToken, creationOptions)
    {
    }

    public ResultTask(Func<ResultTask<TV, TE>> function, TaskCreationOptions creationOptions) : base(function, creationOptions)
    {
    }
}