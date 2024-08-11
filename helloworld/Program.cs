// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Jan!");

string firstFriend = "Jonas";
string secondFriend = "Emilie";

Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

string greeting = "      Hello World     ";
Console.WriteLine($"{greeting}");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"{trimmedGreeting} Jan Poonthong");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"{trimmedGreeting} Jan Poonthong");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"{trimmedGreeting} Jan Poonthong");