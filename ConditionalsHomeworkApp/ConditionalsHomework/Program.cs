

Console.Write("Enter your first name: ");
string? firstName = Console.ReadLine();

// switch implementation
switch (firstName.ToLower())
{
    case "timothy":
    case "tim":
        Console.WriteLine("Hello Professor");
        break;
    default:
        Console.WriteLine("You are a student");
        break;

}

// if implementation
if (firstName.ToLower() == "tim" ||
    firstName.ToLower() == "timothy")
{
    Console.WriteLine("Hello Professor");
}
else
{
    Console.WriteLine("You are a student");
}
