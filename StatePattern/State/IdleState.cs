namespace StatePattern.State;

public class IdleState : IJobState
{
    private readonly JobStateMachine _jobStateMachine;

    public IdleState(JobStateMachine jobStateMachine)
    {
        _jobStateMachine = jobStateMachine;
    }

    public void Idle()
    {
        Console.WriteLine("Job machine is idle");
        _jobStateMachine.SetState(_jobStateMachine.ReceiveJobState);
    }

    public void Receive()
    {
        Console.WriteLine("Job machine is idle");
    }

    public void Assign()
    {
        Console.WriteLine("Job machine is idle");
    }

    public void Process()
    {
        Console.WriteLine("Job machine is idle");
    }

    public void Finish()
    {
        Console.WriteLine("Job machine is idle");
    }

    public void Fail()
    {
        Console.WriteLine("Job machine is idle");
    }

    public void Cancel()
    {
        Console.WriteLine("Job machine is idle");
    }
}