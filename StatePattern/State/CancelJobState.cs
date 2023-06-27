namespace StatePattern.State;

public class CancelJobState : IJobState
{
    private readonly JobStateMachine _jobStateMachine;

    public CancelJobState(JobStateMachine jobStateMachine)
    {
        _jobStateMachine = jobStateMachine;
    }

    public void Idle()
    {
        throw new NotImplementedException();
    }

    public void Receive()
    {
        Console.WriteLine("Cannot receive job, job is already received");
    }

    public void Assign()
    {
        Console.WriteLine("Cannot assign job, job is already assigned");
    }

    public void Process()
    {
        Console.WriteLine("Cannot process job, job is cancelled");
    }

    public void Finish()
    {
        Console.WriteLine("Cannot finish job, job is cancelled");
    }

    public void Fail()
    {
        Console.WriteLine("Cannot fail job, job is cancelled");
    }

    public void Cancel()
    {
        Console.WriteLine("Job cancelled");
        _jobStateMachine.SetState(_jobStateMachine.FinishJobState);
    }
    
}