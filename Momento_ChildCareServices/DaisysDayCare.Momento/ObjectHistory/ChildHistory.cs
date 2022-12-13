
public class ChildHistory
{
    private Stack<ChildState> _children = new Stack<ChildState>();

    public void Push(ChildState state)
    {
        _children.Push(state);
    }
    public ChildState Pop()
    {
        return _children.Pop();
    }
}
