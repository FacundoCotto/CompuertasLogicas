using NUnit.Framework;

[TestFixture]
public class GarageGateTests
{
    [Test]
    public void Output_WithFalseAndFalseAndTrue_True()
    {
        ILogicValue a = new FalseValue();
        ILogicValue b = new FalseValue();
        ILogicValue c = new TrueValue();

        IGate garageGate = new GarageGate(a, b, c);

        Assert.That(garageGate.Output(), Is.EqualTo(true));
    }

    [Test]
    public void Output_WithTrueAndTrueAndTrue_True()
    {
        ILogicValue a = new TrueValue();
        ILogicValue b = new TrueValue();
        ILogicValue c = new TrueValue();

        IGate garageGate = new GarageGate(a, b, c);

        Assert.That(garageGate.Output(), Is.EqualTo(true));
    }
}