using System;

BracketCheckWorker checker = new();

Console.WriteLine("Welcome to the Bracket Checker, here are some examples:");

Console.WriteLine("Input: <> --> " + BracketCheckWorker.HasMatchingBrackets("<>"));  // True
Console.WriteLine("Input: >< --> " + BracketCheckWorker.HasMatchingBrackets("><"));  // False
Console.WriteLine("Input: <<> " + BracketCheckWorker.HasMatchingBrackets("<<>")); // False
Console.WriteLine("Input:  --> " + BracketCheckWorker.HasMatchingBrackets(String.Empty));    // True
Console.WriteLine("Input: <abc...xyz> --> " + BracketCheckWorker.HasMatchingBrackets("<abc...xyz>")); // True

Console.WriteLine("Would you like to input your own input? (y/n)");
string response = Console.ReadLine() ?? string.Empty;
while (response == "y")
{
    Console.WriteLine("Enter your input: ");
    string input = Console.ReadLine() ?? string.Empty;
    if (input == null) break;
    else
    {
        Console.WriteLine("Input: " + input + " --> " + BracketCheckWorker.HasMatchingBrackets(input));
        Console.WriteLine("Would you like to input your own input? (y/n)");
        response = Console.ReadLine() ?? string.Empty;
    }

}
