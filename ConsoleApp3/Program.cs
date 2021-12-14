using System.Text.RegularExpressions;

while (true)
{
    Console.WriteLine("Enter the text...");
    var input = Console.ReadLine();
    if (input == "exit") break;
    if (input == "quit") break;
    if (input is null) continue;

    var rejex = new Regex(@"(\+98|0)?9\d{9}");
    var result = rejex.Replace(input, "");
    Console.WriteLine($"result: {result}");
    Console.WriteLine("_____________________");
    Console.WriteLine();
}
