using System;
using System.Threading;
using HotChocolate.Fetching;

namespace HotChocolate.Execution.Processing;

#pragma warning disable CS0067
internal class NoopBatchDispatcher : IBatchDispatcher
{
    public event EventHandler? TaskEnqueued;

    public bool DispatchOnSchedule { get; set; }

    public void BeginDispatch(CancellationToken cancellationToken) { }

    public static NoopBatchDispatcher Default { get; } = new();
}
