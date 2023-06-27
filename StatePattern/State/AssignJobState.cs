namespace StatePattern.State;

public class AssignJobState : IJobState
{
    private readonly JobStateMachine _jobStateMachine;

    public AssignJobState(JobStateMachine jobStateMachine)
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
        Console.WriteLine("Job assigned");
        _jobStateMachine.SetState(_jobStateMachine.ProcessJobState);
    }

    public void Process()
    {
        Console.WriteLine("Cannot process job, job is not assigned yet");
    }

    public void Finish()
    {
        Console.WriteLine("Cannot finish job, job is not assigned yet");
    }

    public void Fail()
    {
        Console.WriteLine("Cannot fail job, job is not assigned yet");
    }

    public void Cancel()
    {
        Console.WriteLine("Cannot cancel job, job is not assigned yet");
    }
}