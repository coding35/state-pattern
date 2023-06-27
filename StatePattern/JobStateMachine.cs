using StatePattern.State;

namespace StatePattern;

public class JobStateMachine
{
    public IJobState IdleJobState;
    public IJobState AssignJobState;
    public IJobState ReceiveJobState;
    public IJobState ProcessJobState;
    public IJobState FinishJobState;
    public IJobState FailJobState;
    public IJobState CancelJobState;
    
    private IJobState _jobState;

    public JobStateMachine()
    {
        _jobState = new IdleState(this);
        IdleJobState = new IdleState(this);
        AssignJobState = new AssignJobState(this);
        ReceiveJobState = new ReceiveJobState(this);
        ProcessJobState = new ProcessJobState(this);
        FinishJobState = new FinishJobState(this);
        FailJobState = new FailJobState(this);
        CancelJobState = new CancelJobState(this);
    }
    
    public void SetState(IJobState jobState)
    {
        _jobState = jobState;
    }
    
    public void Idle()
    {
        _jobState.Idle();
        Notify();
    }
    
    public void Receive()
    {
        _jobState.Receive();
        Notify();
    }
    
    public void Assign()
    {
        _jobState.Assign();
        Notify();
    }
    
    public void Process()
    {
        _jobState.Process();
        Notify();
    }
    
    public void Finish()
    {
        _jobState.Finish();
        Notify();
    }
    
    public void Fail()
    {
        _jobState.Fail();
        Notify();
    }
    
    public void Cancel()
    {
        _jobState.Cancel();
        Notify();
    }

    private void Notify()
    {
        Console.WriteLine("Job state is " + _jobState.GetType().Name);
    }

    public IJobState GetState()
    {
        return _jobState;
    }
}

