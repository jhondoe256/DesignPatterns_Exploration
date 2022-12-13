
public class ChildState
{
    private string _childName;

    private Child _previousChildState;

    public ChildState(string childName)
    {

        _childName = childName;
    }


    public string GetContent() => _childName;
}
