using NUnit.Framework;

[TestFixture]
public class AndGateTests
{
    [Test]
    public void Output_WithFalseAndFalse_False()
    {
        ILogicValue False1 = new FalseValue();
        ILogicValue False2 = new FalseValue();
        IGate andGate = new AndGate(False1, False2);

        Assert.That(andGate.Output(), Is.EqualTo(false));
    }

    [Test]
    public void Output_WithTrueAndFalse_False()
    {
        ILogicValue False = new FalseValue();
        ILogicValue True = new TrueValue();
        IGate andGate = new AndGate(True, False);

        Assert.That(andGate.Output(), Is.EqualTo(false));
    }

    [Test]
    public void Output_WithTrueAndTrue_True()
    {
        ILogicValue True2 = new TrueValue();
        ILogicValue True1 = new TrueValue();
        IGate orGate = new AndGate(True1, True2);

        Assert.That(orGate.Output(), Is.EqualTo(true));
    }
}