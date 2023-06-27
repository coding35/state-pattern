namespace StatePattern.State;
public class ProcessJobState : IJobState
{
    private readonly JobStateMachine _jobStateMachine;

    public ProcessJobState(JobStateMachine jobStateMachine)
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
        Console.WriteLine("Job is processed");
        _jobStateMachine.SetState(_jobStateMachine.FinishJobState);
    }

    public void Finish()
    {
        Console.WriteLine("Cannot finish job, job is not processed yet");
    }

    public void Fail()
    {
        Console.WriteLine("Cannot fail job, job is not processed yet");
    }

    public void Cancel()
    {
        Console.WriteLine("Cannot cancel job, job is not processed yet");
    }
}