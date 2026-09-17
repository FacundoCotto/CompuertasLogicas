
public class GateOutput : ILogicValue
{
    private IGate gate;

    public GateOutput(IGate gate)
    {
        this.gate = gate;
    }

    public bool Value
    {
        get
        {
            return this.gate.Output();
        }
    }
}