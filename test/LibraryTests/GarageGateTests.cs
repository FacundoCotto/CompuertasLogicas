using NUnit.Framework;

[TestFixture]
public class GarageGateTests
{
    [Test]
    public void Output_WithFalseAndFalseAndFalse_False()
    {
        ILogicValue a = new FalseValue();
        ILogicValue b = new FalseValue();
        ILogicValue c = new FalseValue();

        IGate garageGate = new GarageGate(a, b, c);

        bool result = garageGate.Output();

        Assert.That(result, Is.EqualTo(false));
    }

    [Test]
    public void Output_WithFalseAndFalseAndTrue_True()
    {
        ILogicValue a = new FalseValue();
        ILogicValue b = new FalseValue();
        ILogicValue c = new TrueValue();

        IGate garageGate = new GarageGate(a, b, c);

        bool result = garageGate.Output();

        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void Output_WithFalseAndTrueAndFalse_False()
    {
        ILogicValue a = new FalseValue();
        ILogicValue b = new TrueValue();
        ILogicValue c = new FalseValue();

        IGate garageGate = new GarageGate(a, b, c);

        bool result = garageGate.Output();

        Assert.That(result, Is.EqualTo(false));
    }

    [Test]
    public void Output_WithFalseAndTrueAndTrue_False()
    {
        ILogicValue a = new FalseValue();
        ILogicValue b = new TrueValue();
        ILogicValue c = new TrueValue();

        IGate garageGate = new GarageGate(a, b, c);

        bool result = garageGate.Output();

        Assert.That(result, Is.EqualTo(false));
    }

    [Test]
    public void Output_WithTrueAndFalseAndFalse_False()
    {
        ILogicValue a = new TrueValue();
        ILogicValue b = new FalseValue();
        ILogicValue c = new FalseValue();

        IGate garageGate = new GarageGate(a, b, c);

        bool result = garageGate.Output();

        Assert.That(result, Is.EqualTo(false));
    }

    [Test]
    public void Output_WithTrueAndFalseAndTrue_False()
    {
        ILogicValue a = new TrueValue();
        ILogicValue b = new FalseValue();
        ILogicValue c = new TrueValue();

        IGate garageGate = new GarageGate(a, b, c);

        bool result = garageGate.Output();

        Assert.That(result, Is.EqualTo(false));
    }

    [Test]
    public void Output_WithTrueAndTrueAndFalse_False()
    {
        ILogicValue a = new TrueValue();
        ILogicValue b = new TrueValue();
        ILogicValue c = new FalseValue();

        IGate garageGate = new GarageGate(a, b, c);

        bool result = garageGate.Output();

        Assert.That(result, Is.EqualTo(false));
    }


    [Test]
    public void Output_WithTrueAndTrueAndTrue_True()
    {
        ILogicValue a = new TrueValue();
        ILogicValue b = new TrueValue();
        ILogicValue c = new TrueValue();

        IGate garageGate = new GarageGate(a, b, c);

        bool result = garageGate.Output();

        Assert.That(result, Is.EqualTo(true));
    }
}