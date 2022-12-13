
var editor = new Editor();
var history = new History();
editor.SetContent("a");
history.Push(editor.CreateState());


editor.SetContent("b");
history.Push(editor.CreateState());

editor.SetContent("c");
editor.Restore(history.Pop());
editor.Restore(history.Pop());

System.Console.WriteLine(editor.GetContent());