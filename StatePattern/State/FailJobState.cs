namespace StatePattern.State;

public class FailJobState : IJobState
{
    private readonly JobStateMachine _jobStateMachine;

    public FailJobState(JobStateMachine jobStateMachine)
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
        Console.WriteLine("Job failed to process");
    }

    public void Finish()
    {
        Console.WriteLine("Job failed to finish");
    }

    public void Fail()
    {
        Console.WriteLine("Job has failed");
    }

    public void Cancel()
    {
        Console.WriteLine("Cannot cancel job, job failed");
    }
}