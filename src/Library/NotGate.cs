public class OrGate : IGate
{
    private ILogicValue input1;
    private ILogicValue input2;

    public OrGate(ILogicValue input1, ILogicValue input2)
    {
        this.input1 = input1;
        this.input2 = input2;
    }

    public bool Output()
    {
        return (this.input1.Value() != this.input2.Value() || this.input1.Value() == this.input2.Value()) && (this.input1.Value() || this.input2.Value());
    }
}