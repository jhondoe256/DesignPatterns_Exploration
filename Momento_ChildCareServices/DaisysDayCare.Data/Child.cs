
public class Child
{
    public int Id { get; set; }=1;
    public string Name { get; set; }="n/a";
    public int Age { get; set; } = 3;


    public override string ToString()
    {
        string str = "Child: {" + "\n";
        str += $"Id: {Id}" + "\n";
        str += $"Name: {Name}" + "\n";
        str += $"Age: {Age}" + "\n";
        str += "}" + "\n";
        str += "---------------------------" + "\n";
        return str;
    }

    private int GetRandomNumber()
    {
        var rnd = new Random();
        var number = rnd.Next(1, 11);
        return number;
    }
}
