namespace StatePattern.State;

// implementing the behavior for the state we are in. i.e. ReceiveJobState
public class ReceiveJobState : IJobState
{
    private readonly JobStateMachine _jobStateMachine;

    public ReceiveJobState(JobStateMachine jobStateMachine)
    {
        _jobStateMachine = jobStateMachine;
    }

    public void Idle()
    {
        throw new NotImplementedException();
    }

    public void Receive()
    {
        Console.WriteLine("Job received");
        _jobStateMachine.SetState(_jobStateMachine.AssignJobState);
    }

    public void Assign()
    {
        Console.WriteLine("Cannot assign job, job is not received yet");
    }

    public void Process()
    {
        Console.WriteLine("Cannot process job, job is not received yet");
    }

    public void Finish()
    {
        Console.WriteLine("Cannot finish job, job is not received yet");
    }

    public void Fail()
    {
        Console.WriteLine("Cannot fail job, job is not received yet");
    }

    public void Cancel()
    {
        Console.WriteLine("Cannot cancel job, job is not received yet");
    }
}

