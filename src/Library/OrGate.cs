public class NotGate : IGate
{
    private ILogicValue input;

    public NotGate(ILogicValue input)
    {
        this.input = input;
    }

    public bool Output()
    {
        return !this.input.Value();
    }
}