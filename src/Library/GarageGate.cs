public class GarageGate : IGate
{
    private ILogicValue a;
    private ILogicValue b;
    private ILogicValue c;

    public GarageGate(ILogicValue a, ILogicValue b, ILogicValue c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public bool Output()
    {
        IGate aAndB = new AndGate(this.a, this.b);
        GateOutput aAndBValue = new GateOutput(aAndB);
        IGate notA = new NotGate(this.a);
        IGate notB = new NotGate(this.b);
        GateOutput notAValue = new GateOutput(notA);
        GateOutput notBValue = new GateOutput(notB);
        IGate notAandNotB = new AndGate(notAValue, notBValue);
        GateOutput notAandNotBValue = new GateOutput(notAandNotB);
        IGate notAandNotBorAAndB = new OrGate(notAandNotBValue, aAndBValue);
        GateOutput notAandNotBorAAndBValue = new GateOutput(notAandNotBorAAndB);
        IGate notAandNotBorAAndBValueandC = new AndGate(notAandNotBorAAndBValue, this.c);
        GateOutput notAandNotBorAAndBValueandCValue = new GateOutput(notAandNotBorAAndBValueandC);
        return notAandNotBorAAndBValueandCValue.Value;
    }
}