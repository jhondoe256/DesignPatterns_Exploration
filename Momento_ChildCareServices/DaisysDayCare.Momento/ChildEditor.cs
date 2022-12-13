
public class ChildEditor
{
    private string  _childName;
    
    public ChildState CreateState()
    {
        return new ChildState(_childName);
    }

    public void Restore(ChildState state)
    {
        _childName = state.GetContent();
    }

    public string GetContent() => _childName;
    public void SetContent(string child) { _childName = child; }
}
