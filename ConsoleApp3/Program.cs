using Service;

while (true)
{
    Console.WriteLine("Enter the text...");
    var input = Console.ReadLine();
    if (input == "exit") break;
    if (input == "quit") break;
    if (input is null) continue;

    Console.WriteLine($"result: {PhoneUtils.RemovePhones(input)}");
    Console.WriteLine("_____________________");
    Console.WriteLine();
}
