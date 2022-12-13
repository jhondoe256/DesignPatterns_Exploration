
public class EditorState
{
    private readonly string _Content;

    public EditorState(string content)
    {
        _Content = content;

    }

    public string GetContent() => _Content;
}
