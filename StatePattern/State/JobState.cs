namespace StatePattern.State;

public interface IJobState
{
    void Idle();
    void Receive();
    void Assign();
    void Process();
    void Finish();
    void Fail();
    void Cancel();
}