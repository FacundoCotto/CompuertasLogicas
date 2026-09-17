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
        // A and B
        IGate aAndB = new AndGate(this.a, this.b);
        GateOutput aAndBValue = new GateOutput(aAndB);

        // not A y not B
        IGate notA = new NotGate(this.a);
        IGate notB = new NotGate(this.b);
        GateOutput notAValue = new GateOutput(notA);
        GateOutput notBValue = new GateOutput(notB);

        // not A and not B
        IGate notAandNotB = new AndGate(notAValue, notBValue);
        GateOutput notAandNotBValue = new GateOutput(notAandNotB);

        // (not A and not B) or (A and B)
        IGate notAandNotBorAAndB = new OrGate(notAandNotBValue, aAndBValue);
        GateOutput notAandNotBorAAndBValue = new GateOutput(notAandNotBorAAndB);

        // (not A and not B) or (A and B) and C
        IGate notAandNotBorAAndBValueandC = new AndGate(notAandNotBorAAndBValue, this.c);
        GateOutput notAandNotBorAAndBValueandCValue = new GateOutput(notAandNotBorAAndBValueandC);

        return notAandNotBorAAndBValueandCValue.Value;
    }
}