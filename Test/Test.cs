using System.Net.NetworkInformation;
using NUnit.Framework;
using StatePattern;
using StatePattern.State;

namespace Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldStepThroughStates()
    {
        var jobStateMachine = new JobStateMachine();
        
        jobStateMachine.Idle();
        Assert.IsTrue(jobStateMachine.GetState() is ReceiveJobState);
        jobStateMachine.Receive();
        Assert.IsTrue(jobStateMachine.GetState() is AssignJobState);
        jobStateMachine.Assign();
        Assert.IsTrue(jobStateMachine.GetState() is ProcessJobState);
        jobStateMachine.Process();
        Assert.IsTrue(jobStateMachine.GetState() is FinishJobState);
        jobStateMachine.Finish();
        Assert.IsTrue(jobStateMachine.GetState() is FinishJobState);
    }
}