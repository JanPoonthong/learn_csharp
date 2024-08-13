var names = new List<string> {"Jan", "Ana", "Felipe", "œ"};
names.Add("Jonas");
foreach (var name in names)
{
    System.Console.WriteLine(name);
}