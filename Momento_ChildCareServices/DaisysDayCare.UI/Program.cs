
var history = new ChildHistory();
var child = new Child();
var ChildEditor = new ChildEditor();
ChildEditor.SetContent("n/a");
history.Push(ChildEditor.CreateState());
System.Console.WriteLine("section 1");
System.Console.WriteLine(ChildEditor.GetContent());

System.Console.WriteLine("--------------------------");


child.Name = "The Kid 1";
ChildEditor.SetContent(child.Name);
history.Push(ChildEditor.CreateState());
System.Console.WriteLine("section 2");
System.Console.WriteLine(ChildEditor.GetContent());

System.Console.WriteLine("--------------------------");

ChildEditor.Restore(history.Pop());
ChildEditor.Restore(history.Pop());
System.Console.WriteLine("section 3");
System.Console.WriteLine(ChildEditor.GetContent());