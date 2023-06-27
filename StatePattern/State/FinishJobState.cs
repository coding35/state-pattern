namespace StatePattern.State;

public class FinishJobState : IJobState
{
    private readonly JobStateMachine _jobStateMachine;

    public FinishJobState(JobStateMachine jobStateMachine)
    {
        _jobStateMachine = jobStateMachine;
    }

    public void Idle()
    {
        throw new NotImplementedException();
    }

    public void Receive()
    {
        Console.WriteLine("Job is already received");
    }

    public void Assign()
    {
        Console.WriteLine("Job is already assigned");
    }

    public void Process()
    {
        Console.WriteLine("Cannot process job, job is already finished");
    }

    public void Finish()
    {
        Console.WriteLine("Job is finished");
        _jobStateMachine.SetState(_jobStateMachine.FinishJobState);
    }

    public void Fail()
    {
        Console.WriteLine("Cannot fail job, job is already finished");
    }

    public void Cancel()
    {
        Console.WriteLine("Cannot cancel job, job is already finished");
    }
}