using NUnit.Framework;

[TestFixture]
public class OrGateTests
{
    [Test]
    public void Output_WithFalseAndFalse_False()
    {
        ILogicValue False1 = new FalseValue();
        ILogicValue False2 = new FalseValue();
        IGate orGate = new OrGate(False1, False2);

        Assert.That(orGate.Output(), Is.EqualTo(false));
    }

    [Test]
    public void Output_WithTrueAndFalse_True()
    {
        ILogicValue False = new FalseValue();
        ILogicValue True = new TrueValue();
        IGate orGate = new OrGate(True, False);

        Assert.That(orGate.Output(), Is.EqualTo(true));
    }

    [Test]
    public void Output_WithTrueAndTrue_True()
    {
        ILogicValue True2 = new TrueValue();
        ILogicValue True1 = new TrueValue();
        IGate orGate = new OrGate(True1, True2);

        Assert.That(orGate.Output(), Is.EqualTo(true));
    }
}