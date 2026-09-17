using NUnit.Framework;

[TestFixture]
public class NotGateTests
{
    [Test]
    public void Output_WithTrue_False()
    {
        ILogicValue True = new TrueValue();
        IGate notGate = new NotGate(True);

        Assert.That(notGate.Output(), Is.EqualTo(false));
    }

    [Test]
    public void Output_WithFalse_True()
    {
        ILogicValue False = new FalseValue();
        IGate notGate = new NotGate(False);

        Assert.That(notGate.Output(), Is.EqualTo(true));
    }
}