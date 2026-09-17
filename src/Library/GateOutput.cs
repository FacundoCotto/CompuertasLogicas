
public class GateOutput : ILogicValue
{
    private IGate gate;

    public GateOutput(IGate gate)
    {
        this.gate = gate;
    }

    public bool Value()
    {
        return this.gate.Output();
    }
}